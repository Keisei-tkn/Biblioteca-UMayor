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
            this.btnCartelera = new System.Windows.Forms.PictureBox();
            this.btnBuscarMaterial = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pEditF = new System.Windows.Forms.Panel();
            this.btnAbrirSubM = new System.Windows.Forms.Button();
            this.pSubMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegistrarPresupuesto = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.btnRegistrarMaterial = new System.Windows.Forms.Button();
            this.btnInformesEstadisticos = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.P_Menu = new System.Windows.Forms.Panel();
            this.pSubmenu2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnPresuEditar = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnUEditar = new System.Windows.Forms.Button();
            this.btnMatEditar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.P_contenido = new System.Windows.Forms.Panel();
            this.btnIniciarSesion = new wfBiblioteca.Classes.BotonesPersonalizados();
            this.btnCerrarSes = new wfBiblioteca.Classes.BotonesPersonalizados();
            this.P_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCartelera)).BeginInit();
            this.pSubMenu.SuspendLayout();
            this.P_Menu.SuspendLayout();
            this.pSubmenu2.SuspendLayout();
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
            this.P_titulo.Size = new System.Drawing.Size(1200, 49);
            this.P_titulo.TabIndex = 0;
            this.P_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_titulo_MouseDown);
            // 
            // btnvolver
            // 
            this.btnvolver.Image = global::wfBiblioteca.Properties.Resources.hogar;
            this.btnvolver.Location = new System.Drawing.Point(340, 6);
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
            // btnCartelera
            // 
            this.btnCartelera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(13)))));
            this.btnCartelera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCartelera.Image = ((System.Drawing.Image)(resources.GetObject("btnCartelera.Image")));
            this.btnCartelera.Location = new System.Drawing.Point(77, 2);
            this.btnCartelera.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCartelera.Name = "btnCartelera";
            this.btnCartelera.Size = new System.Drawing.Size(125, 111);
            this.btnCartelera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCartelera.TabIndex = 0;
            this.btnCartelera.TabStop = false;
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
            this.btnBuscarMaterial.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnBuscarMaterial.Location = new System.Drawing.Point(4, 180);
            this.btnBuscarMaterial.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBuscarMaterial.Name = "btnBuscarMaterial";
            this.btnBuscarMaterial.Size = new System.Drawing.Size(246, 46);
            this.btnBuscarMaterial.TabIndex = 0;
            this.btnBuscarMaterial.Text = "Buscar Material";
            this.btnBuscarMaterial.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(0, 178);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 46);
            this.panel1.TabIndex = 3;
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
            this.btnPrestamos.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.ForeColor = System.Drawing.Color.White;
            this.btnPrestamos.Location = new System.Drawing.Point(4, 129);
            this.btnPrestamos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(246, 46);
            this.btnPrestamos.TabIndex = 6;
            this.btnPrestamos.Text = "Prestamos";
            this.btnPrestamos.UseVisualStyleBackColor = false;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel4.Location = new System.Drawing.Point(0, 129);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 46);
            this.panel4.TabIndex = 7;
            // 
            // pEditF
            // 
            this.pEditF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pEditF.Location = new System.Drawing.Point(0, 287);
            this.pEditF.Margin = new System.Windows.Forms.Padding(4);
            this.pEditF.Name = "pEditF";
            this.pEditF.Size = new System.Drawing.Size(10, 60);
            this.pEditF.TabIndex = 11;
            this.pEditF.Visible = false;
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
            this.btnAbrirSubM.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirSubM.ForeColor = System.Drawing.Color.White;
            this.btnAbrirSubM.Location = new System.Drawing.Point(4, 288);
            this.btnAbrirSubM.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAbrirSubM.Name = "btnAbrirSubM";
            this.btnAbrirSubM.Size = new System.Drawing.Size(246, 59);
            this.btnAbrirSubM.TabIndex = 8;
            this.btnAbrirSubM.Text = "Registrar";
            this.btnAbrirSubM.UseVisualStyleBackColor = false;
            this.btnAbrirSubM.Visible = false;
            this.btnAbrirSubM.Click += new System.EventHandler(this.btnEditF_Click);
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
            this.pSubMenu.Location = new System.Drawing.Point(13, 353);
            this.pSubMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pSubMenu.Name = "pSubMenu";
            this.pSubMenu.Size = new System.Drawing.Size(237, 200);
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
            this.btnRegistrarPresupuesto.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPresupuesto.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPresupuesto.Location = new System.Drawing.Point(27, 131);
            this.btnRegistrarPresupuesto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRegistrarPresupuesto.Name = "btnRegistrarPresupuesto";
            this.btnRegistrarPresupuesto.Size = new System.Drawing.Size(206, 61);
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
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(27, 2);
            this.btnRegistrarUsuario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(206, 61);
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
            this.btnRegistrarMaterial.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarMaterial.Location = new System.Drawing.Point(27, 66);
            this.btnRegistrarMaterial.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRegistrarMaterial.Name = "btnRegistrarMaterial";
            this.btnRegistrarMaterial.Size = new System.Drawing.Size(206, 61);
            this.btnRegistrarMaterial.TabIndex = 12;
            this.btnRegistrarMaterial.Text = "Material";
            this.btnRegistrarMaterial.UseVisualStyleBackColor = false;
            this.btnRegistrarMaterial.Click += new System.EventHandler(this.btnEditarF_Click);
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
            this.btnInformesEstadisticos.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformesEstadisticos.ForeColor = System.Drawing.Color.White;
            this.btnInformesEstadisticos.Location = new System.Drawing.Point(4, 232);
            this.btnInformesEstadisticos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnInformesEstadisticos.Name = "btnInformesEstadisticos";
            this.btnInformesEstadisticos.Size = new System.Drawing.Size(246, 46);
            this.btnInformesEstadisticos.TabIndex = 14;
            this.btnInformesEstadisticos.Text = "Informes Estadísticos";
            this.btnInformesEstadisticos.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel6.Location = new System.Drawing.Point(0, 232);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 46);
            this.panel6.TabIndex = 15;
            // 
            // P_Menu
            // 
            this.P_Menu.AutoScroll = true;
            this.P_Menu.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.P_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(13)))));
            this.P_Menu.Controls.Add(this.pSubmenu2);
            this.P_Menu.Controls.Add(this.panel3);
            this.P_Menu.Controls.Add(this.btnEditar);
            this.P_Menu.Controls.Add(this.panel6);
            this.P_Menu.Controls.Add(this.btnInformesEstadisticos);
            this.P_Menu.Controls.Add(this.btnAbrirSubM);
            this.P_Menu.Controls.Add(this.pSubMenu);
            this.P_Menu.Controls.Add(this.pEditF);
            this.P_Menu.Controls.Add(this.panel4);
            this.P_Menu.Controls.Add(this.btnPrestamos);
            this.P_Menu.Controls.Add(this.panel1);
            this.P_Menu.Controls.Add(this.btnBuscarMaterial);
            this.P_Menu.Controls.Add(this.btnCartelera);
            this.P_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.P_Menu.Location = new System.Drawing.Point(0, 49);
            this.P_Menu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.P_Menu.Name = "P_Menu";
            this.P_Menu.Size = new System.Drawing.Size(291, 559);
            this.P_Menu.TabIndex = 1;
            this.P_Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_Menu_MouseDown);
            // 
            // pSubmenu2
            // 
            this.pSubmenu2.BackColor = System.Drawing.Color.Transparent;
            this.pSubmenu2.Controls.Add(this.panel9);
            this.pSubmenu2.Controls.Add(this.btnPresuEditar);
            this.pSubmenu2.Controls.Add(this.panel10);
            this.pSubmenu2.Controls.Add(this.panel11);
            this.pSubmenu2.Controls.Add(this.btnUEditar);
            this.pSubmenu2.Controls.Add(this.btnMatEditar);
            this.pSubmenu2.Location = new System.Drawing.Point(13, 625);
            this.pSubmenu2.Margin = new System.Windows.Forms.Padding(4);
            this.pSubmenu2.Name = "pSubmenu2";
            this.pSubmenu2.Size = new System.Drawing.Size(237, 200);
            this.pSubmenu2.TabIndex = 17;
            this.pSubmenu2.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel9.Location = new System.Drawing.Point(22, 131);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 61);
            this.panel9.TabIndex = 16;
            // 
            // btnPresuEditar
            // 
            this.btnPresuEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnPresuEditar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnPresuEditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnPresuEditar.FlatAppearance.BorderSize = 0;
            this.btnPresuEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnPresuEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPresuEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresuEditar.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresuEditar.ForeColor = System.Drawing.Color.White;
            this.btnPresuEditar.Location = new System.Drawing.Point(27, 131);
            this.btnPresuEditar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPresuEditar.Name = "btnPresuEditar";
            this.btnPresuEditar.Size = new System.Drawing.Size(206, 61);
            this.btnPresuEditar.TabIndex = 15;
            this.btnPresuEditar.Text = "Presupuesto";
            this.btnPresuEditar.UseVisualStyleBackColor = false;
            this.btnPresuEditar.UseWaitCursor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel10.Location = new System.Drawing.Point(23, 66);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 61);
            this.panel10.TabIndex = 14;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel11.Location = new System.Drawing.Point(23, 2);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 60);
            this.panel11.TabIndex = 13;
            // 
            // btnUEditar
            // 
            this.btnUEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnUEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUEditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnUEditar.FlatAppearance.BorderSize = 0;
            this.btnUEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnUEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUEditar.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUEditar.ForeColor = System.Drawing.Color.White;
            this.btnUEditar.Location = new System.Drawing.Point(27, 2);
            this.btnUEditar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnUEditar.Name = "btnUEditar";
            this.btnUEditar.Size = new System.Drawing.Size(206, 61);
            this.btnUEditar.TabIndex = 11;
            this.btnUEditar.Text = "Usuario";
            this.btnUEditar.UseVisualStyleBackColor = false;
            // 
            // btnMatEditar
            // 
            this.btnMatEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnMatEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatEditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnMatEditar.FlatAppearance.BorderSize = 0;
            this.btnMatEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnMatEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMatEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatEditar.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatEditar.ForeColor = System.Drawing.Color.White;
            this.btnMatEditar.Location = new System.Drawing.Point(27, 66);
            this.btnMatEditar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnMatEditar.Name = "btnMatEditar";
            this.btnMatEditar.Size = new System.Drawing.Size(206, 61);
            this.btnMatEditar.TabIndex = 12;
            this.btnMatEditar.Text = "Material";
            this.btnMatEditar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel3.Location = new System.Drawing.Point(0, 559);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 60);
            this.panel3.TabIndex = 12;
            this.panel3.Visible = false;
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
            this.btnEditar.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(4, 560);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(246, 59);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar/Eliminar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // P_contenido
            // 
            this.P_contenido.Location = new System.Drawing.Point(288, 49);
            this.P_contenido.Name = "P_contenido";
            this.P_contenido.Size = new System.Drawing.Size(912, 559);
            this.P_contenido.TabIndex = 2;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 608);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnCartelera)).EndInit();
            this.pSubMenu.ResumeLayout(false);
            this.P_Menu.ResumeLayout(false);
            this.pSubmenu2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private Panel P_titulo;
        private PictureBox btnCerrar;
        private PictureBox btnMin;
        private PictureBox btnvolver;
        public Classes.BotonesPersonalizados btnIniciarSesion;
        public Classes.BotonesPersonalizados btnCerrarSes;
        private PictureBox btnCartelera;
        public Button btnBuscarMaterial;
        private Panel panel1;
        public Button btnPrestamos;
        private Panel panel4;
        private Panel pEditF;
        public Button btnAbrirSubM;
        private Panel pSubMenu;
        private Panel panel2;
        public Button btnRegistrarPresupuesto;
        private Panel panel7;
        private Panel panel5;
        public Button btnRegistrarUsuario;
        public Button btnRegistrarMaterial;
        public Button btnInformesEstadisticos;
        private Panel panel6;
        private Panel P_Menu;
        private Panel pSubmenu2;
        private Panel panel9;
        public Button btnPresuEditar;
        private Panel panel10;
        private Panel panel11;
        public Button btnUEditar;
        public Button btnMatEditar;
        private Panel panel3;
        public Button btnEditar;
        private Panel P_contenido;
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

