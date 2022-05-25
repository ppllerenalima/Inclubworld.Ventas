using Dapper;
using Inclubworld.Ventas.Domain.Entity;
using Inclubworld.Ventas.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Infraestructure.Repository
{
    public class UnidadmedidaRepository
    {
        private readonly IConnectionFactory _connectionFactory;


        public UnidadmedidaRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        #region Métodos Síncronos
        public Boolean DeleteBy(int idUnidadmedida)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UnidadmedidaDelete";
                var parameters = new DynamicParameters();
                parameters.Add("idUnidadmedida", idUnidadmedida);

                var resul = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return resul > 0;
            }
        }

        public IEnumerable<Unidadmedida> GetAll()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UnidadmedidaGetAll";

                var UNIDADMEDIDA_0 = connection.Query<Unidadmedida>(query, commandType: CommandType.StoredProcedure);
                return UNIDADMEDIDA_0;
            }
        }

        public Unidadmedida GetBy(int idUnidadmedida)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UnidadmedidaGetBy";
                var parameters = new DynamicParameters();
                parameters.Add("idUnidadmedida", idUnidadmedida);

                var unidadmedida_obj_0 = connection.QuerySingle<Unidadmedida>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return unidadmedida_obj_0;
            }
        }

        public Boolean InsertBy(Unidadmedida obj_unidadmedida_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UnidadmedidaInsert";
                var parameters = new DynamicParameters();
                parameters.Add("idUnidadmedida", obj_unidadmedida_1.idUnidadmedida);
                parameters.Add("descripcion", obj_unidadmedida_1.descripcion);
                parameters.Add("abrev", obj_unidadmedida_1.abrev);
                parameters.Add("estado", obj_unidadmedida_1.estado);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public Boolean UpdateBy(Unidadmedida obj_unidadmedida_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UnidadmedidaUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("idUnidadmedida", obj_unidadmedida_1.idUnidadmedida);
                parameters.Add("descripcion", obj_unidadmedida_1.descripcion);
                parameters.Add("abrev", obj_unidadmedida_1.abrev);
                parameters.Add("estado", obj_unidadmedida_1.estado);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        #endregion

        #region Métodos Asíncronos
        public async Task<Boolean> DeleteByAsync(int idUnidadmedida)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UnidadmedidaDelete";
                var parameters = new DynamicParameters();
                parameters.Add("idUnidadmedida", idUnidadmedida);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<IEnumerable<Unidadmedida>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UnidadmedidaGetAll";

                var UNIDADMEDIDA_0 = await connection.QueryAsync<Unidadmedida>(query, commandType: CommandType.StoredProcedure);
                return UNIDADMEDIDA_0;
            }
        }

        public async Task<Unidadmedida> GetByAsync(int idUnidadmedida)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UnidadmedidaGetBy";
                var parameters = new DynamicParameters();
                parameters.Add("idUnidadmedida", idUnidadmedida);

                var unidadmedida_obj_0 = await connection.QuerySingleAsync<Unidadmedida>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return unidadmedida_obj_0;
            }
        }

        public async Task<Boolean> InsertByAsync(Unidadmedida obj_unidadmedida_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UnidadmedidaInsert";
                var parameters = new DynamicParameters();
                parameters.Add("idUnidadmedida", obj_unidadmedida_1.idUnidadmedida);
                parameters.Add("descripcion", obj_unidadmedida_1.descripcion);
                parameters.Add("abrev", obj_unidadmedida_1.abrev);
                parameters.Add("estado", obj_unidadmedida_1.estado);

                var resul = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return resul > 0;
            }
        }

        public async Task<Boolean> UpdateByAsync(Unidadmedida obj_unidadmedida_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UnidadmedidaUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("idUnidadmedida", obj_unidadmedida_1.idUnidadmedida);
                parameters.Add("descripcion", obj_unidadmedida_1.descripcion);
                parameters.Add("abrev", obj_unidadmedida_1.abrev);
                parameters.Add("estado", obj_unidadmedida_1.estado);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        #endregion
    }
}
