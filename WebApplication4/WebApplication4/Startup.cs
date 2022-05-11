using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AspNetCore.Authentication.SK.SmartID.SmartID;
using AspNetCore.Authentication.SK.SmartID;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddAuthentication()
        .AddSmartId<ApplicationUser>(SmartIdDefaults.DemoCertificatePublicKey, options =>
        {
            const string displayText = "Smart-ID ASP.NET Core";
            options.RelyingPartyUUID = Configuration["SmartID:RelyingPartyUUID"];
            options.RelyingPartyName = Configuration["SmartID:RelyingPartyName"];
            //options.UseDemo(true); // To use Smart-ID demo, use this.

            options.AllowedInteractions.Add(
                new AllowedInteraction(AllowedInteractionType.VerificationCodeChoice, displayText));
            options.AllowedInteractions.Add(
                new AllowedInteraction(AllowedInteractionType.DisplayTextAndPin, displayText));
        });
            
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
