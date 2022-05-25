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
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioApplication _usuarioApplication;

        public UsuarioController(IUsuarioApplication usuarioApplication)
        {
            _usuarioApplication = usuarioApplication;
        }

        #region Métodos Síncronos
        [HttpPost("/api/Usuario/InsertBy/")]
        public IActionResult InsertBy([FromBody] UsuarioDto usuarioDto)
        {
            if (usuarioDto == null)
                return BadRequest();

            var response = _usuarioApplication.InsertBy(usuarioDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("/api/Usuario/UpdateBy/")]
        public IActionResult UpdateBy([FromBody] UsuarioDto usuarioDto)
        {
            if (usuarioDto == null)
                return BadRequest();

            var response = _usuarioApplication.UpdateBy(usuarioDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("/api/Usuario/DeleteBy/{idUsuario}")]
        public IActionResult DeleteBy(int idUsuario)
        {
            if (idUsuario == 0)
                return BadRequest();

            var response = _usuarioApplication.DeleteBy(idUsuario);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("/api/Usuario/GetBy/{idUsuario}")]
        public IActionResult GetBy(int idUsuario)
        {
            if (idUsuario == 0)
                return BadRequest();

            var response = _usuarioApplication.GetBy(idUsuario);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [AllowAnonymous]
        [HttpGet("/api/Usuario/GetAll/")]
        public IActionResult GetAll()
        {
            var response = _usuarioApplication.GetAll();

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
        #endregion

        #region Métodos Asíncronos
        [HttpPost("/api/Usuario/InsertByAsync/{usuarioDto}/")]
        public async Task<IActionResult> InsertByAsync([FromBody] UsuarioDto usuarioDto)
        {
            if (usuarioDto == null)
                return BadRequest();

            var response = await _usuarioApplication.InsertByAsync(usuarioDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("/api/Usuario/UpdateByAsync/{usuarioDto}/")]
        public async Task<IActionResult> UpdateByAsync([FromBody] UsuarioDto usuarioDto)
        {
            if (usuarioDto == null)
                return BadRequest();

            var response = await _usuarioApplication.UpdateByAsync(usuarioDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("/api/Usuario/DeleteByAsync/{idUsuario}/")]
        public async Task<IActionResult> DeleteByAsync(int idUsuario)
        {
            if (idUsuario == 0)
                return BadRequest();

            var response = await _usuarioApplication.DeleteByAsync(idUsuario);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("/api/Usuario/GetByAsync/{idUsuario}/")]
        public async Task<IActionResult> GetByAsync(int idUsuario)
        {
            if (idUsuario == 0)
                return BadRequest();

            var response = await _usuarioApplication.GetByAsync(idUsuario);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [AllowAnonymous]
        [HttpGet("/api/Usuario/GetAllAsync/")]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _usuarioApplication.GetAllAsync();

            if (response.IsSuccess)
            {

                return Ok(response);
            }
            return BadRequest(response.Message);
        }
        #endregion
    }
}
