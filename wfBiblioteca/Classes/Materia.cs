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

        public Materia(string nombre)
        {
            this.Id = GeneradorId();
            this.Nombre = nombre;
        }

        public void InsertarMateria(Materia mtr)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();

            string cad = $@"INSERT INTO MATERIA(id_materia,nombre_materia) 
            VALUES('{mtr.Id}','{mtr.Nombre}');";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);
            queryInsert.ExecuteNonQuery();

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
            string cadena = "SELECT id_materia from MATERIA";
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
