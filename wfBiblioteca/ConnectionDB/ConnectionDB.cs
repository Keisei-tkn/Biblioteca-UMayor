using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace prueba.Models
{
    public class ConnectionDB
    {
        string Cad = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=bibliotecaumayor; Integrated Security=True";

        public SqlConnection connectDb = new SqlConnection();

        public ConnectionDB()
        {
            connectDb.ConnectionString = Cad;
        }

        public void Open()
        {
            try
            {
                connectDb.Open();
                Console.WriteLine("DB working");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening db: " + ex.Message);
            }
        }

        public void Close()
        {
            connectDb.Close();
        }
    }
}