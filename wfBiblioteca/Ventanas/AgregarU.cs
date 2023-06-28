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
    public partial class AgregarU : Form
    {
        string rut, nombre, apellido, correo, contra;
        string sede, nucleo, pinS, dep, estadoV,tipo, idFun;
        ConnectionDB connection = new ConnectionDB();

        private void txtContraSeguridad_Enter(object sender, EventArgs e)
        {
            this.txtContraSeguridad.UseSystemPasswordChar = true;
        }

        public AgregarU(string id)
        {
            this.idFun = id;
            InitializeComponent();
            DatosCbo();
           


        }
        private void ObtenerDatos()
        {
            this.rut = this.txtRut.Text;
            this.nombre = this.txtNombre.Text;
            this.apellido = this.txtApellido.Text;
            this.correo = this.txtCorreo.Text;
            this.contra = this.txtContraseña.Text;
            this.sede = this.txtSede.Text;
            this.nucleo = this.cboNucleo.SelectedItem.ToString();
            this.pinS = this.txtContraSeguridad.Text;
            this.estadoV = this.txtVerificacion.Text;
            this.dep = Obtenernombre(this.cboDep.SelectedItem.ToString());
            this.tipo = cboTipoU.SelectedItem.ToString();
        }
        private void Limpiar()
        {
            this.txtRut.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
            this.txtContraseña.Text = string.Empty;
            this.txtSede.Text = string.Empty;
            this.txtContraSeguridad.Text = string.Empty;
            this.txtVerificacion.Text = string.Empty;
            cboDep.SelectedIndex = 0;
            this.cboNucleo.SelectedIndex = 0;
            this.txtRut.Focus();


            this.rut = string.Empty;
            this.nombre = string.Empty; 
            this.apellido = string.Empty;
            this.correo = string.Empty;
            this.contra = string.Empty;
            this.sede = string.Empty;
            this.nucleo = string.Empty;
            this.pinS = string.Empty;
            this.estadoV = string.Empty;
            this.dep = string.Empty;
            this.tipo = string.Empty;
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
            ObtenerDatos();
            string claveBD = buscarClave(idFun);
            if (this.txtContraSeguridad.Text == claveBD)
            {
                if (cboTipoU.SelectedItem.ToString() == "Funcionario")
                {
                    Funcionario f1 = new Funcionario(rut, nombre, apellido, contra, correo, tipo, pinS, dep);
                    f1.AgregarFuncionario(f1);
                    MessageBox.Show("USUARIO REGISTRADO EXITOSAMENTE", "EXITO");
                    Limpiar();
                    this.btnRegistrar2.Visible = false;
                    this.btnRegistrar.Visible = true;
                    this.txtContraSeguridad.Visible = false;
                    this.lbl2daClav.Visible = true;
               

                }
                else if (cboTipoU.SelectedItem.ToString() == "Alumno")
                {
                    AlumnoUM a1 = new AlumnoUM(rut, nombre, apellido, contra, correo, tipo, sede);
                    a1.AgregarAlumno(a1);
                    MessageBox.Show("USUARIO REGISTRADO EXITOSAMENTE", "EXITO");
                    Limpiar();
                    this.btnRegistrar2.Visible = false;
                    this.btnRegistrar.Visible = true;
                    this.txtContraSeguridad.Visible = false;
                    this.lbl2daClav.Visible = true;

                }
                else if (cboTipoU.SelectedItem.ToString() == "Alumno Externo")
                {
                    Externos e1 = new Externos(rut, nombre, apellido, contra, correo, tipo, estadoV);
                    e1.AgregarExterno(e1);
                    MessageBox.Show("USUARIO REGISTRADO EXITOSAMENTE", "EXITO");
                    Limpiar();
                    this.btnRegistrar2.Visible = false;
                    this.btnRegistrar.Visible = true;
                    this.txtContraSeguridad.Visible = false;
                    this.lbl2daClav.Visible = true;
                }
                else
                {
                    Profesores p1 = new Profesores(rut, nombre, apellido, contra, correo, tipo, nucleo);
                    p1.AgregarProfesor(p1);
                    MessageBox.Show("USUARIO REGISTRADO EXITOSAMENTE", "EXITO");
                    Limpiar();
                    this.btnRegistrar2.Visible = false;
                    this.btnRegistrar.Visible = true;
                    this.txtContraSeguridad.Visible = false;
                    this.lbl2daClav.Visible = true;

                }
            }
            else
            {
                MessageBox.Show("Contraseña No coincide con la base de datos ");
                this.txt2daClave.Text = string.Empty;
            }
         

        }
        private void DatosComun()
        {
            this.lblRut.Visible = true;
            this.txtRut.Visible = true;
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
            connection.Close();
            cboDep.SelectedIndex = 0;
            this.cboNucleo.SelectedIndex = 0;
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
        private string Obtenernombre(string nombre)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cadena1 = "SELECT * from DEPARTAMENTO";
            SqlCommand comando1 = new SqlCommand(cadena1, connection.connectDb);
            SqlDataReader lector1 = comando1.ExecuteReader();
            while (lector1.Read())
            {
                if (nombre == lector1.GetValue(2).ToString())
                {
                    nombre = lector1.GetValue(1).ToString();
                    return nombre;
                }
            }
            connection.Close();
            return nombre;
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
    }
}
