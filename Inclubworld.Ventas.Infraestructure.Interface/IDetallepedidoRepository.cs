using Inclubworld.Ventas.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Infraestructure.Interface
{
    public interface IDetallepedidoRepository
    {
        #region Métodos Síncronos
        Boolean InsertBy(Detallepedido obj_detallepedido_1);
        Boolean UpdateBy(Detallepedido obj_detallepedido_1);
        Boolean DeleteBy(int idDetallepedido);

        Detallepedido GetBy(int idDetallepedido);
        IEnumerable<Detallepedido> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<Boolean> InsertByAsync(Detallepedido obj_detallepedido_1);
        Task<Boolean> UpdateByAsync(Detallepedido obj_detallepedido_1);
        Task<Boolean> DeleteByAsync(int idDetallepedido);

        Task<Detallepedido> GetByAsync(int idDetallepedido);
        Task<IEnumerable<Detallepedido>> GetAllAsync();
        #endregion
    }
}
