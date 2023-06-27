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
    public partial class AgregarDatos : Form
    {
        public AgregarDatos()
        {
            InitializeComponent();
        }

        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            if (!txtNombreAutor.Text.Equals("")){
                Autor aut = new Autor(txtNombreAutor.Text);
                aut.InsertarAutor(aut);
                MessageBox.Show("Autor Agregado Correctamente");
                txtNombreAutor.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor ingrese un Autor.");
            }
            
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            if (!txtNombreMateria.Text.Equals(""))
            {
                Materia mtr = new Materia(txtNombreMateria.Text);
                mtr.InsertarMateria(mtr);
                MessageBox.Show("Materia Agregada Correctamente");
                txtNombreMateria.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor ingrese una Materia.");
            }
            
        }

        private void btnAgregarEditorial_Click(object sender, EventArgs e)
        {
            if (!txtNombreMateria.Text.Equals(""))
            {
                Editorial edt = new Editorial(txtNombreEditorial.Text);
                edt.InsertarEditorial(edt);
                MessageBox.Show("Editorial Agregada Correctamente");
                txtNombreEditorial.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor ingrese una Editorial.");
            }

        }
    }
}
