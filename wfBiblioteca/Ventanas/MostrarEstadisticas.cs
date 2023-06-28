using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using wfBiblioteca.Classes;
using wfBiblioteca.SQL;

namespace wfBiblioteca.Ventanas
{
    public partial class MostrarEstadisticas : Form
    {
        public MostrarEstadisticas()
        {
            InitializeComponent();

            Estadisticas est = new Estadisticas();

            lblMulta.Text = est.DineroTotalMultas.ToString("C0");
            picTopMaterial.ImageLocation = SearchMaterial(est.MaterialMasPedido[0].Nombre);
            string atr;
            if(est.CantidadAtrasos == 1)
            {
                atr = "Atraso";
            }
            else
            {
                atr = "Atrasos";
            }

            lblAtrasos.Text = est.CantidadAtrasos.ToString() + " " + atr;

            var brush1 = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(18, 99, 107));

            // Create a Color object with the RGB values
            Color color = Color.FromArgb(255, 18, 99, 107);

            // Create a SolidColorBrush using the Color object
            Brush brush = new SolidColorBrush(color);

            cartesianChart1.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Cantidad",
                    Values = new ChartValues<int> { est.CantidadPedidosLibro, est.CantidadPedidosRevista, est.CantidadPedidosAudiovisual, est.CantidadPedidosOtro },
                    Fill = brush
                }
            };

            //also adding values updates and animates the chart automatically

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Tipo Material",
                Labels = new[] { "Libro", "Revista", "Audiovisual", "Otro" },
                Separator = new Separator { Step = 1 }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Cantidad de Prestamos",
                Separator = new Separator { Step = 1 },
                LabelFormatter = value => value.ToString("N0")
            });



            cartesianChart2.Series = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "Cantidad de Pedidos",
                    Values = new ChartValues<double> {est.CantMaterialMasPedido[0], est.CantMaterialMasPedido[1], est.CantMaterialMasPedido[2] },
                    Fill = brush

                }
            };

            cartesianChart2.AxisX.Add(new Axis
            {
                Title = "Cantidad de Prestamos",
                Separator = new Separator { Step = 1 },
                LabelFormatter = value => value.ToString("N0")
            });

            cartesianChart2.AxisY.Add(new Axis
            {
                Labels = new[] { est.MaterialMasPedido[0].Nombre, est.MaterialMasPedido[1].Nombre, est.MaterialMasPedido[2].Nombre },
                Separator = new Separator { Step = 1 }
            });

        }

        public string SearchMaterial(string nombre)
        {
            ConnectionDB connection = new ConnectionDB();
            string titulo;
            string ruta = null ;
            titulo = nombre;
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
                    ruta = ObtenerRuta(lector.GetValue(7).ToString());
                }
                connection.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Mensaje Error" + ex.Message);
            };
            return ruta;
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
    }
}
