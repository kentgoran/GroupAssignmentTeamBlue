using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly IMapper _mapper;

        public AccountController(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Registers a new user to the api
        /// </summary>
        /// <param name="userForCreation">The information needed to create the user</param>
        /// <returns>200 OK, or 400 Bad Request with additional error info in the body</returns>
        [Route("register")]
        [HttpPost]
        [Consumes("application/x-www-form-urlencoded")]
        public async Task<IActionResult> RegisterNewUser([FromForm]UserForCreationDto userForCreation)
        {
            var user = _mapper.Map<User>(userForCreation);
            var result = await _userManager.CreateAsync(user, userForCreation.Password);
            if (!result.Succeeded)
            {
                return BadRequest(result);
            }
            return Ok();
        }
    }
}
