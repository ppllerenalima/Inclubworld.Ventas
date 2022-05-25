using Dapper;
using Inclubworld.Ventas.Domain.Entity;
using Inclubworld.Ventas.Infraestructure.Interface;
using Inclubworld.Ventas.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Infraestructure.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly IConnectionFactory _connectionFactory;


        public PedidoRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        #region Métodos Síncronos
        public Boolean DeleteBy(int idPedido)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PedidoDelete";
                var parameters = new DynamicParameters();
                parameters.Add("idPedido", idPedido);

                var resul = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return resul > 0;
            }
        }

        public IEnumerable<Pedido> GetAll()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PedidoGetAll";

                var PEDIDO_0 = connection.Query<Pedido>(query, commandType: CommandType.StoredProcedure);
                return PEDIDO_0;
            }
        }

        public Pedido GetBy(int idPedido)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PedidoGetBy";
                var parameters = new DynamicParameters();
                parameters.Add("idPedido", idPedido);

                var pedido_obj_0 = connection.QuerySingle<Pedido>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return pedido_obj_0;
            }
        }

        public Boolean InsertBy(Pedido obj_pedido_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PedidoInsert";
                var parameters = new DynamicParameters();
                parameters.Add("idPedido", obj_pedido_1.idPedido);
                parameters.Add("idProveedor", obj_pedido_1.idProveedor);
                parameters.Add("idUsuario", obj_pedido_1.idUsuario);
                parameters.Add("date_registro", obj_pedido_1.date_registro);
                parameters.Add("date_emision", obj_pedido_1.date_emision);
                parameters.Add("subtotal_a", obj_pedido_1.subtotal_a);
                parameters.Add("descuento", obj_pedido_1.descuento);
                parameters.Add("subtotal_b", obj_pedido_1.subtotal_b);
                parameters.Add("igv", obj_pedido_1.igv);
                parameters.Add("total", obj_pedido_1.total);
                parameters.Add("flete", obj_pedido_1.flete);
                parameters.Add("estado", obj_pedido_1.estado);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public Boolean UpdateBy(Pedido obj_pedido_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PedidoUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("idPedido", obj_pedido_1.idPedido);
                parameters.Add("idProveedor", obj_pedido_1.idProveedor);
                parameters.Add("idUsuario", obj_pedido_1.idUsuario);
                parameters.Add("date_registro", obj_pedido_1.date_registro);
                parameters.Add("date_emision", obj_pedido_1.date_emision);
                parameters.Add("subtotal_a", obj_pedido_1.subtotal_a);
                parameters.Add("descuento", obj_pedido_1.descuento);
                parameters.Add("subtotal_b", obj_pedido_1.subtotal_b);
                parameters.Add("igv", obj_pedido_1.igv);
                parameters.Add("total", obj_pedido_1.total);
                parameters.Add("flete", obj_pedido_1.flete);
                parameters.Add("estado", obj_pedido_1.estado);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        #endregion

        #region Métodos Asíncronos
        public async Task<Boolean> DeleteByAsync(int idPedido)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PedidoDelete";
                var parameters = new DynamicParameters();
                parameters.Add("idPedido", idPedido);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<IEnumerable<Pedido>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PedidoGetAll";

                var PEDIDO_0 = await connection.QueryAsync<Pedido>(query, commandType: CommandType.StoredProcedure);
                return PEDIDO_0;
            }
        }

        public async Task<Pedido> GetByAsync(int idPedido)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PedidoGetBy";
                var parameters = new DynamicParameters();
                parameters.Add("idPedido", idPedido);

                var pedido_obj_0 = await connection.QuerySingleAsync<Pedido>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return pedido_obj_0;
            }
        }

        public async Task<Boolean> InsertByAsync(Pedido obj_pedido_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PedidoInsert";
                var parameters = new DynamicParameters();
                parameters.Add("idPedido", obj_pedido_1.idPedido);
                parameters.Add("idProveedor", obj_pedido_1.idProveedor);
                parameters.Add("idUsuario", obj_pedido_1.idUsuario);
                parameters.Add("date_registro", obj_pedido_1.date_registro);
                parameters.Add("date_emision", obj_pedido_1.date_emision);
                parameters.Add("subtotal_a", obj_pedido_1.subtotal_a);
                parameters.Add("descuento", obj_pedido_1.descuento);
                parameters.Add("subtotal_b", obj_pedido_1.subtotal_b);
                parameters.Add("igv", obj_pedido_1.igv);
                parameters.Add("total", obj_pedido_1.total);
                parameters.Add("flete", obj_pedido_1.flete);
                parameters.Add("estado", obj_pedido_1.estado);

                var resul = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return resul > 0;
            }
        }

        public async Task<Boolean> UpdateByAsync(Pedido obj_pedido_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PedidoUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("idPedido", obj_pedido_1.idPedido);
                parameters.Add("idProveedor", obj_pedido_1.idProveedor);
                parameters.Add("idUsuario", obj_pedido_1.idUsuario);
                parameters.Add("date_registro", obj_pedido_1.date_registro);
                parameters.Add("date_emision", obj_pedido_1.date_emision);
                parameters.Add("subtotal_a", obj_pedido_1.subtotal_a);
                parameters.Add("descuento", obj_pedido_1.descuento);
                parameters.Add("subtotal_b", obj_pedido_1.subtotal_b);
                parameters.Add("igv", obj_pedido_1.igv);
                parameters.Add("total", obj_pedido_1.total);
                parameters.Add("flete", obj_pedido_1.flete);
                parameters.Add("estado", obj_pedido_1.estado);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        #endregion
    }
}
