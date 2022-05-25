using Inclubworld.Ventas.Application.DTO;
using Inclubworld.Ventas.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Application.Interface
{
    public interface IPedidoApplication
    {
        #region Métodos Síncronos
        Response<Boolean> InsertBy(PedidoDto pedidoDto);
        Response<Boolean> UpdateBy(PedidoDto pedidoDto);
        Response<Boolean> DeleteBy(int idPedido);

        Response<PedidoDto> GetBy(int idPedido);
        Response<IEnumerable<PedidoDto>> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<Response<Boolean>> InsertByAsync(PedidoDto pedidoDto);
        Task<Response<Boolean>> UpdateByAsync(PedidoDto pedidoDto);
        Task<Response<Boolean>> DeleteByAsync(int idPedido);

        Task<Response<PedidoDto>> GetByAsync(int idPedido);
        Task<Response<IEnumerable<PedidoDto>>> GetAllAsync();
        #endregion
    }
}
