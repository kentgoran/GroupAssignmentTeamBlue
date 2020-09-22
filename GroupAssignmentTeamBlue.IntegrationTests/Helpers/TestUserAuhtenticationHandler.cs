using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace GroupAssignmentTeamBlue.IntegrationTests.Helpers
{
    internal class TestUserAuhtenticationHandler : AuthenticationHandler<TestUserAuthenticationSchemeOptions>
    {
        public TestUserAuhtenticationHandler(IOptionsMonitor<TestUserAuthenticationSchemeOptions> options,
            ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock)
            : base(options, logger, encoder, clock)
        {

        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var principal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, "-1"),
                new Claim(ClaimTypes.Name, "TestUser"),
                new Claim(ClaimTypes.Email, "testuser@test.com"),
                new Claim(ClaimTypes.Role, Options.Role)
            }));

            var ticket = new AuthenticationTicket(principal, "IntegrationTest");
            var authenticationResult = AuthenticateResult.Success(ticket);

            return Task.FromResult(authenticationResult);
        }
    }
}
