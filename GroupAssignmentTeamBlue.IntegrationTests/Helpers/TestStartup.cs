using GroupAssignmentTeamBlue.DAL.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GroupAssignmentTeamBlue.IntegrationTests.Helpers
{
    public class TestStartup
    {
        public IConfiguration Configuration { get; }
        public TestStartup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public virtual void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AdvertContext>(opt =>
            opt.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TestAdvertTeamBlue;" +
                        "Trusted_Connection=True;MultipleActiveResultSets=true"));

        }

        public virtual void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //Below ensures that un-applied migrations are applied at runtime
            using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {

                var context = scope.ServiceProvider.GetService<AdvertContext>();
                //Should work now without deleting the database
                //context.Database.EnsureDeleted();
                context.Database.Migrate();
            }

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
