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
using Microsoft.AspNetCore.Mvc.Testing;
using RestSharp;
using System.Diagnostics;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using GroupAssignmentTeamBlue.DAL.Context;
using Moq;
using AutoMapper;
using GroupAssignmentTeamBlue.API.Controllers;

namespace GroupAssignmentTeamBlue.Tests.IntegrationTests
{
    public class UserSevicesIntegrationTests : IDisposable
    {
        private readonly HttpClient _client;
        private readonly Mock<UnitOfWork> _repositoryMock;
        private readonly RealEstateController _controller;
        private const string getUserRequestUrl = "/users/1";
        private const string getUnexistingUser = "/users/-1";

        
        public UserSevicesIntegrationTests(WebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
            _client.BaseAddress = new Uri("http://localhost:5000/api");

            _repositoryMock = new Mock<UnitOfWork>();
            _repositoryMock.Setup(opt => opt.UserRepository);

            var mapConfig = new MapperConfiguration(opt =>
            { });
            _controller = new RealEstateController(mapConfig.CreateMapper(), new AdvertContext(), );
        }

        #region GetUserTests
        [Fact]
        public async Task GetUser_ExistingUser_ShouldGetUser()
        {
            // Arrange
            // Act
            //var stream = await _client.GetStreamAsync(getUserRequestUrl);


            var response = await _client.GetAsync(getUserRequestUrl);
            var content = await response.Content.ReadAsStringAsync();

            Console.WriteLine(response.Content);
            //response.Content.
            //var jsonContent = (JsonObject)content;

            /*
            using (stream)dd
            {
                stream.

                await response.Content.CopyToAsync(stream);
                var serializer = JsonSerializer.Create();
                var reader = new JsonTextReader();
                serializer.Deserialize(stream);
                User user = (User)DeserializeFromStream(stream);
                stream.
            }
            */


            response.EnsureSuccessStatusCode();

            // Assert
            /*
            Assert.NotNull(user);
            Assert.IsType<UserDto>(user);
            //Assert.Equal(foundUser, user);
            //Assert.Equal(foundUser.Id, user.Id);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);     
            */
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
            //Assert.NotNull(user);
            //Assert.IsType<UserDto>(user);
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

        // Works as TestCleanup
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
