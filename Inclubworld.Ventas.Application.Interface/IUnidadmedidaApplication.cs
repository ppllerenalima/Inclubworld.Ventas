using Inclubworld.Ventas.Application.DTO;
using Inclubworld.Ventas.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Application.Interface
{
    public interface IUnidadmedidaApplication
    {
        #region Métodos Síncronos
        Response<Boolean> InsertBy(UnidadmedidaDto unidadmedidaDto);
        Response<Boolean> UpdateBy(UnidadmedidaDto unidadmedidaDto);
        Response<Boolean> DeleteBy(int idUnidadmedida);

        Response<UnidadmedidaDto> GetBy(int idUnidadmedida);
        Response<IEnumerable<UnidadmedidaDto>> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<Response<Boolean>> InsertByAsync(UnidadmedidaDto unidadmedidaDto);
        Task<Response<Boolean>> UpdateByAsync(UnidadmedidaDto unidadmedidaDto);
        Task<Response<Boolean>> DeleteByAsync(int idUnidadmedida);

        Task<Response<UnidadmedidaDto>> GetByAsync(int idUnidadmedida);
        Task<Response<IEnumerable<UnidadmedidaDto>>> GetAllAsync();
        #endregion
    }
}
