using Celtrino.TransportPlus.App;
using Celtrino.TransportPlus.App.Interfaces;
using Celtrino.TransportPlus.Domain.Interfaces.Repositories;
using Celtrino.TransportPlus.Domain.Interfaces.Services;
using Celtrino.TransportPlus.Domain.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Centrino.TransportPlus.DatabaseProvider.Repositories;
using Swashbuckle.AspNetCore.Swagger;

namespace Celtrino.TransportPlus.API
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            // Register the Swagger generator, defining one or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info{ Title = "TransportPlus API", Version = "v1"});
            });
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

            app.UseMvc();
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TransportPlus API V1");
            });
        }
    }
}
