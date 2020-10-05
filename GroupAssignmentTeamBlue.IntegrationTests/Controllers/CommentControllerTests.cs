using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using FluentAssertions;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.IntegrationTests.Helpers;
using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Text.Json;
using Xunit;
using System.Net.Http;
using System.Text.Unicode;
using System.Text;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class CommentControllerTests : ControllerTestsBase
    {
        public CommentControllerTests(IntegrationTestsWebApplicationFactory<TestStartup> factory)
            : base(factory, "http://localhost:5000/api/comments/")
        {
        }

        [Theory]
        [InlineData(1, 0, 1)]
        public async Task GetCommentsForRealEstate_UnautheticatedUser_ExsistingRealEstate_ShouldReturn401Unauthorized(int id, int skip, int take)
        {
            // Act
            var response = await _client.GetAsync($"{id}?skip={skip}&take={take}");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        }

        [Theory]
        [InlineData(2, 0, 1)]
        public async Task GetCommentsForRealEstate_AutheticatedUser_ExsistingRealEstate_ShouldReturnComments(int id, int skip, int take)
        {
            // Arrange
            var expectedCommentsFromDb = db.CommentRepository.GetCommentsForRealEstate(id, skip, take);
            if (expectedCommentsFromDb == null || expectedCommentsFromDb.Count < 1)
            {
                throw new ArgumentNullException("No sample comments were found, " +
                    "please change the real estate id or add test comments");
            }
            var expectedCommentsDto = _mapper.Map<IEnumerable<CommentDto>>(expectedCommentsFromDb);

            _client.SetFakeBearerToken((object)fakeToken);

            // Act
            var response = await _client.GetFromJsonAsync<IEnumerable<CommentDto>>($"{id}?skip={skip}&take={take}");

            // Assert
            response.Should().BeEquivalentTo(expectedCommentsDto);
        }

        [Theory]
        [InlineData(-1, 0, 1)]
        public async Task GetCommentsForRealEstate_AutheticatedUser_UnexsistingRealEstate_ShouldReturn404(int id, int skip, int take)
        {
            // Arrange
            var expectedCommentsFromDb = db.CommentRepository.GetCommentsForRealEstate(id, skip, take);
            if (expectedCommentsFromDb.Count > 0)
            {
                throw new ArgumentNullException("One or more comments were found for the real estate, " +
                    "please change the real estate id.");
            }
            var expectedCommentsDto = _mapper.Map<IEnumerable<CommentDto>>(expectedCommentsFromDb);

            _client.SetFakeBearerToken((object)fakeToken);

            // Act
            var response = await _client.GetAsync($"{id}?skip={skip}&take={take}");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Theory]
        [InlineData(1, 0, 1)]
        public async Task GetCommentsByUser_AutheticatedUser_ExsistingUser_ShouldReturnComments(int userId, int skip, int take)
        {
            // Arrange
            var userName = db.UserRepository.Get(userId).UserName;

            var expectedCommentsFromDb = db.CommentRepository.GetCommentsByUser(userName, skip, take);
            if (expectedCommentsFromDb == null || expectedCommentsFromDb.Count < 1)
            {
                throw new ArgumentNullException("No sample comments were found, " +
                    "please change the real estate id or add test comments");
            }
            var expectedCommentsDto = _mapper.Map<IEnumerable<CommentDto>>(expectedCommentsFromDb);

            _client.SetFakeBearerToken((object)fakeToken);

            // Act
            var response = await _client.GetFromJsonAsync<IEnumerable<CommentDto>>($"byuser/{userName}?skip={skip}&take={take}");

            // Assert
            response.Should().NotBeEmpty();
            response.Should().BeEquivalentTo(expectedCommentsDto);
        }

        [Theory]
        [InlineData("This is just a test comment")]
        public async Task PostComment_ValidComment_ShouldPostComment(string content)
        {
            // Arrange
            var user = db.UserRepository.Get(1);
            if (user == null)
            {
                throw new Exception("Could not find sample user," +
                    "please change the user id.");
            }

            var realestate = db.RealEstateRepository.Get(1);
            if (realestate == null)
            {
                throw new Exception("Could not find sample real estate," +
                    "please change the real estate id.");
            }

            var comment = db.CommentRepository.GetCommentByUser(user.UserName, content);
            if (comment != null)
            {
                throw new Exception("Comment already exists," +
                    "please change the sample comment or remove the existing comment.");
            }

            var token = FakeToken.CreateFakeTokenByUser(user);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            //_client.SetFakeBearerToken(token);
            var commnetToPost = new CommentForCreationDto() { RealEstateId = 1, Content = content };
            try
            {
                // Act
                var response = await _client.PostAsJsonAsync("", commnetToPost);

                // Assert
                var addedComment = db.CommentRepository.GetCommentByUser(user.UserName, content);
                response.StatusCode.Should().Be(HttpStatusCode.Created);
                response.Should().NotBe("");
                addedComment.Should().NotBeNull();
            }
            finally
            {
                RemoveCommentFromDb(user.UserName, content);
            }
        }

        private void RemoveCommentFromDb(string userName, string content)
        {
            var commentToRemove = db.CommentRepository
                .GetCommentByUser(userName, content);
            if(commentToRemove != null)
            {
                db.CommentRepository.Remove(commentToRemove);
                db.SaveChanges();
            }
        }
    }
}
