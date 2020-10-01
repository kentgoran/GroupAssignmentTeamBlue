using FluentAssertions;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.IntegrationTests.Helpers;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class AccountControllerTests //: ControllerTestsBase
    {
        public AccountControllerTests(IntegrationTestsWebApplicationFactory<Startup> factory)
            //: base(factory, "http://localhost:5000/api/account/register/")
        {
        }

        [Fact]
        public async Task RegisterNewUser_ValidUser_ShouldRegisterUser()
        {

        }
    }
}
