using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.Configuration;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace GroupAssignmentTeamBlue.API.Controllers
{
    public class TokenController : Controller
    {
        private readonly UserManager<User> _userManager;

        public TokenController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [Route("/token")]
        [HttpPost]
        public async Task<IActionResult> Create(string username, string password, string grant_type)
        {
            if(await IsValidUsernameAndPassword(username, password))
            {
                return new ObjectResult(await GenerateToken(username));
            }
            else
            {
                return BadRequest();
            }
        }

        private async Task<bool> IsValidUsernameAndPassword(string username, string password)
        {
            var user = await _userManager.FindByNameAsync(username);
            return await _userManager.CheckPasswordAsync(user, password);
        }

        private async Task<dynamic> GenerateToken(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            DateTimeOffset issuedTime = new DateTimeOffset(DateTime.Now);
            DateTimeOffset expiresTime = new DateTimeOffset(DateTime.Now.AddDays(14));

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Nbf, issuedTime.ToUnixTimeSeconds().ToString()),
                new Claim(JwtRegisteredClaimNames.Exp, expiresTime.ToUnixTimeSeconds().ToString())
            };
            //TODO: Move secret key
            var token = new JwtSecurityToken(
                new JwtHeader(
                    new SigningCredentials(
                        new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes("SuperSecretCodeFromHell666")),
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
