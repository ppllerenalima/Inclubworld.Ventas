using Inclubworld.Ventas.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Domain.Interface
{
    public interface IUnidadmedidaDomain
    {
        #region Métodos Síncronos
        Boolean InsertBy(Unidadmedida obj_unidadmedida_1);
        Boolean UpdateBy(Unidadmedida obj_unidadmedida_1);
        Boolean DeleteBy(int idUnidadmedida);

        Unidadmedida GetBy(int idUnidadmedida);
        IEnumerable<Unidadmedida> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<Boolean> InsertByAsync(Unidadmedida obj_unidadmedida_1);
        Task<Boolean> UpdateByAsync(Unidadmedida obj_unidadmedida_1);
        Task<Boolean> DeleteByAsync(int idUnidadmedida);

        Task<Unidadmedida> GetByAsync(int idUnidadmedida);
        Task<IEnumerable<Unidadmedida>> GetAllAsync();
        #endregion
    }
}
