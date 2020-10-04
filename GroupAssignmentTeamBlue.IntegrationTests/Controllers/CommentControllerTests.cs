using FluentAssertions;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.IntegrationTests.Helpers;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class CommentControllerTests : ControllerTestsBase
    {
        private readonly CommentForCreationDto testComment = 
            new CommentForCreationDto { RealEstateId = 1, Content = "Don't mind this comment"};

        public CommentControllerTests(IntegrationTestsWebApplicationFactory<Startup> factory)
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
        [InlineData(1, 0, 1)]
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

        [Fact]
        public async Task PostComment_ValidComment_ShouldPostComment()
        {

        }
    }
}
