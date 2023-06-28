using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using wfBiblioteca.Classes;

namespace wfBiblioteca.Ventanas
{
    public partial class MostrarEstadisticas : Form
    {
        public MostrarEstadisticas()
        {
            InitializeComponent();

            Estadisticas est = new Estadisticas();

            lblMulta.Text = est.DineroTotalMultas.ToString("C0");
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
        }

    }
}
