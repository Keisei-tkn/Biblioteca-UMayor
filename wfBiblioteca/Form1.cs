using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfBiblioteca.Classes;
using wfBiblioteca.Ventanas;

namespace wfBiblioteca
{
    public partial class Form1 : Form
    {
        string rut, nombre, apellido, c, pass,tipo;
        public Form1(string id,string nom,string ap,string correo,string password,string t)
        {
            rut = id;
            this.nombre = nom;
            this.apellido = ap;
            this.c = correo;
            this.pass = password;
            this.tipo = t;

            Usuario u1 = new Usuario(rut,nombre,apellido,pass,c,tipo);

            if (rut == string.Empty && password == string.Empty)
            {
                InitializeComponent();
            }
            else if (tipo=="Alumno"|| tipo == "Profesor" || tipo == "Externo")
            {
                InitializeComponent();
                btnIniciarSesion.Visible = false;
                btnPrestamos.Visible = true;
                btnInformesEstadisticos.Visible = true;
                btnRegistrarMaterial.Visible = false;
                btnRegistrarPresupuesto.Visible = false;
                btnAbrirSubM.Visible = false;
                btnRegistrarUsuario.Visible = false;
                btnBuscarMaterial.Visible = true;
                btnUEditar.Visible = false;
                btnMatEditar.Visible = false;
                btnEditar.Visible = false;
                btnPresuEditar.Visible = false;
            }
            else if (tipo == "Funcionario")
            {
                InitializeComponent();
                btnIniciarSesion.Visible = false;
                btnPrestamos.Visible = true;
                btnInformesEstadisticos.Visible = true;
                btnRegistrarMaterial.Visible = true;
                btnRegistrarPresupuesto.Visible = true;
                btnAbrirSubM.Visible = true;
                btnRegistrarUsuario.Visible = true;
                btnBuscarMaterial.Visible = true;
                btnUEditar.Visible = true;
                btnMatEditar.Visible = true;
                btnEditar.Visible = true;
                btnPresuEditar.Visible = true;
            }
            
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

            private void btnMin_Click(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Minimized;
            }


            [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();
            [DllImport("user32.DLL", EntryPoint = "SendMessage")]
            private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



            private void P_titulo_MouseDown(object sender, MouseEventArgs e)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
   
            private void P_Menu_MouseDown(object sender, MouseEventArgs e)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }

            private void P_contenido_MouseDown(object sender, MouseEventArgs e)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }

        

        private void btnComida_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new Comida());
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new EditObjetos(EmpCon));
        }

        private void btnEditF_Click(object sender, EventArgs e)
        {
            this.pSubMenu.Visible = true;
        }

 

        private void btnAgregarF_Click(object sender, EventArgs e)
        {
            //this.pSubMenu.Visible = false;
            //AbrirFormEnPanel(new AgregarF(EmpCon));
        }

        private void btnEditarF_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new EditFuncionarios(EmpCon));
            //this.pSubMenu.Visible = false;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            btnPrestamos_Click(null, e);
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.P_contenido.Controls.Count > 0)
                this.P_contenido.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.P_contenido.Controls.Add(fh);
            this.P_contenido.Tag = fh;
            fh.Show();

        }


        
        private void CerrarSesion()
        {
            //Emp = string.Empty;
            //EmpCon = string.Empty;
            //Cli = string.Empty;
            //CliContra = string.Empty;
            //cargo=string.Empty;
            //Form1 frm = new Form1(Emp,EmpCon,Cli,CliContra,cargo);
            //AddOwnedForm(frm);
            //frm.Show();
            this.Hide();
            MessageBox.Show("Sesión Cerrada Con Éxito","Cerrar Sesión");
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
         
            AbrirFormEnPanel(new Home());

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            AddOwnedForm(frm);
            frm.Show();
            this.Hide();
        }

        private void btnCerrarSes_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }

        private Form formularioactivo = null;
        private void OpenChildForm(Form childForm)
        {
            if (formularioactivo != null)
                formularioactivo.Close();
            formularioactivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            P_contenido.Controls.Add(childForm);
            P_contenido.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            this.pSubmenu2.Visible = true;
        }

        private void Ocultarsubmenu()
        {
           //
        }
    }
}
