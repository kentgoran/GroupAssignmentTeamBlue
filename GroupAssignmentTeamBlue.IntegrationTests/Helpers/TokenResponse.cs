using System;
using System.Collections.Generic;
using System.Text;

namespace GroupAssignmentTeamBlue.IntegrationTests.Helpers
{
    public class TokenResponse
    {
        public bool Succeded { get; set; }
        public Dictionary<string, string[]> Errors { get; set; }
    }
}
