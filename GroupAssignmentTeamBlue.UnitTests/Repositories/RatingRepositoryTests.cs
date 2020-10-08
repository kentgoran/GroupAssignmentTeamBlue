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
using System.Text;
using Xunit;

namespace GroupAssignmentTeamBlue.UnitTests.Repositories
{
    public class RatingRepositoryTests
    {
        private readonly RatingRepository repo;
        private readonly List<Rating> testRatings = new List<Rating>()
        {
            new Rating() { Id = 1, Score = 3, RatingUserId = 1, RatedUserId = 2 },
            new Rating() { Id = 2, Score = 2, RatingUserId = 2, RatedUserId = 1 },
            new Rating() { Id = 3, Score = 5, RatingUserId = 3, RatedUserId = 4 }
        };
        private MockedDbSet<Rating> dbSetRatingMock;

        public RatingRepositoryTests()
        {
            // Arrange
            dbSetRatingMock = new MockedDbSet<Rating>(testRatings);

            var builder = new DbContextOptionsBuilder<AdvertContext>();
            var contextMock = new Mock<AdvertContext>(builder.Options);
            contextMock.Setup(c => c.Set<Rating>()).Returns(dbSetRatingMock.Object);
            contextMock.Setup(c => c.Ratings).Returns(dbSetRatingMock.Object);

            repo = new RatingRepository(contextMock.Object);
        }

        [Fact]
        public void Add_ShouldCallAdd_ShouldAddPicture()
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
        }

        [Fact]
        public void RemovePicture_ShouldCallRemove_ShouldRemovePicture()
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
            testRatings.Add(pictureToRemove);
        }

        [Fact]
        public void Get_ShouldCallFind_ShouldReturnPicture()
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
