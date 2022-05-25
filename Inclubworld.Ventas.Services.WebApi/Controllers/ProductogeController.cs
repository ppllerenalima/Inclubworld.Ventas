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
    public class ProductogeController : ControllerBase
    {
        private readonly IProductogeApplication _productogeApplication;

        public ProductogeController(IProductogeApplication productogeApplication)
        {
            _productogeApplication = productogeApplication;
        }

        #region Métodos Síncronos
        [HttpPost("/api/Productoge/InsertBy/")]
        public IActionResult InsertBy([FromBody] ProductogeDto productogeDto)
        {
            if (productogeDto == null)
                return BadRequest();

            var response = _productogeApplication.InsertBy(productogeDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("/api/Productoge/UpdateBy/")]
        public IActionResult UpdateBy([FromBody] ProductogeDto productogeDto)
        {
            if (productogeDto == null)
                return BadRequest();

            var response = _productogeApplication.UpdateBy(productogeDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("/api/Productoge/DeleteBy/{idProductoge}")]
        public IActionResult DeleteBy(int idProductoge)
        {
            if (idProductoge == 0)
                return BadRequest();

            var response = _productogeApplication.DeleteBy(idProductoge);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("/api/Productoge/GetBy/{idProductoge}")]
        public IActionResult GetBy(int idProductoge)
        {
            if (idProductoge == 0)
                return BadRequest();

            var response = _productogeApplication.GetBy(idProductoge);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [AllowAnonymous]
        [HttpGet("/api/Productoge/GetAll/")]
        public IActionResult GetAll()
        {
            var response = _productogeApplication.GetAll();

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
        #endregion

        #region Métodos Asíncronos
        [HttpPost("/api/Productoge/InsertByAsync/{productogeDto}/")]
        public async Task<IActionResult> InsertByAsync([FromBody] ProductogeDto productogeDto)
        {
            if (productogeDto == null)
                return BadRequest();

            var response = await _productogeApplication.InsertByAsync(productogeDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("/api/Productoge/UpdateByAsync/{productogeDto}/")]
        public async Task<IActionResult> UpdateByAsync([FromBody] ProductogeDto productogeDto)
        {
            if (productogeDto == null)
                return BadRequest();

            var response = await _productogeApplication.UpdateByAsync(productogeDto);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("/api/Productoge/DeleteByAsync/{idProductoge}/")]
        public async Task<IActionResult> DeleteByAsync(int idProductoge)
        {
            if (idProductoge == 0)
                return BadRequest();

            var response = await _productogeApplication.DeleteByAsync(idProductoge);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("/api/Productoge/GetByAsync/{idProductoge}/")]
        public async Task<IActionResult> GetByAsync(int idProductoge)
        {
            if (idProductoge == 0)
                return BadRequest();

            var response = await _productogeApplication.GetByAsync(idProductoge);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [AllowAnonymous]
        [HttpGet("/api/Productoge/GetAllAsync/")]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _productogeApplication.GetAllAsync();

            if (response.IsSuccess)
            {

                return Ok(response);
            }
            return BadRequest(response.Message);
        }
        #endregion
    }
}
