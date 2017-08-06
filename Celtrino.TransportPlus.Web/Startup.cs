using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Celtrino.TransportPlus.Web.Data;
using Celtrino.TransportPlus.Web.Models;
using Celtrino.TransportPlus.Web.Services;
using Celtrino.TransportPlus.Domain.Interfaces.Repositories;
using Centrino.TransportPlus.DatabaseProvider.Repositories;
using Celtrino.TransportPlus.Domain.Interfaces.Services;
using Celtrino.TransportPlus.Domain.Services;
using Celtrino.TransportPlus.App;
using Celtrino.TransportPlus.App.Interfaces;
namespace Celtrino.TransportPlus.Web
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsDevelopment())
            {
                // For more details on using the user secret store see https://go.microsoft.com/fwlink/?LinkID=532709
                builder.AddUserSecrets<Startup>();
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc();

            // Add application services.
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();

            //application dependency injection
            services.AddTransient<IMapPointRepository, MapPointRepository>();
            services.AddTransient<IVehicleManufacturerRepository, VehicleManufacturerRepository>();
            services.AddTransient<IVehicleModelRepository, VehicleModelRepository>();
            services.AddTransient<IVehicleRepository, VehicleRepository>();

            services.AddTransient<IMapPointService, MapPointService>();
            services.AddTransient<IVehicleManufacturerService, VehicleManufacturerService>();
            services.AddTransient<IVehicleModelService, VehicleModelService>();
            services.AddTransient<IVehicleService, VehicleService>();

            services.AddTransient<IMapPointAppService, MapPointAppService>();
            services.AddTransient<IVehicleManufacturerAppService, VehicleManufacturerAppService>();
            services.AddTransient<IVehicleModelAppService, VehicleModelAppService>();
            services.AddTransient<IVehicleAppService, VehicleAppService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseIdentity();

            // Add external authentication middleware below. To configure them please see https://go.microsoft.com/fwlink/?LinkID=532715

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
