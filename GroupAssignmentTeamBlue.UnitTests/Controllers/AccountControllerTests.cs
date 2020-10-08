using AutoMapper;
using GroupAssignmentTeamBlue.API.Controllers;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Identity;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupAssignmentTeamBlue.UnitTests.Controllers
{
    public class AccountControllerTests
    {
        private readonly AccountController controller;

        public AccountControllerTests()
        {
            var userStore = new Mock<IUserStore<User>>();
            var hasher = new Mock<IPasswordHasher<User>>();
            var userManager = new Mock<UserManager<User>>(userStore, null, hasher, null, null, null, );


            controller = new AccountController();
        }
    }
}
