namespace beatpeak.Clases
{
    class Beat{
        private int ID {get;}
        public bool Premium { get; set; }
        public string Nombre {get;}
        public string Tipo { get; set; }
        public decimal Precio { get; set; }
        public static int NumeroPedidos { get; set }
    }
}