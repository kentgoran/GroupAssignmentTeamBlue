using FluentAssertions;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.IntegrationTests.Helpers;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class CommentControllerTests : ControllerTestsBase
    {
        private const string noSampleUser = "No sample user was found, please change the user id or add a test user.";
        private const string noSampleComments = "No sample comments were found, please change the real estate id or add test comments.";
        private const string noSampleRealEstate = "Could not find sample real estate, please change the real estate id.";
        private const string commentAlreadyExists = "Comment already exists, please change the sample comment or remove the existing comment.";

        public CommentControllerTests(IntegrationTestsWebApplicationFactory<TestStartup> factory)
            : base(factory, "http://localhost:5000/api/comments/")
        {
        }

        [Theory]
        [InlineData(2, 0, 1)]
        public async Task GetCommentsForRealEstate_ValidSkipTake_Autheticated_ExsistingRealEstate_ShouldReturnComments(
            int realEstateId, int skip, int take)
        {
            // Arrange
            var user = db.UserRepository.Get(1);
            if (user == null)
            {
                throw new Exception(noSampleUser);
            }

            var expectedCommentsFromDb = db.CommentRepository.GetCommentsForRealEstate(realEstateId, skip, take);
            if (expectedCommentsFromDb == null || expectedCommentsFromDb.Count < 1)
            {
                throw new Exception(noSampleComments);
            }

            var expectedCommentsDto = _mapper.Map<IEnumerable<CommentDto>>(expectedCommentsFromDb);

            var token = FakeToken.CreateFakeTokenByUser(user);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // Act
            var response = await _client.GetFromJsonAsync<IEnumerable<CommentDto>>($"{realEstateId}?skip={skip}&take={take}");

            // Assert
            response.Should().BeEquivalentTo(expectedCommentsDto);
        }

        [Theory]
        [InlineData(2, -1, 1)]
        public async Task GetCommentsForRealEstate_InValidSkipTake_Autheticated_ExsistingRealEstate_ShouldReturnBadRequest(
            int realEstateId, int skip, int take)
        {
            // Arrange
            var user = db.UserRepository.Get(1);
            if (user == null)
            {
                throw new Exception(noSampleUser);
            }

            var token = FakeToken.CreateFakeTokenByUser(user);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // Act
            var response = await _client.GetAsync($"{realEstateId}?skip={skip}&take={take}");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Theory]
        [InlineData(1, 0, 1)]
        public async Task GetCommentsForRealEstate_Unautheticated_ExsistingRealEstate_ShouldReturnUnauthorized(
            int realEstateId, int skip, int take)
        {
            // Act
            var response = await _client.GetAsync($"{realEstateId}?skip={skip}&take={take}");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        }

        [Theory]
        [InlineData(-1, 0, 1)]
        public async Task GetCommentsForRealEstate_Autheticated_UnexsistingRealEstate_ShouldReturnNotFound(
            int realEstateId, int skip, int take)
        {
            // Arrange
            var user = db.UserRepository.Get(1);
            if (user == null)
            {
                throw new Exception(noSampleUser);
            }

            var token = FakeToken.CreateFakeTokenByUser(user);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // Act
            var response = await _client.GetAsync($"{realEstateId}?skip={skip}&take={take}");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Theory]
        [InlineData(1, 0, 1)]
        public async Task GetCommentsByUser_ValidSkipTake_Autheticated_ExsistingUser_ShouldReturnComments(
            int userId, int skip, int take)
        {
            // Arrange
            var user = db.UserRepository.Get(userId);

            var expectedCommentsFromDb = db.CommentRepository.GetCommentsByUser(user.UserName, skip, take);
            if (expectedCommentsFromDb == null || expectedCommentsFromDb.Count < 1)
            {
                throw new ArgumentNullException("No sample comments were found, " +
                    "please change the real estate id or add test comments");
            }
            var expectedCommentsDto = _mapper.Map<IEnumerable<CommentDto>>(expectedCommentsFromDb);

            var token = FakeToken.CreateFakeTokenByUser(user);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // Act
            var response = await _client.GetFromJsonAsync<IEnumerable<CommentDto>>($"byuser/{user.UserName}?skip={skip}&take={take}");

            // Assert
            response.Should().NotBeEmpty();
            response.Should().BeEquivalentTo(expectedCommentsDto);
        }

        [Theory]
        [InlineData(1, -1, 1)]
        public async Task GetCommentsByUser_InvalidSkipTake_Autheticated_ExsistingUser_ShouldReturnBadRequest(
            int userId, int skip, int take)
        {
            // Arrange
            var user = db.UserRepository.Get(userId);

            var token = FakeToken.CreateFakeTokenByUser(user);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // Act
            var response = await _client.GetAsync($"byuser/{user.UserName}?skip={skip}&take={take}");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Theory]
        [InlineData("No", 0, 1)]
        public async Task GetCommentsByUser_Autheticated_UnexsistingUser_ShouldReturnNotFound(
            string userName, int skip, int take)
        {
            // Arrange
            var user = db.UserRepository.Get(1);

            var token = FakeToken.CreateFakeTokenByUser(user);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // Act
            var response = await _client.GetAsync($"byuser/{userName}?skip={skip}&take={take}");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Theory]
        [InlineData(1, 0, 1)]
        public async Task GetCommentsByUser_Unautheticated_ExsistingUser_ShouldReturnBadRequest(
            int userId, int skip, int take)
        {
            // Arrange
            var user = db.UserRepository.Get(userId);
            if (user == null)
            {
                throw new Exception(noSampleUser);
            }

            // Act
            var response = await _client.GetAsync($"byuser/{user.UserName}?skip={skip}&take={take}");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        }

        [Theory]
        [InlineData(1, "This is just a test comment")]
        public async Task PostComment_Authenticated_ValidComment_ShouldPostComment(int realEstateId, string content)
        {
            // Arrange
            var user = db.UserRepository.Get(1);
            if (user == null)
            {
                throw new Exception(noSampleUser);
            }

            var realestate = db.RealEstateRepository.Get(realEstateId);
            if (realestate == null)
            {
                throw new Exception(noSampleRealEstate);
            }

            var comment = db.CommentRepository.GetCommentByUser(user.UserName, content);
            if (comment != null)
            {
                throw new Exception(commentAlreadyExists);
            }

            var token = FakeToken.CreateFakeTokenByUser(user);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var commnetToPost = new CommentForCreationDto() { RealEstateId = 1, Content = content };
            try
            {
                // Act
                var response = await _client.PostAsJsonAsync("", commnetToPost);

                // Assert
                response.StatusCode.Should().Be(HttpStatusCode.Created);
                response.Should().NotBe("");
                var addedComment = db.CommentRepository.GetCommentByUser(user.UserName, content);
                addedComment.Should().NotBeNull();
            }
            finally
            {
                RemoveCommentFromDb(user.UserName, content);
            }
        }

        [Theory]
        [InlineData(1, null)]
        public async Task PostComment_Authenticated_InvalidComment_ShouldReturnBadRequest(int realEstateId, string content)
        {
            // Arrange
            var user = db.UserRepository.Get(1);
            if (user == null)
            {
                throw new Exception(noSampleUser);
            }

            var realestate = db.RealEstateRepository.Get(realEstateId);
            if (realestate == null)
            {
                throw new Exception(noSampleRealEstate);
            }

            var token = FakeToken.CreateFakeTokenByUser(user);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var commnetToPost = new CommentForCreationDto() { RealEstateId = realEstateId, Content = content };
            try
            {
                // Act
                var response = await _client.PostAsJsonAsync("", commnetToPost);

                // Assert
                response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
                var addedComment = db.CommentRepository.GetCommentByUser(user.UserName, content);
                addedComment.Should().BeNull();
            }
            finally
            {
                RemoveCommentFromDb(user.UserName, content);
            }
        }

        [Theory]
        [InlineData(1, "This is just a test comment")]
        public async Task PostComment_Unauthenticated_ValidComment_ShouldReturnUnauthorized(int realEstateId, string content)
        {
            // Arrange
            var realestate = db.RealEstateRepository.Get(realEstateId);
            if (realestate == null)
            {
                throw new Exception(noSampleRealEstate);
            }

            var commnetToPost = new CommentForCreationDto() { RealEstateId = realEstateId, Content = content };
            // Act
            var response = await _client.PostAsJsonAsync("", commnetToPost);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        }

        private void RemoveCommentFromDb(string userName, string content)
        {
            var commentToRemove = db.CommentRepository
                .GetCommentByUser(userName, content);
            if (commentToRemove != null)
            {
                db.CommentRepository.Remove(commentToRemove);
                db.SaveChanges();
            }
        }
    }
}
