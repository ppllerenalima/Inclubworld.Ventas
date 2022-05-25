using System;

namespace Inclubworld.Ventas.Domain.Entity
{
    public class Persona
    {
        public int idPersona { get; set; }
        public String nombre { get; set; }
        public String apePaterno { get; set; }
        public String apeMaterno { get; set; }
        public int estado { get; set; }
    }
}
