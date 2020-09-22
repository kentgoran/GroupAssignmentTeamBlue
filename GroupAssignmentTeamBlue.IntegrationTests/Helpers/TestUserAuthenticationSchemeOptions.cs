using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupAssignmentTeamBlue.IntegrationTests.Helpers
{
    class TestUserAuthenticationSchemeOptions : AuthenticationSchemeOptions
    {
        public string Role {get; set;}
    }
}
