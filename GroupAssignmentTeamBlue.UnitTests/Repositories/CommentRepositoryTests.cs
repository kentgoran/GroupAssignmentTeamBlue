using FluentAssertions;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.DAL.Repositories;
using GroupAssignmentTeamBlue.Model;
using GroupAssignmentTeamBlue.UnitTests.Helpers;
using Microsoft.EntityFrameworkCore;
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
            new Comment() { Id = 1, RealEstateId = 1, TimeOfCreation = new DateTime(2020, 07, 06) },
            new Comment() { Id = 2, RealEstateId = 1, TimeOfCreation = new DateTime(2020, 08, 06) },
            new Comment() { Id = 3, RealEstateId = 3, TimeOfCreation = new DateTime(2020, 09, 06) }
        };
        private MockedDbSet<Comment> dbSetCommnetMock;

        public CommentRepositoryTests()
        {
            // Arrange
            dbSetCommnetMock = new MockedDbSet<Comment>(testCommnets);

            var builder = new DbContextOptionsBuilder<AdvertContext>();
            var contextMock = new Mock<AdvertContext>(builder.Options);
            contextMock.Setup(c => c.Set<Comment>()).Returns(dbSetCommnetMock.Object);
            contextMock.Setup(c => c.Comments).Returns(dbSetCommnetMock.Object);

            repo = new CommentRepository(contextMock.Object);
        }

        [Fact]
        public void Add_ShouldCallAdd_ShouldAddComment()
        {
            // Arrange
            var comment = new Comment()
            {
                Id = 4,
                RealEstateId = 3,
                TimeOfCreation = new DateTime(2020, 09, 06)
            };

            dbSetCommnetMock
                .Setup(ds => ds.Add(It.IsAny<Comment>()))
                .Callback<Comment>(testCommnets.Add);

            // Act
            repo.Add(comment);

            // Assert
            testCommnets.Should().Contain(comment);

            // Clean up
            testCommnets.Remove(comment);
        }

        [Fact]
        public void Remove_ShouldCallRemove_ShouldRemoveComment()
        {
            // Arrange
            var commentToRemove = testCommnets.Last();

            dbSetCommnetMock
                .Setup(ds => ds.Remove(It.IsAny<Comment>()))
                .Callback<Comment>(RemoveComment);

            // Act
            repo.Remove(commentToRemove);

            // Assert
            testCommnets.Should().NotContain(commentToRemove);
            testCommnets.Add(commentToRemove);
        }

        [Fact]
        public void Get_ShouldCallFind_ShouldReturnComment()
        {
            // Arrange
            int id = testCommnets.First().Id;
            var expectedComment = testCommnets.First();
            dbSetCommnetMock
                .Setup(ds => ds.Find(It.IsAny<int>()))
                .Returns(FindComment(id));

            // Act
            var comment = repo.Get(id);

            // Assert
            comment.Should().BeEquivalentTo(expectedComment);
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
            dbSetCommnetMock
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
            dbSetCommnetMock
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
