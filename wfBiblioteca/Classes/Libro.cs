using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Classes
{
    class Libro: Material
    {
        public string Isbn { get; set; }
        public int NumPag { get; set; }


        public void InsertarLibro(Libro lib, string idAutor, string idEditorial, string idMateria)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();

            string cad = $@"BEGIN TRANSACTION;
            INSERT INTO MATERIAL(id_material,titulo,fecha_publicacion,unidades_existentes,deposito_o_reserva,estado,id_autor,id_editorial,id_materia) 
            VALUES('{lib.Id}', '{lib.FechaPublicacion.ToString("yyyyMMdd")}', {lib.Unidades}, '{lib.Deposito_reserva}', {(lib.Estado == true ? 1 : 0)}, '{idAutor}','{idEditorial}','{idMateria}')
            
            INSERT INTO LIBRO(isbn, num_pag)
            VALUES('{lib.Isbn}',{lib.NumPag})
             COMMIT;";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);

            connection.Close();
        }
        public void ActualizarLibro(Libro lib)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            UPDATE MATERIAL
            SET titulo = {lib.Nombre}, fecha_publicacion = {lib.FechaPublicacion.ToString("yyyyMMdd")}, unidades_existentes = {lib.Unidades}, deposito_o_reserva = {lib.Deposito_reserva}, estado = {(lib.Estado == true ? 1 : 0)}
            WHERE id_material = {lib.Id};

            UPDATE LIBRO
            SET isbn = {lib.Isbn}, num_pag = {lib.NumPag}
            WHERE id_material = {lib.Id};
            COMMIT;";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }
    }
}
