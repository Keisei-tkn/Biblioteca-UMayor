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
    
    public partial class AgregarM : Form
    {
        string titulo, autor, materia, ruta, RutaOb, categoria;
        string unidades, idioma, tipoPrestamo, editorial, idFun;
        string descripcion, numeropaginas, isbn, contraseña;
        int edicion, vol, duracion;
        DateTime f;

        public AgregarM(string id)
        {
            this.idFun = id;
            InitializeComponent();
            CargarCboTipo();
        }

        private void cboTipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboTipo.SelectedItem.ToString() == "Libro")
            {
                this.lblIsbn.Visible = true;
                this.lblNumeroPaginas.Visible = true;
                this.txtIsbn.Visible = true;
                this.txtPaginas.Visible = true;

                this.lblEdicion.Visible = false;
                this.lblVolumen.Visible = false;
                this.txtEdicion.Visible = false;
                this.txtVol.Visible = false;

                this.lblDuracion.Visible = false;
                this.txtDuracion.Visible = false;

                this.lblCategoria.Visible = false;
                this.txtCategoria.Visible = false;

            }
            else if (cboTipo.SelectedItem.ToString() == "Revista")
            {
                this.lblEdicion.Visible = true;
                this.lblVolumen.Visible = true;
                this.txtEdicion.Visible = true;
                this.txtVol.Visible = true;

                this.lblIsbn.Visible = false;
                this.lblNumeroPaginas.Visible = false;
                this.txtIsbn.Visible = false;
                this.txtPaginas.Visible = false;

                this.lblDuracion.Visible = false;
                this.txtDuracion.Visible = false;

                this.lblCategoria.Visible = false;
                this.txtCategoria.Visible = false;

            }
            else if (cboTipo.SelectedItem.ToString() == "Audiovisual")
            {
                this.lblDuracion.Visible = true;
                this.txtDuracion.Visible = true;

                this.lblIsbn.Visible = false;
                this.lblNumeroPaginas.Visible = false;
                this.txtIsbn.Visible = false;
                this.txtPaginas.Visible = false;

                this.lblEdicion.Visible = false;
                this.lblVolumen.Visible = false;
                this.txtEdicion.Visible = false;
                this.txtVol.Visible = false;

                this.lblCategoria.Visible = false;
                this.txtCategoria.Visible = false;
            }
            else if (cboTipo.SelectedItem.ToString() == "Otro")
            {
                this.lblCategoria.Visible = true;
                this.txtCategoria.Visible = true;

                this.lblIsbn.Visible = false;
                this.lblNumeroPaginas.Visible = false;
                this.txtIsbn.Visible = false;
                this.txtPaginas.Visible = false;

                this.lblEdicion.Visible = false;
                this.lblVolumen.Visible = false;
                this.txtEdicion.Visible = false;
                this.txtVol.Visible = false;

                this.lblDuracion.Visible = false;
                this.txtDuracion.Visible = false;

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ObtenerDatos();
            if (titulo == string.Empty && unidades == string.Empty && idioma == string.Empty)
            {
                MessageBox.Show("Verifique que todos los campos esten rellenados", "Error");
            }
            else
            {
                MessageBox.Show("Para Aplicar los Cambio Coloque su Contraseña", "Aplicar Cambios");
                this.btnAgregar.Visible = false;
                this.btnAgregar2.Visible = true;
                this.lblJefe.Visible = true;
                this.txtContraJefe.Visible = true;

            }
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            //Falta Validador
            int stock;
            int npaginas;
            int.TryParse(numeropaginas, out npaginas);
            int.TryParse(unidades,out stock);
            autor=cboAutor.SelectedIndex.ToString();
            editorial = cboEditorial.SelectedIndex.ToString();
            materia=cboMateria.SelectedIndex.ToString();

            string claveBD = buscarClave(idFun);
            if (this.txtContraJefe.Text == claveBD)
            {
                if (cboTipo.SelectedItem.ToString() == "Libro")
                {
                    Libro l1 = new Libro(titulo, ObtenerId(autor), ObtenerId2(materia), descripcion, true, tipoPrestamo, idioma, f, stock, ObtenerId3(editorial), ruta, isbn, npaginas);
                    l1.InsertarLibro(l1, ObtenerId(autor), ObtenerId3(editorial), ObtenerId2(materia));
                    MessageBox.Show("LIBRO REGISTRADO EXITOSAMENTE", "EXITO");
                    Limpiar();
                }
                else if (cboTipo.SelectedItem.ToString() == "Revista")
                {
                    Revista r1 = new Revista(titulo, ObtenerId(autor), ObtenerId2(materia), descripcion, true, tipoPrestamo, idioma, f, stock, ObtenerId3(editorial), ruta, edicion, vol);
                    r1.InsertarRevista(r1, ObtenerId(autor), ObtenerId3(editorial), ObtenerId2(materia));
                    MessageBox.Show("REVISTA REGISTRADO EXITOSAMENTE", "EXITO");
                    Limpiar();
                }
                else if (cboTipo.SelectedItem.ToString() == "Audiovisual")
                {
                    Audiovisual a1 = new Audiovisual(titulo, ObtenerId(autor), ObtenerId2(materia), descripcion, true, tipoPrestamo, idioma, f, stock, ObtenerId3(editorial), ruta, duracion);
                    a1.InsertarAudiovisual(a1, ObtenerId(autor), ObtenerId3(editorial), ObtenerId2(materia));
                    MessageBox.Show("MATERIAL AUDIOVISUAL REGISTRADO EXITOSAMENTE", "EXITO");
                    Limpiar();
                }
                else if (cboTipo.SelectedItem.ToString() == "Otro")
                {
                    Otro o1 = new Otro(titulo, ObtenerId(autor), ObtenerId2(materia), descripcion, true, tipoPrestamo, idioma, f, stock, ObtenerId3(editorial), ruta, categoria);
                    o1.InsertarOtro(o1, ObtenerId(autor), ObtenerId3(editorial), ObtenerId2(materia));
                    Limpiar();
                }
            }

            }

        
        ConnectionDB connection = new ConnectionDB();
    
        private void ObtenerDatos()
        {
            this.titulo = this.txtTitulo.Text;
            int.TryParse(this.txtDuracion.Text, out duracion);
            
            this.autor = this.cboAutor.SelectedItem.ToString();
            this.materia = this.cboMateria.SelectedItem.ToString();
            this.unidades = this.txtUnidadesExistentes.Text;
            this.idioma = this.txtIdioma.Text;
            this.tipoPrestamo = this.cboPrestamos.SelectedItem.ToString();
            this.editorial = this.cboEditorial.SelectedItem.ToString();
            this.descripcion = this.txtDescripcion.Text;
            this.f = this.dtpFecha.Value;
            this.numeropaginas = this.txtPaginas.Text;
            this.isbn = this.txtIsbn.Text;
            this.contraseña = this.txtContraJefe.Text;
            this.categoria = this.txtCategoria.Text;
            int.TryParse(this.txtEdicion.Text, out edicion);
            int.TryParse(this.txtVol.Text, out vol);
            
        }
        private void Limpiar()
        {
            this.txtCategoria.Text = string.Empty;
            this.txtTitulo.Text = string.Empty;
            this.txtDuracion.Text = string.Empty;
            this.cboAutor.SelectedIndex = 0;
            this.cboMateria.SelectedIndex = 0;
            this.txtUnidadesExistentes.Text = string.Empty;
            this.txtIdioma.Text = string.Empty;
            this.cboPrestamos.SelectedIndex = 0;
            this.cboEditorial.SelectedIndex = 0;
            this.txtDescripcion.Text = string.Empty;
            this.dtpFecha.Text = string.Empty;
            this.txtPaginas.Text = string.Empty;
            this.txtIsbn.Text = string.Empty;
            this.txtContraJefe.Text = string.Empty;
            this.ptbPoster.ImageLocation = "";
            this.txtVol.Text = string.Empty;
            this.txtEdicion.Text = string.Empty;
        }
        
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            string[] campo;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RutaOb = openFileDialog1.FileName;
                campo = RutaOb.Split('2');
                ptbPoster.ImageLocation = openFileDialog1.FileName;
                ruta = campo[2];
                MessageBox.Show(ruta);
               
            }
        }
        private void CargarCboTipo()
        {
            cboTipo.Items.Add("Libro");
            cboTipo.Items.Add("Revista");
            cboTipo.Items.Add("Audiovisual");
            cboTipo.Items.Add("Otro");
            cboPrestamos.Items.Add("Deposito");
            cboPrestamos.Items.Add("Reserva");

            string cadena = "select nombre from AUTOR";
            connection.Open();
            try
            {
                SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    this.cboAutor.Items.Add(lector.GetValue(0).ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Mensaje Error" + ex.Message);
            }

            string cadena2 = "select nombre from EDITORIAL";
            connection.Open();
            try
            {
                SqlCommand comando2 = new SqlCommand(cadena2, connection.connectDb);
                SqlDataReader lector = comando2.ExecuteReader();
                while (lector.Read())
                {
                    this.cboEditorial.Items.Add(lector.GetValue(0).ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Mensaje Error" + ex.Message);
            }
            string cadena3 = "select nombre_materia from MATERIA";
            connection.Open();
            try
            {
                SqlCommand comando3 = new SqlCommand(cadena3, connection.connectDb);
                SqlDataReader lector = comando3.ExecuteReader();
                while (lector.Read())
                {
                    this.cboEditorial.Items.Add(lector.GetValue(0).ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Mensaje Error" + ex.Message);
            }

        }
        private string ObtenerId(string nombre)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cadena = "SELECT * from AUTOR";
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
        private string ObtenerId2(string nombre)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cadena = "SELECT * from MATERIA";
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
        private string ObtenerId3(string nombre)
        {
            ConnectionDB connection = new ConnectionDB();
            connection.Open();
            string cadena = "SELECT * from EDITORIAL";
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
        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
