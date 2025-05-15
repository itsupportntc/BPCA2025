using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BPCACondoDeficiencies
{
    public class Startup
    {
        internal static string ConnectionString;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
            ConnectionString = Configuration.GetConnectionString("DefaultConnection");
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDistributedMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            
            //enable session before MVC
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                 name: "UserPasswordManagement",
                 template: "{controller=Home}/{action=UserPasswordManagement}/{dent}/{ti}");
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Login}/{id?}");
                routes.MapRoute(
                   name: "DoLogin",
                   template: "{controller=Home}/{action=DoLogin}/{userName}/{pwd}/{agencyCode}");
                routes.MapRoute(
                   name: "EditBuilding",
                   template: "{controller=Home}/{action=EditBuilding}/{buildingGuid}/{name}" +
                        "/{address1}/{address2}/{city}/{state}/{zipCode}/{pilotPeriod}/{commonCharges}" +
                        "/{agencyGuid}/{siteId}/{managedSince}/{retail}/{agencyName}");
               
            });
        }
    }
}
