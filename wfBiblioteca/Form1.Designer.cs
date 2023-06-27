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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.P_titulo = new System.Windows.Forms.Panel();
            this.btnvolver = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.P_Menu = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnInformesEstadisticos = new System.Windows.Forms.Button();
            this.pSubMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegistrarPresupuesto = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.btnRegistrarMaterial = new System.Windows.Forms.Button();
            this.btnAbrirSubM = new System.Windows.Forms.Button();
            this.pEditF = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarMaterial = new System.Windows.Forms.Button();
            this.btnCartelera = new System.Windows.Forms.PictureBox();
            this.P_contenido = new System.Windows.Forms.Panel();
            this.btnCerrarSes = new wfBiblioteca.Classes.BotonesPersonalizados();
            this.btnIniciarSesion = new wfBiblioteca.Classes.BotonesPersonalizados();
            this.P_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.P_Menu.SuspendLayout();
            this.pSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCartelera)).BeginInit();
            this.SuspendLayout();
            // 
            // P_titulo
            // 
            this.P_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(13)))));
            this.P_titulo.Controls.Add(this.btnIniciarSesion);
            this.P_titulo.Controls.Add(this.btnCerrarSes);
            this.P_titulo.Controls.Add(this.btnvolver);
            this.P_titulo.Controls.Add(this.btnMin);
            this.P_titulo.Controls.Add(this.btnCerrar);
            this.P_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_titulo.Location = new System.Drawing.Point(0, 0);
            this.P_titulo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.P_titulo.Name = "P_titulo";
            this.P_titulo.Size = new System.Drawing.Size(1200, 48);
            this.P_titulo.TabIndex = 0;
            this.P_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_titulo_MouseDown);
            // 
            // btnvolver
            // 
            this.btnvolver.Image = global::wfBiblioteca.Properties.Resources.hogar;
            this.btnvolver.Location = new System.Drawing.Point(414, 5);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(65, 39);
            this.btnvolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnvolver.TabIndex = 10;
            this.btnvolver.TabStop = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = global::wfBiblioteca.Properties.Resources.minimizar_signo;
            this.btnMin.Location = new System.Drawing.Point(1123, 6);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(28, 27);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::wfBiblioteca.Properties.Resources.cerrar1;
            this.btnCerrar.Location = new System.Drawing.Point(1159, 6);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 27);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // P_Menu
            // 
            this.P_Menu.AutoScroll = true;
            this.P_Menu.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.P_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(13)))));
            this.P_Menu.Controls.Add(this.panel6);
            this.P_Menu.Controls.Add(this.btnInformesEstadisticos);
            this.P_Menu.Controls.Add(this.pSubMenu);
            this.P_Menu.Controls.Add(this.btnAbrirSubM);
            this.P_Menu.Controls.Add(this.pEditF);
            this.P_Menu.Controls.Add(this.panel4);
            this.P_Menu.Controls.Add(this.btnPrestamos);
            this.P_Menu.Controls.Add(this.panel1);
            this.P_Menu.Controls.Add(this.btnBuscarMaterial);
            this.P_Menu.Controls.Add(this.btnCartelera);
            this.P_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.P_Menu.Location = new System.Drawing.Point(0, 48);
            this.P_Menu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.P_Menu.Name = "P_Menu";
            this.P_Menu.Size = new System.Drawing.Size(251, 554);
            this.P_Menu.TabIndex = 1;
            this.P_Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_Menu_MouseDown);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel6.Location = new System.Drawing.Point(0, 230);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 46);
            this.panel6.TabIndex = 15;
            // 
            // btnInformesEstadisticos
            // 
            this.btnInformesEstadisticos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnInformesEstadisticos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformesEstadisticos.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnInformesEstadisticos.FlatAppearance.BorderSize = 0;
            this.btnInformesEstadisticos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnInformesEstadisticos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnInformesEstadisticos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformesEstadisticos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformesEstadisticos.ForeColor = System.Drawing.Color.White;
            this.btnInformesEstadisticos.Location = new System.Drawing.Point(4, 230);
            this.btnInformesEstadisticos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnInformesEstadisticos.Name = "btnInformesEstadisticos";
            this.btnInformesEstadisticos.Size = new System.Drawing.Size(216, 46);
            this.btnInformesEstadisticos.TabIndex = 14;
            this.btnInformesEstadisticos.Text = "Informes Estadísticos";
            this.btnInformesEstadisticos.UseVisualStyleBackColor = false;
            // 
            // pSubMenu
            // 
            this.pSubMenu.BackColor = System.Drawing.Color.Transparent;
            this.pSubMenu.Controls.Add(this.panel2);
            this.pSubMenu.Controls.Add(this.btnRegistrarPresupuesto);
            this.pSubMenu.Controls.Add(this.panel7);
            this.pSubMenu.Controls.Add(this.panel5);
            this.pSubMenu.Controls.Add(this.btnRegistrarUsuario);
            this.pSubMenu.Controls.Add(this.btnRegistrarMaterial);
            this.pSubMenu.Location = new System.Drawing.Point(13, 351);
            this.pSubMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pSubMenu.Name = "pSubMenu";
            this.pSubMenu.Size = new System.Drawing.Size(209, 210);
            this.pSubMenu.TabIndex = 13;
            this.pSubMenu.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Location = new System.Drawing.Point(22, 131);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 61);
            this.panel2.TabIndex = 16;
            // 
            // btnRegistrarPresupuesto
            // 
            this.btnRegistrarPresupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnRegistrarPresupuesto.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnRegistrarPresupuesto.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnRegistrarPresupuesto.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPresupuesto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnRegistrarPresupuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRegistrarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPresupuesto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPresupuesto.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPresupuesto.Location = new System.Drawing.Point(27, 131);
            this.btnRegistrarPresupuesto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRegistrarPresupuesto.Name = "btnRegistrarPresupuesto";
            this.btnRegistrarPresupuesto.Size = new System.Drawing.Size(189, 61);
            this.btnRegistrarPresupuesto.TabIndex = 15;
            this.btnRegistrarPresupuesto.Text = "Presupuesto";
            this.btnRegistrarPresupuesto.UseVisualStyleBackColor = false;
            this.btnRegistrarPresupuesto.UseWaitCursor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel7.Location = new System.Drawing.Point(23, 66);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 61);
            this.panel7.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel5.Location = new System.Drawing.Point(23, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 60);
            this.panel5.TabIndex = 13;
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnRegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            this.btnRegistrarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnRegistrarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(27, 2);
            this.btnRegistrarUsuario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(189, 61);
            this.btnRegistrarUsuario.TabIndex = 11;
            this.btnRegistrarUsuario.Text = "Usuario";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnAgregarF_Click);
            // 
            // btnRegistrarMaterial
            // 
            this.btnRegistrarMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnRegistrarMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarMaterial.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnRegistrarMaterial.FlatAppearance.BorderSize = 0;
            this.btnRegistrarMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnRegistrarMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRegistrarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarMaterial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarMaterial.Location = new System.Drawing.Point(27, 66);
            this.btnRegistrarMaterial.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRegistrarMaterial.Name = "btnRegistrarMaterial";
            this.btnRegistrarMaterial.Size = new System.Drawing.Size(189, 61);
            this.btnRegistrarMaterial.TabIndex = 12;
            this.btnRegistrarMaterial.Text = "Material";
            this.btnRegistrarMaterial.UseVisualStyleBackColor = false;
            this.btnRegistrarMaterial.Click += new System.EventHandler(this.btnEditarF_Click);
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
            this.btnAbrirSubM.Location = new System.Drawing.Point(4, 284);
            this.btnAbrirSubM.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAbrirSubM.Name = "btnAbrirSubM";
            this.btnAbrirSubM.Size = new System.Drawing.Size(216, 60);
            this.btnAbrirSubM.TabIndex = 8;
            this.btnAbrirSubM.Text = "Registrar";
            this.btnAbrirSubM.UseVisualStyleBackColor = false;
            this.btnAbrirSubM.Visible = false;
            this.btnAbrirSubM.Click += new System.EventHandler(this.btnEditF_Click);
            // 
            // pEditF
            // 
            this.pEditF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pEditF.Location = new System.Drawing.Point(0, 285);
            this.pEditF.Margin = new System.Windows.Forms.Padding(4);
            this.pEditF.Name = "pEditF";
            this.pEditF.Size = new System.Drawing.Size(10, 60);
            this.pEditF.TabIndex = 11;
            this.pEditF.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel4.Location = new System.Drawing.Point(0, 127);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 46);
            this.panel4.TabIndex = 7;
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnPrestamos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestamos.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnPrestamos.FlatAppearance.BorderSize = 0;
            this.btnPrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.ForeColor = System.Drawing.Color.White;
            this.btnPrestamos.Location = new System.Drawing.Point(4, 127);
            this.btnPrestamos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(216, 46);
            this.btnPrestamos.TabIndex = 6;
            this.btnPrestamos.Text = "Prestamos";
            this.btnPrestamos.UseVisualStyleBackColor = false;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(0, 176);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 46);
            this.panel1.TabIndex = 3;
            // 
            // btnBuscarMaterial
            // 
            this.btnBuscarMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnBuscarMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarMaterial.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnBuscarMaterial.FlatAppearance.BorderSize = 0;
            this.btnBuscarMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnBuscarMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMaterial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnBuscarMaterial.Location = new System.Drawing.Point(4, 178);
            this.btnBuscarMaterial.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBuscarMaterial.Name = "btnBuscarMaterial";
            this.btnBuscarMaterial.Size = new System.Drawing.Size(216, 46);
            this.btnBuscarMaterial.TabIndex = 0;
            this.btnBuscarMaterial.Text = "Buscar Material";
            this.btnBuscarMaterial.UseVisualStyleBackColor = false;
            // 
            // btnCartelera
            // 
            this.btnCartelera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(13)))));
            this.btnCartelera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCartelera.Image = ((System.Drawing.Image)(resources.GetObject("btnCartelera.Image")));
            this.btnCartelera.Location = new System.Drawing.Point(58, 4);
            this.btnCartelera.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCartelera.Name = "btnCartelera";
            this.btnCartelera.Size = new System.Drawing.Size(117, 104);
            this.btnCartelera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCartelera.TabIndex = 0;
            this.btnCartelera.TabStop = false;
            // 
            // P_contenido
            // 
            this.P_contenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.P_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_contenido.Location = new System.Drawing.Point(251, 48);
            this.P_contenido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.P_contenido.Name = "P_contenido";
            this.P_contenido.Size = new System.Drawing.Size(949, 554);
            this.P_contenido.TabIndex = 2;
            this.P_contenido.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_contenido_MouseDown);
            // 
            // btnCerrarSes
            // 
            this.btnCerrarSes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(13)))));
            this.btnCerrarSes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(13)))));
            this.btnCerrarSes.BorderColor = System.Drawing.Color.Black;
            this.btnCerrarSes.BorderRadius = 40;
            this.btnCerrarSes.BorderSize = 0;
            this.btnCerrarSes.FlatAppearance.BorderSize = 0;
            this.btnCerrarSes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSes.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSes.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSes.Location = new System.Drawing.Point(868, 3);
            this.btnCerrarSes.Name = "btnCerrarSes";
            this.btnCerrarSes.Size = new System.Drawing.Size(171, 40);
            this.btnCerrarSes.TabIndex = 11;
            this.btnCerrarSes.Text = "Cerrar Sesión";
            this.btnCerrarSes.TextColor = System.Drawing.Color.White;
            this.btnCerrarSes.UseVisualStyleBackColor = false;
            this.btnCerrarSes.Click += new System.EventHandler(this.btnCerrarSes_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(13)))));
            this.btnIniciarSesion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(13)))));
            this.btnIniciarSesion.BorderColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.BorderRadius = 40;
            this.btnIniciarSesion.BorderSize = 0;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(868, 5);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(171, 40);
            this.btnIniciarSesion.TabIndex = 10;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.TextColor = System.Drawing.Color.White;
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 602);
            this.Controls.Add(this.P_contenido);
            this.Controls.Add(this.P_Menu);
            this.Controls.Add(this.P_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.P_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.P_Menu.ResumeLayout(false);
            this.pSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCartelera)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Panel P_titulo;
        private PictureBox btnCerrar;
        private Panel P_Menu;
        private PictureBox btnMin;
        private PictureBox btnCartelera;
        private Button btnBuscarMaterial;
        private Panel panel1;
        private Panel panel4;
        private Button btnPrestamos;
        private Panel pEditF;
        private Button btnAbrirSubM;
        private Button btnRegistrarMaterial;
        private Button btnRegistrarUsuario;
        private Panel pSubMenu;
        private Panel panel7;
        private Panel panel5;
        private Panel panel6;
        private Button btnInformesEstadisticos;
        private Panel panel2;
        private Button btnRegistrarPresupuesto;
        private Panel P_contenido;
        private PictureBox btnvolver;
        private Classes.BotonesPersonalizados btnIniciarSesion;
        private Classes.BotonesPersonalizados btnCerrarSes;
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

