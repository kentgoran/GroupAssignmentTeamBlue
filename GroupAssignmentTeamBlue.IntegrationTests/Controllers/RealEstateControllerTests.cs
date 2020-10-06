﻿using AutoMapper;
using FluentAssertions;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.IntegrationTests.Helpers;
using GroupAssignmentTeamBlue.Model.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class RealEstateControllerTests : ControllerTestsBase
    {
        private RealEstateForCreationDto testRealEstate = new RealEstateForCreationDto()
        {   
            Title = "Testing", Description = "Just some testing", Contact = "Tester07",
            Address = "Testing-Facility Road 1", Type = EstateType.Warehouse, RentingPrice = 10000000,
            SellingPrice = null, ConstructionYear = 2020, ListingUrl = "http://findatestingfacility.com/1",
            City = "Varberg", SquareMeters = 100, Rooms = 1, Urls = new List<string> { "https://testingfacility.img" }
        };

        private RealEstateForCreationDto testRealEstateNullDescription = new RealEstateForCreationDto()
        {
            Title = "Testing",
            Description = null,
            Contact = "Tester07",
            Address = "Testing-Facility Road 1",
            Type = EstateType.Warehouse,
            RentingPrice = 10000000,
            SellingPrice = null,
            ConstructionYear = 2020,
            ListingUrl = "http://findatestingfacility.com/1",
            City = "Varberg",
            SquareMeters = 100,
            Rooms = 1,
            Urls = new List<string> { "https://testingfacility.img" }
        };

        public RealEstateControllerTests(IntegrationTestsWebApplicationFactory<TestStartup> factory)
            : base(factory, "http://localhost:5000/api/realestates")
        {
        }

        [Theory]
        [InlineData(1, 2)]
        public async Task GetRealEstates_ValidSkipTake_Unauthenticated_ShouldReturnRealEstates(int skip, int take)
        {
            // Arrange
            var realEstatesEntities = db.RealEstateRepository.SkipAndTakeRealEstates(skip, take);
            if(realEstatesEntities == null ||
                realEstatesEntities.Count() !=  take)
            {
                throw new Exception("Could not find sample real estates," +
                    "please change the skip and take value or add more real estates to the database");
            }

            var expectedRealEstates = _mapper.Map<IEnumerable<RealEstateDto>>(realEstatesEntities);

            // Act
            var response = await _client.GetFromJsonAsync<IEnumerable<RealEstateDto>>($"?skip={skip}&take={take}");

            // Assert
            response.Should().BeEquivalentTo(expectedRealEstates);
        }

        [Theory]
        [InlineData(-1, 0)]
        public async Task GetRealEstates_InvalidSkipTake_Unauthenticated_ShouldReturnBadRequest(int skip, int take)
        {
            // Act
            var response = await _client.GetAsync($"?skip={skip}&take={take}");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Theory]
        [InlineData(0, 10)]
        public async Task GetRealEstates_Unauthenticated_ShouldReturnRealEstates(int defaultSkip, int defaultTake)
        {
            var realEstateEntites = db.RealEstateRepository.SkipAndTakeRealEstates(defaultSkip, defaultTake);
            if(realEstateEntites == null || realEstateEntites.Count < defaultTake)
            {
                throw new Exception("Could not find sample realestates," +
                    "add more real estates to the database.");
            }

            var expectedRealEstates = _mapper.Map<IEnumerable<RealEstateDto>>(realEstateEntites);

            // Act
            var response = await _client.GetFromJsonAsync<IEnumerable<RealEstateDto>>("");

            // Assert
            response.Should().BeEquivalentTo(expectedRealEstates);
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
            var reponse = await _client.GetFromJsonAsync<RealEstatePartlyDetailedDto>("/1");

            // Assert
            reponse.Should().BeEquivalentTo(expectedRealEstate);
        }

        [Fact]
        public async Task GetRealEstate_Unauthenticated_NonexistingRealEstate_ReturnsRealEstate()
        {
            // Arrange
            if (db.RealEstateRepository.EntityExists(-1))
            {
                throw new ArgumentException("A real estate with the given id was found, please change the id.");
            }

            // Act 
            var response = await _client.GetAsync("/-1");

            // Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task GetRealEstate_Authenticated_ExistingRealEstate_ReturnsRealEstate()
        {
            // Arrange
            var realEstateEntity = db.RealEstateRepository.GetWithIncludes(1);
            if (realEstateEntity == null)
            {
                throw new ArgumentNullException("Could not find sample real estate for test");
            }
            var expectedRealEstate = _mapper.Map<RealEstateFullDetailDto>(realEstateEntity);

            var user = db.UserRepository.Get(1);
            var token = FakeToken.CreateFakeTokenByUser(user);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // Act
            var response = await _client.GetFromJsonAsync<RealEstateFullDetailDto>("/1");

            // Assert
            response.Should().BeEquivalentTo(expectedRealEstate);
        }

        [Fact]
        public async Task GetRealEstate_Authenticated_NonExistingRealEstate_ReturnsRealEstate()
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
            var response = await _client.GetAsync("/-1");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task CreateRealEstate_Authenticated_ValidRealEstate_ShouldCreateRealEstate()
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

        [Fact]
        public async Task CreateRealEstate_Authenticated_InvalidRealEstate_ShouldReturnBadRequest()
        {
            // Arrange
            var user = db.UserRepository.Get(1);
            var token = FakeToken.CreateFakeTokenByUser(user);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            try
            {
                // Act
                var response = await _client.PostAsJsonAsync("", testRealEstateNullDescription);

                // Assert
                response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
                var realEstate = context.RealEstates.Where(r => r.Title == testRealEstate.Title)
                .FirstOrDefault();
                realEstate.Should().BeNull();
            }
            finally
            {
                // Incase the real estate got added
                RemoveLastRealEstateFromDb(testRealEstate.Title);
            }
        }

        [Fact]
        public async Task CreateRealEstate_Unauthenticated_InvalidRealEstate_ShouldReturnUnauthorized()
        {
            try
            {
                // Act
                var response = await _client.PostAsJsonAsync("", testRealEstateNullDescription);

                // Assert
                response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
                var realEstate = context.RealEstates.Where(r => r.Title == testRealEstate.Title)
                .FirstOrDefault();
                realEstate.Should().BeNull();
            }
            finally
            {
                // Incase the real estate got added
                RemoveLastRealEstateFromDb(testRealEstate.Title);
            }
        }
        // TODO: Create CreateRealEstate_Unauthorized test

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
