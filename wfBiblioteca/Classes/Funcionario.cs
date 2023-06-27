using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Classes
{
    class Funcionario : Usuario
    {
        ConnectionDB connection = new ConnectionDB();
        public string id_funcionario { get; set; }
        public string contraseña_c { get; set; }
        public string departamento { get; set; }

        public Funcionario(string id, string n, string a, string contra, string c, string contraC, string d) : base(id, n, a, contra, c)
        {
            this.id_funcionario = GeneradorId();
            this.contraseña_c = contraC;
            this.departamento = BuscarDepartamento(d);
        }
        private string BuscarDepartamento(string nombre)
        {
            string idDep;
            SqlDataReader registros = null;
            connection.Open();
            string cadena = "SELECT id_departamento from DEPARTAMENTO WHERE nombre = '" + nombre + "'";
            SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
            registros = comando.ExecuteReader();
            idDep = registros.GetString(0).ToString();
            connection.Close();
            return idDep;
        }

        public void AgregarFuncionario(Funcionario f)
        {
            
            connection.Open();

            string cad = $@"BEGIN TRANSACTION;
            INSERT INTO USUARIO(id_usuario,nombre_usuario,apellido_usuario,contraseña,correo_usuario)
            VALUES('{f.Id}', '{f.Nombre}', '{f.Apellido}', '{f.Contraseña}', '{f.Correo}')

            INSERT INTO FUNCIONARIO(id_usuario,id_funcionario)
            VALUES('{f.Id}','{f.id_funcionario}')

            INSERT INTO RELACION_FUNCIONARIO_DEPARTAMENTO(id_departamento,id_funcionario)
            VALUES('{f.departamento}','{f.id_funcionario}')
             COMMIT;";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);
            queryInsert.ExecuteNonQuery();
            connection.Close();
        }

        public void EditarFuncionario(Funcionario f)
        {
            connection.Open();
            //Se tiene que probar 
            string cad = $@"BEGIN TRANSACTION;
            UPDATE FUNCIONARIO SET id_departamento='{f.Correo}'
            WHERE id_usuario = '{f.Id}';

            UPDATE USUARIO SET correo_usuario='{f.Correo}'
            WHERE id_usuario = '{f.Id}';
            COMMIT;";

            //Hacer el caso en que se cambie de nucleo

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }

        public void EliminarFuncionario(Funcionario f)
        {

            connection.Open();

            string cad = $@"BEGIN TRANSACTION;
            DELETE RELACION_FUNCIONARIO_DEPARTAMENTO
            WHERE id_funcionario='{f.Id}'

            DELETE FUNCIONARIO
            WHERE id_funcionario='{f.Id}'
                

            DELETE USUARIO
            WHERE id_usuario='{f.Id}'
             COMMIT;";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);
            queryInsert.ExecuteNonQuery();

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
            id_funcionario = codeBuilder.ToString();


            if (validar_id(id_funcionario) == false)
            {
                GeneradorId();
            }
            return id_funcionario;
        }
        private bool validar_id(string id)
        {
            bool EstaOk = false;
            SqlDataReader registros = null;
            connection.Open();
            string cadena = "SELECT id_funcionario from FUNCIONARIO";
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
            return EstaOk;
        }

    }
}