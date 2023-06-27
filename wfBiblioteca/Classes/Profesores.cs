using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Classes
{
    class Profesores : Usuario
    {
        ConnectionDB connection = new ConnectionDB();
        public string ID_Nucleo { get; set; }

        public Profesores(string id, string n, string a, string contra, string c, string nomN) : base(id, n, a, contra, c)
        {
            this.ID_Nucleo = BuscarID(nomN);
        }

        private string BuscarID(string nombre)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cadena = "SELECT * from NUCLEO";
            SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                if (nombre == lector.GetValue(1).ToString())
                {
                    nombre = lector.GetValue(0).ToString();
                    return nombre;
                }
            }
            connection.Close();
            return nombre;
        }

        public void AgregarProfesor(Profesores p)
        {

            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            INSERT INTO USUARIO VALUES('{p.Id}', '{p.Nombre}', '{p.Apellido}', '{p.Correo}', '{p.Contraseña}')

            INSERT INTO PROFESOR(id_usuario,id_nucleo)
            VALUES('{p.Id}','{p.ID_Nucleo}')
             COMMIT;";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);
            queryInsert.ExecuteNonQuery();
            connection.Close();
        }
        public void EditarProfesor(Profesores p)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            //Se tiene que probar 
            string cad = $@"BEGIN TRANSACTION;
            UPDATE USUARIO SET correo_usuario='{p.Correo}'
            WHERE id_usuario = '{p.Id}';

            UPDATE PROFESOR SET id_nucleo='{p.ID_Nucleo}'
            WHERE id_usuario = '{p.Id}';

            COMMIT;";
            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }

        public void EliminarProfesor(Profesores p)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            DELETE PROFESOR
            WHERE id_usuario= '{p.Id}';

            DELETE USUARIO
            WHERE id_usuario= '{p.Id}';

            COMMIT;";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }


    }
}
