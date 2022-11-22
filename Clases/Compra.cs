using System;

namespace beatpeak.Clases
{
	class Compra
    {
        private int ID { get; }
        public bool MetodoCompra { get; }
        public decimal Total { get; }
        private string CorreoUsuario { get; }
        public DateTime FechaCompra { get; }
        List<Beat> Carrito { get; set; }
    }
}