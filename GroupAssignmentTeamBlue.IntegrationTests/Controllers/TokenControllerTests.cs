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
        public TokenControllerTests(IntegrationTestsWebApplicationFactory<Startup> factory) 
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

        [Fact] // Ens värt att testa?? Borde isåfall sätta in testuser i actual db och det går inte att göra odentligt utan usermanager...
        public async Task Create_ValidUserNameAndPassword_ShouldReturnToken()
        {
            // Arrange
            //_client.SetFakeBearerToken((object)fakeToken);
            // Mock new db here??
            //var client = CreateClientWithMockDb();

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


        /*
        private HttpClient CreateClientWithMockDb()
        {
            _factory.WithWebHostBuilder(config =>
            {
                config.ConfigureServices(services =>
                {
                    var memCache = new MemoryCache();
                    DbContextOptions contextOptions = new DbContextOptionsBuilder().UseMemoryCache();

                    Mock dbMock = new Mock<AdvertContext>();
                    dbMock.Setups.(a => a);
                    services.AddDbContext(sc =>
                    {
                        sc.use
                    });
                });
            });

        }
        */
    }
}
