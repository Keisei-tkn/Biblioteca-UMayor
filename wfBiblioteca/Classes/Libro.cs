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

        public Libro():base()
        {
            Isbn = null;
            NumPag = 0;
        }

        public Libro(string id, string nombre,string autor, string materia, string descripcion, Boolean estado, string dep_rev, string idioma, DateTime fecha, int un, string editorial, string isbn, int num_pag):base(id, nombre, autor, materia, descripcion, estado, dep_rev, idioma, fecha, un, editorial)
        {
            this.Isbn = isbn;
            this.NumPag = num_pag;
        }
        public void InsertarLibro(Libro lib, string idAutor, string idEditorial, string idMateria)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();

            string cad = $@"BEGIN TRANSACTION;
            INSERT INTO MATERIAL(id_material,titulo,fecha_publicacion,unidades_existentes,deposito_o_reserva,estado,id_autor,id_editorial,id_materia, descripcion) 
            VALUES('{lib.Id}', '{lib.FechaPublicacion.ToString("yyyyMMdd")}', {lib.Unidades}, '{lib.Deposito_reserva}', {(lib.Estado == true ? 1 : 0)}, '{idAutor}','{idEditorial}','{idMateria}','{lib.Descripcion}')
            
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
            SET titulo = '{lib.Nombre}', fecha_publicacion = '{lib.FechaPublicacion.ToString("yyyyMMdd")}', unidades_existentes = {lib.Unidades}, deposito_o_reserva = '{lib.Deposito_reserva}', estado = {(lib.Estado == true ? 1 : 0)}, descripcion = '{lib.Descripcion}'
            WHERE id_material = '{lib.Id}';

            UPDATE LIBRO
            SET isbn = '{lib.Isbn}', num_pag = {lib.NumPag}
            WHERE id_material = '{lib.Id}';
            COMMIT;";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }

        public void EliminarLibro(Libro lib)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            DELETE MATERIAL
            WHERE id_material = {lib.Id};

            DELETE LIBRO
            WHERE id_material = {lib.Id};
            COMMIT;";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }
    }
}
