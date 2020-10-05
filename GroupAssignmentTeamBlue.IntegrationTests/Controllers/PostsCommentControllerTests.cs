using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.IntegrationTests.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public class CommentControllerPostsTests : ControllerTestsBase
    {
        public CommentControllerPostsTests(
            IntegrationTestsWebApplicationFactory<TestStartup> _factory)
            : base(_factory, "http://localhost:5000/api/comments/")
        {

        }
    }
}
