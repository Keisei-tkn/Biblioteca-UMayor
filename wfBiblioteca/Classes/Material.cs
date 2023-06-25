﻿using System;
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
        public List<string> Cola { get; set; } = new List<string>();
        public string Editorial { get; set; }

    }
}
