using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfBiblioteca.Classes
{
    class Libro: Material
    {
        public string Isbn { get; set; }
        public int NumPag { get; set; }
    }
}
