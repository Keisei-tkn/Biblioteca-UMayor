using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Classes
{
    class Materia
    {
        public string Id { get; set; }
        public string Nombre { get; set; }

        public Materia()
        {
            this.Id = null;
            this.Nombre = null;
        }

        public Materia(string id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }

        public void InsertarMateria(Materia mtr)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();

            string cad = $@"INSERT INTO MATERIA(id_materia,nombre_materia) 
            VALUES('{mtr.Id}','{mtr.Nombre}');";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);

            connection.Close();
        }

        public List<Materia> ObtenerListaMateria()
        {
            List<Materia> ListaMateria = new List<Materia>();
            ConnectionDB connection = new ConnectionDB();
            SqlDataReader registros = null;
            connection.Open();
            SqlCommand querySel = new SqlCommand("SELECT MTR.id_materia, MTR.nombre_materia " +
                "FROM MATERIA AS MTR;", connection.connectDb);

            registros = querySel.ExecuteReader();

            while (registros.Read())
            {
                var registro = new Materia()
                {
                    Id = registros["id_materia"].ToString(),
                    Nombre = registros["nombre_materia"].ToString(),
                };
                ListaMateria.Add(registro);
            }
            connection.Close();

            return ListaMateria;
        }

    }
}
