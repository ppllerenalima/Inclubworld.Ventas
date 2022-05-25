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
    public class PersonaApplication : IPersonaApplication
    {
        private readonly IPersonaDomain _personaDomain;
        private readonly IMapper _mapper;
        private readonly IAppLogger<PersonaApplication> _logger;

        public PersonaApplication(IPersonaDomain personaDomain, IMapper mapper, IAppLogger<PersonaApplication> logger)
        {
            _personaDomain = personaDomain;
            _mapper = mapper;
            _logger = logger;
        }

        #region Métodos Síncronos
        public Response<bool> DeleteBy(int idPersona)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = _personaDomain.DeleteBy(idPersona);
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

        public Response<IEnumerable<PersonaDto>> GetAll()
        {
            var response = new Response<IEnumerable<PersonaDto>>();
            try
            {
                var persona = _personaDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<PersonaDto>>(persona);

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

        public Response<PersonaDto> GetBy(int idPersona)
        {
            var response = new Response<PersonaDto>();
            try
            {
                var persona = _personaDomain.GetBy(idPersona);
                response.Data = _mapper.Map<PersonaDto>(persona);

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

        public Response<bool> InsertBy(PersonaDto personaDto)
        {
            var response = new Response<bool>();
            try
            {
                var persona = _mapper.Map<Persona>(personaDto);
                response.Data = _personaDomain.InsertBy(persona);
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

        public Response<bool> UpdateBy(PersonaDto personaDto)
        {
            var response = new Response<bool>();
            try
            {
                var persona = _mapper.Map<Persona>(personaDto);
                response.Data = _personaDomain.UpdateBy(persona);
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
        public async Task<Response<bool>> DeleteByAsync(int idPersona)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _personaDomain.DeleteByAsync(idPersona);
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

        public async Task<Response<IEnumerable<PersonaDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<PersonaDto>>();
            try
            {
                var persona = await _personaDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<PersonaDto>>(persona);

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

        public async Task<Response<PersonaDto>> GetByAsync(int idPersona)
        {
            var response = new Response<PersonaDto>();
            try
            {
                var persona = await _personaDomain.GetByAsync(idPersona);
                response.Data = _mapper.Map<PersonaDto>(persona);

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

        public async Task<Response<bool>> InsertByAsync(PersonaDto personaDto)
        {
            var response = new Response<bool>();
            try
            {
                var persona = _mapper.Map<Persona>(personaDto);
                response.Data = await _personaDomain.InsertByAsync(persona);
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

        public async Task<Response<bool>> UpdateByAsync(PersonaDto personaDto)
        {
            var response = new Response<bool>();
            try
            {
                var persona = _mapper.Map<Persona>(personaDto);
                response.Data = await _personaDomain.UpdateByAsync(persona);
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
