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
    public class ProductoesController : ControllerBase
    {
        private readonly IProductoesApplication _productoesApplication;

        public ProductoesController(IProductoesApplication productoesApplication)
        {
            _productoesApplication = productoesApplication;
        }

        #region Métodos Síncronos
        [HttpPost("/api/Productoes/InsertBy/")]
        public IActionResult InsertBy([FromBody] ProductoesDto productoesDto)
        {
            if (productoesDto == null)
                return BadRequest();

            var response = _productoesApplication.InsertBy(productoesDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("/api/Productoes/UpdateBy/")]
        public IActionResult UpdateBy([FromBody] ProductoesDto productoesDto)
        {
            if (productoesDto == null)
                return BadRequest();

            var response = _productoesApplication.UpdateBy(productoesDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("/api/Productoes/DeleteBy/{idProductoes}")]
        public IActionResult DeleteBy(int idProductoes)
        {
            if (idProductoes == 0)
                return BadRequest();

            var response = _productoesApplication.DeleteBy(idProductoes);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("/api/Productoes/GetBy/{idProductoes}")]
        public IActionResult GetBy(int idProductoes)
        {
            if (idProductoes == 0)
                return BadRequest();

            var response = _productoesApplication.GetBy(idProductoes);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [AllowAnonymous]
        [HttpGet("/api/Productoes/GetAll/")]
        public IActionResult GetAll()
        {
            var response = _productoesApplication.GetAll();

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
        #endregion

        #region Métodos Asíncronos
        [HttpPost("/api/Productoes/InsertByAsync/{productoesDto}/")]
        public async Task<IActionResult> InsertByAsync([FromBody] ProductoesDto productoesDto)
        {
            if (productoesDto == null)
                return BadRequest();

            var response = await _productoesApplication.InsertByAsync(productoesDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("/api/Productoes/UpdateByAsync/{productoesDto}/")]
        public async Task<IActionResult> UpdateByAsync([FromBody] ProductoesDto productoesDto)
        {
            if (productoesDto == null)
                return BadRequest();

            var response = await _productoesApplication.UpdateByAsync(productoesDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("/api/Productoes/DeleteByAsync/{idProductoes}/")]
        public async Task<IActionResult> DeleteByAsync(int idProductoes)
        {
            if (idProductoes == 0)
                return BadRequest();

            var response = await _productoesApplication.DeleteByAsync(idProductoes);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("/api/Productoes/GetByAsync/{idProductoes}/")]
        public async Task<IActionResult> GetByAsync(int idProductoes)
        {
            if (idProductoes == 0)
                return BadRequest();

            var response = await _productoesApplication.GetByAsync(idProductoes);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [AllowAnonymous]
        [HttpGet("/api/Productoes/GetAllAsync/")]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _productoesApplication.GetAllAsync();

            if (response.IsSuccess)
            {

                return Ok(response);
            }
            return BadRequest(response.Message);
        }
        #endregion
    }
}
