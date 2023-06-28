using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Classes
{
    class Otro:Material
    {
        public string Categoria { get; set; }

        public Otro():base()
        {
            this.Categoria = null;
        }

        public Otro(string nombre, string autor, string materia, string descripcion, Boolean estado, string dep_rev, string idioma, DateTime fecha, int un, string editorial,string imagen, string categoria) : base( nombre, autor, materia, descripcion, estado, dep_rev, idioma, fecha, un, editorial, imagen)
        {
            this.Categoria = categoria;
        }

        public void InsertarOtro(Otro otr, string idAutor, string idEditorial, string idMateria)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();

            string cad = $@"BEGIN TRANSACTION;
            INSERT INTO MATERIAL(id_material,titulo,fecha_publicacion,unidades_existentes,deposito_o_reserva,estado,portada,id_autor,id_editorial,id_materia, descripcion) 
            VALUES('{otr.Id}', '{otr.FechaPublicacion.ToString("yyyyMMdd")}', {otr.Unidades}, '{otr.Deposito_reserva}', '{otr.Imagen}',{(otr.Estado == true ? 1 : 0)}, '{idAutor}','{idEditorial}','{idMateria}','{otr.Descripcion}')
            
            INSERT INTO OTRO(categoria)
            VALUES('{otr.Categoria}')
             COMMIT;";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);

            connection.Close();
        }
        public void ActualizarOtro(Otro otr)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            UPDATE MATERIAL
            SET titulo = {otr.Nombre}, fecha_publicacion = {otr.FechaPublicacion.ToString("yyyyMMdd")}, unidades_existentes = {otr.Unidades}, deposito_o_reserva = {otr.Deposito_reserva}, estado = {(otr.Estado == true ? 1 : 0)}, descripcion = '{otr.Descripcion}'
            WHERE id_material = {otr.Id};

            UPDATE LIBRO
            SET categoria = {otr.Categoria}
            WHERE id_material = {otr.Id};
            COMMIT;";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }

        public void EliminarOtro(Otro otr)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            DELETE MATERIAL
            WHERE id_material = {otr.Id};

            DELETE OTRO
            WHERE id_material = {otr.Id};
            COMMIT;";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }
    }
}
