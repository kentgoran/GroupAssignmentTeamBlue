using FluentAssertions;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class TokenControllerTests : ControllerTestsBase
    {
        public TokenControllerTests(WebApplicationFactory<Startup> factory) : base(factory, 
                "http://localhost:5000/")
        {
            AddTestUserToDb();
        }

        [Fact]
        public async Task Create_ValidUserNameAndPassword_ShouldReturnToken()
        {
            // Arrange
            // Lägg någon annan stans?
            string content = $" userName : {testUserIdentity.UserName} password : {testUserForCreation.Password} ";
            content.Prepend('{').Append('}');

            var requestContent = new StringContent(content, Encoding.UTF8 , "applcation/json");
            
            // Act
            var response =  await _client.PostAsJsonAsync("token", requestContent);

            // Assert
            response.Content.Should().NotBeNull();

        }
    }
}
