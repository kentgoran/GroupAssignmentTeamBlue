using FluentAssertions;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.IntegrationTests.Helpers;
using System;
using System.Dynamic;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class UserControllerTests : ControllerTestsBase
    {
        private const string noSampleUser = "Could not find sample user.";

        public UserControllerTests(IntegrationTestsWebApplicationFactory<TestStartup> factory)
            : base(factory, "http://localhost:5000/api/users/")
        {
        }

        [Fact]
        public async Task GetUser_ExsistingUser_ShouldReturnUser()
        {
            // Arrange
            var expectedUser = db.UserRepository.Get(1);
            if (expectedUser == null)
            {
                throw new Exception(noSampleUser);
            }
            var expectedUserWithIncludes = db.UserRepository.Get(expectedUser.UserName);

            var expectedUserDto = _mapper.Map<UserDto>(expectedUserWithIncludes);

            // Act + Assert
            // GetFromJsonAsync will throw an exception if the response statuscode is not in the 200 range
            var response = await _client.GetFromJsonAsync<UserDto>(expectedUser.UserName);

            // Assert
            response.Should().BeEquivalentTo(expectedUserDto);
            Assert.NotNull(response);
        }

        [Theory]
        [InlineData("No")]
        public async Task GetUser_UnexsistingUser_ShouldReturnNotFound(string userNamne)
        {
            var response = await _client.GetAsync(userNamne);

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task RateUser_Authenticated_ExsistingUsers_ShouldCreateRating()
        {
            // Arrange
            var ratingUser = db.UserRepository.Get(1);
            var ratedUser = db.UserRepository.Get(2);
            if (ratingUser == null || ratedUser == null)
            {
                throw new Exception(noSampleUser);
            }

            var oldRating = db.RatingRepository.Get(ratedUser.Id, ratingUser.Id);
            int? oldScore = oldRating == null ? null : oldRating.Score as int?;

            var rating = new RatingForCreationDto() { UserName = ratedUser.UserName, Value = 2 };

            var token = FakeToken.CreateFakeTokenByUser(ratingUser);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            try
            {
                // Act
                var response = await _client.PutAsJsonAsync("rate", rating);

                // Assert
                response.StatusCode.Should().Be(HttpStatusCode.OK);
                var addedRating = db.RatingRepository.Get(ratedUser.Id, ratingUser.Id);
                addedRating.Should().NotBeNull();
                addedRating.Score.Should().Be(rating.Value);
            }
            // Finally to ensure that the test-cleanup is always executed
            finally
            {
                // Cleanup incase of test failure
                RemoveRatingFromDb(ratedUser.Id, ratingUser.Id, oldScore);
                this.Dispose();
            }
        }

        [Theory]
        [InlineData("No")]
        public async Task RateUser_Authenticated_UnexsistingRatedUser_ShouldReturnNotFound(
            string unexistingUserName)
        {
            // Arrange
            var ratingUser = db.UserRepository.Get(1);
            if (ratingUser == null)
            {
                throw new Exception(noSampleUser);
            }

            var ratedUser = db.UserRepository.Get(unexistingUserName);
            if(ratedUser != null)
            {
                throw new ArgumentNullException("User did exist, " +
                    "please change the username for the non existing testing user.");
            }

            var rating = new RatingForCreationDto() { UserName = unexistingUserName, Value = 2 };

            var token = FakeToken.CreateFakeTokenByUser(ratingUser);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);


            // Act
            var response = await _client.PutAsJsonAsync("rate", rating);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task RateUser_Unauthenticated_ExistingUsers_ShouldReturnUnauthorized()
        {
            // Arrange
            var ratingUser = db.UserRepository.Get(1);
            var ratedUser = db.UserRepository.Get(2);
            if (ratingUser == null || ratedUser == null)
            {
                throw new ArgumentNullException(noSampleUser);
            }

            var oldRating = db.RatingRepository.Get(ratedUser.Id, ratingUser.Id);
            int? oldScore = oldRating == null ? null : oldRating.Score as int?;

            var rating = new RatingForCreationDto() { UserName = ratedUser.UserName, Value = 2 };

            try
            {
                // Act
                var response = await _client.PutAsJsonAsync("rate", rating);

                // Assert
                response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
                var addedRating = db.RatingRepository.Get(ratedUser.Id, ratingUser.Id);
                addedRating?.Score.Should().Be(oldScore);
            }
            // Finally to ensure that the test-cleanup is always executed
            finally
            {
                // Cleanup incase of test failure
                RemoveRatingFromDb(ratedUser.Id, ratingUser.Id, oldScore);
                this.Dispose();
            }
        }

        private void RemoveRatingFromDb(int ratedUserId, int ratingUserId, int? oldScore)
        {
            var rating = db.RatingRepository.Get(ratedUserId, ratingUserId);

            if (rating != null)
            {
                if (oldScore != null)
                {
                    rating.Score = Int32.Parse(oldScore.ToString());
                }
                else
                {
                    db.RatingRepository.Remove(rating);
                }

                db.SaveChanges();
            }
        }
    }
}
