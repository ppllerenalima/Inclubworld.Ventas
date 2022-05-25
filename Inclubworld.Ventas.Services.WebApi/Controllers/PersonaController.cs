using Inclubworld.Ventas.Application.DTO;
using Inclubworld.Ventas.Application.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Services.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaApplication _personaApplication;

        public PersonaController(IPersonaApplication personaApplication)
        {
            _personaApplication = personaApplication;
        }

        #region Métodos Síncronos
        [HttpPost("/api/Persona/InsertBy/")]
        public IActionResult InsertBy([FromBody] PersonaDto personaDto)
        {
            if (personaDto == null)
                return BadRequest();

            var response = _personaApplication.InsertBy(personaDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("/api/Persona/UpdateBy/")]
        public IActionResult UpdateBy([FromBody] PersonaDto personaDto)
        {
            if (personaDto == null)
                return BadRequest();

            var response = _personaApplication.UpdateBy(personaDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("/api/Persona/DeleteBy/{idPersona}")]
        public IActionResult DeleteBy(int idPersona)
        {
            if (idPersona == 0)
                return BadRequest();

            var response = _personaApplication.DeleteBy(idPersona);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("/api/Persona/GetBy/{idPersona}")]
        public IActionResult GetBy(int idPersona)
        {
            if (idPersona == 0)
                return BadRequest();

            var response = _personaApplication.GetBy(idPersona);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [AllowAnonymous]
        [HttpGet("/api/Persona/GetAll/")]
        public IActionResult GetAll()
        {
            var response = _personaApplication.GetAll();

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
        #endregion

        #region Métodos Asíncronos
        [HttpPost("/api/Persona/InsertByAsync/{personaDto}/")]
        public async Task<IActionResult> InsertByAsync([FromBody] PersonaDto personaDto)
        {
            if (personaDto == null)
                return BadRequest();

            var response = await _personaApplication.InsertByAsync(personaDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("/api/Persona/UpdateByAsync/{personaDto}/")]
        public async Task<IActionResult> UpdateByAsync([FromBody] PersonaDto personaDto)
        {
            if (personaDto == null)
                return BadRequest();

            var response = await _personaApplication.UpdateByAsync(personaDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("/api/Persona/DeleteByAsync/{idPersona}/")]
        public async Task<IActionResult> DeleteByAsync(int idPersona)
        {
            if (idPersona == 0)
                return BadRequest();

            var response = await _personaApplication.DeleteByAsync(idPersona);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("/api/Persona/GetByAsync/{idPersona}/")]
        public async Task<IActionResult> GetByAsync(int idPersona)
        {
            if (idPersona == 0)
                return BadRequest();

            var response = await _personaApplication.GetByAsync(idPersona);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [AllowAnonymous]
        [HttpGet("/api/Persona/GetAllAsync/")]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _personaApplication.GetAllAsync();

            if (response.IsSuccess)
            {

                return Ok(response);
            }
            return BadRequest(response.Message);
        }
        #endregion
    }
}
