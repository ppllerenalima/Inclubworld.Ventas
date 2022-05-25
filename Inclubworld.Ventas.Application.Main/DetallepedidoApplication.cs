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
    public class DetallepedidoApplication : IDetallepedidoApplication
    {
        private readonly IDetallepedidoDomain _detallepedidoDomain;
        private readonly IMapper _mapper;
        private readonly IAppLogger<DetallepedidoApplication> _logger;

        public DetallepedidoApplication(IDetallepedidoDomain detallepedidoDomain, IMapper mapper, IAppLogger<DetallepedidoApplication> logger)
        {
            _detallepedidoDomain = detallepedidoDomain;
            _mapper = mapper;
            _logger = logger;
        }

        #region Métodos Síncronos
        public Response<bool> DeleteBy(int idDetallepedido)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = _detallepedidoDomain.DeleteBy(idDetallepedido);
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

        public Response<IEnumerable<DetallepedidoDto>> GetAll()
        {
            var response = new Response<IEnumerable<DetallepedidoDto>>();
            try
            {
                var detallepedido = _detallepedidoDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<DetallepedidoDto>>(detallepedido);

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

        public Response<DetallepedidoDto> GetBy(int idDetallepedido)
        {
            var response = new Response<DetallepedidoDto>();
            try
            {
                var detallepedido = _detallepedidoDomain.GetBy(idDetallepedido);
                response.Data = _mapper.Map<DetallepedidoDto>(detallepedido);

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

        public Response<bool> InsertBy(DetallepedidoDto detallepedidoDto)
        {
            var response = new Response<bool>();
            try
            {
                var detallepedido = _mapper.Map<Detallepedido>(detallepedidoDto);
                response.Data = _detallepedidoDomain.InsertBy(detallepedido);
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

        public Response<bool> UpdateBy(DetallepedidoDto detallepedidoDto)
        {
            var response = new Response<bool>();
            try
            {
                var detallepedido = _mapper.Map<Detallepedido>(detallepedidoDto);
                response.Data = _detallepedidoDomain.UpdateBy(detallepedido);
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
        public async Task<Response<bool>> DeleteByAsync(int idDetallepedido)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _detallepedidoDomain.DeleteByAsync(idDetallepedido);
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

        public async Task<Response<IEnumerable<DetallepedidoDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<DetallepedidoDto>>();
            try
            {
                var detallepedido = await _detallepedidoDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<DetallepedidoDto>>(detallepedido);

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

        public async Task<Response<DetallepedidoDto>> GetByAsync(int idDetallepedido)
        {
            var response = new Response<DetallepedidoDto>();
            try
            {
                var detallepedido = await _detallepedidoDomain.GetByAsync(idDetallepedido);
                response.Data = _mapper.Map<DetallepedidoDto>(detallepedido);

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

        public async Task<Response<bool>> InsertByAsync(DetallepedidoDto detallepedidoDto)
        {
            var response = new Response<bool>();
            try
            {
                var detallepedido = _mapper.Map<Detallepedido>(detallepedidoDto);
                response.Data = await _detallepedidoDomain.InsertByAsync(detallepedido);
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

        public async Task<Response<bool>> UpdateByAsync(DetallepedidoDto detallepedidoDto)
        {
            var response = new Response<bool>();
            try
            {
                var detallepedido = _mapper.Map<Detallepedido>(detallepedidoDto);
                response.Data = await _detallepedidoDomain.UpdateByAsync(detallepedido);
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
