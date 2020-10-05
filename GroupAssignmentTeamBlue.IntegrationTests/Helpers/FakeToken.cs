using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GroupAssignmentTeamBlue.IntegrationTests.Helpers
{
    internal static class FakeToken
    {
        internal static string CreateFakeTokenByUser(User user)
        {
            DateTimeOffset issuedTime = new DateTimeOffset(DateTime.Now);
            DateTimeOffset expiresTime = new DateTimeOffset(DateTime.Now.AddDays(14));

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Nbf, issuedTime.ToUnixTimeSeconds().ToString()),
                new Claim(JwtRegisteredClaimNames.Exp, expiresTime.ToUnixTimeSeconds().ToString())
            };

            var token = new JwtSecurityToken(
                new JwtHeader(
                    new SigningCredentials(
                        new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes("Hash12938934KjYzzGAISfkoffTrollBoll2878huu4738higu3")),
                        SecurityAlgorithms.HmacSha256)),
                    new JwtPayload(claims));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
