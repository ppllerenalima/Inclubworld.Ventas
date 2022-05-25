using AutoMapper;
using Inclubworld.Ventas.Application.DTO;
using Inclubworld.Ventas.Domain.Entity;

namespace Inclubworld.Ventas.Transversal.Mapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Detallepedido, DetallepedidoDto>().ReverseMap();
            CreateMap<Pedido, PedidoDto>().ReverseMap();
            CreateMap<Persona, PersonaDto>().ReverseMap();
            CreateMap<Productoes, ProductoesDto>().ReverseMap();
            CreateMap<Productoge, ProductogeDto>().ReverseMap();
            CreateMap<Unidadmedida, UnidadmedidaDto>().ReverseMap();
            CreateMap<Usuario, UsuarioDto>().ReverseMap();
        }
    }
}
