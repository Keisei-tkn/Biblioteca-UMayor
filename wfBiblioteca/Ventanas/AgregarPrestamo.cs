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
        string idFun, idBd;
        ConnectionDB connection = new ConnectionDB();
        MaterialDB m1 = new MaterialDB();
        Prestamo p1;
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

        private void lsvUsuarios_Click(object sender, EventArgs e)
        {
            this.idBd = lsvUsuarios.SelectedItems[0].SubItems[0].Text;
            string cadena;
            ListViewItem item = new ListViewItem();
            if (cboTipoUsuario.SelectedItem.ToString() == "Funcionario")
            {
             
                cadena = "Select u.id_usuario,u.nombre_usuario,u.apellido_usuario,u.correo_usuario,f.id_funcionario from USUARIO as U inner join FUNCIONARIO as f on u.id_usuario =f.id_usuario WHERE u.id_usuario='" + idBd + "'";
                connection.Open();

                try
                {
                    SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        this.lblUsuario.Text = lector.GetValue(1).ToString() + " " + lector.GetValue(2).ToString();

                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Mensaje Error" + ex.Message);
                }


            }
            else if (cboTipoUsuario.SelectedItem.ToString() == "Alumno")
            {

                cadena = "Select u.id_usuario,u.nombre_usuario,u.apellido_usuario,u.correo_usuario,a.sede from USUARIO as U inner join ALUMNO as a on u.id_usuario =a.id_usuario WHERE u.id_usuario='" + idBd + "'";
                connection.Open();

                try
                {
                    SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        this.lblUsuario.Text = lector.GetValue(1).ToString() + " " + lector.GetValue(2).ToString();


                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Mensaje Error" + ex.Message);
                }

            }
            else if (cboTipoUsuario.SelectedItem.ToString() == "Alumno Externo")
            {
                cadena = "Select u.id_usuario,u.nombre_usuario,u.apellido_usuario,u.correo_usuario,e.certificado_externo from USUARIO as U inner join EXTERNO as e on u.id_usuario =e.id_usuario WHERE u.id_usuario='" + idBd + "'";
                connection.Open();

                try
                {
                    SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        this.lblUsuario.Text = lector.GetValue(1).ToString() + " " + lector.GetValue(2).ToString();

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
       
                cadena = "Select u.id_usuario,u.nombre_usuario,u.apellido_usuario,u.correo_usuario,p.id_nucleo from USUARIO as U inner join PROFESOR as p on u.id_usuario =p.id_usuario WHERE u.id_usuario='" + idBd + "'";
                connection.Open();

                try
                {
                    SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        this.lblUsuario.Text = lector.GetValue(1).ToString()+" "+ lector.GetValue(2).ToString();

                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Mensaje Error" + ex.Message);
                }


            }
        }

        private void btnPrestamo1_Click(object sender, EventArgs e)
        {
            string claveBD = buscarClave(idFun);
            if (this.txtContraSeguridad.Text == claveBD)
            {
                if (cboTipoMaterial.SelectedItem.ToString() == "Libro")
                {
                    foreach (var a in m1.ObtenerLibro())
                    {
                        if (this.LblMaterial.Text == a.Nombre)
                        {
                            p1 = new Prestamo(a);
                            InsertarPrestamo(idBd, p1);
                            MessageBox.Show("Prestamo Registrado Exitosamente");
                        }
                    }

                }
                else if (cboTipoMaterial.SelectedItem.ToString() == "Revista")
                {

                    foreach (var a in m1.ObtenerRevista())
                    {
                        if (this.LblMaterial.Text == a.Nombre)
                        {
                            p1 = new Prestamo(a);
                            InsertarPrestamo(idBd, p1);
                            MessageBox.Show("Prestamo Registrado Exitosamente");
                        }
                    }
                }
                else if (cboTipoMaterial.SelectedItem.ToString() == "Audiovisual")
                {

                    foreach (var a in m1.ObtenerAudiovisual())
                    {
                        if (this.LblMaterial.Text == a.Nombre)
                        {
                            p1 = new Prestamo(a);
                            InsertarPrestamo(idBd, p1);
                            MessageBox.Show("Prestamo Registrado Exitosamente");
                        }
                    }
                }
                else
                {

                    foreach (var a in m1.ObtenerOtro())
                    {
                        if (this.LblMaterial.Text == a.Nombre)
                        {
                            p1 = new Prestamo(a);
                            InsertarPrestamo(idBd, p1);
                            MessageBox.Show("Prestamo Registrado Exitosamente");
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Contraseña No coincide con la base de datos ");
                this.txtContraSeguridad.Text = string.Empty;
            }
            this.btnPrestamo.Visible = true;
            this.btnPrestamo1.Visible = false;
            this.txtContraSeguridad.Visible = false;
            this.lblConfirmacion.Visible = false;

        }


        private void InsertarPrestamo(string ident ,Prestamo p )
        {
            Prestamo p2 = new Prestamo(p);
            connection.Open();
            string cad = $@"BEGIN TRANSACTION;
            INSERT INTO HISTORIAL(id_prestamo,id_usuario)
            VALUES('{p2.Id}', '{ident}')
             COMMIT;";
            SqlCommand queryInsert = new SqlCommand(cad, connection.connectDb);
            queryInsert.ExecuteNonQuery();

            connection.Close();
        }
        private ListViewItem MyListView_MouseClick(object sender, MouseEventArgs e)
        {
            ListView listView = (ListView)sender;
            ListViewItem clickedItem = listView.GetItemAt(e.X, e.Y);
            return clickedItem;
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            string nombreU = this.lblUsuario.Text;
            string material = this.lblM.Text;
            if (nombreU == "" || material== "")
            {
               
                MessageBox.Show("Seleccione Un Usuario o Material");
            }
            else
            {
                this.lblConfirmacion.Visible = true;
                this.txtContraSeguridad.Visible = true;
                this.btnPrestamo.Visible = false;
                this.btnPrestamo1.Visible = true;
                MessageBox.Show("Para Aplicar Cambios Coloque Su Clave ");
            }
        }
        private string buscarClave(string clave)
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
        private void txtContraSeguridad_Enter(object sender, EventArgs e)
        {
            this.txtContraSeguridad.UseSystemPasswordChar = true;
        }

        private void lsvMaterial_Click(object sender, EventArgs e)
        {
            if (cboTipoMaterial.SelectedItem.ToString() == "Libro")
            {
                foreach (var a in m1.ObtenerLibro())
                {
                    this.lblM.Text = a.Nombre;
                }

            }
            else if (cboTipoMaterial.SelectedItem.ToString() == "Revista")
            {

                foreach (var a in m1.ObtenerRevista())
                {
                    this.lblM.Text = a.Nombre;
                }
            }
            else if (cboTipoMaterial.SelectedItem.ToString() == "Audiovisual")
            {
                foreach (var a in m1.ObtenerAudiovisual())
                {
                    this.lblM.Text = a.Nombre;
                }
            }
            else
            {
                foreach (var a in m1.ObtenerOtro())
                {
                    this.lblM.Text = a.Nombre;
                }
            }
        }



    }
    
}
