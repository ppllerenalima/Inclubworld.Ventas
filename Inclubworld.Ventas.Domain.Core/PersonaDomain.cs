using Inclubworld.Ventas.Domain.Entity;
using Inclubworld.Ventas.Domain.Interface;
using Inclubworld.Ventas.Infraestructure.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inclubworld.Ventas.Domain.Core
{
    public class PersonaDomain : IPersonaDomain
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaDomain(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        #region Métodos Síncronos
        public Boolean DeleteBy(int idPersona)
        {
            return _personaRepository.DeleteBy(idPersona);
        }

        public IEnumerable<Persona> GetAll()
        {
            return _personaRepository.GetAll();
        }

        public Persona GetBy(int idPersona)
        {
            return _personaRepository.GetBy(idPersona);
        }

        public Boolean InsertBy(Persona obj_persona_1)
        {
            return _personaRepository.InsertBy(obj_persona_1);
        }

        public Boolean UpdateBy(Persona obj_persona_1)
        {
            return _personaRepository.UpdateBy(obj_persona_1);
        }
        #endregion

        #region Métodos Asíncronos
        public async Task<Boolean> DeleteByAsync(int idPersona)
        {
            return await _personaRepository.DeleteByAsync(idPersona);
        }

        public async Task<IEnumerable<Persona>> GetAllAsync()
        {
            return await _personaRepository.GetAllAsync();
        }

        public async Task<Persona> GetByAsync(int idPersona)
        {
            return await _personaRepository.GetByAsync(idPersona);
        }

        public async Task<Boolean> InsertByAsync(Persona obj_persona_1)
        {
            return await _personaRepository.InsertByAsync(obj_persona_1);
        }

        public async Task<Boolean> UpdateByAsync(Persona obj_persona_1)
        {
            return await _personaRepository.UpdateByAsync(obj_persona_1);
        }
        #endregion
    }
}
