using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace wfBiblioteca
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.White;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.White;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            AddOwnedForm(frm);
            frm.Show();
            this.Hide();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Inicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            AddOwnedForm(frm);
            frm.Show();
            this.Hide();
        }

        private void btnAcceder_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            int borderRadius = 20; // Ajusta este valor para cambiar el grado de redondeo

            buttonPath.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            buttonPath.AddArc(btnAcceder.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            buttonPath.AddArc(btnAcceder.Width - borderRadius, btnAcceder.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            buttonPath.AddArc(0, btnAcceder.Height - borderRadius, borderRadius, borderRadius, 90, 90);

            btnAcceder.Region = new System.Drawing.Region(buttonPath);
        }

        private void btnVolver_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            int borderRadius = 20; // Ajusta este valor para cambiar el grado de redondeo

            buttonPath.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            buttonPath.AddArc(btnVolver.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            buttonPath.AddArc(btnVolver.Width - borderRadius, btnVolver.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            buttonPath.AddArc(0, btnVolver.Height - borderRadius, borderRadius, borderRadius, 90, 90);

            btnVolver.Region = new System.Drawing.Region(buttonPath);
        }

    }
}
