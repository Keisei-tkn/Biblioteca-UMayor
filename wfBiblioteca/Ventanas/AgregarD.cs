using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfBiblioteca.Classes;

namespace wfBiblioteca.Ventanas
{
    public partial class AgregarD : Form
    {
        string NomN, NomD, presupuesto;
        public AgregarD()
        {
            InitializeComponent();
          
        }

        private void btnAgregarN_Click(object sender, EventArgs e)
        {
            this.NomN = this.txtNombreN.Text;
            if (NomN==string.Empty)
            {
                MessageBox.Show("Ingrese Nombre Nucleo");
            }
            else
            {
                this.lblNucleoS.Visible = true;
                this.txtContraNucleo.Visible = true;
                this.btnAgregarN2.Visible = true;

            }
        }

        private void btnAgregarN2_Click(object sender, EventArgs e)
        {
            this.NomN = this.txtNombreN.Text;
            Nucleo n1 = new Nucleo(NomN);
            n1.AgregarNucleo(n1);
            Limpiar();
        }

        private void btnAgregarDep2_Click(object sender, EventArgs e)
        {
            NomD = this.txtNombreD.Text;
            presupuesto = this.txtPresupuesto.Text;
            Departamento d1 = new Departamento(NomD, presupuesto);
            d1.AgregarDepartamento(d1);
            Limpiar();
        }

        private void btnAgregarDep_Click(object sender, EventArgs e)
        {
            NomD = this.txtNombreD.Text;
            presupuesto = this.txtPresupuesto.Text;
            if (NomD == string.Empty| presupuesto==string.Empty)
            {
                MessageBox.Show("Ingrese Nombre Departamento o Presupuesto");
            }
            else
            {
                this.lblDepS.Visible = true;
                this.txtContraDep.Visible = true;
                this.btnAgregarDep2.Visible = true;
            }
        }

        private void Limpiar()
        {
            this.txtNombreN.Text = string.Empty;
            this.txtNombreD.Text = string.Empty;
            this.txtPresupuesto.Text = string.Empty;

        }


    }
}
