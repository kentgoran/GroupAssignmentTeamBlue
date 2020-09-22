using FluentAssertions;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class AccountControllerTests : ControllerTestsBase
    {
        public AccountControllerTests(UserManager<User> userManager, 
            WebApplicationFactory<Startup> factory) : base(factory, 
                "http://localhost:5000/account/")
        {
        }

        [Fact]
        public async Task RegisterNewUser_ValidUser_ShouldRegisterUser()
        {
            // Act + Assert
            var response = await _client.PostAsJsonAsync("register", testUserForCreation);

            // Assert
            var user = db.UserRepository.Get(testUserForCreation.UserName);
            Assert.NotNull(user);
        }
    }
}
