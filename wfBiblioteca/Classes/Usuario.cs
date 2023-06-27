using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Classes
{
    class Usuario
    {
        public string Id { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Contraseña { set; get; }
        public string Correo { set; get; }

        public Usuario(string id, string n, string a, string contra, string c)
        {
            Id = id;
            Nombre = n;
            Apellido = a;
            Contraseña = contra;
            Correo = c;
        }
    }
}
