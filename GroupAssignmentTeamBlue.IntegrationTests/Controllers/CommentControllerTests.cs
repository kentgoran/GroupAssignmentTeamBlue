using FluentAssertions;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Controllers;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.IntegrationTests.Helpers;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class CommentControllerTests : ControllerTestsBase
    {

        public CommentControllerTests(UserManager<User> userManager, 
            WebApplicationFactory<Startup> factory) : base(factory, 
                "http://localhost:5000/api/comments/")
        {
            AddTestUserToDb();
        }

        [Theory]
        [InlineData(1, 0, 1)]
        public async Task GetComment_ExsistingRealEstate_ShouldReturnComments(int id, int skip, int take)
        {
            // Arrange
            var expectedCommentsFromDb = db.CommentRepository.GetCommentsForRealEstate(id, skip, take);
            if(expectedCommentsFromDb == null || expectedCommentsFromDb.Count < 1)
            {
                throw new ArgumentNullException("No sample comments were found, " +
                    "please change the real estate id or add test comments");
            }
            var expectedCommentsDto = mapper.Map<IEnumerable<CommentDto>>(expectedCommentsFromDb);

            // Authentication, funkar inte...
            /*
            var clientWithAuth = _factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services => 
                {
                    services.AddMvc(opt =>
                    {
                        opt.Filters.Add(new FakeUserFilter());
                    });

                    services.AddAuthentication("IntegrationTest")
                    .AddScheme<TestUserAuthenticationSchemeOptions, TestUserAuhtenticationHandler>("IntegrationTest",
                    opt => opt.Role = "User");
                });
            }).CreateClient();
            

            clientWithAuth.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("IntegrationTest");
            */

            // Act
            var response = await _client.GetFromJsonAsync<IEnumerable<CommentDto>>($"{id}?skip={skip}&take={take}");

            // Assert
            response.Should().NotBeEmpty();
            response.Should().BeEquivalentTo(expectedCommentsDto);
        }

        [Theory]
        [InlineData(1, 0, 1)]
        public async Task GetCommentsByUser_ExsistingUser_ShouldReturnComments(int userId, int skip, int take)
        {
            // Arrange
            var userName = db.UserRepository.Get(userId).UserName;
            
            var expectedCommentsFromDb = db.CommentRepository.GetCommentsByUser(userName, skip, take);
            if (expectedCommentsFromDb == null || expectedCommentsFromDb.Count < 1)
            {
                throw new ArgumentNullException("No sample comments were found, " +
                    "please change the real estate id or add test comments");
            }
            var expectedCommentsDto = mapper.Map<IEnumerable<CommentDto>>(expectedCommentsFromDb);

            // Authorisation here!


            // Act
            var response = await _client.GetFromJsonAsync<IEnumerable<CommentDto>>($"byuser/{userName}?skip={skip}&take={take}");

            // Assert
            response.Should().NotBeEmpty();
            response.Should().BeEquivalentTo(expectedCommentsDto);
        }

        [Fact]
        public async Task PostComment_ValidComment_ShouldPostComment()
        {

        }
    }
}
