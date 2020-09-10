using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GroupAssignmentTeamBlue.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
