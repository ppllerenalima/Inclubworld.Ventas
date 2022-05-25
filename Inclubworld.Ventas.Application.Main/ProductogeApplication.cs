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
    public class ProductogeApplication : IProductogeApplication
    {
        private readonly IProductogeDomain _productogeDomain;
        private readonly IMapper _mapper;
        private readonly IAppLogger<ProductogeApplication> _logger;

        public ProductogeApplication(IProductogeDomain productogeDomain, IMapper mapper, IAppLogger<ProductogeApplication> logger)
        {
            _productogeDomain = productogeDomain;
            _mapper = mapper;
            _logger = logger;
        }

        #region Métodos Síncronos
        public Response<bool> DeleteBy(int idProductoge)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = _productogeDomain.DeleteBy(idProductoge);
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

        public Response<IEnumerable<ProductogeDto>> GetAll()
        {
            var response = new Response<IEnumerable<ProductogeDto>>();
            try
            {
                var productoge = _productogeDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<ProductogeDto>>(productoge);

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

        public Response<ProductogeDto> GetBy(int idProductoge)
        {
            var response = new Response<ProductogeDto>();
            try
            {
                var productoge = _productogeDomain.GetBy(idProductoge);
                response.Data = _mapper.Map<ProductogeDto>(productoge);

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

        public Response<bool> InsertBy(ProductogeDto productogeDto)
        {
            var response = new Response<bool>();
            try
            {
                var productoge = _mapper.Map<Productoge>(productogeDto);
                response.Data = _productogeDomain.InsertBy(productoge);
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

        public Response<bool> UpdateBy(ProductogeDto productogeDto)
        {
            var response = new Response<bool>();
            try
            {
                var productoge = _mapper.Map<Productoge>(productogeDto);
                response.Data = _productogeDomain.UpdateBy(productoge);
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
        public async Task<Response<bool>> DeleteByAsync(int idProductoge)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _productogeDomain.DeleteByAsync(idProductoge);
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

        public async Task<Response<IEnumerable<ProductogeDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<ProductogeDto>>();
            try
            {
                var productoge = await _productogeDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<ProductogeDto>>(productoge);

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

        public async Task<Response<ProductogeDto>> GetByAsync(int idProductoge)
        {
            var response = new Response<ProductogeDto>();
            try
            {
                var productoge = await _productogeDomain.GetByAsync(idProductoge);
                response.Data = _mapper.Map<ProductogeDto>(productoge);

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

        public async Task<Response<bool>> InsertByAsync(ProductogeDto productogeDto)
        {
            var response = new Response<bool>();
            try
            {
                var productoge = _mapper.Map<Productoge>(productogeDto);
                response.Data = await _productogeDomain.InsertByAsync(productoge);
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

        public async Task<Response<bool>> UpdateByAsync(ProductogeDto productogeDto)
        {
            var response = new Response<bool>();
            try
            {
                var productoge = _mapper.Map<Productoge>(productogeDto);
                response.Data = await _productogeDomain.UpdateByAsync(productoge);
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
