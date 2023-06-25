using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfBiblioteca.Classes
{
    class Prestamo
    {
        public string Id { get; set; }
        public DateTime fechaPrestamo { get; set; }
        public DateTime fechaDevolucion { get; set; }
    }
}
 