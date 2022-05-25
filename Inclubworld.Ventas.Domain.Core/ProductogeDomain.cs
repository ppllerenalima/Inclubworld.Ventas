using Inclubworld.Ventas.Domain.Entity;
using Inclubworld.Ventas.Domain.Interface;
using Inclubworld.Ventas.Infraestructure.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Domain.Core
{
    public class ProductogeDomain : IProductogeDomain
    {
        private readonly IProductogeRepository _productogeRepository;

        public ProductogeDomain(IProductogeRepository productogeRepository)
        {
            _productogeRepository = productogeRepository;
        }

        #region Métodos Síncronos
        public Boolean DeleteBy(int idProductoge)
        {
            return _productogeRepository.DeleteBy(idProductoge);
        }

        public IEnumerable<Productoge> GetAll()
        {
            return _productogeRepository.GetAll();
        }

        public Productoge GetBy(int idProductoge)
        {
            return _productogeRepository.GetBy(idProductoge);
        }

        public Boolean InsertBy(Productoge obj_productoge_1)
        {
            return _productogeRepository.InsertBy(obj_productoge_1);
        }

        public Boolean UpdateBy(Productoge obj_productoge_1)
        {
            return _productogeRepository.UpdateBy(obj_productoge_1);
        }
        #endregion

        #region Métodos Asíncronos
        public async Task<Boolean> DeleteByAsync(int idProductoge)
        {
            return await _productogeRepository.DeleteByAsync(idProductoge);
        }

        public async Task<IEnumerable<Productoge>> GetAllAsync()
        {
            return await _productogeRepository.GetAllAsync();
        }

        public async Task<Productoge> GetByAsync(int idProductoge)
        {
            return await _productogeRepository.GetByAsync(idProductoge);
        }

        public async Task<Boolean> InsertByAsync(Productoge obj_productoge_1)
        {
            return await _productogeRepository.InsertByAsync(obj_productoge_1);
        }

        public async Task<Boolean> UpdateByAsync(Productoge obj_productoge_1)
        {
            return await _productogeRepository.UpdateByAsync(obj_productoge_1);
        }
        #endregion
    }
}
