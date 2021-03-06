﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GroupAssignmentTeamBlue.API.ErrorService;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GroupAssignmentTeamBlue.API.Controllers
{
    /// <summary>
    /// Controller for handling Accounts
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Consumes("application/x-www-form-urlencoded")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor, sets up the AccountController
        /// </summary>
        /// <param name="userManager">UserManager to be injected</param>
        /// <param name="mapper">AutoMapper to be injected</param>
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiErrorResponseBody))]
        public async Task<IActionResult> RegisterNewUser([FromForm]UserForCreationDto userForCreation)
        {
            var user = _mapper.Map<User>(userForCreation);
            var result = await _userManager.CreateAsync(user, userForCreation.Password);
            if (!result.Succeeded)
            {
                //Create an errorResponeBody, and add all errors found in userManagers result
                ApiErrorResponseBody errorResponse = new ApiErrorResponseBody(false);
                foreach(var error in result.Errors)
                {
                    errorResponse.AddError(error.Code, new string[] { error.Description });
                }
                return BadRequest(errorResponse);
            }
            return Ok();
        }
    }
}
