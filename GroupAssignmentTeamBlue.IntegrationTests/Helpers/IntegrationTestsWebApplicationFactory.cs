using AutoMapper;
using FluentAssertions.Common;
using GroupAssignmentTeamBlue.API;
using GroupAssignmentTeamBlue.API.Profiles;
using GroupAssignmentTeamBlue.DAL.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using WebMotions.Fake.Authentication.JwtBearer;

namespace GroupAssignmentTeamBlue.IntegrationTests.Helpers
{
    public class IntegrationTestsWebApplicationFactory<TStartup> :
        WebApplicationFactory<TStartup> where TStartup : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.AddAuthentication(opt =>
                {
                    opt.DefaultAuthenticateScheme = FakeJwtBearerDefaults.AuthenticationScheme;
                    opt.DefaultChallengeScheme = FakeJwtBearerDefaults.AuthenticationScheme;
                }).AddFakeJwtBearer();

                /*
                services.AddDbContext<AdvertContext>(opt =>
                {
                    opt.UseSqlServer($"Server=(localdb)\\mssqllocaldb;Database=TestAdvertTeamBlue;" +
                        $"Trusted_Connection=True;MultipleActiveResultSets=true");
                });
                */

                var config = new MapperConfiguration(opt =>
                {
                    opt.AddProfile(new UserProfile());
                    opt.AddProfile(new RealEstateProfile());
                    opt.AddProfile(new CommentProfile());
                });
                services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

                
                var contextOptions = new DbContextOptionsBuilder<AdvertContext>();
                contextOptions.UseSqlServer(
                    $"Server=(localdb)\\mssqllocaldb;Database=TestAdvertTeamBlue;Trusted_Connection=True" +
                    $";MultipleActiveResultSets=true");
                var context = new AdvertContext(contextOptions.Options);
                context.Database.EnsureCreated();
                services.AddSingleton(new AdvertContext(contextOptions.Options));

                var serviceProvider = services.BuildServiceProvider();

                //services.AddScoped<AdvertContext>();

                /*
                using (var scope = serviceProvider.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    var context = scopedServices.GetRequiredService<AdvertContext>();
                    context.Database.Migrate();
                }
                */


            });
        }
    }
}
