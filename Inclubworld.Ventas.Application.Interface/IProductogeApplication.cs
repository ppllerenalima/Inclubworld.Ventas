using Inclubworld.Ventas.Application.DTO;
using Inclubworld.Ventas.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Application.Interface
{
    public interface IProductogeApplication
    {
        #region Métodos Síncronos
        Response<Boolean> InsertBy(ProductogeDto productogeDto);
        Response<Boolean> UpdateBy(ProductogeDto productogeDto);
        Response<Boolean> DeleteBy(int idProductoge);

        Response<ProductogeDto> GetBy(int idProductoge);
        Response<IEnumerable<ProductogeDto>> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<Response<Boolean>> InsertByAsync(ProductogeDto productogeDto);
        Task<Response<Boolean>> UpdateByAsync(ProductogeDto productogeDto);
        Task<Response<Boolean>> DeleteByAsync(int idProductoge);

        Task<Response<ProductogeDto>> GetByAsync(int idProductoge);
        Task<Response<IEnumerable<ProductogeDto>>> GetAllAsync();
        #endregion
    }
}
