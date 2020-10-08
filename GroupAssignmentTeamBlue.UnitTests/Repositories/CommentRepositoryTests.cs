using AutoMapper.Configuration.Conventions;
using FluentAssertions;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.DAL.Repositories;
using GroupAssignmentTeamBlue.Model;
using GroupAssignmentTeamBlue.UnitTests.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GroupAssignmentTeamBlue.UnitTests.Repositories
{
    public class CommentRepositoryTests
    {
        private readonly CommentRepository repo;
        private readonly List<Comment> testCommnets = new List<Comment>()
        {
            new Comment() { Id = 1, RealEstateId = 1,
                RealEstateInQuestion = new RealEstate() { Id = 1},
                User = new User() { UserName = "test" },
                TimeOfCreation = new DateTime(2020, 07, 06) },
            new Comment() { Id = 2, RealEstateId = 1,
                RealEstateInQuestion = new RealEstate() { Id = 1},
                User = new User() { UserName = "blob" },
                TimeOfCreation = new DateTime(2020, 08, 06) },
            new Comment() { Id = 3, RealEstateId = 3, Content = "Hello",
                RealEstateInQuestion = new RealEstate() { Id = 3},
                User = new User() { UserName = "test" }, 
                TimeOfCreation = new DateTime(2020, 09, 06) }
        };
        private MockedDbSet<Comment> dbSetCommentMock;

        public CommentRepositoryTests()
        {
            // Arrange
            dbSetCommentMock = new MockedDbSet<Comment>(testCommnets);

            var builder = new DbContextOptionsBuilder<AdvertContext>();
            var contextMock = new Mock<AdvertContext>(builder.Options);
            contextMock.Setup(c => c.Set<Comment>()).Returns(dbSetCommentMock.Object);
            contextMock.Setup(c => c.Comments).Returns(dbSetCommentMock.Object);

            repo = new CommentRepository(contextMock.Object);
        }

        [Fact]
        public void Add_ShouldCallAddOnce_ShouldAddComment()
        {
            // Arrange
            var comment = new Comment()
            {
                Id = 4,
                RealEstateId = 3,
                TimeOfCreation = new DateTime(2020, 09, 06)
            };

            dbSetCommentMock
                .Setup(ds => ds.Add(It.IsAny<Comment>()))
                .Callback<Comment>(testCommnets.Add);

            // Act
            repo.Add(comment);

            // Assert
            testCommnets.Should().Contain(comment);

            // Clean up
            testCommnets.Remove(comment);
            dbSetCommentMock.Verify(m => m.Add(It.IsAny<Comment>()), Times.Exactly(1));
        }

        [Fact]
        public void Remove_ShouldCallRemoveOnce_ShouldRemoveComment()
        {
            // Arrange
            var commentToRemove = testCommnets.Last();

            dbSetCommentMock
                .Setup(ds => ds.Remove(It.IsAny<Comment>()))
                .Callback<Comment>(RemoveComment);

            // Act
            repo.Remove(commentToRemove);

            // Assert
            testCommnets.Should().NotContain(commentToRemove);
            dbSetCommentMock.Verify(m => m.Remove(It.IsAny<Comment>()), Times.Exactly(1));

            testCommnets.Add(commentToRemove);
        }

        [Fact]
        public void GetCommentsForRealEstate_ExistingRealEstate_ShouldGetComment()
        {
            // Arrange
            int realEstateId = testCommnets.First().RealEstateId;
            var expectedComments = testCommnets.Where(c => c.RealEstateId == realEstateId);

            // Act
            var realEstates = repo.GetCommentsForRealEstate(
                realEstateId, 0, expectedComments.Count());

            // Assert
            realEstates.Should().BeEquivalentTo(expectedComments);
        }

        [Fact]
        public void GetCommentsForRealEstate_NonExistingRealEstate_ShoulReturnEmptylist()
        {
            // Arrange
            int realEstateId = -1;

            // Act
            var realEstates = repo.GetCommentsForRealEstate(
                realEstateId, 0, 1);

            // Assert
            realEstates.Should().BeEquivalentTo(new List<RealEstate>());
        }

        [Fact]
        public void GetCommentsByUser_ShouldGetComments()
        {
            // Arrange
            var username = testCommnets.First().User.UserName;
            var expectedComments = testCommnets.Where(c => c.User.UserName == username);

            // Act
            var comments = repo.GetCommentsByUser(username, 0, expectedComments.Count());

            // Assert
            comments.Should().BeEquivalentTo(expectedComments);
        }

        [Fact]
        public void GetCommentByUser_ShouldGetComment()
        {
            // Arrange
            var username = testCommnets.Last().User.UserName;
            var commmentContent = testCommnets.Last().Content;
            var expectedComment = testCommnets.Last();

            // Act
            var comment = repo.GetCommentByUser(username, commmentContent);

            // Assert
            comment.Should().BeEquivalentTo(expectedComment);
        }

        [Fact]
        public void GetCommentsByRealEstateCount_ShouldGetComments()
        {
            // Arrange
            int realEstateId = testCommnets.First().RealEstateInQuestion.Id;
            int expectedCount = testCommnets.Where(c => c.RealEstateInQuestion.Id == realEstateId).Count();

            // Act  
            var count = repo.GetCommentsByRealEstateCount(realEstateId);

            // Assert
            count.Should().Be(expectedCount);
        }

        [Fact]
        public void GetCommentsByUsernameCount_ShouldGetComments()
        {
            // Arrange
            string userName = testCommnets.First().User.UserName;
            int expectedCount = testCommnets.Where(c => c.User.UserName == userName).Count();

            // Act
            int count = repo.GetCommentsByUsernameCount(userName);

            // Assert
            count.Should().Be(expectedCount);
        }

        [Fact]
        public void Get_ShouldCallFind_ShouldReturnComment()
        {
            // Arrange
            int id = testCommnets.First().Id;
            var expectedComment = testCommnets.First();
            dbSetCommentMock
                .Setup(ds => ds.Find(It.IsAny<int>()))
                .Returns(FindComment(id));

            // Act
            var comment = repo.Get(id);

            // Assert
            comment.Should().BeEquivalentTo(expectedComment);
            dbSetCommentMock.Verify(m => m.Find(It.IsAny<int>()), Times.Exactly(1));
        }

        [Fact]
        public void GetAll_ShouldGetAll()
        {
            // Act
            var comments = repo.GetAll();

            // Assert
            comments.Should().BeEquivalentTo(testCommnets);
        }

        [Fact]
        public void EntityExists_ExistingEntity_ShouldReturnTrue()
        {
            // Arrange
            int id = testCommnets.First().Id;
            dbSetCommentMock
                .Setup(ds => ds.Find(It.IsAny<int>()))
                .Returns(FindComment(id));

            // Act
            var exists = repo.EntityExists(id);

            // Assert
            exists.Should().BeTrue();
        }

        [Fact]
        public void EntityExists_UnexistingEntity_ShouldReturnFalse()
        {
            // Arrange
            int id = -1;
            dbSetCommentMock
                .Setup(ds => ds.Find(It.IsAny<int>()))
                .Returns(FindComment(id));

            // Act
            var exists = repo.EntityExists(id);

            // Assert
            exists.Should().BeFalse();
        }

        private Comment FindComment(int id)
        {
            return testCommnets.Find(p => p.Id == id);
        }

        private void RemoveComment(Comment comment)
        {
            testCommnets.Remove(comment);
        }
    }
}
