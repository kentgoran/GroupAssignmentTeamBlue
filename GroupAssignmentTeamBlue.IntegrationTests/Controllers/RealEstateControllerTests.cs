﻿using AutoMapper;
using FluentAssertions;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Models.DtoModels;
using GroupAssignmentTeamBlue.API.Profiles;
using GroupAssignmentTeamBlue.DAL.Repositories;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal.Account.Manage;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class RealEstateControllerTests : ControllerTestsBase
    {
        public RealEstateControllerTests(WebApplicationFactory<Startup> factory) : base(factory, "http://localhost:5000/api/realestates/")
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
        public async Task GetRealEstate_Unauthenticated_NonexistingRealEstate_ReturnsRealEstate()
        {
            if (db.RealEstateRepository.EntityExists(-1))
            {
                throw new ArgumentNullException("A real estate with the given id was found :(");
            }

            var response = await _client.GetAsync("-1");

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
