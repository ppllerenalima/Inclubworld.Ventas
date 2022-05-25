using System;

namespace Inclubworld.Ventas.Domain.Entity
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public int idPersona { get; set; }
        public String user_name { get; set; }
        public String user_pass { get; set; }
        public int estado { get; set; }
    }
}
