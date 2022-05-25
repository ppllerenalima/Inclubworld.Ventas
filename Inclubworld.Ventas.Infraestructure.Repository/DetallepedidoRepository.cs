using Dapper;
using Inclubworld.Ventas.Domain.Entity;
using Inclubworld.Ventas.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Infraestructure.Repository
{
    public class DetallepedidoRepository
    {
        private readonly IConnectionFactory _connectionFactory;


        public DetallepedidoRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        #region Métodos Síncronos
        public Boolean DeleteBy(int idDetallepedido)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "DetallepedidoDelete";
                var parameters = new DynamicParameters();
                parameters.Add("idDetallepedido", idDetallepedido);

                var resul = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return resul > 0;
            }
        }

        public IEnumerable<Detallepedido> GetAll()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "DetallepedidoGetAll";

                var DETALLEPEDIDO_0 = connection.Query<Detallepedido>(query, commandType: CommandType.StoredProcedure);
                return DETALLEPEDIDO_0;
            }
        }

        public Detallepedido GetBy(int idDetallepedido)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "DetallepedidoGetBy";
                var parameters = new DynamicParameters();
                parameters.Add("idDetallepedido", idDetallepedido);

                var detallepedido_obj_0 = connection.QuerySingle<Detallepedido>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return detallepedido_obj_0;
            }
        }

        public Boolean InsertBy(Detallepedido obj_detallepedido_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "DetallepedidoInsert";
                var parameters = new DynamicParameters();
                parameters.Add("idDetallepedido", obj_detallepedido_1.idDetallepedido);
                parameters.Add("idPedido", obj_detallepedido_1.idPedido);
                parameters.Add("idProductoes", obj_detallepedido_1.idProductoes);
                parameters.Add("cantidad", obj_detallepedido_1.cantidad);
                parameters.Add("precio", obj_detallepedido_1.precio);
                parameters.Add("subtotal_a", obj_detallepedido_1.subtotal_a);
                parameters.Add("descuento", obj_detallepedido_1.descuento);
                parameters.Add("subtotal_b", obj_detallepedido_1.subtotal_b);
                parameters.Add("igv", obj_detallepedido_1.igv);
                parameters.Add("total", obj_detallepedido_1.total);
                parameters.Add("flete", obj_detallepedido_1.flete);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public Boolean UpdateBy(Detallepedido obj_detallepedido_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "DetallepedidoUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("idDetallepedido", obj_detallepedido_1.idDetallepedido);
                parameters.Add("idProductoes", obj_detallepedido_1.idProductoes);
                parameters.Add("cantidad", obj_detallepedido_1.cantidad);
                parameters.Add("precio", obj_detallepedido_1.precio);
                parameters.Add("subtotal_a", obj_detallepedido_1.subtotal_a);
                parameters.Add("descuento", obj_detallepedido_1.descuento);
                parameters.Add("subtotal_b", obj_detallepedido_1.subtotal_b);
                parameters.Add("igv", obj_detallepedido_1.igv);
                parameters.Add("total", obj_detallepedido_1.total);
                parameters.Add("flete", obj_detallepedido_1.flete);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        #endregion

        #region Métodos Asíncronos
        public async Task<Boolean> DeleteByAsync(int idDetallepedido)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "DetallepedidoDelete";
                var parameters = new DynamicParameters();
                parameters.Add("idDetallepedido", idDetallepedido);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<IEnumerable<Detallepedido>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "DetallepedidoGetAll";

                var DETALLEPEDIDO_0 = await connection.QueryAsync<Detallepedido>(query, commandType: CommandType.StoredProcedure);
                return DETALLEPEDIDO_0;
            }
        }

        public async Task<Detallepedido> GetByAsync(int idDetallepedido)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "DetallepedidoGetBy";
                var parameters = new DynamicParameters();
                parameters.Add("idDetallepedido", idDetallepedido);

                var detallepedido_obj_0 = await connection.QuerySingleAsync<Detallepedido>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return detallepedido_obj_0;
            }
        }

        public async Task<Boolean> InsertByAsync(Detallepedido obj_detallepedido_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "DetallepedidoInsert";
                var parameters = new DynamicParameters();
                parameters.Add("idDetallepedido", obj_detallepedido_1.idDetallepedido);
                parameters.Add("idPedido", obj_detallepedido_1.idPedido);
                parameters.Add("idProductoes", obj_detallepedido_1.idProductoes);
                parameters.Add("cantidad", obj_detallepedido_1.cantidad);
                parameters.Add("precio", obj_detallepedido_1.precio);
                parameters.Add("subtotal_a", obj_detallepedido_1.subtotal_a);
                parameters.Add("descuento", obj_detallepedido_1.descuento);
                parameters.Add("subtotal_b", obj_detallepedido_1.subtotal_b);
                parameters.Add("igv", obj_detallepedido_1.igv);
                parameters.Add("total", obj_detallepedido_1.total);
                parameters.Add("flete", obj_detallepedido_1.flete);

                var resul = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return resul > 0;
            }
        }

        public async Task<Boolean> UpdateByAsync(Detallepedido obj_detallepedido_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "DetallepedidoUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("idDetallepedido", obj_detallepedido_1.idDetallepedido);
                parameters.Add("idProductoes", obj_detallepedido_1.idProductoes);
                parameters.Add("cantidad", obj_detallepedido_1.cantidad);
                parameters.Add("precio", obj_detallepedido_1.precio);
                parameters.Add("subtotal_a", obj_detallepedido_1.subtotal_a);
                parameters.Add("descuento", obj_detallepedido_1.descuento);
                parameters.Add("subtotal_b", obj_detallepedido_1.subtotal_b);
                parameters.Add("igv", obj_detallepedido_1.igv);
                parameters.Add("total", obj_detallepedido_1.total);
                parameters.Add("flete", obj_detallepedido_1.flete);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        #endregion
    }
}
