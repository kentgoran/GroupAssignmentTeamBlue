using GroupAssignmentTeamBlue.DAL.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebMotions.Fake.Authentication.JwtBearer;

namespace GroupAssignmentTeamBlue.IntegrationTests.Helpers
{
    public class FakeAuthenticationStartup : TestStartup
    {
        public FakeAuthenticationStartup(IConfiguration configuration)
            : base(configuration)
        {
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services"></param>
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AdvertContext>(opt =>
            opt.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TestAdvertTeamBlue;" +
                        "Trusted_Connection=True;MultipleActiveResultSets=true"));

            // Adding fake jtw bearer for easier testing
            services.AddAuthentication(opt =>
            {
                opt.DefaultScheme = FakeJwtBearerDefaults.AuthenticationScheme;
                opt.DefaultAuthenticateScheme = FakeJwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = FakeJwtBearerDefaults.AuthenticationScheme;
            }).AddFakeJwtBearer();
        }

        public override void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
        }

        /*
                services.AddAuthentication(opt =>
                {
                    opt.DefaultAuthenticateScheme = FakeJwtBearerDefaults.AuthenticationScheme;
                    opt.DefaultChallengeScheme = FakeJwtBearerDefaults.AuthenticationScheme;
                }).AddFakeJwtBearer();
         */
    }
}
