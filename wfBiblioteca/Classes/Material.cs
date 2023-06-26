using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfBiblioteca.Classes 
{ 
    public class Material
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Materia { get; set; }
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
        public string Deposito_reserva { get; set; }
        public string Idioma { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int Unidades { get; set; }
        public string Editorial { get; set; }

        public Material()
        {
            this.Id = null;
            this.Nombre = null;
            this.Autor = null;
            this.Materia = null;
            this.Descripcion = null;
            this.Estado = false;
            this.Deposito_reserva = null;
            this.Idioma = null;
            this.FechaPublicacion = DateTime.MinValue;
            this.Unidades = 0;
            this.Editorial = null;
        }
        public Material(string id, string nombre, string autor, string materia, string descripcion, Boolean estado, string dep_rev, string idioma, DateTime fecha, int un, string editorial)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Autor = autor;
            this.Materia = materia;
            this.Descripcion = descripcion;
            this.Estado = estado;
            this.Deposito_reserva = dep_rev;
            this.Idioma = idioma;
            this.FechaPublicacion = fecha;
            this.Unidades = un;
            this.Editorial = editorial;
        }
    }
}
