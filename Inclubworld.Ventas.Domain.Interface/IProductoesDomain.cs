using Inclubworld.Ventas.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Domain.Interface
{
    public interface IProductoesDomain
    {
        #region Métodos Síncronos
        Boolean InsertBy(Productoes obj_productoes_1);
        Boolean UpdateBy(Productoes obj_productoes_1);
        Boolean DeleteBy(int idProductoes);

        Productoes GetBy(int idProductoes);
        IEnumerable<Productoes> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<Boolean> InsertByAsync(Productoes obj_productoes_1);
        Task<Boolean> UpdateByAsync(Productoes obj_productoes_1);
        Task<Boolean> DeleteByAsync(int idProductoes);

        Task<Productoes> GetByAsync(int idProductoes);
        Task<IEnumerable<Productoes>> GetAllAsync();
        #endregion
    }
}
