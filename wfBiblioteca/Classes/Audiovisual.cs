﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Classes
{
    class Audiovisual:Material
    {
        public int Duracion { get; set; }

        public void InsertarAudiovisual(Audiovisual aud, string idAutor, string idEditorial, string idMateria)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();

            string cad = $@"BEGIN TRANSACTION;
            INSERT INTO MATERIAL(id_material,titulo,fecha_publicacion,unidades_existentes,deposito_o_reserva,estado,id_autor,id_editorial,id_materia) 
            VALUES('{aud.Id}', '{aud.FechaPublicacion.ToString("yyyyMMdd")}', {aud.Unidades}, '{aud.Deposito_reserva}', {(aud.Estado == true ? 1 : 0)}, '{idAutor}','{idEditorial}','{idMateria}')
            
            INSERT INTO AUDIOVISUAL(duracion)
            VALUES({aud.Duracion})
             COMMIT;";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);

            connection.Close();
        }
        public void ActualizarAudiovisual(Audiovisual aud)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            UPDATE MATERIAL
            SET titulo = {aud.Nombre}, fecha_publicacion = {aud.FechaPublicacion.ToString("yyyyMMdd")}, unidades_existentes = {aud.Unidades}, deposito_o_reserva = {aud.Deposito_reserva}, estado = {(aud.Estado == true ? 1 : 0)}
            WHERE id_material = {aud.Id};

            UPDATE AUDIOVISUAL
            SET duracion = {aud.Duracion}
            WHERE id_material = {aud.Id};
            COMMIT;";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }

    }
}
