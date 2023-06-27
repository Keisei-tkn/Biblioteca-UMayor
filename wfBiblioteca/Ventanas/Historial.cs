using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfBiblioteca.Classes;

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
            else{
                List<Prestamo> ListaPrestamo = prs.ObtenerHistorial(txtIdUsuario.Text);
                foreach(Prestamo p in ListaPrestamo)
                {
                    Material matSpec = ListaMat.Find(Material => Material.Id == p.IdMaterial);

                    ListViewItem item = new ListViewItem(p.FechaPrestamo.ToString("dd-MM-yyyy"));
                    item.SubItems.Add(matSpec.Nombre);
                    lsvHistorial.Items.Add(item);
                }
            }
        }
    }
}
