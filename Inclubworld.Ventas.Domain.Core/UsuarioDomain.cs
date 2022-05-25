using Inclubworld.Ventas.Domain.Entity;
using Inclubworld.Ventas.Domain.Interface;
using Inclubworld.Ventas.Infraestructure.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Domain.Core
{
    public class UsuarioDomain : IUsuarioDomain
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioDomain(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        #region Métodos Síncronos
        public Boolean DeleteBy(int idUsuario)
        {
            return _usuarioRepository.DeleteBy(idUsuario);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _usuarioRepository.GetAll();
        }

        public Usuario GetBy(int idUsuario)
        {
            return _usuarioRepository.GetBy(idUsuario);
        }

        public Boolean InsertBy(Usuario obj_usuario_1)
        {
            return _usuarioRepository.InsertBy(obj_usuario_1);
        }

        public Boolean UpdateBy(Usuario obj_usuario_1)
        {
            return _usuarioRepository.UpdateBy(obj_usuario_1);
        }
        #endregion

        #region Métodos Asíncronos
        public async Task<Boolean> DeleteByAsync(int idUsuario)
        {
            return await _usuarioRepository.DeleteByAsync(idUsuario);
        }

        public async Task<IEnumerable<Usuario>> GetAllAsync()
        {
            return await _usuarioRepository.GetAllAsync();
        }

        public async Task<Usuario> GetByAsync(int idUsuario)
        {
            return await _usuarioRepository.GetByAsync(idUsuario);
        }

        public async Task<Boolean> InsertByAsync(Usuario obj_usuario_1)
        {
            return await _usuarioRepository.InsertByAsync(obj_usuario_1);
        }

        public async Task<Boolean> UpdateByAsync(Usuario obj_usuario_1)
        {
            return await _usuarioRepository.UpdateByAsync(obj_usuario_1);
        }
        #endregion
    }
}
