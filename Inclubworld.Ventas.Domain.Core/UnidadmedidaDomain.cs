using Inclubworld.Ventas.Domain.Entity;
using Inclubworld.Ventas.Domain.Interface;
using Inclubworld.Ventas.Infraestructure.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Domain.Core
{
    public class UnidadmedidaDomain : IUnidadmedidaDomain
    {
        private readonly IUnidadmedidaRepository _unidadmedidaRepository;

        public UnidadmedidaDomain(IUnidadmedidaRepository unidadmedidaRepository)
        {
            _unidadmedidaRepository = unidadmedidaRepository;
        }

        #region Métodos Síncronos
        public Boolean DeleteBy(int idUnidadmedida)
        {
            return _unidadmedidaRepository.DeleteBy(idUnidadmedida);
        }

        public IEnumerable<Unidadmedida> GetAll()
        {
            return _unidadmedidaRepository.GetAll();
        }

        public Unidadmedida GetBy(int idUnidadmedida)
        {
            return _unidadmedidaRepository.GetBy(idUnidadmedida);
        }

        public Boolean InsertBy(Unidadmedida obj_unidadmedida_1)
        {
            return _unidadmedidaRepository.InsertBy(obj_unidadmedida_1);
        }

        public Boolean UpdateBy(Unidadmedida obj_unidadmedida_1)
        {
            return _unidadmedidaRepository.UpdateBy(obj_unidadmedida_1);
        }
        #endregion

        #region Métodos Asíncronos
        public async Task<Boolean> DeleteByAsync(int idUnidadmedida)
        {
            return await _unidadmedidaRepository.DeleteByAsync(idUnidadmedida);
        }

        public async Task<IEnumerable<Unidadmedida>> GetAllAsync()
        {
            return await _unidadmedidaRepository.GetAllAsync();
        }

        public async Task<Unidadmedida> GetByAsync(int idUnidadmedida)
        {
            return await _unidadmedidaRepository.GetByAsync(idUnidadmedida);
        }

        public async Task<Boolean> InsertByAsync(Unidadmedida obj_unidadmedida_1)
        {
            return await _unidadmedidaRepository.InsertByAsync(obj_unidadmedida_1);
        }

        public async Task<Boolean> UpdateByAsync(Unidadmedida obj_unidadmedida_1)
        {
            return await _unidadmedidaRepository.UpdateByAsync(obj_unidadmedida_1);
        }
        #endregion
    }
}
