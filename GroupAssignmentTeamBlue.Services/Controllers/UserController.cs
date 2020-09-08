using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.Services.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetUsers()
        {
            // TODO: Get users from repo
            return NoContent();
        }

        [HttpGet("{id}", Name = "GetUser")]
        public ActionResult GetUser(Guid userId)
        {
            // TODO: Get user from repo
            return NoContent();
        }
    }
}
