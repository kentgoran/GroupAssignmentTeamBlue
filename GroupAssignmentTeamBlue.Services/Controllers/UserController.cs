using GroupAssignmentTeamBlue.Services.DtoModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.Services.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<UserDto>> GetUsers()
        {
            // TODO: Get users from repo
            return NoContent();
        }

        [HttpGet("{id}", Name = "GetUser")]
        public IActionResult GetUser(Guid userId)
        {
            // TODO: Get user from repo
            return NoContent();
        }

        [HttpPost]
        public IActionResult CreateUser(UserForCreationDto user)
        {
            // TODO: Add user to db
            return NoContent();
        }
    }
}
