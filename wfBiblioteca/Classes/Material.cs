using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Classes 
{
    public class Material
    {
        ConnectionDB connection = new ConnectionDB();
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Materia { get; set; }
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
        public string Deposito_reserva { get; set; }
        public string Idioma { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int Unidades { get; set; }
        public string Editorial { get; set; }
        public string Imagen { get; set; }

        public Material()
        {
            this.Id = null;
            this.Nombre = null;
            this.Autor = null;
            this.Materia = null;
            this.Descripcion = null;
            this.Estado = false;
            this.Deposito_reserva = null;
            this.Idioma = null;
            this.FechaPublicacion = DateTime.MinValue;
            this.Unidades = 0;
            this.Editorial = null;
        }
        public Material(string nombre, string autor, string materia, string descripcion, Boolean estado, string dep_rev, string idioma, DateTime fecha, int un, string editorial, string imagen)
        {
            this.Id = GeneradorId();
            this.Nombre = nombre;
            this.Autor = autor;
            this.Materia = materia;
            this.Descripcion = descripcion;
            this.Estado = estado;
            this.Deposito_reserva = dep_rev;
            this.Idioma = idioma;
            this.FechaPublicacion = fecha;
            this.Unidades = un;
            this.Editorial = editorial;
            this.Imagen = imagen;
        }
        private string GeneradorId()
        {
            Random random = new Random();
            StringBuilder codeBuilder = new StringBuilder();

            // Generar tres letras mayúsculas
            for (int i = 0; i < 3; i++)
            {
                char letter = (char)random.Next('A', 'Z' + 1);
                codeBuilder.Append(letter);
            }

            // Generar tres números al azar
            for (int i = 0; i < 3; i++)
            {
                int number = random.Next(0, 10);
                codeBuilder.Append(number);
            }
            Id = codeBuilder.ToString();


            if (validar_id(Id) == false)
            {
                GeneradorId();
            }
            return Id;
        }
        private bool validar_id(string id)
        {
            bool EstaOk = false;
            SqlDataReader registros = null;
            connection.Open();
            string cadena = "SELECT id_nucleo from MATERIAL";
            SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
            registros = comando.ExecuteReader();
            string idBuscado;

            while (registros.Read())
            {
                idBuscado = registros.GetString(0).ToString();
                if (id == idBuscado)
                {
                    EstaOk = false;
                    connection.Close();
                    return EstaOk;
                }
                else
                {

                    EstaOk = true;


                }
            }
            connection.Close();
            return EstaOk;
        }
    }
}
