using Inclubworld.Ventas.Application.DTO;
using Inclubworld.Ventas.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Application.Interface
{
    public interface IProductoesApplication
    {
        #region Métodos Síncronos
        Response<Boolean> InsertBy(ProductoesDto productoesDto);
        Response<Boolean> UpdateBy(ProductoesDto productoesDto);
        Response<Boolean> DeleteBy(int idProductoes);

        Response<ProductoesDto> GetBy(int idProductoes);
        Response<IEnumerable<ProductoesDto>> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<Response<Boolean>> InsertByAsync(ProductoesDto productoesDto);
        Task<Response<Boolean>> UpdateByAsync(ProductoesDto productoesDto);
        Task<Response<Boolean>> DeleteByAsync(int idProductoes);

        Task<Response<ProductoesDto>> GetByAsync(int idProductoes);
        Task<Response<IEnumerable<ProductoesDto>>> GetAllAsync();
        #endregion
    }
}
