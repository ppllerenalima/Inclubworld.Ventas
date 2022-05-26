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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UnidadmedidaController : ControllerBase
    {
        private readonly IUnidadmedidaApplication _unidadmedidaApplication;

        public UnidadmedidaController(IUnidadmedidaApplication unidadmedidaApplication)
        {
            _unidadmedidaApplication = unidadmedidaApplication;
        }

        #region Métodos Síncronos
        [HttpPost("/api/Unidadmedida/InsertBy/")]
        public IActionResult InsertBy([FromBody] UnidadmedidaDto unidadmedidaDto)
        {
            if (unidadmedidaDto == null)
                return BadRequest();

            var response = _unidadmedidaApplication.InsertBy(unidadmedidaDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("/api/Unidadmedida/UpdateBy/")]
        public IActionResult UpdateBy([FromBody] UnidadmedidaDto unidadmedidaDto)
        {
            if (unidadmedidaDto == null)
                return BadRequest();

            var response = _unidadmedidaApplication.UpdateBy(unidadmedidaDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("/api/Unidadmedida/DeleteBy/{idUnidadmedida}")]
        public IActionResult DeleteBy(int idUnidadmedida)
        {
            if (idUnidadmedida == 0)
                return BadRequest();

            var response = _unidadmedidaApplication.DeleteBy(idUnidadmedida);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("/api/Unidadmedida/GetBy/{idUnidadmedida}")]
        public IActionResult GetBy(int idUnidadmedida)
        {
            if (idUnidadmedida == 0)
                return BadRequest();

            var response = _unidadmedidaApplication.GetBy(idUnidadmedida);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [AllowAnonymous]
        [HttpGet("/api/Unidadmedida/GetAll/")]
        public IActionResult GetAll()
        {
            var response = _unidadmedidaApplication.GetAll();

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
        #endregion

        #region Métodos Asíncronos
        [HttpPost("/api/Unidadmedida/InsertByAsync/{unidadmedidaDto}/")]
        public async Task<IActionResult> InsertByAsync([FromBody] UnidadmedidaDto unidadmedidaDto)
        {
            if (unidadmedidaDto == null)
                return BadRequest();

            var response = await _unidadmedidaApplication.InsertByAsync(unidadmedidaDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("/api/Unidadmedida/UpdateByAsync/{unidadmedidaDto}/")]
        public async Task<IActionResult> UpdateByAsync([FromBody] UnidadmedidaDto unidadmedidaDto)
        {
            if (unidadmedidaDto == null)
                return BadRequest();

            var response = await _unidadmedidaApplication.UpdateByAsync(unidadmedidaDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("/api/Unidadmedida/DeleteByAsync/{idUnidadmedida}/")]
        public async Task<IActionResult> DeleteByAsync(int idUnidadmedida)
        {
            if (idUnidadmedida == 0)
                return BadRequest();

            var response = await _unidadmedidaApplication.DeleteByAsync(idUnidadmedida);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("/api/Unidadmedida/GetByAsync/{idUnidadmedida}/")]
        public async Task<IActionResult> GetByAsync(int idUnidadmedida)
        {
            if (idUnidadmedida == 0)
                return BadRequest();

            var response = await _unidadmedidaApplication.GetByAsync(idUnidadmedida);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [AllowAnonymous]
        [HttpGet("/api/Unidadmedida/GetAllAsync/")]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _unidadmedidaApplication.GetAllAsync();

            if (response.IsSuccess)
            {

                return Ok(response);
            }
            return BadRequest(response.Message);
        }
        #endregion
    }
}
