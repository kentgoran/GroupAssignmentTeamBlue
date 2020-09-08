using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.Services.Controllers
{
    [ApiController]
    [Route("api/tests")]
    public class TestController : ControllerBase
    {
        private readonly string TestData = "Hello!";

        public TestController()
        { }

        [HttpGet]
        public ActionResult GetTestData()
        {
            return Ok(TestData);
        }
    }
}
