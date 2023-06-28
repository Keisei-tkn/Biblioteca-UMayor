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
    public partial class AgregarDatos : Form
    {
        string idFun;
        ConnectionDB connection = new ConnectionDB();
        public AgregarDatos(string id)
        {
            idFun = id;
            InitializeComponent();
        }
        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            if (!txtNombreAutor.Text.Equals(""))
            {
                this.btnAgregarAutor2.Visible = true;
                this.btnAgregarAutor.Visible = true;
                this.txtContraA.Visible = true;
                this.lblContraA1.Visible = true;
                MessageBox.Show("Para Aplicar Los Cambios Ingrese Su clave de seguridad");

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
                this.btnAgregarMateria.Visible = true;
                this.btnAgregarMateria2.Visible = true;
                this.txtContraM.Visible = true;
                this.lblContraM1.Visible = true;
                MessageBox.Show("Para Aplicar Los Cambios Ingrese Su clave de seguridad");

            }
            else
            {
                MessageBox.Show("Por favor ingrese una Materia.");
            }

        }

        private void btnAgregarEditorial_Click(object sender, EventArgs e)
        {
            if (!txtNombreEditorial.Text.Equals(""))
            {
                this.btnAgregarAutor2.Visible = true;
                this.btnAgregarAutor.Visible = true;
                this.txtContraA.Visible = true;
                this.lblContraE11.Visible = true;
                MessageBox.Show("Para Aplicar Los Cambios Ingrese Su clave de seguridad");

            }
            else
            {
                MessageBox.Show("Por favor ingrese una Editorial.");
            }

        }

        private void btnAgregarAutor2_Click(object sender, EventArgs e)
        {
            string claveBD = buscarClave(idFun);
            if (this.txtContraA.Text == claveBD)
            {
                Autor aut = new Autor(txtNombreAutor.Text);
                aut.InsertarAutor(aut);
                MessageBox.Show("Autor Agregado Correctamente");
                txtNombreAutor.Text = string.Empty;
                this.lblContraA1.Visible = true;
                this.btnAgregarAutor2.Visible = true;
                this.btnAgregarAutor.Visible = true;
                txtContraA.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Contraseña No coincide con la base de datos ");
                this.txtContraA.Text = string.Empty;
            }
            
        }

        private void btnAgregarMateria2_Click(object sender, EventArgs e)
        {
            string claveBD = buscarClave(idFun);
            if (this.txtContraM.Text == claveBD)
            {
                Materia mtr = new Materia(txtNombreMateria.Text);
                mtr.InsertarMateria(mtr);
                MessageBox.Show("Materia Agregada Correctamente");
                txtNombreMateria.Text = string.Empty;
                txtContraM.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Contraseña No coincide con la base de datos ");
                txtContraM.Text = string.Empty;
            }
            
        }

        private void btnAgregarEditorial2_Click(object sender, EventArgs e)
        {

            string claveBD = buscarClave(idFun);
            if (this.txtContraE.Text == claveBD)
            {
                Editorial edt = new Editorial(txtNombreEditorial.Text);
                edt.InsertarEditorial(edt);
                MessageBox.Show("Editorial Agregada Correctamente");
                txtNombreEditorial.Text = string.Empty;
                txtContraE.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Contraseña No coincide con la base de datos ");
                txtContraE.Text = string.Empty;
            }
            
        }

        private String buscarClave(String clave)
        {
            string cadena;
            cadena = "Select u.id_usuario,u.nombre_usuario,f.contraseña_c from USUARIO as U inner join FUNCIONARIO as f on u.id_usuario =f.id_usuario WHERE u.id_usuario='" + clave + "'";
            SqlDataReader registros = null;
            connection.Open();
            SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
            registros = comando.ExecuteReader();
            string idBuscado;
            while (registros.Read())
            {
                idBuscado = registros.GetString(0).ToString();
                if (clave == idBuscado)
                {
                    clave = registros.GetString(2).ToString();
                    connection.Close();
                    return clave;

                }

            }
            connection.Close();
            return clave;
        }

        private void txtContraA_Enter(object sender, EventArgs e)
        {
            this.txtContraA.UseSystemPasswordChar = true;
        }

        private void txtContraM_Enter(object sender, EventArgs e)
        {
            this.txtContraM.UseSystemPasswordChar = true;
        }

        private void txtContraE_Enter(object sender, EventArgs e)
        {
            this.txtContraE.UseSystemPasswordChar = true;
        }
    }
}
