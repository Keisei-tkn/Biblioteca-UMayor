﻿using System;
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
                OpenChildForm(new Home());
                btnPrestamos.Visible = false;
                btnInformesEstadisticos.Visible = false;
                btnBuscarMaterial.Visible = true;
                btnEditar.Visible = false;
                btnRegistrar.Visible = false;
            }
            else if (tipo=="Alumno"|| tipo == "Profesor" || tipo == "Externo")
            {
                InitializeComponent();
                OpenChildForm(new Home());
                btnIniciarSesion.Visible = false;
                btnPrestamos.Visible = true;
                btnInformesEstadisticos.Visible = true;
                btnBuscarMaterial.Visible = true;
                btnEditar.Visible = true;
                btnRegistrar.Visible = true;
                btnEditar.Enabled = false;
                btnRegistrar.Enabled = false;
            }
            else if (tipo == "Funcionario")
            {
                InitializeComponent();
                OpenChildForm(new Home());
                btnIniciarSesion.Visible = false;
                btnPrestamos.Visible = true;
                btnInformesEstadisticos.Visible = true;
                btnBuscarMaterial.Visible = true;
                btnEditar.Visible = true;
                btnRegistrar.Visible = true;
                btnEditar.Enabled = true;
                btnRegistrar.Enabled = true;
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
            AbrirFormEnPanel(new Home());
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

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Historial());

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Home());
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            AddOwnedForm(frm);
            frm.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(pSubMenu);
        }

        private void btnCerrarSes_Click(object sender, EventArgs e)
        {
            rut = "";
            nombre = "";
            pass = "";
            btnPrestamos.Visible = false;
            btnRegistrar.Visible = false;
            btnInformesEstadisticos.Visible = false;
            btnEditar.Visible = false;
            MessageBox.Show("Se ha cerrado sesión correctamente");
            btnIniciarSesion.Visible = true;
            Form1 frm = new Form1(rut, nombre, apellido, c, pass, tipo);
            AddOwnedForm(frm);
            frm.Show();
            this.Hide();
        }

        private void btnvolver_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.LightGray;
        }

        private void btnvolver_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.FromArgb(255, 194, 13);
        }

        private void btnDatosMat_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new AgregarDatos(rut));
        }

        private void btnRegistarUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new AgregarU(rut));
        }

        private void btnRegistarPresupuesto_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new AgregarD(rut));
        }

        private void btnEUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new EditarU(rut));
        }

        private void btnEMat_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new EditarM());
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRegistarMaterial_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new AgregarM(rut));
        }

        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new AgregarPrestamo(rut));
        }

        private void btnInformesEstadisticos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new MostrarEstadisticas());
        }

        private void btnBuscarMaterial_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new BuscarMaterial());
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
            MostrarSubmenu(pSubmenu2);
        }

        private void Ocultarsubmenu()
        {
            if (pSubMenu.Visible == true)
                pSubMenu.Visible = false;
            if (pSubmenu2.Visible == true)
                pSubmenu2.Visible = false;
        }
        private void MostrarSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                Ocultarsubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
    }
}