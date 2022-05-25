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
    public class UsuarioApplication : IUsuarioApplication
    {
        private readonly IUsuarioDomain _usuarioDomain;
        private readonly IMapper _mapper;
        private readonly IAppLogger<UsuarioApplication> _logger;

        public UsuarioApplication(IUsuarioDomain usuarioDomain, IMapper mapper, IAppLogger<UsuarioApplication> logger)
        {
            _usuarioDomain = usuarioDomain;
            _mapper = mapper;
            _logger = logger;
        }

        #region Métodos Síncronos
        public Response<bool> DeleteBy(int idUsuario)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = _usuarioDomain.DeleteBy(idUsuario);
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

        public Response<IEnumerable<UsuarioDto>> GetAll()
        {
            var response = new Response<IEnumerable<UsuarioDto>>();
            try
            {
                var usuario = _usuarioDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<UsuarioDto>>(usuario);

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

        public Response<UsuarioDto> GetBy(int idUsuario)
        {
            var response = new Response<UsuarioDto>();
            try
            {
                var usuario = _usuarioDomain.GetBy(idUsuario);
                response.Data = _mapper.Map<UsuarioDto>(usuario);

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

        public Response<bool> InsertBy(UsuarioDto usuarioDto)
        {
            var response = new Response<bool>();
            try
            {
                var usuario = _mapper.Map<Usuario>(usuarioDto);
                response.Data = _usuarioDomain.InsertBy(usuario);
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

        public Response<bool> UpdateBy(UsuarioDto usuarioDto)
        {
            var response = new Response<bool>();
            try
            {
                var usuario = _mapper.Map<Usuario>(usuarioDto);
                response.Data = _usuarioDomain.UpdateBy(usuario);
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
        public async Task<Response<bool>> DeleteByAsync(int idUsuario)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _usuarioDomain.DeleteByAsync(idUsuario);
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

        public async Task<Response<IEnumerable<UsuarioDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<UsuarioDto>>();
            try
            {
                var usuario = await _usuarioDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<UsuarioDto>>(usuario);

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

        public async Task<Response<UsuarioDto>> GetByAsync(int idUsuario)
        {
            var response = new Response<UsuarioDto>();
            try
            {
                var usuario = await _usuarioDomain.GetByAsync(idUsuario);
                response.Data = _mapper.Map<UsuarioDto>(usuario);

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

        public async Task<Response<bool>> InsertByAsync(UsuarioDto usuarioDto)
        {
            var response = new Response<bool>();
            try
            {
                var usuario = _mapper.Map<Usuario>(usuarioDto);
                response.Data = await _usuarioDomain.InsertByAsync(usuario);
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

        public async Task<Response<bool>> UpdateByAsync(UsuarioDto usuarioDto)
        {
            var response = new Response<bool>();
            try
            {
                var usuario = _mapper.Map<Usuario>(usuarioDto);
                response.Data = await _usuarioDomain.UpdateByAsync(usuario);
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
