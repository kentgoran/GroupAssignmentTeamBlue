﻿using AutoMapper;
using FluentAssertions.Common;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Controllers;
using GroupAssignmentTeamBlue.API.Profiles;
using GroupAssignmentTeamBlue.DAL.Context;
using GroupAssignmentTeamBlue.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using WebMotions.Fake.Authentication.JwtBearer;

namespace GroupAssignmentTeamBlue.IntegrationTests.Helpers
{
    public class IntegrationTestsWebApplicationFactory<TStartup> :
        WebApplicationFactory<TStartup> where TStartup : class
    {
        protected override IHostBuilder CreateHostBuilder()
        {
            var builder = Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(config =>
                {
                    config.UseStartup<TStartup>().UseTestServer();
                });
            return builder;
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                //services.AddAuthentication(opt =>
                //{
                //    opt.DefaultAuthenticateScheme = FakeJwtBearerDefaults.AuthenticationScheme;
                //    opt.DefaultChallengeScheme = FakeJwtBearerDefaults.AuthenticationScheme;
                //}).AddFakeJwtBearer();
                
                services.AddDbContext<AdvertContext>(opt =>
                {
                    opt.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TestAdvertTeamBlue;" +
                        "Trusted_Connection=True;MultipleActiveResultSets=true");
                });

                var config = new MapperConfiguration(opt =>
                {
                    opt.AddProfile(new UserProfile());
                    opt.AddProfile(new RealEstateProfile());
                    opt.AddProfile(new CommentProfile());
                });
                services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

                services.AddControllers().AddApplicationPart(typeof(UserController).Assembly);
            });
        }
    }
}
