using AutoMapper;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Models.DtoModels.ForCreation;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.IntegrationTests.Helpers;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Dynamic;
using System.Net.Http;
using System.Transactions;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public abstract class ControllerTestsBase : 
        IClassFixture<IntegrationTestsWebApplicationFactory<TestStartup>>, IDisposable
    {
        protected readonly HttpClient _client;
        protected readonly IntegrationTestsWebApplicationFactory<TestStartup> _factory;
        protected readonly UnitOfWork db;
        protected readonly IMapper _mapper;
        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=TestAdvertTeamBlue;" +
                        "Trusted_Connection=True;MultipleActiveResultSets=true";
        protected readonly AdvertContext context;

        public ControllerTestsBase(IntegrationTestsWebApplicationFactory<TestStartup> factory,
            string baseUri)
        {
            _factory = factory;

            _mapper = _factory.Services.GetRequiredService<IMapper>();            

            context = ConfigureTestDbContext();
            context.Database.Migrate();
            db = new UnitOfWork(context);

            if (!String.IsNullOrEmpty(baseUri))
            {
                _factory.ClientOptions.BaseAddress = new Uri(baseUri);
            }

            _client = _factory.CreateClient();
        }

        private AdvertContext ConfigureTestDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AdvertContext>()
                .UseSqlServer(connectionString);
            return new AdvertContext(optionsBuilder.Options);
        }

        public void Dispose()
        {
            if(context.Database.GetEnlistedTransaction() != null)
            {
                context.Database.RollbackTransaction();
            }
        }
    }
}
