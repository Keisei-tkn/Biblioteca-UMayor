using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Ventanas
{
    public partial class BuscarMaterial : Form
    {
        ConnectionDB connection = new ConnectionDB();
        public BuscarMaterial()
        {
            InitializeComponent();
        }

        private void pbxBuscar_Click(object sender, EventArgs e)
        {
            
            string titulo;
            titulo = this.txtBuscar.Text;
            string cadena = $@"select MATERIAL.titulo ,EDITORIAL.nombre ,AUTOR.nombre ,MATERIAL.fecha_publicacion,MATERIAL.unidades_existentes, MATERIAL.id_material, MATERIAL.descripcion, MATERIAL.portada
                               FROM MATERIAL INNER JOIN EDITORIAL ON MATERIAL.id_editorial = EDITORIAL.id_editorial
                               INNER JOIN AUTOR ON MATERIAL.id_autor = AUTOR.id_autor
                               INNER JOIN MATERIA ON MATERIAL.id_materia = MATERIA.id_materia
                               WHERE MATERIAL.titulo COLLATE Latin1_General_CI_AI like '%{titulo}%';";
            connection.Open();
            try
            {
                SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    this.lblTitu.Text = lector.GetValue(0).ToString();
                    this.lblEditorial.Text = lector.GetValue(1).ToString();
                    this.lblAutor.Text = lector.GetValue(2).ToString();
                    this.lblFecha.Text = lector.GetValue(3).ToString();
                    this.lblUni.Text = lector.GetValue(4).ToString();
                    this.lblUbi.Text = lector.GetValue(5).ToString();
                    this.lblDescr.Text = lector.GetValue(6).ToString();
                    this.pbxPortada.ImageLocation = ObtenerRuta(lector.GetValue(7).ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Mensaje Error" + ex.Message);
            };

            
        }
        private string ObtenerRuta(string rutaBd)
        {
            string rutabuscar = Directory.GetCurrentDirectory();
            string[] campo;
            string str = "bin";
            campo = rutabuscar.Split(new string[] { str }, StringSplitOptions.None);
            rutaBd = campo[0] + rutaBd;
            return rutaBd;
        }
        private void Limpiar()
        {
            this.lala.Text = string.Empty;
            this.lblEditorial.Text = string.Empty;
            this.lele.Text = string.Empty;
            this.asdkas.Text = string.Empty;
            this.aaaaqaw.Text = string.Empty;
            this.asdaq.Text = string.Empty;
            this.lblDescr.Text = string.Empty;
            this.txtBuscar.Text = string.Empty;
        }
    }
}
