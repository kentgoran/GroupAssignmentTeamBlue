using Castle.DynamicProxy.Generators;
using FluentAssertions;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.DAL.Repositories;
using GroupAssignmentTeamBlue.IntegrationTests.Helpers;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Manage.Internal;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class TokenControllerTests : ControllerTestsBase
    {
        private readonly TokenRequestContent content =
            new TokenRequestContent() { UserName = "Test", Password = "123BestPassword", Grant_Type = "password" };
        public TokenControllerTests(IntegrationTestsWebApplicationFactory<TestStartup> factory)
            : base(factory, "http://localhost:5000/token/")
        {
        }

        [Fact]
        public async Task Create_InvalidUserNameAndPassword_ShouldReturn400BadRequest()
        {
            // Arrange
            var contentDictionary = new Dictionary<string, string>()
            {
                { "username", content.UserName },
                { "password", content.Password },
                { "grant_type", content.Grant_Type }
            };

            var encodedContent = new FormUrlEncodedContent(contentDictionary);

            // Act
            var response = await _client.PostAsync("", encodedContent);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }
    }
}
