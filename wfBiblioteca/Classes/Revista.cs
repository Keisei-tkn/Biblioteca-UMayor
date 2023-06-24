using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Classes
{
    class Revista:Material
    {
        public int Numero { get; set; }
        public int Volumen { get; set; }

        public void InsertarRevista(Revista rev, string idAutor, string idEditorial, string idMateria)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();

            string cad = $@"BEGIN TRANSACTION;
            INSERT INTO MATERIAL(id_material,titulo,fecha_publicacion,unidades_existentes,deposito_o_reserva,estado,id_autor,id_editorial,id_materia) 
            VALUES('{rev.Id}', '{rev.FechaPublicacion.ToString("yyyyMMdd")}', {rev.Unidades}, '{rev.Deposito_reserva}', {(rev.Estado == true ? 1 : 0)}, '{idAutor}','{idEditorial}','{idMateria}')
            
            INSERT INTO REVISTA(num_revista, vol_revista)
            VALUES('{rev.Numero}',{rev.Volumen})
             COMMIT;";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);

            connection.Close();
        }
        public void ActualizarRevista(Revista rev)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            UPDATE MATERIAL
            SET titulo = {rev.Nombre}, fecha_publicacion = {rev.FechaPublicacion.ToString("yyyyMMdd")}, unidades_existentes = {rev.Unidades}, deposito_o_reserva = {rev.Deposito_reserva}, estado = {(rev.Estado == true ? 1 : 0)}
            WHERE id_material = {rev.Id};

            UPDATE REVISTA
            SET num_revista = {rev.Numero}, vol_revista = {rev.Volumen}
            WHERE id_material = {rev.Id};
            COMMIT;";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }

        public void EliminarRevista(Revista rev)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            DELETE MATERIAL
            WHERE id_material = {rev.Id};

            DELETE REVISTA
            WHERE id_material = {rev.Id};
            COMMIT;";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }
    }
}
