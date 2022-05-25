using Dapper;
using Inclubworld.Ventas.Domain.Entity;
using Inclubworld.Ventas.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Infraestructure.Repository
{
    public class UsuarioRepository
    {
        private readonly IConnectionFactory _connectionFactory;


        public UsuarioRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        #region Métodos Síncronos
        public Boolean DeleteBy(int idUsuario)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UsuarioDelete";
                var parameters = new DynamicParameters();
                parameters.Add("idUsuario", idUsuario);

                var resul = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return resul > 0;
            }
        }

        public IEnumerable<Usuario> GetAll()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UsuarioGetAll";

                var USUARIO_0 = connection.Query<Usuario>(query, commandType: CommandType.StoredProcedure);
                return USUARIO_0;
            }
        }

        public Usuario GetBy(int idUsuario)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UsuarioGetBy";
                var parameters = new DynamicParameters();
                parameters.Add("idUsuario", idUsuario);

                var usuario_obj_0 = connection.QuerySingle<Usuario>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return usuario_obj_0;
            }
        }

        public Boolean InsertBy(Usuario obj_usuario_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UsuarioInsert";
                var parameters = new DynamicParameters();
                parameters.Add("idUsuario", obj_usuario_1.idUsuario);
                parameters.Add("idPersona", obj_usuario_1.idPersona);
                parameters.Add("user_name", obj_usuario_1.user_name);
                parameters.Add("user_pass", obj_usuario_1.user_pass);
                parameters.Add("estado", obj_usuario_1.estado);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public Boolean UpdateBy(Usuario obj_usuario_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UsuarioUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("idUsuario", obj_usuario_1.idUsuario);
                parameters.Add("idPersona", obj_usuario_1.idPersona);
                parameters.Add("user_name", obj_usuario_1.user_name);
                parameters.Add("user_pass", obj_usuario_1.user_pass);
                parameters.Add("estado", obj_usuario_1.estado);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        #endregion

        #region Métodos Asíncronos
        public async Task<Boolean> DeleteByAsync(int idUsuario)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UsuarioDelete";
                var parameters = new DynamicParameters();
                parameters.Add("idUsuario", idUsuario);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<IEnumerable<Usuario>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UsuarioGetAll";

                var USUARIO_0 = await connection.QueryAsync<Usuario>(query, commandType: CommandType.StoredProcedure);
                return USUARIO_0;
            }
        }

        public async Task<Usuario> GetByAsync(int idUsuario)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UsuarioGetBy";
                var parameters = new DynamicParameters();
                parameters.Add("idUsuario", idUsuario);

                var usuario_obj_0 = await connection.QuerySingleAsync<Usuario>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return usuario_obj_0;
            }
        }

        public async Task<Boolean> InsertByAsync(Usuario obj_usuario_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UsuarioInsert";
                var parameters = new DynamicParameters();
                parameters.Add("idUsuario", obj_usuario_1.idUsuario);
                parameters.Add("idPersona", obj_usuario_1.idPersona);
                parameters.Add("user_name", obj_usuario_1.user_name);
                parameters.Add("user_pass", obj_usuario_1.user_pass);
                parameters.Add("estado", obj_usuario_1.estado);

                var resul = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return resul > 0;
            }
        }

        public async Task<Boolean> UpdateByAsync(Usuario obj_usuario_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UsuarioUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("idUsuario", obj_usuario_1.idUsuario);
                parameters.Add("idPersona", obj_usuario_1.idPersona);
                parameters.Add("user_name", obj_usuario_1.user_name);
                parameters.Add("user_pass", obj_usuario_1.user_pass);
                parameters.Add("estado", obj_usuario_1.estado);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        #endregion
    }
}
