using AutoMapper;
using FluentAssertions;
using GroupAssignmentTeamBlue.API.Controllers;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.API.Profiles;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace GroupAssignmentTeamBlue.UnitTests.Controllers
{
    public class AccountControllerTests
    {
        private readonly AccountController controller;
        private Mock<UserManager<User>> managerMock;

        public AccountControllerTests()
        {

            var config = new MapperConfiguration(opt =>
            {
                opt.AddProfile(typeof(UserProfile));
            });
            var mapper = new Mapper(config);

            var userStore = new Mock<IUserStore<User>>();
            var hasher = new Mock<IPasswordHasher<User>>();
            managerMock = new Mock<UserManager<User>>(
                userStore.Object, null, hasher.Object, null, null, null, null, null, null);

            controller = new AccountController(managerMock.Object, mapper);
        }

        [Fact]
        public async Task RegisterNewUser_ValidUser_ShouldRegisterUserReturnOk()
        {
            var user = new UserForCreationDto() { UserName = "Hello", Password = "123", ConfirmPassword = "123" };

            // Arrange
            managerMock.Setup(um => um.CreateAsync(It.IsAny<User>(), It.IsAny<string>())).ReturnsAsync(IdentityResult.Success);

            // Act
            var result = await controller.RegisterNewUser(user);

            // Assert
            result.Should().BeEquivalentTo(new OkResult());
        }

    }
}
