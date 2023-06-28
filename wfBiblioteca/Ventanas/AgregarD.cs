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
    public partial class AgregarD : Form
    {
        ConnectionDB connection = new ConnectionDB();
        string NomN, NomD, presupuesto,idFun;
        public AgregarD(string rutID)
        {
            this.idFun = rutID;
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
            string claveBD = buscarClave(idFun);
            this.NomN = this.txtNombreN.Text;
            Nucleo n1 = new Nucleo(NomN);
            if (this.txtContraNucleo.Text == claveBD)
            {
                n1.AgregarNucleo(n1);
                Limpiar();
                MessageBox.Show("Departamento Agregado Exitosamente");
                this.btnAgregarN2.Visible = false;
                this.btnAgregarN.Visible = true;
                this.txtContraNucleo.Visible = false;
            }
            else
            {
                MessageBox.Show("Contraseña No coincide con la base de datos ");
            }
           
        }

        private void btnAgregarDep2_Click(object sender, EventArgs e)
        {
            string claveBD = buscarClave(idFun);
            NomD = this.txtNombreD.Text;
            presupuesto = this.txtPresupuesto.Text;
            Departamento d1 = new Departamento(NomD, presupuesto);
            if (this.txtContraDep.Text == claveBD)
            {
                d1.AgregarDepartamento(d1);
                MessageBox.Show("Departamento Agregado Exitosamente");
                Limpiar();
                this.btnAgregarN2.Visible = false;
                this.btnAgregarN.Visible = true;
                this.txtContraNucleo.Visible = false;
            }
            else
            {
                MessageBox.Show("Contraseña No coincide con la base de datos ");
            }
 
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
                    clave= registros.GetString(2).ToString();
                    connection.Close();
                    return clave;
             
                }
  
            }
            connection.Close();
            return clave;
        }



    }
}
