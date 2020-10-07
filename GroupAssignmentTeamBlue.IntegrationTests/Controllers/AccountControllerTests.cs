using FluentAssertions;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.IntegrationTests.Helpers;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class AccountControllerTests : ControllerTestsBase
    {
        private string userAlreadyExists = "User already exists, please change the username.";

        public AccountControllerTests(IntegrationTestsWebApplicationFactory<TestStartup> factory)
            : base(factory, "http://localhost:5000/api/account/")
        {
        }

        [Theory]
        [InlineData("test@user.com", "test@user.com", "SuchAGoodPassword123!")]
        public async Task RegisterNewUser_ValidUser_ShouldRegisterUser(
            string userName, string email, string password)
        {
            // Arrange
            var user = db.UserRepository.Get(userName);
            if (user != null)
            {
                throw new Exception(userAlreadyExists);
            }

            var requestContent = new Dictionary<string, string>()
            {
                { "username", userName },
                { "email", email },
                { "password", password},
                { "confirmPassword", password}
            };

            var encodedContent = new FormUrlEncodedContent(requestContent);

            try
            {
                // Act
                var response = await _client.PostAsync("register", encodedContent);

                // Assert
                response.StatusCode.Should().Be(HttpStatusCode.OK);
                var addedUser = db.UserRepository.Get(userName);
                addedUser.Should().NotBeNull();
            }
            finally
            {
                RemoveUserFromDb(userName);
            }
        }


        [Theory]
        [InlineData("test@user.com", "SuchAGoodPassword123!")]
        public async Task RegisterNewUser_InvalidUser_ShouldReturnBadRequest(
        string userName, string password)
        {
            var user = db.UserRepository.Get(userName);
            if (user != null)
            {
                throw new Exception(userAlreadyExists);
            }

            // Arrange
            var contentDictionary = new Dictionary<string, string>()
            {
                { "username", userName },
                { "email", null },
                { "password", password },
                { "confirmPassword", password}
            };

            var encodedContent = new FormUrlEncodedContent(contentDictionary);

            try
            {
                // Act
                var response = await _client.PostAsync("register", encodedContent);

                // Assert
                response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
                var addedUser = db.UserRepository.Get(userName);
                addedUser.Should().BeNull();
            }
            finally
            {
                // Incase user was added to the database
                RemoveUserFromDb(userName);
            }
        }

        private void RemoveUserFromDb(string userName)
        {
            var userToRemove = db.UserRepository.Get(userName);
            if (userToRemove != null)
            {
                db.UserRepository.Remove(userToRemove);
                db.SaveChanges();
            }
        }
    }
}
