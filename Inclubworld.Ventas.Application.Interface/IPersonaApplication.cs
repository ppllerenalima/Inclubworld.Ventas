using Inclubworld.Ventas.Application.DTO;
using Inclubworld.Ventas.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Application.Interface
{
    public interface IPersonaApplication
    {
        #region Métodos Síncronos
        Response<Boolean> InsertBy(PersonaDto personaDto);
        Response<Boolean> UpdateBy(PersonaDto personaDto);
        Response<Boolean> DeleteBy(int idPersona);

        Response<PersonaDto> GetBy(int idPersona);
        Response<IEnumerable<PersonaDto>> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<Response<Boolean>> InsertByAsync(PersonaDto personaDto);
        Task<Response<Boolean>> UpdateByAsync(PersonaDto personaDto);
        Task<Response<Boolean>> DeleteByAsync(int idPersona);

        Task<Response<PersonaDto>> GetByAsync(int idPersona);
        Task<Response<IEnumerable<PersonaDto>>> GetAllAsync();
        #endregion
    }
}
