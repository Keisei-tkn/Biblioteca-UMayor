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
            SqlDataReader registros = null;
            connection.Open();
            string cadena = "SELECT id_nucleo from NUCLEO WHERE nombre = '" + nombre + "'";
            SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
            registros = comando.ExecuteReader();
            string idBuscado;
            idBuscado = registros.GetString(0).ToString();
            connection.Close();
            return idBuscado;

        }

        public void AgregarProfesor(Profesores p)
        {

            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            INSERT INTO USUARIO(id_usuario,nombre_usuario,apellido_usuario,contraseña,correo_usuario)
            VALUES('{p.Id}', '{p.Nombre}', {p.Apellido}, '{p.Contraseña}', '{p.Correo}')

            INSERT INTO PROFESOR(id_usuario,id_nucleo)
            VALUES('{p.Id}','{p.ID_Nucleo}')
             COMMIT;";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);

            connection.Close();
        }
        public void EditarProfesor(Profesores p)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            //Se tiene que probar 
            string cad = $@"BEGIN TRANSACTION;
            UPDATE USUARIO SET id_usuario='{p.Id}',nombre_usuario='{p.Nombre}',apellido_usuario='{p.Apellido}',contraseña='{p.Contraseña}',correo_usuario='{p.Correo}'
            WHERE id_usuario = '{p.Id}';
            COMMIT;";

            //Hacer el caso en que se cambie de nucleo

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
