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
    public class ProductogeRepository : IProductogeRepository
    {
        private readonly IConnectionFactory _connectionFactory;


        public ProductogeRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        #region Métodos Síncronos
        public Boolean DeleteBy(int idProductoge)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductogeDelete";
                var parameters = new DynamicParameters();
                parameters.Add("idProductoge", idProductoge);

                var resul = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return resul > 0;
            }
        }

        public IEnumerable<Productoge> GetAll()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductogeGetAll";

                var PRODUCTOGE_0 = connection.Query<Productoge>(query, commandType: CommandType.StoredProcedure);
                return PRODUCTOGE_0;
            }
        }

        public Productoge GetBy(int idProductoge)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductogeGetBy";
                var parameters = new DynamicParameters();
                parameters.Add("idProductoge", idProductoge);

                var productoge_obj_0 = connection.QuerySingle<Productoge>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return productoge_obj_0;
            }
        }

        public Boolean InsertBy(Productoge obj_productoge_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductogeInsert";
                var parameters = new DynamicParameters();
                parameters.Add("descripcion", obj_productoge_1.descripcion);
                parameters.Add("estado", obj_productoge_1.estado);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public Boolean UpdateBy(Productoge obj_productoge_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductogeUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("idProductoge", obj_productoge_1.idProductoge);
                parameters.Add("descripcion", obj_productoge_1.descripcion);
                parameters.Add("estado", obj_productoge_1.estado);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        #endregion

        #region Métodos Asíncronos
        public async Task<Boolean> DeleteByAsync(int idProductoge)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductogeDelete";
                var parameters = new DynamicParameters();
                parameters.Add("idProductoge", idProductoge);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<IEnumerable<Productoge>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductogeGetAll";

                var PRODUCTOGE_0 = await connection.QueryAsync<Productoge>(query, commandType: CommandType.StoredProcedure);
                return PRODUCTOGE_0;
            }
        }

        public async Task<Productoge> GetByAsync(int idProductoge)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductogeGetBy";
                var parameters = new DynamicParameters();
                parameters.Add("idProductoge", idProductoge);

                var productoge_obj_0 = await connection.QuerySingleAsync<Productoge>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return productoge_obj_0;
            }
        }

        public async Task<Boolean> InsertByAsync(Productoge obj_productoge_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductogeInsert";
                var parameters = new DynamicParameters();
                parameters.Add("idProductoge", obj_productoge_1.idProductoge);
                parameters.Add("descripcion", obj_productoge_1.descripcion);
                parameters.Add("estado", obj_productoge_1.estado);

                var resul = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return resul > 0;
            }
        }

        public async Task<Boolean> UpdateByAsync(Productoge obj_productoge_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductogeUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("idProductoge", obj_productoge_1.idProductoge);
                parameters.Add("descripcion", obj_productoge_1.descripcion);
                parameters.Add("estado", obj_productoge_1.estado);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        #endregion
    }
}
