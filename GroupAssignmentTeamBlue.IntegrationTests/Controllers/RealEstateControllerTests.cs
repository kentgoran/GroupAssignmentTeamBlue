using FluentAssertions;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.IntegrationTests.Helpers;
using GroupAssignmentTeamBlue.Model.Enums;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class RealEstateControllerTests : ControllerTestsBase
    {
        private RealEstateForCreationDto testRealEstate = new RealEstateForCreationDto()
            { Title = "Testing", Description = "Just some testing", Contact = "Tester07", 
            Address = "Testing-Facility Road 1", Type = EstateType.Warehouse, RentingPrice = 10000000,
            SellingPrice = null, ConstructionYear = 2020, ListingUrl = "http://findatestingfacility.com/1",
            City = "Varberg", SquareMeters = 100, Rooms = 1, Urls = null};

        public RealEstateControllerTests(IntegrationTestsWebApplicationFactory<TestStartup> factory)
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

            var expectedRealEstate = _mapper.Map<RealEstatePartlyDetailedDto>(realEstateEntity);

            // Act + Assert
            var reponse = await _client.GetFromJsonAsync<RealEstatePartlyDetailedDto>("1");

            // Assert
            reponse.Should().BeEquivalentTo(expectedRealEstate);
        }

        //TODO: GetRealEstate test with skip and take

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
            var expectedRealEstate = _mapper.Map<RealEstateFullDetailDto>(realEstateEntity);

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

            var user = db.UserRepository.Get(1);
            var token = FakeToken.CreateFakeTokenByUser(user);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // Act
            var response = await _client.GetAsync("-1");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task CreateRealEstate_ValidRealEstate_ShouldCreateRealEstate()
        {
            // Arrange
            var realEstate = context.RealEstates.Where(r => r.Title == testRealEstate.Title)
                .FirstOrDefault();
            if (realEstate != null)
            {
                throw new Exception("Real estate already exists," +
                    "please change the test real estate or remove the existing record.");
            }

            var user = db.UserRepository.Get(1);
            var token = FakeToken.CreateFakeTokenByUser(user);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            try
            {
                // Act
                var response = await _client.PostAsJsonAsync("", testRealEstate);

                // Assert
                response.StatusCode.Should().Be(HttpStatusCode.Created);
                realEstate = context.RealEstates.Where(r => r.Title == testRealEstate.Title)
                .FirstOrDefault();
                realEstate.Should().NotBeNull();
            }
            finally
            {
                RemoveLastRealEstateFromDb(testRealEstate.Title);
            }
        }

        private void RemoveLastRealEstateFromDb(string realEstateTitle)
        {
            var realEstate = context.RealEstates
                .Where(r => r.Title == realEstateTitle).FirstOrDefault();
            if(realEstate != null)
            {
                db.RealEstateRepository.Remove(realEstate);
                db.SaveChanges();
            }
        }
    }
}
