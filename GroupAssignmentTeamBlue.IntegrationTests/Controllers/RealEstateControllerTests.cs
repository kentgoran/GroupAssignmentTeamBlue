using FluentAssertions;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.IntegrationTests.Helpers;
using System;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class RealEstateControllerTests : ControllerTestsBase
    {

        public RealEstateControllerTests(IntegrationTestsWebApplicationFactory<Startup> factory)
            : base(factory, "http://localhost:5000/api/realestates/")
        {
        }

        [Fact]
        public async Task GetRealEstate_Unauthenticated_ExistingRealEstate_ReturnsRealEstate()
        {
            // Arrange
            var realEstateEntity = db.RealEstateRepository.Get(1);
            if (realEstateEntity == null)
            {
                throw new ArgumentNullException("Could not find sample real estate for test");
            }

            var expectedRealEstate = mapper.Map<RealEstatePartlyDetailedDto>(realEstateEntity);

            // Act + Assert
            var reponse = await _client.GetFromJsonAsync<RealEstatePartlyDetailedDto>("1");

            // Assert
            reponse.Should().BeEquivalentTo(expectedRealEstate);
        }

        [Fact]
        public async Task GetRealEstate_Unauthorized_NonexistingRealEstate_ReturnsRealEstate()
        {
            // Arrange
            if (db.RealEstateRepository.EntityExists(-1))
            {
                throw new ArgumentException("A real estate with the given id was found, please change the id");
            }

            // Act 
            var response = await _client.GetAsync("-1");

            // Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task GetRealEstate_Authorized_ExistingRealEstate_ReturnsRealEstate()
        {
            // Arrange
            var realEstateEntity = db.RealEstateRepository.Get(1);
            if (realEstateEntity == null)
            {
                throw new ArgumentNullException("Could not find sample real estate for test");
            }
            var expectedRealEstate = mapper.Map<RealEstateFullDetailDto>(realEstateEntity);

            _client.SetFakeBearerToken((object)fakeToken);

            // Act
            var response = await _client.GetFromJsonAsync<RealEstateFullDetailDto>("1");

            // Assert
            response.Should().BeEquivalentTo(expectedRealEstate);
        }

        [Fact]
        public async Task GetRealEstate_Authorized_NonExistingRealEstate_ReturnsRealEstate()
        {
            // Arrange
            var realEstateEntity = db.RealEstateRepository.Get(-1);
            if (realEstateEntity != null)
            {
                throw new ArgumentException("Could not find sample real estate for test");
            }

            _client.SetFakeBearerToken((object)fakeToken);

            // Act
            var response = await _client.GetAsync("-1");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task CreateRealEstate_ValidRealEstate_ReturnsRealEstate()
        {

        }
    }
}
