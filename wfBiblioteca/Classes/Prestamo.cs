using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Classes
{
    class Prestamo
    {
        public string Id { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string IdMaterial { get; set; }
        public Boolean Activo { get; set; }

        public Prestamo()
        {
            Id = null;
            FechaPrestamo = DateTime.MinValue;
            FechaDevolucion = DateTime.MinValue;
            IdMaterial = null;
            Activo = false;
        }
        public Prestamo(Prestamo p)
        {
            Id = p.Id;
            FechaPrestamo = p.FechaPrestamo;
            FechaDevolucion = p.FechaDevolucion;
            IdMaterial = p.IdMaterial;
            Activo = p.Activo;
        }

        public Prestamo(Material mat)
        {
            Id = GeneradorId();
            FechaPrestamo = DateTime.Now;
            if (mat.Deposito_reserva.Equals("Deposito")){
                FechaDevolucion = FechaPrestamo.AddDays(7);
            }else
            {
                FechaDevolucion = FechaPrestamo.AddDays(1);
            }
            IdMaterial = mat.Id;
            Activo = true;
        }

        public void InsertarPrestamo(Prestamo prs)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();

            string cad = $@"INSERT INTO PRESTAMO(id_prestamo,fecha_prestamo, fecha, devolucion, id_material) 
            VALUES('{prs.Id}','{prs.FechaPrestamo.ToString()}', '{prs.FechaDevolucion.ToString()}','{prs.IdMaterial}');";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);

            queryInsert.ExecuteNonQuery();
            connection.Close();
        }

        public List<Prestamo> ObtenerHistorial(string id_usuario)
        {
            List<Prestamo> Historial;
            ConnectionDB connection = new ConnectionDB();
            SqlDataReader registros = null;
            connection.Open();
            List<String> IdPrestamos = new List<string>();

            SqlCommand querySel = new SqlCommand($@"SELECT HIS.id_prestamo FROM HISTORIAL AS HIS WHERE HIS.id_usuario = '{id_usuario}';", connection.connectDb);

            registros = querySel.ExecuteReader();

            while (registros.Read())
            {
                string registro = registros["id_prestamo"].ToString();
                IdPrestamos.Add(registro);
            }
            connection.Close();
            Historial = ObtenerPrestamos(IdPrestamos);
            return Historial;
        }

        public List<Prestamo> ObtenerPrestamos(List<String> IdPrestamos)
        {
            List<Prestamo> ListaPrestamos = new List<Prestamo>();
            ConnectionDB connection = new ConnectionDB();
            SqlDataReader registros = null;
            connection.Open();

            foreach (string Id in IdPrestamos) {
                SqlCommand querySel = new SqlCommand($@"SELECT PRS.id_prestamo, PRS.fecha_prestamo, PRS.fecha_devolucion, PRS.id_material, PRS.activo FROM PRESTAMO AS PRS WHERE id_prestamo = '{Id}';", connection.connectDb);

                registros = querySel.ExecuteReader();

                while (registros.Read())
                {
                    var registro = new Prestamo()
                    {
                        Id = registros["id_prestamo"].ToString(),
                        FechaPrestamo = DateTime.Parse(registros["fecha_prestamo"].ToString()),
                        FechaDevolucion = DateTime.Parse(registros["fecha_devolucion"].ToString()),
                        IdMaterial = registros["id_material"].ToString(),
                        Activo = (bool)registros["activo"]
                    };
                    ListaPrestamos.Add(registro);
                }
            }
            connection.Close();
            return ListaPrestamos;
        }
        public List<Prestamo> ObtenerAllPrestamos()
        {
            List<Prestamo> ListaPrestamos = new List<Prestamo>();
            ConnectionDB connection = new ConnectionDB();
            SqlDataReader registros = null;
            connection.Open();

            SqlCommand querySel = new SqlCommand($@"SELECT PRS.id_prestamo, PRS.fecha_prestamo, PRS.fecha_devolucion, PRS.id_material, PRS.activo FROM PRESTAMO AS PRS;", connection.connectDb);

            registros = querySel.ExecuteReader();

            while (registros.Read())
            {
                var registro = new Prestamo()
                {
                    Id = registros["id_prestamo"].ToString(),
                    FechaPrestamo = DateTime.Parse(registros["fecha_prestamo"].ToString()),
                    FechaDevolucion = DateTime.Parse(registros["fecha_devolucion"].ToString()),
                    IdMaterial = registros["id_material"].ToString(),
                    Activo = (bool)registros["activo"]
                };
                ListaPrestamos.Add(registro);
            }

            connection.Close();
            return ListaPrestamos;
        }

        public Boolean CheckAtraso()
        {
            Boolean Atrasado;
            if(FechaDevolucion < DateTime.Now)
            {
                Atrasado = true;
            }
            else
            {
                Atrasado = false;
            }
            return Atrasado;
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
            ConnectionDB connection = new ConnectionDB();
            bool EstaOk = false;
            SqlDataReader registros = null;
            connection.Open();
            string cadena = "SELECT id_prestamo from PRESTAMO";
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


        public void UpdatePrestamo(Prestamo prs)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            UPDATE PRESTAMO
            SET activo = '{0}'
            WHERE id_prestamo = '{prs.Id}';

            UPDATE ATRASO
            SET pagado = '{1}'
            WHERE id_prestamo = '{prs.Id}';
            COMMIT;";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }



        public List<Prestamo> ObtenerAllPrestamosActivos()
        {
            List<Prestamo> ListaPrestamos = new List<Prestamo>();
            ConnectionDB connection = new ConnectionDB();
            SqlDataReader registros = null;
            connection.Open();

            SqlCommand querySel = new SqlCommand($@"SELECT PRS.id_prestamo, PRS.fecha_prestamo, PRS.fecha_devolucion, PRS.id_material, PRS.activo FROM PRESTAMO AS PRS WHERE PRS.activo = 1;", connection.connectDb);

            registros = querySel.ExecuteReader();

            while (registros.Read())
            {
                var registro = new Prestamo()
                {
                    Id = registros["id_prestamo"].ToString(),
                    FechaPrestamo = DateTime.Parse(registros["fecha_prestamo"].ToString()),
                    FechaDevolucion = DateTime.Parse(registros["fecha_devolucion"].ToString()),
                    IdMaterial = registros["id_material"].ToString(),
                    Activo = (bool)registros["activo"]
                };
                ListaPrestamos.Add(registro);
            }

            connection.Close();
            return ListaPrestamos;
        }
    }
}
 