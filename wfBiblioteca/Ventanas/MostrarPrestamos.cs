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
using wfBiblioteca;

namespace wfBiblioteca.Ventanas
{
    public partial class MostrarPrestamos : Form
    {
        Boolean activo = true;
        public MostrarPrestamos()
        {
            InitializeComponent();

            Prestamo prs = new Prestamo();
            MaterialDB mat = new MaterialDB();
            List<Prestamo> ListaPrestamo = new List<Prestamo>();
            List<Material> ListaMat = mat.ListaMaterial;
            ListaPrestamo = prs.ObtenerAllPrestamosActivos();
            
            foreach(Prestamo p in ListaPrestamo)
            {
                Material matSpec = ListaMat.Find(Material => Material.Id == p.IdMaterial);
              
                ListViewItem item = new ListViewItem(p.Id);
                item.SubItems.Add(ObtenerNombre(ObtenerIdUsuario(p.Id)));
                item.SubItems.Add(matSpec.Nombre);
                item.SubItems.Add(p.FechaDevolucion.ToString("dd-MM-yyyy"));

                if (p.CheckAtraso())
                {
                    item.SubItems.Add("Si");

                    if (!ExisteAtraso(p.Id))
                    {
                        Atraso atraso = new Atraso(p);
                        atraso.InsertarAtraso(atraso);
                        item.SubItems.Add(atraso.Multa.ToString("C0"));
                    }
                    else {
                        Atraso Atraso = new Atraso();
                        Atraso = Atraso.ObtenerAtraso(p);
                        item.SubItems.Add(Atraso.Multa.ToString("C0"));
                    }

                }
                else
                {
                    item.SubItems.Add("No");
                }

                lsvPrestamos.Items.Add(item);
            }
        }

        public void Actualizar()
        {
            activo = false;
            while (lsvPrestamos.Items.Count > 0)
            {
                lsvPrestamos.Items.RemoveAt(0);
            }
            
            Prestamo prs = new Prestamo();
            MaterialDB mat = new MaterialDB();
            List<Prestamo> ListaPrestamo = new List<Prestamo>();
            List<Material> ListaMat = mat.ListaMaterial;
            ListaPrestamo = prs.ObtenerAllPrestamosActivos();

            foreach (Prestamo p in ListaPrestamo)
            {
                Material matSpec = ListaMat.Find(Material => Material.Id == p.IdMaterial);

                ListViewItem item = new ListViewItem(p.Id);
                item.SubItems.Add(ObtenerNombre(ObtenerIdUsuario(p.Id)));
                item.SubItems.Add(matSpec.Nombre);
                item.SubItems.Add(p.FechaDevolucion.ToString("dd-MM-yyyy"));

                if (p.CheckAtraso())
                {
                    item.SubItems.Add("Si");

                    if (!ExisteAtraso(p.Id))
                    {
                        Atraso atraso = new Atraso(p);
                        atraso.InsertarAtraso(atraso);
                        item.SubItems.Add(atraso.Multa.ToString("C0"));
                    }
                    else
                    {
                        Atraso Atraso = new Atraso();
                        Atraso = Atraso.ObtenerAtraso(p);
                        item.SubItems.Add(Atraso.Multa.ToString("C0"));
                    }

                }
                else
                {
                    item.SubItems.Add("No");
                }

                lsvPrestamos.Items.Add(item);
            }


        }

        private string ObtenerNombre(string  Id)
        {
            ConnectionDB connection = new ConnectionDB();
            String nombre = null;
            connection.Open();
            string cadena1 = "SELECT * from USUARIO";
            SqlCommand comando1 = new SqlCommand(cadena1, connection.connectDb);
            SqlDataReader lector1 = comando1.ExecuteReader();
            while (lector1.Read())
            {
                if (Id == lector1.GetValue(0).ToString())
                {
                    nombre = lector1.GetValue(1).ToString();
                    return nombre;
                }
            }
            connection.Close();
            return nombre;
        }

        private string ObtenerIdUsuario(string IdPrestamo)
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataReader registros = null;
            connection.Open();
            String IdUsuario = null;

            SqlCommand querySel = new SqlCommand($@"SELECT HIS.id_usuario FROM HISTORIAL AS HIS WHERE HIS.id_prestamo = '{IdPrestamo}';", connection.connectDb);

            registros = querySel.ExecuteReader();

            while (registros.Read())
            {
                IdUsuario = registros["id_usuario"].ToString();
               
            }
            connection.Close();

            return IdUsuario;
        }

        private Boolean ExisteAtraso(string IdPrestamo)
        {
            Atraso atr = new Atraso();
            Boolean existe = false;
            List<Atraso> ListaAtraso = atr.ObtenerAllAtrasos();
            foreach(Atraso a in ListaAtraso)
            {
                if(a.IdPrestamo == IdPrestamo)
                {
                    existe = true;
                    return existe;
                }
            }
            return existe;
        }

        private void lsvPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activo)
            {
                string idPrestamo;
                idPrestamo = lsvPrestamos.SelectedItems[0].SubItems[0].Text;
                Prestamo prs = new Prestamo();
                DialogResult result = MessageBox.Show("Finalizar Prestamo", "Confirmacion", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    // User clicked the "Yes" button
                    // Perform the desired action

                    foreach (Prestamo p in prs.ObtenerAllPrestamosActivos())
                    {
                        if (p.Id.Equals(idPrestamo))
                        {
                            prs.UpdatePrestamo(p);
                        }

                    }
                    Actualizar();
                    activo = true;


                }
                else if (result == DialogResult.No)
                {
                    // User clicked the "No" button
                    // Perform the desired action
                }
                else if (result == DialogResult.Cancel)
                {
                    // User clicked the "Cancel" button
                    // Perform the desired action
                }
            }

        }
    }
}
