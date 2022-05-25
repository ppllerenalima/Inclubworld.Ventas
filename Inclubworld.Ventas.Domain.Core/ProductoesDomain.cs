using Inclubworld.Ventas.Domain.Entity;
using Inclubworld.Ventas.Domain.Interface;
using Inclubworld.Ventas.Infraestructure.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Domain.Core
{
    public class ProductoesDomain : IProductoesDomain
    {
        private readonly IProductoesRepository _productoesRepository;

        public ProductoesDomain(IProductoesRepository productoesRepository)
        {
            _productoesRepository = productoesRepository;
        }

        #region Métodos Síncronos
        public Boolean DeleteBy(int idProductoes)
        {
            return _productoesRepository.DeleteBy(idProductoes);
        }

        public IEnumerable<Productoes> GetAll()
        {
            return _productoesRepository.GetAll();
        }

        public Productoes GetBy(int idProductoes)
        {
            return _productoesRepository.GetBy(idProductoes);
        }

        public Boolean InsertBy(Productoes obj_productoes_1)
        {
            return _productoesRepository.InsertBy(obj_productoes_1);
        }

        public Boolean UpdateBy(Productoes obj_productoes_1)
        {
            return _productoesRepository.UpdateBy(obj_productoes_1);
        }
        #endregion

        #region Métodos Asíncronos
        public async Task<Boolean> DeleteByAsync(int idProductoes)
        {
            return await _productoesRepository.DeleteByAsync(idProductoes);
        }

        public async Task<IEnumerable<Productoes>> GetAllAsync()
        {
            return await _productoesRepository.GetAllAsync();
        }

        public async Task<Productoes> GetByAsync(int idProductoes)
        {
            return await _productoesRepository.GetByAsync(idProductoes);
        }

        public async Task<Boolean> InsertByAsync(Productoes obj_productoes_1)
        {
            return await _productoesRepository.InsertByAsync(obj_productoes_1);
        }

        public async Task<Boolean> UpdateByAsync(Productoes obj_productoes_1)
        {
            return await _productoesRepository.UpdateByAsync(obj_productoes_1);
        }
        #endregion
    }
}
