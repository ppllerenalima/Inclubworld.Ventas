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
    public class UnidadmedidaApplication : IUnidadmedidaApplication
    {
        private readonly IUnidadmedidaDomain _unidadmedidaDomain;
        private readonly IMapper _mapper;
        private readonly IAppLogger<UnidadmedidaApplication> _logger;

        public UnidadmedidaApplication(IUnidadmedidaDomain unidadmedidaDomain, IMapper mapper, IAppLogger<UnidadmedidaApplication> logger)
        {
            _unidadmedidaDomain = unidadmedidaDomain;
            _mapper = mapper;
            _logger = logger;
        }

        #region Métodos Síncronos
        public Response<bool> DeleteBy(int idUnidadmedida)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = _unidadmedidaDomain.DeleteBy(idUnidadmedida);
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

        public Response<IEnumerable<UnidadmedidaDto>> GetAll()
        {
            var response = new Response<IEnumerable<UnidadmedidaDto>>();
            try
            {
                var unidadmedida = _unidadmedidaDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<UnidadmedidaDto>>(unidadmedida);

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

        public Response<UnidadmedidaDto> GetBy(int idUnidadmedida)
        {
            var response = new Response<UnidadmedidaDto>();
            try
            {
                var unidadmedida = _unidadmedidaDomain.GetBy(idUnidadmedida);
                response.Data = _mapper.Map<UnidadmedidaDto>(unidadmedida);

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

        public Response<bool> InsertBy(UnidadmedidaDto unidadmedidaDto)
        {
            var response = new Response<bool>();
            try
            {
                var unidadmedida = _mapper.Map<Unidadmedida>(unidadmedidaDto);
                response.Data = _unidadmedidaDomain.InsertBy(unidadmedida);
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

        public Response<bool> UpdateBy(UnidadmedidaDto unidadmedidaDto)
        {
            var response = new Response<bool>();
            try
            {
                var unidadmedida = _mapper.Map<Unidadmedida>(unidadmedidaDto);
                response.Data = _unidadmedidaDomain.UpdateBy(unidadmedida);
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
        public async Task<Response<bool>> DeleteByAsync(int idUnidadmedida)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _unidadmedidaDomain.DeleteByAsync(idUnidadmedida);
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

        public async Task<Response<IEnumerable<UnidadmedidaDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<UnidadmedidaDto>>();
            try
            {
                var unidadmedida = await _unidadmedidaDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<UnidadmedidaDto>>(unidadmedida);

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

        public async Task<Response<UnidadmedidaDto>> GetByAsync(int idUnidadmedida)
        {
            var response = new Response<UnidadmedidaDto>();
            try
            {
                var unidadmedida = await _unidadmedidaDomain.GetByAsync(idUnidadmedida);
                response.Data = _mapper.Map<UnidadmedidaDto>(unidadmedida);

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

        public async Task<Response<bool>> InsertByAsync(UnidadmedidaDto unidadmedidaDto)
        {
            var response = new Response<bool>();
            try
            {
                var unidadmedida = _mapper.Map<Unidadmedida>(unidadmedidaDto);
                response.Data = await _unidadmedidaDomain.InsertByAsync(unidadmedida);
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

        public async Task<Response<bool>> UpdateByAsync(UnidadmedidaDto unidadmedidaDto)
        {
            var response = new Response<bool>();
            try
            {
                var unidadmedida = _mapper.Map<Unidadmedida>(unidadmedidaDto);
                response.Data = await _unidadmedidaDomain.UpdateByAsync(unidadmedida);
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
