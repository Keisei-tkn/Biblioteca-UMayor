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
    public partial class EditarU : Form
    {
        string rut, nombre, apellido, correo, contra;
        string sede, nucleo, pinS, dep, estadoV;
        ConnectionDB connection = new ConnectionDB();


        private void ObtenerDatos()
        {

            this.nombre = this.txtNombre.Text;
            this.apellido = this.txtApellido.Text;
            this.correo = this.txtCorreo.Text;
            this.contra = this.txtContraseña.Text;
            this.sede = this.txtSede.Text;
            this.nucleo = this.cboNucleo.SelectedItem.ToString();
            this.pinS = this.txtContraSeguridad.Text;
            this.estadoV = this.txtVerificacion.Text;
            this.dep = this.cboDep.SelectedItem.ToString();
        }
        private void Limpiar()
        {

            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
            this.txtContraseña.Text = string.Empty;
            this.txtSede.Text = string.Empty;
            this.txtContraSeguridad.Text = string.Empty;
            this.txtVerificacion.Text = string.Empty;
            cboDep.SelectedIndex = 0;
            this.cboNucleo.SelectedIndex = 0;
 
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            ObtenerDatos();
            if (rut == string.Empty && nombre == string.Empty && apellido == string.Empty && correo == string.Empty)
            {
                MessageBox.Show("Verifique que todos los campos esten rellenados", "Error");
            }
            else
            {
                MessageBox.Show("Para Aplicar los Cambio Coloque su Contraseña", "Aplicar Cambios");
                this.btnRegistrar.Visible = false;
                this.btnRegistrar2.Visible = true;
                this.lblConfirmacion.Visible = true;
                this.txtContraSeguridad.Visible = true;

            }
        }
        private void btnRegistrar2_Click(object sender, EventArgs e)
        {
            //Falta Validador
            if (cboTipoU.SelectedItem.ToString() == "Funcionario")
            {
                Funcionario f1 = new Funcionario(rut, nombre, apellido, contra, correo, pinS, dep);
                f1.AgregarFuncionario(f1);

            }
            else if (cboTipoU.SelectedItem.ToString() == "Alumno")
            {
                AlumnoUM a1 = new AlumnoUM(rut, nombre, apellido, contra, correo, sede);
                a1.AgregarAlumno(a1);
                MessageBox.Show("USUARIO REGISTRADO EXITOSAMENTE", "EXITO");
                Limpiar();

            }
            else if (cboTipoU.SelectedItem.ToString() == "Alumno Externo")
            {
                Externos e1 = new Externos(rut, nombre, apellido, contra, correo, estadoV);
                e1.AgregarExterno(e1);
            }
            else
            {
                Profesores p1 = new Profesores(rut, nombre, apellido, contra, correo, nucleo);
                p1.AgregarProfesor(p1);

            }

        }
        private void DatosComun()
        {
            this.lblRut.Visible = true;

            this.lblRut1.Visible = true;
            this.lblNombre.Visible = true;
            this.txtNombre.Visible = true;
            this.lblApellido.Visible = true;
            this.txtApellido.Visible = true;
            this.lblCorreo.Visible = true;
            this.txtCorreo.Visible = true;
            this.lblContra.Visible = true;
            this.txtContraseña.Visible = true;

        }
        private void DatosCbo()
        {
            this.cboTipoU.Items.Add("Funcionario");
            this.cboTipoU.Items.Add("Profesor");
            this.cboTipoU.Items.Add("Alumno");
            this.cboTipoU.Items.Add("Alumno Externo");

            string cadena = "select nombre from DEPARTAMENTO";
            connection.Open();
            try
            {
                SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    this.cboDep.Items.Add(lector.GetValue(0).ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Mensaje Error" + ex.Message);
            }

            string cadena2 = "select nombre from NUCLEO";
            connection.Open();
            try
            {
                SqlCommand comando2 = new SqlCommand(cadena2, connection.connectDb);
                SqlDataReader lector = comando2.ExecuteReader();
                while (lector.Read())
                {
                    this.cboNucleo.Items.Add(lector.GetValue(0).ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Mensaje Error" + ex.Message);
            }
        }

        private void cboTipoU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoU.SelectedItem.ToString() == "Funcionario")
            {
                DatosComun();
                this.lblDepartamento.Visible = true;
                this.cboDep.Visible = true;
                this.lbl2daClav.Visible = true;
                this.txt2daClave.Visible = true;

                //datos no comun
                this.lblNucleo.Visible = false;
                this.cboNucleo.Visible = false;
                this.lblSede.Visible = false;
                this.txtSede.Visible = false;
                this.lblVerificacion.Visible = false;
                this.txtVerificacion.Visible = false;
            }
            else if (cboTipoU.SelectedItem.ToString() == "Alumno")
            {

                DatosComun();
                this.lblSede.Visible = true;
                this.txtSede.Visible = true;

                //datos no comun
                this.lblNucleo.Visible = false;
                this.cboNucleo.Visible = false;
                this.lblDepartamento.Visible = false;
                this.cboDep.Visible = false;
                this.lbl2daClav.Visible = false;
                this.txt2daClave.Visible = false;
                this.lblVerificacion.Visible = false;
                this.txtVerificacion.Visible = false;

            }
            else if (cboTipoU.SelectedItem.ToString() == "Alumno Externo")
            {

                DatosComun();
                this.lblVerificacion.Visible = true;
                this.txtVerificacion.Visible = true;

                //datos no comun
                this.lblNucleo.Visible = false;
                this.cboNucleo.Visible = false;
                this.lblDepartamento.Visible = false;
                this.cboDep.Visible = false;
                this.lbl2daClav.Visible = false;
                this.txt2daClave.Visible = false;
                this.lblSede.Visible = false;
                this.txtSede.Visible = false;
            }
            else
            {
                DatosComun();
                this.lblNucleo.Visible = true;
                this.cboNucleo.Visible = true;

                //datos no comun
                this.lblDepartamento.Visible = false;
                this.cboDep.Visible = false;
                this.lbl2daClav.Visible = false;
                this.txt2daClave.Visible = false;
                this.lblSede.Visible = false;
                this.txtSede.Visible = false;
                this.lblVerificacion.Visible = false;
                this.txtVerificacion.Visible = false;

            }

        }
        public EditarU()
        {
            InitializeComponent();
        }
    }
}
