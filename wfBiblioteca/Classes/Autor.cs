using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Classes
{
    class Autor
    {
        public string Id;
        public string Nombre;

        public Autor()
        {
            this.Id = null;
            this.Nombre = null;
        }

        public Autor(string id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }

        public void InsertarAutor(Autor aut)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();

            string cad = $@"INSERT INTO AUTOR(id_autor,nombre) 
            VALUES('{aut.Id}','{aut.Nombre}');";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);

            connection.Close();
        }

        public List<Autor> ObtenerListaAutor()
        {
            List<Autor> ListaAutor = new List<Autor>();
            ConnectionDB connection = new ConnectionDB();
            SqlDataReader registros = null;
            connection.Open();
            SqlCommand querySel = new SqlCommand("SELECT AUT.id_autor, AUT.nombre " +
                "FROM AUTOR AS AUT;", connection.connectDb);

            registros = querySel.ExecuteReader();

            while (registros.Read())
            {
                var registro = new Autor()
                {
                    Id = registros["id_autor"].ToString(),
                    Nombre = registros["nombre"].ToString(),
                };
                ListaAutor.Add(registro);
            }
            connection.Close();

            return ListaAutor;
        }
    }
}
