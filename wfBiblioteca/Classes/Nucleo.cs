using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.ConnectionBD;

namespace wfBiblioteca.Classes
{
    class Nucleo
    {
        ConnectionDB connection = new ConnectionDB();
        public string id_nucleo { get; set; }
        public string Nombre { get; set; }


        public Nucleo(string nombre)
        {
            id_nucleo = GeneradorId();
            Nombre = nombre;
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
            id_nucleo = codeBuilder.ToString();

            
            if (validar_id(id_nucleo) == false)
            {
                GeneradorId();
            }
            return id_nucleo;
        }
        private bool validar_id(string id)
        {
            bool EstaOk = false;
            SqlDataReader registros = null;
            connection.Open();
            string cadena = "SELECT id_nucleo from NUCLEO";
            SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
            registros = comando.ExecuteReader();
            string idBuscado;

            while (registros.Read())
            {
                idBuscado = registros.GetString(0).ToString();
                if (id==idBuscado)
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
            return EstaOk;
        }
    }
}
