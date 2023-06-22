using System;
using System.Windows.Forms;
//Edito Andrews
namespace wfBiblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.P_titulo = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.P_Menu = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnC = new System.Windows.Forms.Button();
            this.pSubMenu = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAgregarF = new System.Windows.Forms.Button();
            this.btnEditarF = new System.Windows.Forms.Button();
            this.btnAbrirSubM = new System.Windows.Forms.Button();
            this.pEditF = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pEdit = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnComida = new System.Windows.Forms.Button();
            this.btnPelis = new System.Windows.Forms.Button();
            this.P_contenido = new System.Windows.Forms.Panel();
            this.btnCartelera = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.P_titulo.SuspendLayout();
            this.P_Menu.SuspendLayout();
            this.pSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCartelera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // P_titulo
            // 
            this.P_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(13)))));
            this.P_titulo.Controls.Add(this.btnCerrarSesion);
            this.P_titulo.Controls.Add(this.btnLogin);
            this.P_titulo.Controls.Add(this.btnRestaurar);
            this.P_titulo.Controls.Add(this.btnMin);
            this.P_titulo.Controls.Add(this.btnMax);
            this.P_titulo.Controls.Add(this.btnCerrar);
            this.P_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_titulo.Location = new System.Drawing.Point(0, 0);
            this.P_titulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.P_titulo.Name = "P_titulo";
            this.P_titulo.Size = new System.Drawing.Size(900, 33);
            this.P_titulo.TabIndex = 0;
            this.P_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_titulo_MouseDown);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(13)))));
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(673, 0);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(112, 33);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Visible = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(13)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(683, 1);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 33);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // P_Menu
            // 
            this.P_Menu.AutoScroll = true;
            this.P_Menu.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.P_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(13)))));
            this.P_Menu.Controls.Add(this.panel6);
            this.P_Menu.Controls.Add(this.btnC);
            this.P_Menu.Controls.Add(this.pSubMenu);
            this.P_Menu.Controls.Add(this.btnAbrirSubM);
            this.P_Menu.Controls.Add(this.pEditF);
            this.P_Menu.Controls.Add(this.btnEditar);
            this.P_Menu.Controls.Add(this.pEdit);
            this.P_Menu.Controls.Add(this.panel4);
            this.P_Menu.Controls.Add(this.btnHome);
            this.P_Menu.Controls.Add(this.panel2);
            this.P_Menu.Controls.Add(this.panel1);
            this.P_Menu.Controls.Add(this.btnComida);
            this.P_Menu.Controls.Add(this.btnPelis);
            this.P_Menu.Controls.Add(this.btnCartelera);
            this.P_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.P_Menu.Location = new System.Drawing.Point(0, 33);
            this.P_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.P_Menu.Name = "P_Menu";
            this.P_Menu.Size = new System.Drawing.Size(184, 456);
            this.P_Menu.TabIndex = 1;
            this.P_Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_Menu_MouseDown);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel6.Location = new System.Drawing.Point(0, 189);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(4, 37);
            this.panel6.TabIndex = 15;
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.Location = new System.Drawing.Point(3, 187);
            this.btnC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(162, 37);
            this.btnC.TabIndex = 14;
            this.btnC.Text = "Cartelera";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // pSubMenu
            // 
            this.pSubMenu.BackColor = System.Drawing.Color.Transparent;
            this.pSubMenu.Controls.Add(this.panel7);
            this.pSubMenu.Controls.Add(this.panel5);
            this.pSubMenu.Controls.Add(this.btnAgregarF);
            this.pSubMenu.Controls.Add(this.btnEditarF);
            this.pSubMenu.Location = new System.Drawing.Point(8, 388);
            this.pSubMenu.Name = "pSubMenu";
            this.pSubMenu.Size = new System.Drawing.Size(157, 121);
            this.pSubMenu.TabIndex = 13;
            this.pSubMenu.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel7.Location = new System.Drawing.Point(25, 61);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(4, 55);
            this.panel7.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel5.Location = new System.Drawing.Point(25, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 45);
            this.panel5.TabIndex = 13;
            // 
            // btnAgregarF
            // 
            this.btnAgregarF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnAgregarF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarF.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnAgregarF.FlatAppearance.BorderSize = 0;
            this.btnAgregarF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnAgregarF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAgregarF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarF.ForeColor = System.Drawing.Color.White;
            this.btnAgregarF.Location = new System.Drawing.Point(28, 2);
            this.btnAgregarF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarF.Name = "btnAgregarF";
            this.btnAgregarF.Size = new System.Drawing.Size(142, 53);
            this.btnAgregarF.TabIndex = 11;
            this.btnAgregarF.Text = "Agregar Funcionario";
            this.btnAgregarF.UseVisualStyleBackColor = false;
            this.btnAgregarF.Click += new System.EventHandler(this.btnAgregarF_Click);
            // 
            // btnEditarF
            // 
            this.btnEditarF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnEditarF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarF.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEditarF.FlatAppearance.BorderSize = 0;
            this.btnEditarF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnEditarF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEditarF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarF.ForeColor = System.Drawing.Color.White;
            this.btnEditarF.Location = new System.Drawing.Point(28, 55);
            this.btnEditarF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarF.Name = "btnEditarF";
            this.btnEditarF.Size = new System.Drawing.Size(142, 64);
            this.btnEditarF.TabIndex = 12;
            this.btnEditarF.Text = "Editar Funcionario";
            this.btnEditarF.UseVisualStyleBackColor = false;
            this.btnEditarF.Click += new System.EventHandler(this.btnEditarF_Click);
            // 
            // btnAbrirSubM
            // 
            this.btnAbrirSubM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnAbrirSubM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirSubM.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnAbrirSubM.FlatAppearance.BorderSize = 0;
            this.btnAbrirSubM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnAbrirSubM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAbrirSubM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirSubM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirSubM.ForeColor = System.Drawing.Color.White;
            this.btnAbrirSubM.Location = new System.Drawing.Point(3, 339);
            this.btnAbrirSubM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbrirSubM.Name = "btnAbrirSubM";
            this.btnAbrirSubM.Size = new System.Drawing.Size(162, 52);
            this.btnAbrirSubM.TabIndex = 8;
            this.btnAbrirSubM.Text = "Agregar/Editar funcionarios";
            this.btnAbrirSubM.UseVisualStyleBackColor = false;
            this.btnAbrirSubM.Visible = false;
            this.btnAbrirSubM.Click += new System.EventHandler(this.btnEditF_Click);
            // 
            // pEditF
            // 
            this.pEditF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pEditF.Location = new System.Drawing.Point(0, 339);
            this.pEditF.Name = "pEditF";
            this.pEditF.Size = new System.Drawing.Size(4, 37);
            this.pEditF.TabIndex = 11;
            this.pEditF.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(3, 278);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(162, 56);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Agregar/Modificar Objetos";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pEdit
            // 
            this.pEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pEdit.Location = new System.Drawing.Point(0, 286);
            this.pEdit.Name = "pEdit";
            this.pEdit.Size = new System.Drawing.Size(4, 37);
            this.pEdit.TabIndex = 9;
            this.pEdit.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel4.Location = new System.Drawing.Point(0, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 37);
            this.panel4.TabIndex = 7;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(3, 103);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(162, 37);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Location = new System.Drawing.Point(0, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 37);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 37);
            this.panel1.TabIndex = 3;
            // 
            // btnComida
            // 
            this.btnComida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnComida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComida.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnComida.FlatAppearance.BorderSize = 0;
            this.btnComida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnComida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnComida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComida.ForeColor = System.Drawing.Color.White;
            this.btnComida.Location = new System.Drawing.Point(3, 235);
            this.btnComida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(162, 37);
            this.btnComida.TabIndex = 1;
            this.btnComida.Text = "Comida";
            this.btnComida.UseVisualStyleBackColor = false;
            this.btnComida.Click += new System.EventHandler(this.btnComida_Click);
            // 
            // btnPelis
            // 
            this.btnPelis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnPelis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPelis.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnPelis.FlatAppearance.BorderSize = 0;
            this.btnPelis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnPelis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPelis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPelis.ForeColor = System.Drawing.Color.White;
            this.btnPelis.Location = new System.Drawing.Point(3, 143);
            this.btnPelis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPelis.Name = "btnPelis";
            this.btnPelis.Size = new System.Drawing.Size(162, 37);
            this.btnPelis.TabIndex = 0;
            this.btnPelis.Text = "Biblioteca Películas";
            this.btnPelis.UseVisualStyleBackColor = false;
            this.btnPelis.Click += new System.EventHandler(this.btnPelis_Click);
            // 
            // P_contenido
            // 
            this.P_contenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.P_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_contenido.Location = new System.Drawing.Point(184, 33);
            this.P_contenido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.P_contenido.Name = "P_contenido";
            this.P_contenido.Size = new System.Drawing.Size(716, 456);
            this.P_contenido.TabIndex = 2;
            this.P_contenido.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_contenido_MouseDown);
            // 
            // btnCartelera
            // 
            this.btnCartelera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(13)))));
            this.btnCartelera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCartelera.Image = global::wfBiblioteca.Properties.Resources.Logo;
            this.btnCartelera.Location = new System.Drawing.Point(30, 1);
            this.btnCartelera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCartelera.Name = "btnCartelera";
            this.btnCartelera.Size = new System.Drawing.Size(106, 96);
            this.btnCartelera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCartelera.TabIndex = 0;
            this.btnCartelera.TabStop = false;
            this.btnCartelera.Click += new System.EventHandler(this.btnCartelera_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::wfBiblioteca.Properties.Resources.res;
            this.btnRestaurar.Location = new System.Drawing.Point(840, 5);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(21, 22);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = global::wfBiblioteca.Properties.Resources.minimazar;
            this.btnMin.Location = new System.Drawing.Point(809, 5);
            this.btnMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(21, 22);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = global::wfBiblioteca.Properties.Resources.maxi;
            this.btnMax.Location = new System.Drawing.Point(840, 5);
            this.btnMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(21, 22);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 1;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::wfBiblioteca.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(869, 5);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 489);
            this.Controls.Add(this.P_contenido);
            this.Controls.Add(this.P_Menu);
            this.Controls.Add(this.P_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.P_titulo.ResumeLayout(false);
            this.P_Menu.ResumeLayout(false);
            this.pSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCartelera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Panel P_titulo;
        private PictureBox btnCerrar;
        private Panel P_Menu;
        private Panel P_contenido;
        private PictureBox btnMin;
        private PictureBox btnMax;
        private PictureBox btnRestaurar;
        private PictureBox btnCartelera;
        private Button btnPelis;
        private Button btnComida;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Button btnHome;
        private Button btnLogin;
        private Button btnCerrarSesion;
        private Panel pEditF;
        private Button btnEditar;
        private Panel pEdit;
        private Button btnAbrirSubM;
        private Button btnEditarF;
        private Button btnAgregarF;
        private Panel pSubMenu;
        private Panel panel7;
        private Panel panel5;
        private Panel panel6;
        private Button btnC;
        //private MouseEventHandler P_titulo_MouseDown;
        //private EventHandler btnRestaurar_Click;
        //private EventHandler btnMin_Click;
        //private EventHandler btnMax_Click;
        //private EventHandler pictureBox1_Click;
        //private PaintEventHandler panel4_Paint;
        //private EventHandler btnComida_Click;
        //private EventHandler btnPelis_Click;

        //public MouseEventHandler P_contenido_MouseDown { get; private set; }
    }
}

