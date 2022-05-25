using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Services.WebApi.Modules.Feature
{
    public static class FeatureExtensions
    {
        public static IServiceCollection AddFeature(this IServiceCollection services, IConfiguration configuration)
        {
            String myPolice = "policyApiVentas";

            services.AddCors(options =>
            {
                options.AddPolicy(name: myPolice,
                                  builder =>
                                  {
                                      builder.WithOrigins(configuration["Config:OriginCors"])
                                             .AllowAnyHeader()
                                             .AllowAnyMethod();
                                  });
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest);

            return services;
        }
    }
}
