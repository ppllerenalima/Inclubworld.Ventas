using Inclubworld.Ventas.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Domain.Interface
{
    public interface IPersonaDomain
    {
        #region Métodos Síncronos
        Boolean InsertBy(Persona obj_persona_1);
        Boolean UpdateBy(Persona obj_persona_1);
        Boolean DeleteBy(int idPersona);

        Persona GetBy(int idPersona);
        IEnumerable<Persona> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<Boolean> InsertByAsync(Persona obj_persona_1);
        Task<Boolean> UpdateByAsync(Persona obj_persona_1);
        Task<Boolean> DeleteByAsync(int idPersona);

        Task<Persona> GetByAsync(int idPersona);
        Task<IEnumerable<Persona>> GetAllAsync();
        #endregion
    }
}
