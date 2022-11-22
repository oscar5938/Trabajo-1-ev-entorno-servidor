using System;

namespace beatpeak.Clases
{
    class Usuario
    {
        private int ID { get; }
        public string Nombre { get; }
        private string Email { get; }
        private decimal Cartera { get; set; }
        public boolean Status { get; set; }

        public DateTime FechaCreacion { get; }
        public string Rol { get; set; }

        private List<Beat> ListaBeatsFavs { get; set;}
        private List<Beat> ListaBeatsPublicados{get; set;}
        private List<Beat> ListaBeatsComprados { get; }
        private List<Compra> ListaCompras { get; }

        private static int NumeroID=0;
        public Usuario(string Nombre)
        {
            this.Id=NumeroID;
            NumeroID++;
            this.Nombre=Nombre;
            this.Cartera=0;
            this.Status=true;
            this.FechaCreacion=DateTime.Now;
            this.Rol="Estandar";
            this.ListaBeatsFavs=new List<Beat>();
            this.ListaBeatsPublicados=new List<Beat>();
        }
    }
}