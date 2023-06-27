using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfBiblioteca.Classes;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Ventanas
{
    public partial class AgregarPrestamo : Form
    {
        ConnectionDB connection = new ConnectionDB();
        public AgregarPrestamo()
        {
            InitializeComponent();
            DatosCbo();
        }
        private void DatosCbo()
        {
            this.cboTipoUsuario.Items.Add("Funcionario");
            this.cboTipoUsuario.Items.Add("Profesor");
            this.cboTipoUsuario.Items.Add("Alumno");
            this.cboTipoUsuario.Items.Add("Alumno Externo");
        }
    }
}
