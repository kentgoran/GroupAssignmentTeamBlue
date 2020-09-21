using AutoMapper;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Profiles;
using GroupAssignmentTeamBlue.DAL.Context;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xunit;

namespace GroupAssignmentTeamBlue.IntegrationTests.Controllers
{
    public abstract class ControllerTestsBase : IClassFixture<WebApplicationFactory<Startup>>
    {
        protected readonly HttpClient _client;
        protected readonly UnitOfWork db;
        protected readonly IMapper mapper;

        public ControllerTestsBase(WebApplicationFactory<Startup> factory, string baseUri)
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

            if(!String.IsNullOrEmpty(baseUri))
            {
                factory.ClientOptions.BaseAddress = new Uri(baseUri);
            }

            _client = factory.CreateClient();
        }
    }
}
