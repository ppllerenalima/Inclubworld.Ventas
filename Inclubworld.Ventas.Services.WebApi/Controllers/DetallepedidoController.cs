using Inclubworld.Ventas.Application.DTO;
using Inclubworld.Ventas.Application.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Services.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DetallepedidoController : ControllerBase
    {
        private readonly IDetallepedidoApplication _detallepedidoApplication;

        public DetallepedidoController(IDetallepedidoApplication detallepedidoApplication)
        {
            _detallepedidoApplication = detallepedidoApplication;
        }

        #region Métodos Síncronos
        [HttpPost("/api/Detallepedido/InsertBy/")]
        public IActionResult InsertBy([FromBody] DetallepedidoDto detallepedidoDto)
        {
            if (detallepedidoDto == null)
                return BadRequest();

            var response = _detallepedidoApplication.InsertBy(detallepedidoDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("/api/Detallepedido/UpdateBy/")]
        public IActionResult UpdateBy([FromBody] DetallepedidoDto detallepedidoDto)
        {
            if (detallepedidoDto == null)
                return BadRequest();

            var response = _detallepedidoApplication.UpdateBy(detallepedidoDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("/api/Detallepedido/DeleteBy/{idDetallepedido}")]
        public IActionResult DeleteBy(int idDetallepedido)
        {
            if (idDetallepedido == 0)
                return BadRequest();

            var response = _detallepedidoApplication.DeleteBy(idDetallepedido);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("/api/Detallepedido/GetBy/{idDetallepedido}")]
        public IActionResult GetBy(int idDetallepedido)
        {
            if (idDetallepedido == 0)
                return BadRequest();

            var response = _detallepedidoApplication.GetBy(idDetallepedido);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [AllowAnonymous]
        [HttpGet("/api/Detallepedido/GetAll/")]
        public IActionResult GetAll()
        {
            var response = _detallepedidoApplication.GetAll();

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
        #endregion

        #region Métodos Asíncronos
        [HttpPost("/api/Detallepedido/InsertByAsync/{detallepedidoDto}/")]
        public async Task<IActionResult> InsertByAsync([FromBody] DetallepedidoDto detallepedidoDto)
        {
            if (detallepedidoDto == null)
                return BadRequest();

            var response = await _detallepedidoApplication.InsertByAsync(detallepedidoDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("/api/Detallepedido/UpdateByAsync/{detallepedidoDto}/")]
        public async Task<IActionResult> UpdateByAsync([FromBody] DetallepedidoDto detallepedidoDto)
        {
            if (detallepedidoDto == null)
                return BadRequest();

            var response = await _detallepedidoApplication.UpdateByAsync(detallepedidoDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("/api/Detallepedido/DeleteByAsync/{idDetallepedido}/")]
        public async Task<IActionResult> DeleteByAsync(int idDetallepedido)
        {
            if (idDetallepedido == 0)
                return BadRequest();

            var response = await _detallepedidoApplication.DeleteByAsync(idDetallepedido);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("/api/Detallepedido/GetByAsync/{idDetallepedido}/")]
        public async Task<IActionResult> GetByAsync(int idDetallepedido)
        {
            if (idDetallepedido == 0)
                return BadRequest();

            var response = await _detallepedidoApplication.GetByAsync(idDetallepedido);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [AllowAnonymous]
        [HttpGet("/api/Detallepedido/GetAllAsync/")]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _detallepedidoApplication.GetAllAsync();

            if (response.IsSuccess)
            {

                return Ok(response);
            }
            return BadRequest(response.Message);
        }
        #endregion
    }
}
