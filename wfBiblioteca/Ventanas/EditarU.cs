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
        string rut,id, nombre, apellido, correo;
        string sede, nucleo, dep, estadoV;

        ConnectionDB connection = new ConnectionDB();
        public EditarU()
        {
            InitializeComponent();
            DatosCbo();
        }
        private void ObtenerDatos()
        {
            this.rut = this.lblRut.Text;
            this.nombre = this.lblNombre.Text;
            this.apellido = this.lblApellido.Text;
            this.correo = this.txtCorreo.Text;
            this.sede = this.txtSede.Text;
            this.nucleo = this.cboNucleo.SelectedItem.ToString();
            this.estadoV = this.txtVerificacion.Text;
            this.dep = this.cboDep.SelectedItem.ToString();
        }
        private void Limpiar()
        {

            this.lblRut.Text = string.Empty;
            this.lblNombre.Text = string.Empty;
            this.lblApellido.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
            this.txtSede.Text = string.Empty;
            this.txtContraSeguridad.Text = string.Empty;
            this.txtVerificacion.Text = string.Empty;
            cboDep.SelectedIndex = 0;
            this.cboNucleo.SelectedIndex = 0;
 
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


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
            //Falta Validador
            if (cboTipoU.SelectedItem.ToString() == "Funcionario")
            {

                
            }
            else if (cboTipoU.SelectedItem.ToString() == "Alumno")
            {
                
            }
            else if (cboTipoU.SelectedItem.ToString() == "Alumno Externo")
            {
                
            }
            else
            {
                

            }

        }
        private void DatosComun()
        {
            
            this.lblRut1.Visible = true;
            this.lblNom1.Visible = true;
            this.lblNombre.Visible = true;
            this.lblApellido1.Visible = true;
            this.lblCorreo.Visible = true;
            this.lblRut.Visible = true;
            this.lblApellido.Visible = true;
            this.txtCorreo.Visible = true;
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
        private void lsvUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            this.id = lsvUsuarios.SelectedItems[0].SubItems[0].Text;
            string cadena;
            ListViewItem item = new ListViewItem();
            if (cboTipoU.SelectedItem.ToString() == "Funcionario")
            {
                Limpiar();
                cadena = "Select u.id_usuario,u.nombre_usuario,u.apellido_usuario,u.correo_usuario,f.id_funcionario from USUARIO as U inner join FUNCIONARIO as f on u.id_usuario =f.id_usuario WHERE u.id_usuario='"+id+"'";
                connection.Open();

                try
                {
                    SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        this.lblRut.Text = lector.GetValue(0).ToString();
                        this.lblNombre.Text = lector.GetValue(1).ToString();
                        this.lblApellido.Text = lector.GetValue(2).ToString();
                        this.txtCorreo.Text = lector.GetValue(3).ToString();
                        this.cboDep.Text = Obtenernombre(ObtenerId(lector.GetValue(4).ToString()));

                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Mensaje Error" + ex.Message);
                }
               

            }
            else if (cboTipoU.SelectedItem.ToString() == "Alumno")
            {
                Limpiar();
                cadena = "Select u.id_usuario,u.nombre_usuario,u.apellido_usuario,u.correo_usuario,a.sede from USUARIO as U inner join ALUMNO as a on u.id_usuario =a.id_usuario WHERE u.id_usuario='" + id + "'";
                connection.Open();

                try
                {
                    SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        this.lblRut.Text = lector.GetValue(0).ToString();
                        this.lblNombre.Text = lector.GetValue(1).ToString();
                        this.lblApellido.Text = lector.GetValue(2).ToString();
                        this.txtSede.Text = lector.GetValue(4).ToString();
                        this.txtCorreo.Text = lector.GetValue(3).ToString();


                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Mensaje Error" + ex.Message);
                }
           
            }
            else if (cboTipoU.SelectedItem.ToString() == "Alumno Externo")
            {
                Limpiar();
                cadena = "Select u.id_usuario,u.nombre_usuario,u.apellido_usuario,u.correo_usuario,e.certificado_externo from USUARIO as U inner join EXTERNO as e on u.id_usuario =e.id_usuario WHERE u.id_usuario='" + id + "'";
                connection.Open();

                try
                {
                    SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        this.lblRut.Text = lector.GetValue(0).ToString();
                        this.lblNombre.Text = lector.GetValue(1).ToString();
                        this.lblApellido.Text = lector.GetValue(2).ToString();
                        this.txtCorreo.Text = lector.GetValue(3).ToString();
                        this.txtVerificacion.Text= lector.GetValue(4).ToString();


                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Mensaje Error" + ex.Message);
                }
              


            }
            else
            {
                Limpiar();
                cadena = "Select u.id_usuario,u.nombre_usuario,u.apellido_usuario,u.correo_usuario,p.id_nucleo from USUARIO as U inner join PROFESOR as p on u.id_usuario =p.id_usuario WHERE u.id_usuario='" + id + "'";
                connection.Open();

                try
                {
                    SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        this.lblRut.Text = lector.GetValue(0).ToString();
                        this.lblNombre.Text = lector.GetValue(1).ToString();
                        this.lblApellido.Text = lector.GetValue(2).ToString();
                        this.txtCorreo.Text = lector.GetValue(3).ToString();
                        this.cboNucleo.Text = ObtenerId(lector.GetValue(4).ToString());

                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Mensaje Error" + ex.Message);
                }
            

            }
            

        }

        private void cboTipoU_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.lsvUsuarios.Items.Clear();
            string cadena;
            ListViewItem item = new ListViewItem();
            if (cboTipoU.SelectedItem.ToString() == "Funcionario")
            {
                Limpiar();
                DatosComun();
                cadena = "Select u.id_usuario,u.nombre_usuario,u.apellido_usuario,u.correo_usuario,f.id_funcionario from USUARIO as U inner join FUNCIONARIO as f on u.id_usuario =f.id_usuario";
                connection.Open();

                try
                {
                    SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        item = lsvUsuarios.Items.Add(lector.GetValue(0).ToString());
                        item.SubItems.Add(lector.GetValue(1).ToString());
                        item.SubItems.Add(lector.GetValue(2).ToString());

                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Mensaje Error" + ex.Message);
                }
                connection.Close();

                //mostrar cosas 
                this.lblDepartamento.Visible = true;
                this.cboDep.Visible = true;

                //cosas que se ocultan
                this.lblNucleo.Visible = false;
                this.cboNucleo.Visible = false;
                this.lblSede.Visible = false;
                this.txtSede.Visible = false;
                this.lblVerificacion.Visible = false;
                this.txtVerificacion.Visible = false;

            }
            else if (cboTipoU.SelectedItem.ToString() == "Alumno")
            {
                Limpiar();
                DatosComun();
                cadena = "Select u.id_usuario,u.nombre_usuario,u.apellido_usuario,u.correo_usuario,a.sede from USUARIO as U inner join ALUMNO as a on u.id_usuario =a.id_usuario";
                connection.Open();

                try
                {
                    SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        item = lsvUsuarios.Items.Add(lector.GetValue(0).ToString());
                        item.SubItems.Add(lector.GetValue(1).ToString());
                        item.SubItems.Add(lector.GetValue(2).ToString());

                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Mensaje Error" + ex.Message);
                }
                connection.Close();
                //mostrar cosas 
                this.lblSede.Visible = true;
                this.txtSede.Visible = true;

     

                //cosas que se ocultan
                this.lblNucleo.Visible = false;
                this.cboNucleo.Visible = false;
                this.lblDepartamento.Visible = false;
                this.cboDep.Visible = false;
                this.lblVerificacion.Visible = false;
                this.txtVerificacion.Visible = false;


            }
            else if (cboTipoU.SelectedItem.ToString() == "Alumno Externo")
            {
                Limpiar();
                DatosComun();
                cadena = "Select u.id_usuario,u.nombre_usuario,u.apellido_usuario,u.correo_usuario,e.certificado_externo from USUARIO as U inner join EXTERNO as e on u.id_usuario =e.id_usuario";
                connection.Open();

                try
                {
                    SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        item = lsvUsuarios.Items.Add(lector.GetValue(0).ToString());
                        item.SubItems.Add(lector.GetValue(1).ToString());
                        item.SubItems.Add(lector.GetValue(2).ToString());
                     

                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Mensaje Error" + ex.Message);
                }
                connection.Close();
                //mostrar cosas 
                this.txtVerificacion.Visible = true;
                this.lblVerificacion.Visible = true;
                
         

                //cosas que se ocultan
                this.lblNucleo.Visible = false;
                this.cboNucleo.Visible = false;
                this.lblDepartamento.Visible = false;
                this.cboDep.Visible = false;
                this.lblSede.Visible = false;
                this.txtSede.Visible = false;

            }
            else
            {
                Limpiar();
                DatosComun();
                cadena = "Select u.id_usuario,u.nombre_usuario,u.apellido_usuario,u.correo_usuario,p.id_nucleo from USUARIO as U inner join PROFESOR as p on u.id_usuario =p.id_usuario";
                connection.Open();

                try
                {
                    SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        item = lsvUsuarios.Items.Add(lector.GetValue(0).ToString());
                        item.SubItems.Add(lector.GetValue(1).ToString());
                        item.SubItems.Add(lector.GetValue(2).ToString());

                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Mensaje Error" + ex.Message);
                }
                connection.Close();
                //mostrar cosas 
                this.lblNucleo.Visible = true;
                this.cboNucleo.Visible = true;
 

                //cosas que se ocultan
                this.lblDepartamento.Visible = false;
                this.cboDep.Visible = false;
                this.lblSede.Visible = false;
                this.txtSede.Visible = false;
                this.lblVerificacion.Visible = false;
                this.txtVerificacion.Visible = false;
            }
         


        }

        private string BuscarIDN(string nombre)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cadena = "SELECT * from NUCLEO";
            SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                if (nombre == lector.GetValue(0).ToString())
                {
                    nombre = lector.GetValue(1).ToString();
                    connection.Close();
                    return nombre;
                }
            }
            connection.Close();
            return nombre;
        }
        private string ObtenerId(string nombre)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cadena = "SELECT * from RELACION_FUNCIONARIO_DEPARTAMENTO";
            SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
            SqlDataReader lector = comando.ExecuteReader();
            
            
            while (lector.Read())
            {
                if (nombre == lector.GetValue(1).ToString())
                {
                    nombre = lector.GetValue(0).ToString();
                    connection.Close();
                    return nombre;
                }
            }
            connection.Close();
            return nombre;
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
                if (nombre == lector1.GetValue(0).ToString())
                {
                    nombre = lector1.GetValue(2).ToString();
                    return nombre;
                }
            }
            connection.Close();
            return nombre;
        }


    }
}
