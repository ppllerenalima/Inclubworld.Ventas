using Inclubworld.Ventas.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Domain.Interface
{
    public interface IProductogeDomain
    {
        #region Métodos Síncronos
        Boolean InsertBy(Productoge obj_productoge_1);
        Boolean UpdateBy(Productoge obj_productoge_1);
        Boolean DeleteBy(int idProductoge);

        Productoge GetBy(int idProductoge);
        IEnumerable<Productoge> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<Boolean> InsertByAsync(Productoge obj_productoge_1);
        Task<Boolean> UpdateByAsync(Productoge obj_productoge_1);
        Task<Boolean> DeleteByAsync(int idProductoge);

        Task<Productoge> GetByAsync(int idProductoge);
        Task<IEnumerable<Productoge>> GetAllAsync();
        #endregion
    }
}
