using Inclubworld.Ventas.Services.WebApi.Modules.Authentication;
using Inclubworld.Ventas.Services.WebApi.Modules.Feature;
using Inclubworld.Ventas.Services.WebApi.Modules.Injection;
using Inclubworld.Ventas.Services.WebApi.Modules.Mapper;
using Inclubworld.Ventas.Services.WebApi.Modules.Swagger;
using Inclubworld.Ventas.Services.WebApi.Modules.Validator;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Inclubworld.Ventas.Services.WebApi
{
    public class Startup
    {
        readonly String myPolice = "policyApiVentas";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMapper();
            services.AddFeature(this.Configuration);
            services.AddInjection(this.Configuration);
            services.AddAuthentication(this.Configuration);
            services.AddSwagger();
            services.AddValidator();

            services.AddControllers()
                .AddNewtonsoftJson(options => { options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver(); });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Inclubworld.Ventas.Services.WebApi v1"));
            }

            app.UseCors(myPolice);
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
