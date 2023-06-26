using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Classes
{
    class Externos:Usuario
    {
        ConnectionDB connection = new ConnectionDB();
        public string Estado_Certificado{ get; set; }
        public Externos(string id, string n, string a, string contra, string c,string estado) : base(id, n, a, contra, c)
        {
            this.Estado_Certificado = estado;
        }

        public void AgregarAlumno(Externos e)
        {
            
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            INSERT INTO USUARIO(id_usuario,nombre_usuario,apellido_usuario,contraseña,correo_usuario)
            VALUES('{e.Id}', '{e.Nombre}', {e.Apellido}, '{e.Contraseña}', {e.Correo})

            INSERT INTO EXTERNO(id_usuario,certificado_externo)
            VALUES('{e.Id}','{e.Estado_Certificado}')
             COMMIT;";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);

            connection.Close();
        }

        public void EditarAlumno(Externos e)
        {
            
            connection.Open();
            //Se tiene que probar 
            string cad = $@"BEGIN TRANSACTION;
            UPDATE USUARIO SET id_usuario='{e.Id}',nombre_usuario='{e.Nombre}',apellido_usuario='{e.Apellido}',contraseña='{e.Contraseña}',correo_usuario='{e.Correo}
            WHERE id_usuario = {e.Id};
            
            UPDATE EXTERNO SET certificado_externo='{e.Estado_Certificado}'
            WHERE id_usuario='{e.Id}'

            COMMIT;";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }
        public void EliminarAlumno(Externos e)
        {
            
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            DELETE EXTERNO
            WHERE id_usuario= {e.Id};

            DELETE USUARIO
            WHERE id_usuario= {e.Id};

            COMMIT;";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }


    }
}
