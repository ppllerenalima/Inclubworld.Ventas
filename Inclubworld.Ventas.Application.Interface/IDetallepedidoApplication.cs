using Inclubworld.Ventas.Application.DTO;
using Inclubworld.Ventas.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Application.Interface
{
    public interface IDetallepedidoApplication
    {
        #region Métodos Síncronos
        Response<Boolean> InsertBy(DetallepedidoDto detallepedidoDto);
        Response<Boolean> UpdateBy(DetallepedidoDto detallepedidoDto);
        Response<Boolean> DeleteBy(int idDetallepedido);

        Response<DetallepedidoDto> GetBy(int idDetallepedido);
        Response<IEnumerable<DetallepedidoDto>> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<Response<Boolean>> InsertByAsync(DetallepedidoDto detallepedidoDto);
        Task<Response<Boolean>> UpdateByAsync(DetallepedidoDto detallepedidoDto);
        Task<Response<Boolean>> DeleteByAsync(int idDetallepedido);

        Task<Response<DetallepedidoDto>> GetByAsync(int idDetallepedido);
        Task<Response<IEnumerable<DetallepedidoDto>>> GetAllAsync();
        #endregion
    }
}
