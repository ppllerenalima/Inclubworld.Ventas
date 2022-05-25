using System;

namespace Inclubworld.Ventas.Application.DTO
{
    public class UsuarioDto
    {
        public int idUsuario { get; set; }
        public int idPersona { get; set; }
        public String user_name { get; set; }
        public String user_pass { get; set; }
        public int estado { get; set; }
    }
}
