using Inclubworld.Ventas.Application.DTO;
using Inclubworld.Ventas.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Application.Interface
{
    public interface IUsuarioApplication
    {
        #region Métodos Síncronos
        Response<Boolean> InsertBy(UsuarioDto usuarioDto);
        Response<Boolean> UpdateBy(UsuarioDto usuarioDto);
        Response<Boolean> DeleteBy(int idUsuario);

        Response<UsuarioDto> GetBy(int idUsuario);
        Response<IEnumerable<UsuarioDto>> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<Response<Boolean>> InsertByAsync(UsuarioDto usuarioDto);
        Task<Response<Boolean>> UpdateByAsync(UsuarioDto usuarioDto);
        Task<Response<Boolean>> DeleteByAsync(int idUsuario);

        Task<Response<UsuarioDto>> GetByAsync(int idUsuario);
        Task<Response<IEnumerable<UsuarioDto>>> GetAllAsync();
        #endregion
    }
}
