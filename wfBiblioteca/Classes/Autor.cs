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

        public Autor(string nombre)
        {
            this.Id = GeneradorId();
            this.Nombre = nombre;
        }

        public void InsertarAutor(Autor aut)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();

            string cad = $@"INSERT INTO AUTOR(id_autor,nombre) 
            VALUES('{aut.Id}','{aut.Nombre}');";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);

            queryInsert.ExecuteNonQuery();
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


        private string GeneradorId()
        {
            Random random = new Random();
            StringBuilder codeBuilder = new StringBuilder();

            // Generar tres letras mayúsculas
            for (int i = 0; i < 3; i++)
            {
                char letter = (char)random.Next('A', 'Z' + 1);
                codeBuilder.Append(letter);
            }

            // Generar tres números al azar
            for (int i = 0; i < 3; i++)
            {
                int number = random.Next(0, 10);
                codeBuilder.Append(number);
            }
            Id = codeBuilder.ToString();


            if (validar_id(Id) == false)
            {
                GeneradorId();
            }
            return Id;
        }
        private bool validar_id(string id)
        {
            ConnectionDB connection = new ConnectionDB();
            bool EstaOk = false;
            SqlDataReader registros = null;
            connection.Open();
            string cadena = "SELECT id_autor from AUTOR";
            SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
            registros = comando.ExecuteReader();
            string idBuscado;

            while (registros.Read())
            {
                idBuscado = registros.GetString(0).ToString();
                if (id == idBuscado)
                {
                    EstaOk = false;
                    connection.Close();
                    return EstaOk;
                }
                else
                {

                    EstaOk = true;
                }
            }
            connection.Close();
            return EstaOk;
        }
    }

}
