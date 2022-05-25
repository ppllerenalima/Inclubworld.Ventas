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
    public class ProductoesApplication : IProductoesApplication
    {
        private readonly IProductoesDomain _productoesDomain;
        private readonly IMapper _mapper;
        private readonly IAppLogger<ProductoesApplication> _logger;

        public ProductoesApplication(IProductoesDomain productoesDomain, IMapper mapper, IAppLogger<ProductoesApplication> logger)
        {
            _productoesDomain = productoesDomain;
            _mapper = mapper;
            _logger = logger;
        }

        #region Métodos Síncronos
        public Response<bool> DeleteBy(int idProductoes)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = _productoesDomain.DeleteBy(idProductoes);
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

        public Response<IEnumerable<ProductoesDto>> GetAll()
        {
            var response = new Response<IEnumerable<ProductoesDto>>();
            try
            {
                var productoes = _productoesDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<ProductoesDto>>(productoes);

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

        public Response<ProductoesDto> GetBy(int idProductoes)
        {
            var response = new Response<ProductoesDto>();
            try
            {
                var productoes = _productoesDomain.GetBy(idProductoes);
                response.Data = _mapper.Map<ProductoesDto>(productoes);

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

        public Response<bool> InsertBy(ProductoesDto productoesDto)
        {
            var response = new Response<bool>();
            try
            {
                var productoes = _mapper.Map<Productoes>(productoesDto);
                response.Data = _productoesDomain.InsertBy(productoes);
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

        public Response<bool> UpdateBy(ProductoesDto productoesDto)
        {
            var response = new Response<bool>();
            try
            {
                var productoes = _mapper.Map<Productoes>(productoesDto);
                response.Data = _productoesDomain.UpdateBy(productoes);
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
        public async Task<Response<bool>> DeleteByAsync(int idProductoes)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _productoesDomain.DeleteByAsync(idProductoes);
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

        public async Task<Response<IEnumerable<ProductoesDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<ProductoesDto>>();
            try
            {
                var productoes = await _productoesDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<ProductoesDto>>(productoes);

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

        public async Task<Response<ProductoesDto>> GetByAsync(int idProductoes)
        {
            var response = new Response<ProductoesDto>();
            try
            {
                var productoes = await _productoesDomain.GetByAsync(idProductoes);
                response.Data = _mapper.Map<ProductoesDto>(productoes);

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

        public async Task<Response<bool>> InsertByAsync(ProductoesDto productoesDto)
        {
            var response = new Response<bool>();
            try
            {
                var productoes = _mapper.Map<Productoes>(productoesDto);
                response.Data = await _productoesDomain.InsertByAsync(productoes);
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

        public async Task<Response<bool>> UpdateByAsync(ProductoesDto productoesDto)
        {
            var response = new Response<bool>();
            try
            {
                var productoes = _mapper.Map<Productoes>(productoesDto);
                response.Data = await _productoesDomain.UpdateByAsync(productoes);
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
