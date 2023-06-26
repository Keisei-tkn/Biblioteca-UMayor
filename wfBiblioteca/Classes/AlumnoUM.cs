using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Classes
{
    class AlumnoUM : Usuario
    {

        public string Sede { get; set; }

        public AlumnoUM(string id, string n, string a, string contra, string correo, string sede) : base(id, n, a, contra, correo)
        {
            Sede = sede;
        }
        public void AgregarAlumno(AlumnoUM a)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();

            string cad = $@"BEGIN TRANSACTION;
            INSERT INTO USUARIO(id_usuario,nombre_usuario,apellido_usuario,contraseña,correo_usuario)
            VALUES('{a.Id}', '{a.Nombre}', {a.Apellido}, '{a.Contraseña}', {a.Correo})

            INSERT INTO ALUMNO(id_usuario,sede)
            VALUES('{a.Id}','{a.Sede}')
             COMMIT;";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);

            connection.Close();
        }

        public void EditarAlumno(AlumnoUM a)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            //Se tiene que probar 
            string cad = $@"BEGIN TRANSACTION;
            UPDATE USUARIO SET id_usuario='{a.Id}',nombre_usuario='{a.Nombre}',apellido_usuario='{a.Apellido}',contraseña='{a.Contraseña}',correo_usuario='{a.Correo}
            WHERE id_usuario = {a.Id};
            
            UPDATE ALUMNO SET sede='{a.Sede}'
            WHERE id_usuario='{a.Id}'

            COMMIT;";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }
        public void EliminarAlumno(AlumnoUM u)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            DELETE ALUMNO
            WHERE id_usuario= {u.Id};

            DELETE USUARIO
            WHERE id_usuario= {u.Id};

            COMMIT;";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }
    }
}