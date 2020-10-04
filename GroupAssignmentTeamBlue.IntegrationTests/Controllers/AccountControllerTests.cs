using FluentAssertions;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Controllers;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.DAL.Repositories;
using GroupAssignmentTeamBlue.IntegrationTests.Helpers;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class AccountControllerTests : ControllerTestsBase
    {
        private readonly AccountController accountController;

        public AccountControllerTests(IntegrationTestsWebApplicationFactory<Startup> factory)
            : base(factory, "http://localhost:5000/api/account/register/")
        {
            
        }

        [Theory]
        [InlineData("test@user.com", "test@user.com", "SuchAGoodPassword123!")]
        public async Task RegisterNewUser_ValidUser_ShouldRegisterUser(
            string userName, string email, string password)
        {
            var user = db.UserRepository.Get(userName);
            if (user != null)
            {
                throw new Exception("User already exists, " +
                    "please change the pre-made user or remove the user");
            }

            var testUser = new UserForCreationDto() 
            { UserName = userName, Email = email, Password = password, ConfirmPassword = password};


            // Arrange

            try
            {
                // Act
                var response = accountController.RegisterNewUser(testUser);

                var statusCode = Enum.Parse(typeof(HttpStatusCode), response.Result.ToString());

                // Assert
                statusCode.Should().Be(HttpStatusCode.OK);
                var addedUser = db.UserRepository.Get(userName);
                addedUser.Should().NotBeNull();
            }
            finally
            {
                RemoveUserFromDb(userName);
            }
        }


        [Theory]
        [InlineData("test@user.com", "test@user.com", "SuchAGoodPassword123!")]
        public async Task RegisterNewUser_InvalidUser_ShouldRegisterUser(
        string userName, string email, string password)
        {
            var user = db.UserRepository.Get(userName);
            if (user != null)
            {
                throw new Exception("User already exists, " +
                    "please change the pre-made user or remove the user");
            }


            // Arrange
            var contentDictionary = new Dictionary<string, string>()
            {
                { "username", null },
                { "email", email },
                { "password", password },
                { "confirmPassword", password}
            };

            var encodedContent = new FormUrlEncodedContent(contentDictionary);

            try
            {
                // Act
                var response = await _client.PostAsync("", encodedContent);

                // Assert
                response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
                var addedUser = db.UserRepository.Get(userName);
                addedUser.Should().NotBeNull();
            }
            finally
            {
                RemoveUserFromDb(userName);
            }
        }

        private void RemoveUserFromDb(string userName)
        {
            var userToRemove = db.UserRepository.Get(userName);
            if (userToRemove != null)
            {
                db.UserRepository.Remove(userToRemove);
            }
        }
    }
}
