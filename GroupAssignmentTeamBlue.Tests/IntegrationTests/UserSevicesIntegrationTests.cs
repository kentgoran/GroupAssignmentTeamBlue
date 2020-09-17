using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using GroupAssignmentTeamBlue.API;
using Microsoft.AspNetCore.Http;
using GroupAssignmentTeamBlue.Model;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using System.IO;

namespace GroupAssignmentTeamBlue.Tests.IntegrationTests
{
    public class UserSevicesIntegrationTests
    {
        private readonly HttpClient _client;
        private const string getUserRequestUrl = "http://localhost:5000/api/users/idhere";

        public UserSevicesIntegrationTests()
        {
            
            _client = new HttpClient();
        }


        // Tests for status codes??

        #region GetUserTests
        [Fact]
        public async Task GetUser_ExistingUser_ShouldGetUser()
        {
            // Arrange

            // Act
            var response = await _client.GetAsync(getUserRequestUrl);
            using (var stream = new MemoryStream())
            {

            }
            /*
             var user = await response.Content.CopyToAsync();
            // Assert
            Assert.NotNull(user);
            Assert.IsType<UserDto>(user);
            //Assert.Equal(foundUser, user);
            Assert.Equal(foundUser.Id, user.Id);
            */
        }

        [Fact]
        public void GetUser_InvalidUser_ShouldNotCreateUser()
        {
            // Arrange
            // Act
            // Assert
        }
        #endregion

        #region RateUserTests
        [Fact]
        public void RateUser_ValidRating_ShouldCreateRating()
        {
            // Arrange
            // Act
            // Assert
        }

        [Fact]
        public void RateUser_UnExistingRatedUser_ShouldReturn400()
        {
            // Arrange
            // Act
            // Assert
        }

        [Fact]
        public void RateUser_RatingScoreOutOfAllowedRange_ShouldNotCreateRating()
        {
            // Arrange
            // Act
            // Assert
        }
        #endregion

    }
}
