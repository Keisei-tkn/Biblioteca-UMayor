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
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Prestamo prs = new Prestamo();
            MaterialDB mat = new MaterialDB();
            List<wfBiblioteca.Classes.Material> ListaMat = mat.ListaMaterial;
            if (txtIdUsuario.Text == String.Empty)
            {
                MessageBox.Show("Por favor ingrese una ID");
            }
            else if(Validar_id(txtIdUsuario.Text)){
                List<Prestamo> ListaPrestamo = prs.ObtenerHistorial(txtIdUsuario.Text);
                while (lsvHistorial.Items.Count > 0)
                {
                    lsvHistorial.Items.RemoveAt(0);
                }
                foreach (Prestamo p in ListaPrestamo)
                {
                    Material matSpec = ListaMat.Find(Material => Material.Id == p.IdMaterial);

                    ListViewItem item = new ListViewItem(p.FechaPrestamo.ToString("dd-MM-yyyy"));
                    item.SubItems.Add(matSpec.Nombre);
                    lsvHistorial.Items.Add(item);
                }
            }
            else
            {
                txtIdUsuario.Clear();
                while (lsvHistorial.Items.Count > 0)
                {
                    lsvHistorial.Items.RemoveAt(0);
                }
                MessageBox.Show("ID ingresada no existe.");
            }
        }

        private bool Validar_id(string id)
        {
            ConnectionDB connection = new ConnectionDB();
            bool EstaOk = false;
            SqlDataReader registros = null;
            connection.Open();
            string cadena = "SELECT id_usuario from USUARIO";
            SqlCommand comando = new SqlCommand(cadena, connection.connectDb);
            registros = comando.ExecuteReader();
            string idBuscado;

            while (registros.Read())
            {
                idBuscado = registros.GetString(0).ToString();
                if (id == idBuscado)
                {
                    EstaOk = true;
                    connection.Close();
                    return EstaOk;
                }
                else
                {

                    EstaOk = false;


                }
            }
            return EstaOk;
        }
    }
}
