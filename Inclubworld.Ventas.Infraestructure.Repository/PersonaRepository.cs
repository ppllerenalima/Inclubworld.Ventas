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
    public class PersonaRepository : IPersonaRepository
    {
        private readonly IConnectionFactory _connectionFactory;


        public PersonaRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        #region Métodos Síncronos
        public Boolean DeleteBy(int idPersona)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PersonaDelete";
                var parameters = new DynamicParameters();
                parameters.Add("idPersona", idPersona);

                var resul = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return resul > 0;
            }
        }

        public IEnumerable<Persona> GetAll()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PersonaGetAll";

                var PERSONA_0 = connection.Query<Persona>(query, commandType: CommandType.StoredProcedure);
                return PERSONA_0;
            }
        }

        public Persona GetBy(int idPersona)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PersonaGetBy";
                var parameters = new DynamicParameters();
                parameters.Add("idPersona", idPersona);

                var persona_obj_0 = connection.QuerySingle<Persona>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return persona_obj_0;
            }
        }

        public Boolean InsertBy(Persona obj_persona_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PersonaInsert";
                var parameters = new DynamicParameters();
                parameters.Add("idPersona", obj_persona_1.idPersona);
                parameters.Add("nombre", obj_persona_1.nombre);
                parameters.Add("apePaterno", obj_persona_1.apePaterno);
                parameters.Add("apeMaterno", obj_persona_1.apeMaterno);
                parameters.Add("estado", obj_persona_1.estado);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public Boolean UpdateBy(Persona obj_persona_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PersonaUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("idPersona", obj_persona_1.idPersona);
                parameters.Add("nombre", obj_persona_1.nombre);
                parameters.Add("apePaterno", obj_persona_1.apePaterno);
                parameters.Add("apeMaterno", obj_persona_1.apeMaterno);
                parameters.Add("estado", obj_persona_1.estado);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        #endregion

        #region Métodos Asíncronos
        public async Task<Boolean> DeleteByAsync(int idPersona)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PersonaDelete";
                var parameters = new DynamicParameters();
                parameters.Add("idPersona", idPersona);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<IEnumerable<Persona>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PersonaGetAll";

                var PERSONA_0 = await connection.QueryAsync<Persona>(query, commandType: CommandType.StoredProcedure);
                return PERSONA_0;
            }
        }

        public async Task<Persona> GetByAsync(int idPersona)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PersonaGetBy";
                var parameters = new DynamicParameters();
                parameters.Add("idPersona", idPersona);

                var persona_obj_0 = await connection.QuerySingleAsync<Persona>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return persona_obj_0;
            }
        }

        public async Task<Boolean> InsertByAsync(Persona obj_persona_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PersonaInsert";
                var parameters = new DynamicParameters();
                parameters.Add("idPersona", obj_persona_1.idPersona);
                parameters.Add("nombre", obj_persona_1.nombre);
                parameters.Add("apePaterno", obj_persona_1.apePaterno);
                parameters.Add("apeMaterno", obj_persona_1.apeMaterno);
                parameters.Add("estado", obj_persona_1.estado);

                var resul = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return resul > 0;
            }
        }

        public async Task<Boolean> UpdateByAsync(Persona obj_persona_1)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "PersonaUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("idPersona", obj_persona_1.idPersona);
                parameters.Add("nombre", obj_persona_1.nombre);
                parameters.Add("apePaterno", obj_persona_1.apePaterno);
                parameters.Add("apeMaterno", obj_persona_1.apeMaterno);
                parameters.Add("estado", obj_persona_1.estado);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
        #endregion
    }
}
