using FluentAssertions;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.IntegrationTests.Helpers;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class UserControllerTests : ControllerTestsBase
    {

        public UserControllerTests(IntegrationTestsWebApplicationFactory<Startup> factory)
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
                throw new ArgumentNullException("Could not find sample user");
            }
            var expectedUserDto = mapper.Map<UserDto>(expectedUser);

            // Act + Assert
            // GetFromJsonAsync will throw an exception if the response statuscode is not in the 200 range
            var response = await _client.GetFromJsonAsync<UserDto>(expectedUser.UserName);

            // Assert
            response.Should().BeEquivalentTo(expectedUserDto);
            Assert.NotNull(response);
        }

        [Fact]
        public async Task GetUser_UnexsistingUser_ShouldReturn404NotFound()
        {
            // Ändra string vv 
            var response = await _client.GetAsync(" ");

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task RateUser_ExsistingUser_ShouldCreateRating()
        {
            var ratingUser = db.UserRepository.Get(1);
            var ratedUser = db.UserRepository.Get(2);
            if (ratingUser == null || ratedUser == null)
            {
                throw new ArgumentNullException("Could not find sample users");
            }

            try
            {
                // Arrange
                var rating = new RatingForCreationDto() { UserName = ratedUser.UserName, Value = 2 };

                _client.SetFakeBearerToken(ratingUser.UserName, null, (object)ratingUser.Id);

                // Act
                var response = await _client.PostAsJsonAsync<RatingForCreationDto>("rate", rating);

                // Asssert
                response.Content.Should().BeEquivalentTo("");
            }
            catch (Exception)
            {
                // Cleanup incase of test failure
                RemoveAddedRatingFromTestDb(ratingUser.Id, ratedUser.Id);
                this.Dispose();
            }

            // Cleanup
            RemoveAddedRatingFromTestDb(ratingUser.Id, ratedUser.Id);
        }

        private void RemoveAddedRatingFromTestDb(int ratingUserId, int ratedUserId)
        {
            var rating = db.RatingRepository.Get(ratingUserId, ratedUserId);
            if(rating != null)
            {
                db.RatingRepository.Remove(rating);
            }
        }
    }
}
