using Inclubworld.Ventas.Domain.Entity;
using Inclubworld.Ventas.Domain.Interface;
using Inclubworld.Ventas.Infraestructure.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Domain.Core
{
    public class DetallepedidoDomain : IDetallepedidoDomain
    {
        private readonly IDetallepedidoRepository _detallepedidoRepository;

        public DetallepedidoDomain(IDetallepedidoRepository detallepedidoRepository)
        {
            _detallepedidoRepository = detallepedidoRepository;
        }

        #region Métodos Síncronos
        public Boolean DeleteBy(int idDetallepedido)
        {
            return _detallepedidoRepository.DeleteBy(idDetallepedido);
        }

        public IEnumerable<Detallepedido> GetAll()
        {
            return _detallepedidoRepository.GetAll();
        }

        public Detallepedido GetBy(int idDetallepedido)
        {
            return _detallepedidoRepository.GetBy(idDetallepedido);
        }

        public Boolean InsertBy(Detallepedido obj_detallepedido_1)
        {
            return _detallepedidoRepository.InsertBy(obj_detallepedido_1);
        }

        public Boolean UpdateBy(Detallepedido obj_detallepedido_1)
        {
            return _detallepedidoRepository.UpdateBy(obj_detallepedido_1);
        }
        #endregion

        #region Métodos Asíncronos
        public async Task<Boolean> DeleteByAsync(int idDetallepedido)
        {
            return await _detallepedidoRepository.DeleteByAsync(idDetallepedido);
        }

        public async Task<IEnumerable<Detallepedido>> GetAllAsync()
        {
            return await _detallepedidoRepository.GetAllAsync();
        }

        public async Task<Detallepedido> GetByAsync(int idDetallepedido)
        {
            return await _detallepedidoRepository.GetByAsync(idDetallepedido);
        }

        public async Task<Boolean> InsertByAsync(Detallepedido obj_detallepedido_1)
        {
            return await _detallepedidoRepository.InsertByAsync(obj_detallepedido_1);
        }

        public async Task<Boolean> UpdateByAsync(Detallepedido obj_detallepedido_1)
        {
            return await _detallepedidoRepository.UpdateByAsync(obj_detallepedido_1);
        }
        #endregion
    }
}
