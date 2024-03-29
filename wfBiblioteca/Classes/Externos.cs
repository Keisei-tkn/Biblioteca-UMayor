﻿using System;
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
        public Externos(string id, string n, string a, string contra, string c,string t ,string estado) : base(id, n, a, contra, c,t)
        {
            this.Estado_Certificado = estado;
        }
        public Externos(string id, string c, string estado) : base(id, c)
        {
            this.Estado_Certificado = estado;
        }


        public void AgregarExterno(Externos e)
        {
            
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            INSERT INTO USUARIO VALUES('{e.Id}', '{e.Nombre}', '{e.Apellido}', '{e.Correo}', '{e.Contraseña}','{e.Tipo}')

            INSERT INTO EXTERNO(id_usuario,certificado_externo)
            VALUES('{e.Id}','{e.Estado_Certificado}')
             COMMIT;";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);
            queryInsert.ExecuteNonQuery();
            connection.Close();
        }

        public void EditarExterno(Externos e)
        {
            
            connection.Open();
            //Se tiene que probar 
            string cad = $@"BEGIN TRANSACTION;
            UPDATE USUARIO SET correo_usuario='{e.Correo}'
            WHERE id_usuario = '{e.Id}';
            
            UPDATE EXTERNO SET certificado_externo='{e.Estado_Certificado}'
            WHERE id_usuario='{e.Id}'

            COMMIT;";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }
        public void EliminarExterno(Externos e)
        {
            
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            DELETE EXTERNO
            WHERE id_usuario= '{e.Id}';

            DELETE USUARIO
            WHERE id_usuario= '{e.Id}';

            COMMIT;";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }


    }
}
