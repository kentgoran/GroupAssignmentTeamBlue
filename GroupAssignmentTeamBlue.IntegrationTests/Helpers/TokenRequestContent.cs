using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GroupAssignmentTeamBlue.IntegrationTests.Helpers
{
    public class TokenRequestContent
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Grant_Type { get; set; }
    }
}
