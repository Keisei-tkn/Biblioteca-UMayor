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

        public AlumnoUM(string id, string n, string a, string contra, string correo,string t ,string sede) : base(id, n, a, contra, correo,t)
        {
            Sede = sede;
        }
        public AlumnoUM(string id, string correo, string sede) : base(id, correo)
        {
            Sede = sede;
        }
        public void AgregarAlumno(AlumnoUM a)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();

            string cad = $@"BEGIN TRANSACTION;
            INSERT INTO USUARIO VALUES('{a.Id}', '{a.Nombre}', '{a.Apellido}', '{a.Correo}', '{a.Contraseña}','{a.Tipo}')

            INSERT INTO ALUMNO VALUES('{a.Id}','{a.Sede}')
            COMMIT;";
            try
            {
                SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);
                queryInsert.ExecuteNonQuery();
                Console.WriteLine("Registro realizado correctamente");
                connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            
            
        }
        public void EditarAlumno(AlumnoUM a)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            //Se tiene que probar 
            string cad = $@"BEGIN TRANSACTION;
            UPDATE USUARIO SET correo_usuario='{a.Correo}'
            WHERE id_usuario = '{a.Id}';
            
            UPDATE ALUMNO SET sede='{a.Sede}'
            WHERE id_usuario='{a.Id}'

            COMMIT;";

            try
            {
                SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
                queryUpdate.ExecuteNonQuery();
                Console.WriteLine("Registro realizado correctamente");
                connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }

            
        }
        public void EliminarAlumno(AlumnoUM u)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            DELETE ALUMNO
            WHERE id_usuario= '{u.Id}';

            DELETE USUARIO
            WHERE id_usuario= '{u.Id}';

            COMMIT;";

            try
            {
                SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
                queryUpdate.ExecuteNonQuery();
                Console.WriteLine("Registro realizado correctamente");
                connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }

        }
    }
}