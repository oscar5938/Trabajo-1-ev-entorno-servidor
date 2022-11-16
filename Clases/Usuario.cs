using System;

namespace beatpeak.Clases
{
    class Usuario
    {
        private int ID { get; }
        public string Nombre { get; }
        private decimal Cartera { get; set; }
        public boolean Status { get; set; }

        public DateTime FechaCreacion { get; }
        public string Rol { get; set; }

        public List<Beat> ListaBeatsFavs { get; set;}
        public List<Beat> ListaBeatsPublicados{get; set;}
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