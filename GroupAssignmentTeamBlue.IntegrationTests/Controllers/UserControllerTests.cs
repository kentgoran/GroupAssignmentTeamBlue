using FluentAssertions;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class UserControllerTests : ControllerTestsBase
    {
        public UserControllerTests(UserManager<User> userManager, 
            WebApplicationFactory<Startup> factory) : base(factory, 
                "http://localhost:5000/api/users/")
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

        // Rate user test here!
    }
}
