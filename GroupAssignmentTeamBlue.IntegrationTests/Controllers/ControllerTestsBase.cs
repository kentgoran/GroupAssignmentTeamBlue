using AutoMapper;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.IntegrationTests.Helpers;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Dynamic;
using System.Net.Http;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public abstract class ControllerTestsBase : IClassFixture<IntegrationTestsWebApplicationFactory<Startup>>, IDisposable
    {
        protected readonly HttpClient _client;
        protected readonly WebApplicationFactory<Startup> _factory;
        protected readonly UnitOfWork db;
        protected readonly IMapper mapper;
        private readonly AdvertContext context;
        protected readonly UserForCreationDto testUserForCreation = new UserForCreationDto()
        { UserName = "TestUser", Email = "test@user.com", Password = "123", ConfirmPassword = "123" };
        protected readonly User testUserIdentity;
        protected dynamic fakeToken;

        public ControllerTestsBase(IntegrationTestsWebApplicationFactory<Startup> factory,
            string baseUri)
        {
            _factory = factory;

            mapper = _factory.Services.GetRequiredService<IMapper>();

            context = _factory.Services.GetRequiredService<AdvertContext>();

            context.Database.EnsureCreated();
            db = new UnitOfWork(context);

            fakeToken = new ExpandoObject();
            fakeToken.sub = Guid.NewGuid();
            fakeToken.role = new[] { "sub-role", "admin" };

            if (!String.IsNullOrEmpty(baseUri))
            {
                _factory.ClientOptions.BaseAddress = new Uri(baseUri);
            }

            _client = _factory.CreateClient();
        }

        public void Dispose()
        {
            context.Database.EnsureDeleted();
        }
    }
}
