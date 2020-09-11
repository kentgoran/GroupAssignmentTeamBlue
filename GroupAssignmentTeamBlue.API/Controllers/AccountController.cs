using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GroupAssignmentTeamBlue.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;

        public AccountController(UserManager<User> userManager)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }
        
        [Route("register")]
        [HttpPost]
        [Consumes("application/x-www-form-urlencoded")]
        public IActionResult RegisterNewUser([FromForm]UserForCreationDto user)
        {
            //TODO: Actually add the new user, hash password etc
            return Ok();
        }
    }
}
