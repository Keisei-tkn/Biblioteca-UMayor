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
        public string Tipo { set; get; }


        public Usuario(string id, string n, string a, string contra, string c,String t)
        {
            Id = id;
            Nombre = n;
            Apellido = a;
            Contraseña = contra;
            Correo = c;
            Tipo = t;
        }
        public Usuario()
        {
            Id = "SIN DEFINIR";
            Nombre = "SIN DEFINIR";
            Apellido = "SIN DEFINIR";
            Contraseña = "SIN DEFINIR";
            Correo = "SIN DEFINIR";
        }
        public Usuario(string id, string c)
        {
            Id = id;
            Correo = c;
        }
        public Usuario(Usuario u1)
        {
            Id = u1.Id;
            Nombre = u1.Nombre;
            Apellido = u1.Apellido;
            Contraseña = u1.Contraseña;
            Correo = u1.Correo;
        }
    }
}
