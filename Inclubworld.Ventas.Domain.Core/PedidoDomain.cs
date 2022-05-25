using Inclubworld.Ventas.Domain.Entity;
using Inclubworld.Ventas.Domain.Interface;
using Inclubworld.Ventas.Infraestructure.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Domain.Core
{
    public class PedidoDomain : IPedidoDomain
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoDomain(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        #region Métodos Síncronos
        public Boolean DeleteBy(int idPedido)
        {
            return _pedidoRepository.DeleteBy(idPedido);
        }

        public IEnumerable<Pedido> GetAll()
        {
            return _pedidoRepository.GetAll();
        }

        public Pedido GetBy(int idPedido)
        {
            return _pedidoRepository.GetBy(idPedido);
        }

        public Boolean InsertBy(Pedido obj_pedido_1)
        {
            return _pedidoRepository.InsertBy(obj_pedido_1);
        }

        public Boolean UpdateBy(Pedido obj_pedido_1)
        {
            return _pedidoRepository.UpdateBy(obj_pedido_1);
        }
        #endregion

        #region Métodos Asíncronos
        public async Task<Boolean> DeleteByAsync(int idPedido)
        {
            return await _pedidoRepository.DeleteByAsync(idPedido);
        }

        public async Task<IEnumerable<Pedido>> GetAllAsync()
        {
            return await _pedidoRepository.GetAllAsync();
        }

        public async Task<Pedido> GetByAsync(int idPedido)
        {
            return await _pedidoRepository.GetByAsync(idPedido);
        }

        public async Task<Boolean> InsertByAsync(Pedido obj_pedido_1)
        {
            return await _pedidoRepository.InsertByAsync(obj_pedido_1);
        }

        public async Task<Boolean> UpdateByAsync(Pedido obj_pedido_1)
        {
            return await _pedidoRepository.UpdateByAsync(obj_pedido_1);
        }
        #endregion
    }
}
