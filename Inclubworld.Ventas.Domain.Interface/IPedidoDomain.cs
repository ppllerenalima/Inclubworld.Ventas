using Inclubworld.Ventas.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Domain.Interface
{
    public interface IPedidoDomain
    {
        #region Métodos Síncronos
        Boolean InsertBy(Pedido obj_pedido_1);
        Boolean UpdateBy(Pedido obj_pedido_1);
        Boolean DeleteBy(int idPedido);

        Pedido GetBy(int idPedido);
        IEnumerable<Pedido> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<Boolean> InsertByAsync(Pedido obj_pedido_1);
        Task<Boolean> UpdateByAsync(Pedido obj_pedido_1);
        Task<Boolean> DeleteByAsync(int idPedido);

        Task<Pedido> GetByAsync(int idPedido);
        Task<IEnumerable<Pedido>> GetAllAsync();
        #endregion
    }
}
