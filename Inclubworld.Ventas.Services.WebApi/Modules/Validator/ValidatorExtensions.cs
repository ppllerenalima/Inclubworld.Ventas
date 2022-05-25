using Microsoft.Extensions.DependencyInjection;
using Inclubworld.Ventas.Application.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Services.WebApi.Modules.Validator
{
    public static class ValidatorExtensions
    {
        public static IServiceCollection AddValidator(this IServiceCollection services)
        {
            services.AddTransient<UsuarioDtoValidator>();

            return services;
        }
    }
}
