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
        string idFun;
        ConnectionDB connection = new ConnectionDB();
        MaterialDB m1 = new MaterialDB();
        public AgregarPrestamo(string id)
        {
            this.idFun = id;
            InitializeComponent();
            DatosCbo();
        }
        private void DatosCbo()
        {
            this.cboTipoUsuario.Items.Add("Funcionario");
            this.cboTipoUsuario.Items.Add("Profesor");
            this.cboTipoUsuario.Items.Add("Alumno");
            this.cboTipoUsuario.Items.Add("Alumno Externo");


            this.cboTipoMaterial.Items.Add("Audiovisual");
            this.cboTipoMaterial.Items.Add("Libro");
            this.cboTipoMaterial.Items.Add("Revista");
            this.cboTipoMaterial.Items.Add("Otro");
         
        }
        private void cboTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lsvUsuarios.Items.Clear();
            string cadena;
            ListViewItem item = new ListViewItem();
            if (cboTipoUsuario.SelectedItem.ToString() == "Funcionario")
            {
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
            }
            else if (cboTipoUsuario.SelectedItem.ToString() == "Alumno")
            {

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



            }
            else if (cboTipoUsuario.SelectedItem.ToString() == "Alumno Externo")
            {
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
            }
            else
            {
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
            }
        }
        private void cboTipoMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lsvMaterial.Items.Clear();
            ListViewItem item = new ListViewItem();
            if (cboTipoMaterial.SelectedItem.ToString() == "Libro")
            {
                foreach(var a in m1.ObtenerLibro())
                {
                    item = lsvMaterial.Items.Add(a.Id);
                    item.SubItems.Add(a.Nombre);
                }

            }
            else if (cboTipoMaterial.SelectedItem.ToString() == "Revista")
            {
                
                foreach (var a in m1.ObtenerRevista())
                {
                    item = lsvMaterial.Items.Add(a.Id);
                    item.SubItems.Add(a.Nombre);
                }
            }
            else if (cboTipoMaterial.SelectedItem.ToString() == "Audiovisual")
            {
                
                foreach (var a in m1.ObtenerAudiovisual())
                {
                    item = lsvMaterial.Items.Add(a.Id);
                    item.SubItems.Add(a.Nombre);
                }
            }
            else
            {
                
                foreach (var a in m1.ObtenerOtro())
                {
                    item = lsvMaterial.Items.Add(a.Id);
                    item.SubItems.Add(a.Nombre);
                }
            }
        }
    }
}
