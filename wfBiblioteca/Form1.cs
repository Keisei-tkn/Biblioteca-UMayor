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
using wfBiblioteca.Ventanas;

namespace wfBiblioteca
{
    public partial class Form1 : Form
    {
        //string Emp, EmpCon, Cli, CliContra,cargo;
        public Form1(/*string EmpBuscado, string EmpConBuscado , string CliBuscado, string CliContraBuscada, string Cargoencontrado*/)
        {
            InitializeComponent();
            //this.Emp = EmpBuscado;
            //this.EmpCon = EmpConBuscado;
            //this.Cli = CliBuscado;
            //this.CliContra = CliContraBuscada;
            //this.cargo = Cargoencontrado;
            //if (Emp == string.Empty && EmpCon == string.Empty && Cli == string.Empty && CliContra == string.Empty&&cargo==string.Empty)
            //{
               
            //}
            //else if (Emp != string.Empty && EmpCon != string.Empty && Cli == null && CliContra == null && cargo != string.Empty)
            //{
            //    if (cargo != "Cajero"&& cargo != "Supervisor")
            //    {
            //        InitializeComponent();
            //        this.btnLogin.Visible = false;
            //        this.btnCerrarSesion.Visible = true;
            //        this.btnEditar.Visible = true;
            //        this.pEdit.Visible = true;
            //        this.btnAbrirSubM.Visible = true;
            //        this.pEditF.Visible = true;
                   
                    
            //    }
            //    else if(cargo == "Supervisor")
            //    {
            //        InitializeComponent();
            //        this.btnLogin.Visible = false;
            //        this.btnCerrarSesion.Visible = true;
            //        this.btnEditar.Visible = true;
            //        this.pEdit.Visible = true;

                    
            //    }
            //    else
            //    {
            //        InitializeComponent();
            //        this.btnLogin.Visible = false;
            //        this.btnCerrarSesion.Visible = true;
                 
            //    }

            //}
            //else 
            //{
            
            //    InitializeComponent();
            //    this.btnLogin.Visible = false;
            //    this.btnCerrarSesion.Visible = true;
            //    MessageBox.Show("Se inicio sesion como Cliente");
                
            //}
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

            private void btnMax_Click(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMax.Visible = false;
                btnRestaurar.Visible = true;
            }

            private void btnRestaurar_Click(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Normal;
                btnMax.Visible = true;
                btnRestaurar.Visible = false;
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion();
            
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Home());
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

        private void btnCartelera_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new Cartelera(Cli));
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

        private void btnC_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new Cartelera(Cli));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnHome_Click(null, e);
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


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            AddOwnedForm(frm);
            frm.Show();
            this.Hide();
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
        
    }
}
