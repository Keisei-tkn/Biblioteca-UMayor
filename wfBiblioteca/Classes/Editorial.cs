using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Classes
{
    class Editorial
    {
        public string Id { get; set; }
        public string Nombre { get; set; }

        public Editorial()
        {
            this.Id = null;
            this.Nombre = null;
        }

        public Editorial(string id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }
        public void InsertarEditorial(Editorial edt)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();

            string cad = $@"INSERT INTO AUTOR(id_editorial,nombre) 
            VALUES('{edt.Id}','{edt.Nombre}');";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);

            connection.Close();
        }

        public List<Editorial> ObtenerListaEditorial()
        {
            List<Editorial> ListaEditorial = new List<Editorial>();
            ConnectionDB connection = new ConnectionDB();
            SqlDataReader registros = null;
            connection.Open();
            SqlCommand querySel = new SqlCommand("SELECT EDT.id_editorial, EDT.nombre " +
                "FROM EDITORIAL AS EDT;", connection.connectDb);

            registros = querySel.ExecuteReader();

            while (registros.Read())
            {
                var registro = new Editorial()
                {
                    Id = registros["id_editorial"].ToString(),
                    Nombre = registros["nombre"].ToString(),
                };
                ListaEditorial.Add(registro);
            }
            connection.Close();

            return ListaEditorial;
        }
    }
}
