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
    public partial class MostrarPrestamos : Form
    {
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
    }
}
