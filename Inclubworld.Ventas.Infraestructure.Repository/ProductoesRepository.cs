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
    public class ProductoesRepository : IProductoesRepository
    {
        private readonly IConnectionFactory _connectionFactory;


        public ProductoesRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        #region Métodos Síncronos
        public Boolean DeleteBy(int idProductoes)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductoesDelete";
                var parameters = new DynamicParameters();
                parameters.Add("idProductoes", idProductoes);

                var resul = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return resul > 0;
            }
        }

        public IEnumerable<Productoes> GetAll()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductoesGetAll";

                var PRODUCTOES_0 = connection.Query<Productoes>(query, commandType: CommandType.StoredProcedure);
                return PRODUCTOES_0;
            }
        }

        public Productoes GetBy(int idProductoes)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductoesGetBy";
                var parameters = new DynamicParameters();
                parameters.Add("idProductoes", idProductoes);

                var productoes_obj_0 = connection.QuerySingle<Productoes>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return productoes_obj_0;
            }
        }

        public Boolean InsertBy(Productoes obj_productoes_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductoesInsert";
                var parameters = new DynamicParameters();
                parameters.Add("idProductoes", obj_productoes_1.idProductoes);
                parameters.Add("idUnidadmedida", obj_productoes_1.idUnidadmedida);
                parameters.Add("idProductoge", obj_productoes_1.idProductoge);
                parameters.Add("factor", obj_productoes_1.factor);
                parameters.Add("estado", obj_productoes_1.estado);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public Boolean UpdateBy(Productoes obj_productoes_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductoesUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("idProductoes", obj_productoes_1.idProductoes);
                parameters.Add("idUnidadmedida", obj_productoes_1.idUnidadmedida);
                parameters.Add("idProductoge", obj_productoes_1.idProductoge);
                parameters.Add("factor", obj_productoes_1.factor);
                parameters.Add("estado", obj_productoes_1.estado);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        #endregion

        #region Métodos Asíncronos
        public async Task<Boolean> DeleteByAsync(int idProductoes)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductoesDelete";
                var parameters = new DynamicParameters();
                parameters.Add("idProductoes", idProductoes);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<IEnumerable<Productoes>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductoesGetAll";

                var PRODUCTOES_0 = await connection.QueryAsync<Productoes>(query, commandType: CommandType.StoredProcedure);
                return PRODUCTOES_0;
            }
        }

        public async Task<Productoes> GetByAsync(int idProductoes)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductoesGetBy";
                var parameters = new DynamicParameters();
                parameters.Add("idProductoes", idProductoes);

                var productoes_obj_0 = await connection.QuerySingleAsync<Productoes>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return productoes_obj_0;
            }
        }

        public async Task<Boolean> InsertByAsync(Productoes obj_productoes_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductoesInsert";
                var parameters = new DynamicParameters();
                parameters.Add("idProductoes", obj_productoes_1.idProductoes);
                parameters.Add("idUnidadmedida", obj_productoes_1.idUnidadmedida);
                parameters.Add("idProductoge", obj_productoes_1.idProductoge);
                parameters.Add("factor", obj_productoes_1.factor);
                parameters.Add("estado", obj_productoes_1.estado);

                var resul = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return resul > 0;
            }
        }

        public async Task<Boolean> UpdateByAsync(Productoes obj_productoes_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ProductoesUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("idProductoes", obj_productoes_1.idProductoes);
                parameters.Add("idUnidadmedida", obj_productoes_1.idUnidadmedida);
                parameters.Add("idProductoge", obj_productoes_1.idProductoge);
                parameters.Add("factor", obj_productoes_1.factor);
                parameters.Add("estado", obj_productoes_1.estado);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        #endregion
    }
}
