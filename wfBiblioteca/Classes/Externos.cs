using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfBiblioteca.Classes
{
    class Externos:Usuario
    {
        public string InstitucionOrigen { get; set; }
        public Externos(string id, string n, string a, string contra, string c) : base(id, n, a, contra, c)
        {
        }

        
    }
}
