using AutoMapper;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.API.Profiles;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Moq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public abstract class ControllerTestsBase : IClassFixture<WebApplicationFactory<Startup>>, IDisposable
    {
        protected readonly HttpClient _client;
        protected readonly WebApplicationFactory<Startup> _factory;
        protected readonly UnitOfWork db;
        protected readonly IMapper mapper;
        protected readonly UserForCreationDto testUserForCreation = new UserForCreationDto()
        { UserName = "TestUser", Email = "test@user.com", Password = "123", ConfirmPassword = "123" };
        protected readonly User testUserIdentity;
        protected bool testUserWasCreated = false;
        private readonly UserManager<User> _userManager;

        public ControllerTestsBase(WebApplicationFactory<Startup> factory,
            string baseUri)
        {
            var config = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new UserProfile());
                opt.AddProfile(new RealEstateProfile());
                opt.AddProfile(new CommentProfile());
            });
            mapper = config.CreateMapper();

            var dbContextBuilder = new DbContextOptionsBuilder<AdvertContext>()
                // fixa så att det inte är hard coded  vv
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AdvertTeamBlue;Trusted_Connection=True;MultipleActiveResultSets=true");

            var context = new AdvertContext(dbContextBuilder.Options);
            db = new UnitOfWork(context);

            var userMngrMock = new Mock<UserManager<User>>();


            _factory = factory;
            if (!String.IsNullOrEmpty(baseUri))
            {
                _factory.ClientOptions.BaseAddress = new Uri(baseUri);
            }

            _client = _factory.CreateClient();
        }

        private async Task CreateTestUserIdentity()
        {
            var user = mapper.Map<User>(testUserForCreation);
            user.Id = 0;
            user.EmailConfirmed = true;
            await _userManager.CreateAsync(user);
            await _userManager.AddPasswordAsync(user, testUserForCreation.Password);
        }

        protected void AddTestUserToDb()
        {
            CreateTestUserIdentity().Wait();

            if (testUserIdentity != null)
            {
                db.UserRepository.Add(testUserIdentity);
                db.SaveChanges();
                testUserWasCreated = true;
            }
        }

        public void Dispose()
        {
            // Removes the testuser from db if it was created and used for tests
            if (testUserWasCreated)
            {
                var testUserFromDb = db.UserRepository.Get(testUserIdentity.UserName);
                db.UserRepository.Remove(testUserFromDb.Id);
            }
        }
    }
}
