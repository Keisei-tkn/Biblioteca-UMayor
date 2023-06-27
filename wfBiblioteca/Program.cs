using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using wfBiblioteca.SQL;
using wfBiblioteca.Ventanas;

namespace wfBiblioteca
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string usuario, password, tipo;
            string nom, apellido, correo;
            usuario = string.Empty;
            password = string.Empty;
            nom = string.Empty;
            apellido = string.Empty;
            correo = string.Empty;
            tipo = string.Empty;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(usuario, nom, apellido, password, correo,tipo));
        }
    }
}
