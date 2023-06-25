using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Classes
{
    class Usuario
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Correo { set; get; }


        public List<Prestamo> ObtenerHistorial(Usuario usr)
        {
            List<Prestamo> historial = new List<Prestamo>();
            ConnectionDB connection = new ConnectionDB();
            SqlDataReader registros = null;
            connection.Open();
            SqlCommand querySel = new SqlCommand($@"SELECT * 
                FROM PRESTAMO
                WHERE PRESTAMO.id_material = '{usr.Id}'", connection.connectDb);

            registros = querySel.ExecuteReader();

            while (registros.Read())
            {
                var registro = new Prestamo()
                {
                    Id = registros["id_material"].ToString(),
                   FechaPrestamo = DateTime.Parse(registros["fecha_prestamo"].ToString()),
                   FechaDevolucion = DateTime.Parse(registros["fecha_devolucion"].ToString())
                };
                historial.Add(registro);
            }
            connection.Close();

            return historial;
        }

    }
}
