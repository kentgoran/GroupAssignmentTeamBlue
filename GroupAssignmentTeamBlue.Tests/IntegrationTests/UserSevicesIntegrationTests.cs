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
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.IdentityModel.Tokens.Jwt;
using Newtonsoft.Json;

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

        #region GetUserTests
        [Fact]
        public async Task GetUser_ExistingUser_ShouldGetUser()
        {
            // Arrange

            // Act
            var response = await _client.GetAsync(getUserRequestUrl);
            using (var stream = new MemoryStream())
            {
                await response.Content.CopyToAsync(stream);
                var serializer = JsonSerializer.Create();
                serializer.Deserialize(stream);
                User user = (User)DeserializeFromStream(stream);
                stream.
            }

            using (var reader = new Json())
                // Assert

                Assert.NotNull(user);
            Assert.IsType<UserDto>(user);
            //Assert.Equal(foundUser, user);
            //Assert.Equal(foundUser.Id, user.Id);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);           
        }

        [Fact]
        public async Task GetUser_InvalidUser_ShouldNotCreateUser()
        {
            // Arrange

            // Act
            var response = await _client.GetAsync(getUserRequestUrl);
            using (var stream = new MemoryStream())
            {
                await response.Content.CopyToAsync(stream);
            }
            
            // Assert
            Assert.NotNull(user);
            Assert.IsType<UserDto>(user);
            //Assert.Equal(foundUser, user);
            //Assert.Equal(foundUser.Id, user.Id);
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
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
