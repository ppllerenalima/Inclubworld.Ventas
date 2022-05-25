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
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoApplication _pedidoApplication;

        public PedidoController(IPedidoApplication pedidoApplication)
        {
            _pedidoApplication = pedidoApplication;
        }

        #region Métodos Síncronos
        [HttpPost("/api/Pedido/InsertBy/")]
        public IActionResult InsertBy([FromBody] PedidoDto pedidoDto)
        {
            if (pedidoDto == null)
                return BadRequest();

            var response = _pedidoApplication.InsertBy(pedidoDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("/api/Pedido/UpdateBy/")]
        public IActionResult UpdateBy([FromBody] PedidoDto pedidoDto)
        {
            if (pedidoDto == null)
                return BadRequest();

            var response = _pedidoApplication.UpdateBy(pedidoDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("/api/Pedido/DeleteBy/{idPedido}")]
        public IActionResult DeleteBy(int idPedido)
        {
            if (idPedido == 0)
                return BadRequest();

            var response = _pedidoApplication.DeleteBy(idPedido);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("/api/Pedido/GetBy/{idPedido}")]
        public IActionResult GetBy(int idPedido)
        {
            if (idPedido == 0)
                return BadRequest();

            var response = _pedidoApplication.GetBy(idPedido);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [AllowAnonymous]
        [HttpGet("/api/Pedido/GetAll/")]
        public IActionResult GetAll()
        {
            var response = _pedidoApplication.GetAll();

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
        #endregion

        #region Métodos Asíncronos
        [HttpPost("/api/Pedido/InsertByAsync/{pedidoDto}/")]
        public async Task<IActionResult> InsertByAsync([FromBody] PedidoDto pedidoDto)
        {
            if (pedidoDto == null)
                return BadRequest();

            var response = await _pedidoApplication.InsertByAsync(pedidoDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("/api/Pedido/UpdateByAsync/{pedidoDto}/")]
        public async Task<IActionResult> UpdateByAsync([FromBody] PedidoDto pedidoDto)
        {
            if (pedidoDto == null)
                return BadRequest();

            var response = await _pedidoApplication.UpdateByAsync(pedidoDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("/api/Pedido/DeleteByAsync/{idPedido}/")]
        public async Task<IActionResult> DeleteByAsync(int idPedido)
        {
            if (idPedido == 0)
                return BadRequest();

            var response = await _pedidoApplication.DeleteByAsync(idPedido);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("/api/Pedido/GetByAsync/{idPedido}/")]
        public async Task<IActionResult> GetByAsync(int idPedido)
        {
            if (idPedido == 0)
                return BadRequest();

            var response = await _pedidoApplication.GetByAsync(idPedido);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [AllowAnonymous]
        [HttpGet("/api/Pedido/GetAllAsync/")]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _pedidoApplication.GetAllAsync();

            if (response.IsSuccess)
            {

                return Ok(response);
            }
            return BadRequest(response.Message);
        }
        #endregion
    }
}
