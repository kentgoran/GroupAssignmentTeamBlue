using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GroupAssignmentTeamBlue.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private UserManager<User> UserManager { get; }
        private SignInManager<User> SignInManager { get; }
        public AccountController(UserManager<User> userManager,
        SignInManager<User> signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }
        [Route("register")]
        [HttpPost]

        //Does not route username email and pw atm, needs to fix
        public async Task<IActionResult> Register(string username, string email, string password)
        {
            try
            {
                User user = await UserManager.FindByNameAsync(username);
                if(user == null)
                {
                    user = new User();
                    user.UserName = username;
                    user.Email = email;

                    IdentityResult result = await UserManager.CreateAsync(user, password);

                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok("User created successfully.");
        }
    }
}
