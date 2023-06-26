using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfBiblioteca.ConnectionBD;

namespace wfBiblioteca.Classes
{
    class Funcionario:Usuario
    {
        public string id_funcionario { get; set; }
        public string contraseña_c { get; set; }
        public string departamento { get; set; }
        public Funcionario(string id, string n, string a, string contra, string c,string contraC,string d) : base(id, n, a, contra, c)
        {
            this.contraseña_c = contraC;
            this.departamento = d;
        }

        public void AgregarFuncionario(Funcionario f)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();

            string cad = $@"BEGIN TRANSACTION;
            INSERT INTO USUARIO(id_usuario,nombre_usuario,apellido_usuario,contraseña,correo_usuario)
            VALUES('{f.Id}', '{f.Nombre}', {f.Apellido}, '{f.Contraseña}', {f.Correo})

            INSERTE INTO ALUMNO(id_usuario,sede)
            VALUES('{a.Id}','{a.Sede}')
             COMMIT;";

            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);

            connection.Close();
        }
        private void BuscarDepartamento(string d )
        {

        }

    }
}
