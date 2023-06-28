using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace wfBiblioteca.SQL
{
    public class ConnectionDB
    {
        string Cad = "Data Source=COMPUSEBA\\SQLEXPRESS; Initial Catalog=BibliotecaMayor; Integrated Security=True";

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
                System.Diagnostics.Debug.WriteLine("DB Working");
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