using System;

namespace Inclubworld.Ventas.Application.DTO
{
    public class PedidoDto
    {
        public int idPedido { get; set; }
        public int idProveedor { get; set; }
        public int idUsuario { get; set; }
        public DateTime date_registro { get; set; }
        public DateTime date_emision { get; set; }
        public Decimal subtotal_a { get; set; }
        public Decimal descuento { get; set; }
        public Decimal subtotal_b { get; set; }
        public Decimal igv { get; set; }
        public Decimal total { get; set; }
        public Decimal flete { get; set; }
        public int estado { get; set; }
    }
}
