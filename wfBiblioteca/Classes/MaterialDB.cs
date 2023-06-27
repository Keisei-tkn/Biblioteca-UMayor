using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.SQL;
using System.Data.SqlClient;

namespace wfBiblioteca.Classes
{
    class MaterialDB
    {
        public List<Material> ListaMaterial;

        public MaterialDB()
        {
            this.ListaMaterial = new List<Material>();
            this.ListaMaterial.AddRange(ObtenerLibro());
            this.ListaMaterial.AddRange(ObtenerAudiovisual());
            this.ListaMaterial.AddRange(ObtenerRevista());
            this.ListaMaterial.AddRange(ObtenerOtro());
        }

        public List<Material> ObtenerLibro() {
            List<Material>  ListaLibro = new List<Material>();
            ConnectionDB connection = new ConnectionDB();
            SqlDataReader registros = null;
            connection.Open();
            SqlCommand querySel = new SqlCommand("SELECT MAT.id_material, MAT.titulo, MAT.fecha_publicacion, MAT.unidades_existentes, MAT.deposito_o_reserva, MAT.disponible, MAT.descripcion, " +
                "MAR.nombre_materia, AUT.nombre autor, ED.nombre editorial, LIB.isbn, LIB.num_pag " +
                "FROM MATERIAL AS MAT " +
                "INNER JOIN LIBRO AS LIB ON MAT.id_material = LIB.id_material " +
                "INNER JOIN MATERIA AS MAR ON MAT.id_materia = MAR.id_materia " +
                "INNER JOIN AUTOR AS AUT ON MAT.id_autor = AUT.id_autor " +
                "INNER JOIN EDITORIAL AS ED ON MAT.id_editorial = ED.id_editorial; ", connection.connectDb);

            registros = querySel.ExecuteReader();

            while (registros.Read())
            {
                var registro = new Libro()
                {
                    Id = registros["id_material"].ToString(),
                    Nombre = registros["titulo"].ToString(),
                    FechaPublicacion = DateTime.Parse(registros["fecha_publicacion"].ToString()),
                    Unidades = (int)registros["unidades_existentes"],
                    Descripcion = registros["descripcion"].ToString(),
                    Materia = registros["nombre_materia"].ToString(),
                    Estado = (bool)registros["disponible"],
                    Autor = registros["autor"].ToString(),
                    Editorial = registros["editorial"].ToString(),
                    Isbn = registros["isbn"].ToString(),
                    NumPag = (int)registros["num_pag"]
                };
                ListaLibro.Add(registro);
            }
            connection.Close();

            return ListaLibro;
        }

        public List<Material> ObtenerRevista()
        {
            List<Material>  ListaRevista = new List<Material>();
            ConnectionDB connection = new ConnectionDB();
            SqlDataReader registros = null;
            connection.Open();
            SqlCommand querySel = new SqlCommand("SELECT MAT.id_material, MAT.titulo, MAT.fecha_publicacion, MAT.unidades_existentes, MAT.deposito_o_reserva, MAT.disponible, MAT.descripcion, " +
                "MAR.nombre_materia, AUT.nombre autor, ED.nombre editorial, REV.num_revista, REV.vol_revista, MAR.nombre_materia " +
                "FROM MATERIAL AS MAT " +
                "INNER JOIN REVISTA AS REV ON MAT.id_material = REV.id_material " +
                "INNER JOIN MATERIA AS MAR ON MAT.id_materia = MAR.id_materia " +
                "INNER JOIN AUTOR AS AUT ON MAT.id_autor = AUT.id_autor " +
                "INNER JOIN EDITORIAL AS ED ON MAT.id_editorial = ED.id_editorial ", connection.connectDb);

            registros = querySel.ExecuteReader();

            while (registros.Read())
            {
                var registro = new Revista()
                {
                    Id = registros["id_material"].ToString(),
                    Nombre = registros["titulo"].ToString(),
                    FechaPublicacion = DateTime.Parse(registros["fecha_publicacion"].ToString()),
                    Unidades = (int)registros["unidades_existentes"],
                    Descripcion = registros["descripcion"].ToString(),
                    Materia = registros["nombre_materia"].ToString(),
                    Estado = (bool)registros["disponible"],
                    Autor = registros["autor"].ToString(),
                    Editorial = registros["editorial"].ToString(),
                    Numero = (int)registros["num_revista"],
                    Volumen = (int)registros["vol_revista"]
                    
                };
                ListaRevista.Add(registro);
            }
            connection.Close();

            return ListaRevista;
        }

        public List<Material> ObtenerAudiovisual()
        {
            List<Material> ListaAudiovisual = new List<Material>();
            ConnectionDB connection = new ConnectionDB();
            SqlDataReader registros = null;
            connection.Open();
            SqlCommand querySel = new SqlCommand($@"SELECT MAT.id_material, MAT.titulo, MAT.fecha_publicacion, MAT.unidades_existentes, MAT.deposito_o_reserva, MAT.disponible, MAT.descripcion,
            MAR.nombre_materia, AUT.nombre autor, ED.nombre editorial, AUD.duracion
            FROM MATERIAL AS MAT
            INNER JOIN AUDIOVISUAL AS AUD ON MAT.id_material = AUD.id_material 
            INNER JOIN MATERIA AS MAR ON MAT.id_materia = MAR.id_materia 
            INNER JOIN AUTOR AS AUT ON MAT.id_autor = AUT.id_autor 
            INNER JOIN EDITORIAL AS ED ON MAT.id_editorial = ED.id_editorial; ", connection.connectDb);

            registros = querySel.ExecuteReader();

            while (registros.Read())
            {
                var registro = new Audiovisual()
                {
                    Id = registros["id_material"].ToString(),
                    Nombre = registros["titulo"].ToString(),
                    FechaPublicacion = DateTime.Parse(registros["fecha_publicacion"].ToString()),
                    Unidades = (int)registros["unidades_existentes"],
                    Descripcion = registros["descripcion"].ToString(),
                    Materia = registros["nombre_materia"].ToString(),
                    Estado = (bool)registros["disponible"],
                    Autor = registros["autor"].ToString(),
                    Editorial = registros["editorial"].ToString(),
                    Duracion = (int)registros["duracion"]

                };
                ListaAudiovisual.Add(registro);
            }
            connection.Close();

            return ListaAudiovisual;

        }

        public List<Material> ObtenerOtro()
        {
            List<Material>  ListaOtro = new List<Material>();
            ConnectionDB connection = new ConnectionDB();
            SqlDataReader registros = null;
            connection.Open();
            SqlCommand querySel = new SqlCommand($@"SELECT MAT.id_material, MAT.titulo, MAT.fecha_publicacion, MAT.unidades_existentes, MAT.deposito_o_reserva, MAT.disponible, MAT.descripcion, 
            MAR.nombre_materia, AUT.nombre autor, ED.nombre editorial, OTR.categoria 
            FROM MATERIAL AS MAT
            INNER JOIN OTRO AS OTR ON MAT.id_material = OTR.id_material 
            INNER JOIN MATERIA AS MAR ON MAT.id_materia = MAR.id_materia 
            INNER JOIN AUTOR AS AUT ON MAT.id_autor = AUT.id_autor 
            INNER JOIN EDITORIAL AS ED ON MAT.id_editorial = ED.id_editorial", connection.connectDb);

            registros = querySel.ExecuteReader();

            while (registros.Read())
            {
                var registro = new Otro()
                {
                    Id = registros["id_material"].ToString(),
                    Nombre = registros["titulo"].ToString(),
                    FechaPublicacion = DateTime.Parse(registros["fecha_publicacion"].ToString()),
                    Unidades = (int)registros["unidades_existentes"],
                    Descripcion = registros["descripcion"].ToString(),
                    Materia = registros["nombre_materia"].ToString(),
                    Estado = (bool)registros["disponible"],
                    Autor = registros["autor"].ToString(),
                    Editorial = registros["editorial"].ToString(),
                    Categoria = registros["categoria"].ToString()
                };
                ListaOtro.Add(registro);
            }
            connection.Close();
            return ListaOtro;
        }




    }
}
