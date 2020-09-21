using FluentAssertions;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Controllers;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class CommentControllerTests : ControllerTestsBase
    {
        public CommentControllerTests(WebApplicationFactory<Startup> factory) : base(factory, "http://localhost:5000/api/comments/")
        { 
        }

        [Fact]
        public async Task GetComment_ExsistingRealEstate_ShouldReturnComments()
        {
            // Arrange
            int id = 1;
            int skip = 0;
            int take = 1;
                                                                         // Id, Skip, Take
            var expectedCommentsFromDb = db.CommentRepository.GetCommentsForRealEstate(id, skip, take);
            if(expectedCommentsFromDb == null || expectedCommentsFromDb.Count < 1)
            {
                throw new ArgumentNullException("No sample comments were found, " +
                    "please change the real estate id or add test comments");
            }
            var expectedCommentsDto = mapper.Map<IEnumerable<CommentDto>>(expectedCommentsFromDb);

            // Authorisation here!
            
            
            // Act
            var response = await _client.GetFromJsonAsync<IEnumerable<CommentDto>>($"{id}?skip={skip}&take={take}");

            // Assert
            response.Should().NotBeEmpty();
            response.Should().BeEquivalentTo(expectedCommentsDto);
        }
    }
}
