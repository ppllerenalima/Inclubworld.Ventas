using Inclubworld.Ventas.Transversal.Common;
using Inclubworld.Ventas.Application.DTO;
using Inclubworld.Ventas.Application.Interface;
using Inclubworld.Ventas.Domain.Entity;
using Inclubworld.Ventas.Domain.Interface;
using System;
using AutoMapper;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Inclubworld.Ventas.Application.Main
{
    public class PedidoApplication : IPedidoApplication
    {
        private readonly IPedidoDomain _pedidoDomain;
        private readonly IMapper _mapper;
        private readonly IAppLogger<PedidoApplication> _logger;

        public PedidoApplication(IPedidoDomain pedidoDomain, IMapper mapper, IAppLogger<PedidoApplication> logger)
        {
            _pedidoDomain = pedidoDomain;
            _mapper = mapper;
            _logger = logger;
        }

        #region Métodos Síncronos
        public Response<bool> DeleteBy(int idPedido)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = _pedidoDomain.DeleteBy(idPedido);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación Exitosa. !!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<IEnumerable<PedidoDto>> GetAll()
        {
            var response = new Response<IEnumerable<PedidoDto>>();
            try
            {
                var pedido = _pedidoDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<PedidoDto>>(pedido);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa. !!!";
                }
                _logger.LogInformation("Consulta Exitosa. !!!");
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                _logger.LogError(e.Message);
            }
            return response;
        }

        public Response<PedidoDto> GetBy(int idPedido)
        {
            var response = new Response<PedidoDto>();
            try
            {
                var pedido = _pedidoDomain.GetBy(idPedido);
                response.Data = _mapper.Map<PedidoDto>(pedido);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa. !!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<bool> InsertBy(PedidoDto pedidoDto)
        {
            var response = new Response<bool>();
            try
            {
                var pedido = _mapper.Map<Pedido>(pedidoDto);
                response.Data = _pedidoDomain.InsertBy(pedido);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso. !!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<bool> UpdateBy(PedidoDto pedidoDto)
        {
            var response = new Response<bool>();
            try
            {
                var pedido = _mapper.Map<Pedido>(pedidoDto);
                response.Data = _pedidoDomain.UpdateBy(pedido);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización Exitosa. !!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        #endregion

        #region Métodos Asíncronos
        public async Task<Response<bool>> DeleteByAsync(int idPedido)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _pedidoDomain.DeleteByAsync(idPedido);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación Exitosa. !!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public async Task<Response<IEnumerable<PedidoDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<PedidoDto>>();
            try
            {
                var pedido = await _pedidoDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<PedidoDto>>(pedido);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa. !!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public async Task<Response<PedidoDto>> GetByAsync(int idPedido)
        {
            var response = new Response<PedidoDto>();
            try
            {
                var pedido = await _pedidoDomain.GetByAsync(idPedido);
                response.Data = _mapper.Map<PedidoDto>(pedido);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa. !!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public async Task<Response<bool>> InsertByAsync(PedidoDto pedidoDto)
        {
            var response = new Response<bool>();
            try
            {
                var pedido = _mapper.Map<Pedido>(pedidoDto);
                response.Data = await _pedidoDomain.InsertByAsync(pedido);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso. !!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public async Task<Response<bool>> UpdateByAsync(PedidoDto pedidoDto)
        {
            var response = new Response<bool>();
            try
            {
                var pedido = _mapper.Map<Pedido>(pedidoDto);
                response.Data = await _pedidoDomain.UpdateByAsync(pedido);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización Exitosa. !!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        #endregion
    }
}
