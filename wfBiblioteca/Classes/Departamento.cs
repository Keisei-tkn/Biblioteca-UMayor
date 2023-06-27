using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Classes
{
    class Departamento
    {
        ConnectionDB connection = new ConnectionDB();
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Presupuesto { get; set; }

        public Departamento(string n,string p)
        {
            this.Id = GeneradorId();
            this.Nombre = n;
            this.Presupuesto = p;
        }

        public void AgregarDepartamento(Departamento d)
        {
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            INSERT INTO DEPARTAMENTO VALUES('{d.Id}', {d.Presupuesto},'{d.Nombre}')
            COMMIT;";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);
            queryInsert.ExecuteNonQuery();
            connection.Close();
        }
        public void EditarDepartamento(Departamento d)
        {
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            UPDATE DEPARTAMENTO SET presupuesto='{d.Presupuesto}'
            WHERE id_departamento = '{d.Id}';
            COMMIT;";
            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }
        public void EliminarDepartamento(Departamento d)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            DELETE RELACION_FUNCIONARIO_DEPARTAMENTO
            WHERE id_departamento= '{d.Id}';

            DELETE DEPARTAMENTO
            WHERE id_departamento= '{d.Id}';
            COMMIT;";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
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
            bool EstaOk = false;
            SqlDataReader registros = null;
            connection.Open();
            string cadena = "SELECT id_departamento from DEPARTAMENTO";
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
