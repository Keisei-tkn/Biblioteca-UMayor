using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Classes
{
    class Atraso
    {
        public string Id { get; set; }
        public string IdPrestamo { get; set; }
        public decimal Multa { get; set; }
        public Boolean Pagado { get; set; }

        public Atraso()
        {
            Id = null;
            IdPrestamo = null;
            Multa = 0;
            Pagado = false;
        }

        public Atraso(Prestamo prs)
        {
            Id = GeneradorId();
            IdPrestamo = prs.Id;
            Multa = 500;
            Pagado = false;
        }

        public void InsertarAtraso(Atraso atr)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();

            string cad = $@"INSERT INTO ATRASO(id_atraso,id_prestamo, multa, pagado) 
            VALUES('{atr.Id}','{atr.IdPrestamo}',{atr.Multa},{(atr.Pagado == true ? 1 : 0)});";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);

            queryInsert.ExecuteNonQuery();
            connection.Close();
        }

        public void AumentoMulta(Atraso atr, Prestamo prs)
        {
            TimeSpan diferencia = prs.FechaDevolucion - prs.FechaPrestamo;
            int cantidadDias = (int)diferencia.TotalDays;
            decimal multa = (decimal)(500 * (Math.Pow(2, cantidadDias)));

            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cad = $@"UPDATE ATRASO
            SET multa = {multa} 
            WHERE id_material = '{atr.Id}';";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }

        public void PagoMulta(Atraso atr)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cad = $@"UPDATE ATRASO
            SET pagado = {1} 
            WHERE id_material = '{atr.Id}';";

            SqlCommand queryUpdate = new SqlCommand(cad, connection.connectDb);
            queryUpdate.ExecuteNonQuery();

            connection.Close();
        }

        public Atraso ObtenerAtraso(Prestamo prs)
        {
            Atraso atraso = new Atraso();
            ConnectionDB connection = new ConnectionDB();
            SqlDataReader registros = null;
            connection.Open();

            SqlCommand querySel = new SqlCommand($@"SELECT ATR.id_atraso, ATR.id_prestamo, ATR.multa, ATR.pagado FROM ATRASO AS ATR WHERE id_prestamo = '{prs.Id}';", connection.connectDb);

            registros = querySel.ExecuteReader();

            while (registros.Read())
            {
                var registro = new Atraso()
                {
                    Id = registros["id_atraso"].ToString(),
                    IdPrestamo = registros["id_prestamo"].ToString(),
                    Multa = (decimal)registros["multa"],
                    Pagado = (bool)registros["estado"] 
                };
                atraso = registro;
                
            }

            connection.Close();
            return atraso;
        }
        public List<Atraso> ObtenerAllAtrasos()
        {
            List<Atraso> ListaAtraso = new List<Atraso>();
            ConnectionDB connection = new ConnectionDB();
            SqlDataReader registros = null;
            connection.Open();

            SqlCommand querySel = new SqlCommand($@"SELECT ATR.id_atraso, ATR.id_prestamo, ATR.multa, ATR.pagado FROM ATRASO AS ATR;", connection.connectDb);

            registros = querySel.ExecuteReader();

            while (registros.Read())
            {
                var registro = new Atraso()
                {
                    Id = registros["id_atraso"].ToString(),
                    IdPrestamo = registros["id_prestamo"].ToString(),
                    Multa = (decimal)registros["multa"],
                    Pagado = (bool)registros["estado"]
                };
                ListaAtraso.Add(registro);
            }

            connection.Close();
            return ListaAtraso;
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
            string cadena = "SELECT id_atraso from ATRASO";
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
