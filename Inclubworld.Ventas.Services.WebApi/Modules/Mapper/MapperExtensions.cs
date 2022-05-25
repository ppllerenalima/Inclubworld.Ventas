using AutoMapper;
using Inclubworld.Ventas.Transversal.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace Inclubworld.Ventas.Services.WebApi.Modules.Mapper
{
    public static class MapperExtensions
    {
        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingsProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            //services.AddAutoMapper(z => z.AddProfile(new MappingsProfile()));

            return services;
        }
    }
}
