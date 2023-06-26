using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfBiblioteca.Ventanas
{
    public partial class Home : Form
    {
        private int tiempo;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo++;
            Aaa.Text = tiempo.ToString();

            if (Aaa.Text == "200" || rdbDos.Checked == true)
            {
                imagen1.ImageLocation = Application.StartupPath + "\\imageneshome\\i2.jpg";
                rdbUno.Checked = false;
                rdbDos.Checked = true;
                rdbTres.Checked = false;

            }
            if (Aaa.Text == "400" || rdbTres.Checked == true)
            {
                imagen1.ImageLocation = Application.StartupPath + "\\imageneshome\\i3.jpg";
                rdbUno.Checked = false;
                rdbDos.Checked = false;
                rdbTres.Checked = true;
            }
            if (Aaa.Text == "600" || rdbUno.Checked == true)
            {
                timer1.Enabled = false;
                imagen1.ImageLocation = Application.StartupPath + "\\imageneshome\\i1.jpg";
                rdbUno.Checked = true;
                rdbDos.Checked = false;
                rdbTres.Checked = false;
                timer1.Start();
            }
            if (Aaa.Text == "800")
            {
                tiempo = 0;
                Aaa.Text = "0";
                timer1.Start();
            }
        }
    }
}
