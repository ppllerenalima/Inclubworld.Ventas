using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Inclubworld.Ventas.Application.Interface;
using Inclubworld.Ventas.Application.Main;
using Inclubworld.Ventas.Domain.Core;
using Inclubworld.Ventas.Domain.Interface;
using Inclubworld.Ventas.Infraestructure.Data;
using Inclubworld.Ventas.Infraestructure.Interface;
using Inclubworld.Ventas.Infraestructure.Repository;
using Inclubworld.Ventas.Transversal.Common;
using Inclubworld.Ventas.Transversal.Logging;

namespace Inclubworld.Ventas.Services.WebApi.Modules.Injection
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IConfiguration>(configuration);
            services.AddSingleton<IConnectionFactory, ConnectionFactory>();

            services.AddScoped<IDetallepedidoApplication, DetallepedidoApplication>();
            services.AddScoped<IDetallepedidoDomain, DetallepedidoDomain>();
            services.AddScoped<IDetallepedidoRepository, DetallepedidoRepository>();

            services.AddScoped<IPedidoApplication, PedidoApplication>();
            services.AddScoped<IPedidoDomain, PedidoDomain>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();

            services.AddScoped<IPersonaApplication, PersonaApplication>();
            services.AddScoped<IPersonaDomain, PersonaDomain>();
            services.AddScoped<IPersonaRepository, PersonaRepository>();

            services.AddScoped<IProductoesApplication, ProductoesApplication>();
            services.AddScoped<IProductoesDomain, ProductoesDomain>();
            services.AddScoped<IProductoesRepository, ProductoesRepository>();

            services.AddScoped<IProductogeApplication, ProductogeApplication>();
            services.AddScoped<IProductogeDomain, ProductogeDomain>();
            services.AddScoped<IProductogeRepository, ProductogeRepository>();

            services.AddScoped<IUnidadmedidaApplication, UnidadmedidaApplication>();
            services.AddScoped<IUnidadmedidaDomain, UnidadmedidaDomain>();
            services.AddScoped<IUnidadmedidaRepository, UnidadmedidaRepository>();

            services.AddScoped<IUsuarioApplication, UsuarioApplication>();
            services.AddScoped<IUsuarioDomain, UsuarioDomain>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

            return services;
        }
    }
}
