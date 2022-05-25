using Inclubworld.Ventas.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Infraestructure.Interface
{
    public interface IUsuarioRepository
    {
        #region Métodos Síncronos
        Boolean InsertBy(Usuario obj_usuario_1);
        Boolean UpdateBy(Usuario obj_usuario_1);
        Boolean DeleteBy(int idUsuario);

        Usuario GetBy(int idUsuario);
        IEnumerable<Usuario> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<Boolean> InsertByAsync(Usuario obj_usuario_1);
        Task<Boolean> UpdateByAsync(Usuario obj_usuario_1);
        Task<Boolean> DeleteByAsync(int idUsuario);

        Task<Usuario> GetByAsync(int idUsuario);
        Task<IEnumerable<Usuario>> GetAllAsync();
        #endregion
    }
}
