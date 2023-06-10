using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace LoginPage_NZ
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Configure services here.
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app)
        {
            // Configure the HTTP request pipeline here.
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Auth}/{action=Login}}");
            });
        }
    }
}
