using System;

namespace Inclubworld.Ventas.Application.DTO
{
    public class DetallepedidoDto
    {
        public int idDetallepedido { get; set; }
        public int idPedido { get; set; }
        public int idProductoes { get; set; }
        public Decimal cantidad { get; set; }
        public Decimal precio { get; set; }
        public Decimal subtotal_a { get; set; }
        public Decimal descuento { get; set; }
        public Decimal subtotal_b { get; set; }
        public Decimal igv { get; set; }
        public Decimal total { get; set; }
        public Decimal flete { get; set; }
    }
}
