using FluentAssertions;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.DAL.Repositories;
using GroupAssignmentTeamBlue.Model;
using GroupAssignmentTeamBlue.UnitTests.Helpers;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using Xunit;

namespace GroupAssignmentTeamBlue.UnitTests.Repositories
{
    public class RatingRepositoryTests
    {
        private readonly RatingRepository repo;
        private readonly List<Rating> testRatings = new List<Rating>()
        {
            new Rating() { Id = 1, Score = 3, RatingUser = new User() { Id = 1},
                RatedUser = new User() { Id = 2 }},
            new Rating() { Id = 2, Score = 2, RatingUser = new User() { Id = 2}, 
                RatedUser = new User() { Id = 1 }},
            new Rating() { Id = 3, Score = 5, RatingUser = new User() { Id = 3 }, 
                RatedUser = new User() { Id = 4 }}
        };
        private MockedDbSet<Rating> dbSetRatingMock;
        private Mock<AdvertContext> contextMock;

        public RatingRepositoryTests()
        {
            // Arrange
            dbSetRatingMock = new MockedDbSet<Rating>(testRatings);

            var builder = new DbContextOptionsBuilder<AdvertContext>();
            contextMock = new Mock<AdvertContext>(builder.Options);
            contextMock.Setup(c => c.Set<Rating>()).Returns(dbSetRatingMock.Object);
            contextMock.Setup(c => c.Ratings).Returns(dbSetRatingMock.Object);

            repo = new RatingRepository(contextMock.Object);
        }

        [Fact]
        public void Add_ShouldCallAdd_ShouldAddRating()
        {
            // Arrange
            var rating = new Rating() { Id = 8, Score = 3, RatingUserId = 6, RatedUserId = 5 };

            dbSetRatingMock
                .Setup(ds => ds.Add(It.IsAny<Rating>()))
                .Callback<Rating>(testRatings.Add);

            // Act
            repo.Add(rating);

            // Assert
            testRatings.Should().Contain(rating);

            // Clean up
            testRatings.Remove(rating);
            dbSetRatingMock.Verify(ds => ds.Add(It.IsAny<Rating>()), Times.Exactly(1));
        }

        [Fact]
        public void RemovePicture_ShouldCallRemove_ShouldRemoveRating()
        {
            // Arrange
            var pictureToRemove = testRatings.Last();

            dbSetRatingMock
                .Setup(ds => ds.Remove(It.IsAny<Rating>()))
                .Callback<Rating>(RemoveRating);

            // Act
            repo.Remove(pictureToRemove);

            // Assert
            testRatings.Should().NotContain(pictureToRemove);
            dbSetRatingMock.Verify(ds => ds.Remove(It.IsAny<Rating>()), Times.Exactly(1));
            testRatings.Add(pictureToRemove);
        }

        [Fact]
        public void Get_ShouldCallFind_ShouldReturnRating()
        {
            // Arrange
            int id = testRatings.First().Id;
            var expectedPic = testRatings.First();
            dbSetRatingMock
                .Setup(ds => ds.Find(It.IsAny<int>()))
                .Returns(FindRating(id));

            // Act
            var picture = repo.Get(id);

            // Assert
            picture.Should().BeEquivalentTo(expectedPic);
            dbSetRatingMock.Verify(ds => ds.Find(It.IsAny<int>()), Times.Exactly(1));
        }

        [Fact]
        public void GetAll_ShouldGetAll()
        {
            // Act
            var ratings = repo.GetAll();

            // Assert
            ratings.Should().BeEquivalentTo(testRatings);
        }

        [Fact]
        public void Get_WithRatedUserIdRatingUserId_ShouldReturnRating()
        {
            // Arrange
            int ratedUserId = testRatings.First().RatedUser.Id;
            int ratingUserId = testRatings.First().RatingUser.Id;
            var expectedRating = testRatings.First();

            // Act
            var rating = repo.Get(ratedUserId, ratingUserId);

            // Assert
            rating.Should().BeEquivalentTo(expectedRating);
        }

        [Fact]
        public void EntityExists_ExistingEntity_ShouldReturnTrue()
        {
            // Arrange
            int id = testRatings.First().Id;
            dbSetRatingMock
                .Setup(ds => ds.Find(It.IsAny<int>()))
                .Returns(FindRating(id));

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
            dbSetRatingMock
                .Setup(ds => ds.Find(It.IsAny<int>()))
                .Returns(FindRating(id));

            // Act
            var exists = repo.EntityExists(id);

            // Assert
            exists.Should().BeFalse();
        }

        private Rating FindRating(int id)
        {
            return testRatings.Find(p => p.Id == id);
        }

        private void RemoveRating(Rating rating)
        {
            testRatings.Remove(rating);
        }
    }
}
