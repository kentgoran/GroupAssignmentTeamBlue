using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using GroupAssignmentTeamBlue.API.ErrorService;
using GroupAssignmentTeamBlue.API.Models;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace GroupAssignmentTeamBlue.API.Controllers
{
    /// <summary>
    /// Controller for tokens. Called upon to create an access token
    /// </summary>
    [Consumes("application/x-www-form-urlencoded")]
    public class TokenController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Constructor, sets up the controller
        /// </summary>
        /// <param name="userManager">UserManager to be injected</param>
        /// <param name="configuration">Configuration to be injected</param>
        public TokenController(UserManager<User> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        /// <summary>
        /// POST action for /token, checks username and password to generate a token
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="grant_type"></param>
        /// <returns>A token, expiration time etc</returns>
        [Route("/token")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(JwtTokenModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiErrorResponseBody))]
        public async Task<IActionResult> Create(string username, string password, string grant_type)
        {
            if(await IsValidUsernameAndPassword(username, password))
            {
                return Ok(new ObjectResult(await GenerateToken(username)));
            }
            else
            {
                ApiErrorResponseBody errorResponse = new ApiErrorResponseBody(false);
                errorResponse.AddError("Username/Password", new string[] { "Invalid username or password" });
                return BadRequest(errorResponse);
            }
        }

        /// <summary>
        /// Checks if given username and password are correct
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>boolean, true if username exists and the given password is correct</returns>
        private async Task<bool> IsValidUsernameAndPassword(string username, string password)
        {
            var user = await _userManager.FindByNameAsync(username);
            return await _userManager.CheckPasswordAsync(user, password);
        }

        /// <summary>
        /// Generates a token, with it's given parameters
        /// </summary>
        /// <param name="username"></param>
        /// <returns>A token consisting of username, access_token, expiration date etc</returns>
        private async Task<dynamic> GenerateToken(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            DateTimeOffset issuedTime = new DateTimeOffset(DateTime.Now);
            DateTimeOffset expiresTime = new DateTimeOffset(DateTime.Now.AddDays(14));

            //This list of claims is used to create the token below
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Nbf, issuedTime.ToUnixTimeSeconds().ToString()),
                new Claim(JwtRegisteredClaimNames.Exp, expiresTime.ToUnixTimeSeconds().ToString())
            };
            var token = new JwtSecurityToken(
                new JwtHeader(
                    new SigningCredentials(
                        new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(_configuration.GetValue<string>("PasswordKey"))),
                        SecurityAlgorithms.HmacSha256)),
                    new JwtPayload(claims));

            //This is the response, Converting to int32 is to remove decimals from the number
            var output = new
            {
                Access_Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expires_in = Convert.ToInt32((expiresTime - issuedTime).TotalSeconds),
                UserName = username,
                Issued = issuedTime,
                Expires = expiresTime
            };

            return output;
        }
    }
}
