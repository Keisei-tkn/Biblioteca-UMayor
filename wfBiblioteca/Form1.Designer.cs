﻿using System;
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
            this.P_Menu = new System.Windows.Forms.Panel();
            this.pSubmenu2 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEpre = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEUsuario = new System.Windows.Forms.Button();
            this.btnEMat = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pSubMenu = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnRegistarPresupuesto = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnRegistarUsuario = new System.Windows.Forms.Button();
            this.btnRegistarMaterial = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnInformesEstadisticos = new System.Windows.Forms.Button();
            this.btnBuscarMaterial = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnCartelera = new System.Windows.Forms.PictureBox();
            this.P_contenido = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnvolver = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIniciarSesion = new wfBiblioteca.Classes.BotonesPersonalizados();
            this.btnCerrarSes = new wfBiblioteca.Classes.BotonesPersonalizados();
            this.P_Menu.SuspendLayout();
            this.pSubmenu2.SuspendLayout();
            this.pSubMenu.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCartelera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_Menu
            // 
            this.P_Menu.AutoScroll = true;
            this.P_Menu.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.P_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(13)))));
            this.P_Menu.Controls.Add(this.pSubmenu2);
            this.P_Menu.Controls.Add(this.btnEditar);
            this.P_Menu.Controls.Add(this.pSubMenu);
            this.P_Menu.Controls.Add(this.btnRegistrar);
            this.P_Menu.Controls.Add(this.btnInformesEstadisticos);
            this.P_Menu.Controls.Add(this.btnBuscarMaterial);
            this.P_Menu.Controls.Add(this.btnPrestamos);
            this.P_Menu.Controls.Add(this.panel8);
            this.P_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.P_Menu.Location = new System.Drawing.Point(0, 0);
            this.P_Menu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.P_Menu.Name = "P_Menu";
            this.P_Menu.Size = new System.Drawing.Size(290, 546);
            this.P_Menu.TabIndex = 1;
            this.P_Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_Menu_MouseDown);
            // 
            // pSubmenu2
            // 
            this.pSubmenu2.BackColor = System.Drawing.Color.Transparent;
            this.pSubmenu2.Controls.Add(this.panel2);
            this.pSubmenu2.Controls.Add(this.btnEpre);
            this.pSubmenu2.Controls.Add(this.panel3);
            this.pSubmenu2.Controls.Add(this.panel4);
            this.pSubmenu2.Controls.Add(this.btnEUsuario);
            this.pSubmenu2.Controls.Add(this.btnEMat);
            this.pSubmenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubmenu2.Location = new System.Drawing.Point(0, 570);
            this.pSubmenu2.Margin = new System.Windows.Forms.Padding(4);
            this.pSubmenu2.Name = "pSubmenu2";
            this.pSubmenu2.Size = new System.Drawing.Size(269, 156);
            this.pSubmenu2.TabIndex = 19;
            this.pSubmenu2.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Location = new System.Drawing.Point(26, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 46);
            this.panel2.TabIndex = 16;
            // 
            // btnEpre
            // 
            this.btnEpre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnEpre.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnEpre.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEpre.FlatAppearance.BorderSize = 0;
            this.btnEpre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnEpre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEpre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEpre.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEpre.ForeColor = System.Drawing.Color.White;
            this.btnEpre.Location = new System.Drawing.Point(31, 105);
            this.btnEpre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEpre.Name = "btnEpre";
            this.btnEpre.Size = new System.Drawing.Size(240, 46);
            this.btnEpre.TabIndex = 15;
            this.btnEpre.Text = "Presupuesto";
            this.btnEpre.UseVisualStyleBackColor = false;
            this.btnEpre.UseWaitCursor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel3.Location = new System.Drawing.Point(25, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 46);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel4.Location = new System.Drawing.Point(25, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 46);
            this.panel4.TabIndex = 13;
            // 
            // btnEUsuario
            // 
            this.btnEUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnEUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEUsuario.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEUsuario.FlatAppearance.BorderSize = 0;
            this.btnEUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnEUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEUsuario.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEUsuario.ForeColor = System.Drawing.Color.White;
            this.btnEUsuario.Location = new System.Drawing.Point(29, 6);
            this.btnEUsuario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEUsuario.Name = "btnEUsuario";
            this.btnEUsuario.Size = new System.Drawing.Size(240, 46);
            this.btnEUsuario.TabIndex = 11;
            this.btnEUsuario.Text = "Usuario";
            this.btnEUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEMat
            // 
            this.btnEMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnEMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEMat.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEMat.FlatAppearance.BorderSize = 0;
            this.btnEMat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnEMat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEMat.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEMat.ForeColor = System.Drawing.Color.White;
            this.btnEMat.Location = new System.Drawing.Point(29, 55);
            this.btnEMat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEMat.Name = "btnEMat";
            this.btnEMat.Size = new System.Drawing.Size(240, 46);
            this.btnEMat.TabIndex = 12;
            this.btnEMat.Text = "Material";
            this.btnEMat.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(0, 511);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(269, 59);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar/Eliminar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // pSubMenu
            // 
            this.pSubMenu.BackColor = System.Drawing.Color.Transparent;
            this.pSubMenu.Controls.Add(this.panel13);
            this.pSubMenu.Controls.Add(this.btnRegistarPresupuesto);
            this.pSubMenu.Controls.Add(this.panel14);
            this.pSubMenu.Controls.Add(this.panel15);
            this.pSubMenu.Controls.Add(this.btnRegistarUsuario);
            this.pSubMenu.Controls.Add(this.btnRegistarMaterial);
            this.pSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubMenu.Location = new System.Drawing.Point(0, 348);
            this.pSubMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pSubMenu.Name = "pSubMenu";
            this.pSubMenu.Size = new System.Drawing.Size(269, 163);
            this.pSubMenu.TabIndex = 17;
            this.pSubMenu.Visible = false;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel13.Location = new System.Drawing.Point(24, 104);
            this.panel13.Margin = new System.Windows.Forms.Padding(4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(7, 46);
            this.panel13.TabIndex = 16;
            // 
            // btnRegistarPresupuesto
            // 
            this.btnRegistarPresupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnRegistarPresupuesto.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnRegistarPresupuesto.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnRegistarPresupuesto.FlatAppearance.BorderSize = 0;
            this.btnRegistarPresupuesto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnRegistarPresupuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRegistarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistarPresupuesto.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistarPresupuesto.ForeColor = System.Drawing.Color.White;
            this.btnRegistarPresupuesto.Location = new System.Drawing.Point(29, 104);
            this.btnRegistarPresupuesto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRegistarPresupuesto.Name = "btnRegistarPresupuesto";
            this.btnRegistarPresupuesto.Size = new System.Drawing.Size(240, 46);
            this.btnRegistarPresupuesto.TabIndex = 15;
            this.btnRegistarPresupuesto.Text = "Presupuesto";
            this.btnRegistarPresupuesto.UseVisualStyleBackColor = false;
            this.btnRegistarPresupuesto.UseWaitCursor = true;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel14.Location = new System.Drawing.Point(25, 54);
            this.panel14.Margin = new System.Windows.Forms.Padding(4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(7, 46);
            this.panel14.TabIndex = 14;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel15.Location = new System.Drawing.Point(25, 4);
            this.panel15.Margin = new System.Windows.Forms.Padding(4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(7, 46);
            this.panel15.TabIndex = 13;
            // 
            // btnRegistarUsuario
            // 
            this.btnRegistarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnRegistarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnRegistarUsuario.FlatAppearance.BorderSize = 0;
            this.btnRegistarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnRegistarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRegistarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistarUsuario.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnRegistarUsuario.Location = new System.Drawing.Point(29, 4);
            this.btnRegistarUsuario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRegistarUsuario.Name = "btnRegistarUsuario";
            this.btnRegistarUsuario.Size = new System.Drawing.Size(240, 46);
            this.btnRegistarUsuario.TabIndex = 11;
            this.btnRegistarUsuario.Text = "Usuario";
            this.btnRegistarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnRegistarMaterial
            // 
            this.btnRegistarMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnRegistarMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistarMaterial.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnRegistarMaterial.FlatAppearance.BorderSize = 0;
            this.btnRegistarMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnRegistarMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRegistarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistarMaterial.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnRegistarMaterial.Location = new System.Drawing.Point(29, 54);
            this.btnRegistarMaterial.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRegistarMaterial.Name = "btnRegistarMaterial";
            this.btnRegistarMaterial.Size = new System.Drawing.Size(240, 46);
            this.btnRegistarMaterial.TabIndex = 12;
            this.btnRegistarMaterial.Text = "Material";
            this.btnRegistarMaterial.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(0, 302);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(269, 46);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnInformesEstadisticos
            // 
            this.btnInformesEstadisticos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnInformesEstadisticos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformesEstadisticos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformesEstadisticos.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnInformesEstadisticos.FlatAppearance.BorderSize = 0;
            this.btnInformesEstadisticos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnInformesEstadisticos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnInformesEstadisticos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformesEstadisticos.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformesEstadisticos.ForeColor = System.Drawing.Color.White;
            this.btnInformesEstadisticos.Location = new System.Drawing.Point(0, 256);
            this.btnInformesEstadisticos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnInformesEstadisticos.Name = "btnInformesEstadisticos";
            this.btnInformesEstadisticos.Size = new System.Drawing.Size(269, 46);
            this.btnInformesEstadisticos.TabIndex = 18;
            this.btnInformesEstadisticos.Text = "Informes Estadísticos";
            this.btnInformesEstadisticos.UseVisualStyleBackColor = false;
            // 
            // btnBuscarMaterial
            // 
            this.btnBuscarMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnBuscarMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarMaterial.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnBuscarMaterial.FlatAppearance.BorderSize = 0;
            this.btnBuscarMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnBuscarMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMaterial.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnBuscarMaterial.Location = new System.Drawing.Point(0, 210);
            this.btnBuscarMaterial.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBuscarMaterial.Name = "btnBuscarMaterial";
            this.btnBuscarMaterial.Size = new System.Drawing.Size(269, 46);
            this.btnBuscarMaterial.TabIndex = 18;
            this.btnBuscarMaterial.Text = "Buscar Material";
            this.btnBuscarMaterial.UseVisualStyleBackColor = false;
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnPrestamos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrestamos.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnPrestamos.FlatAppearance.BorderSize = 0;
            this.btnPrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamos.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.ForeColor = System.Drawing.Color.White;
            this.btnPrestamos.Location = new System.Drawing.Point(0, 164);
            this.btnPrestamos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(269, 46);
            this.btnPrestamos.TabIndex = 18;
            this.btnPrestamos.Text = "Prestamos";
            this.btnPrestamos.UseVisualStyleBackColor = false;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnCartelera);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(269, 164);
            this.panel8.TabIndex = 0;
            // 
            // btnCartelera
            // 
            this.btnCartelera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(13)))));
            this.btnCartelera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCartelera.Image = ((System.Drawing.Image)(resources.GetObject("btnCartelera.Image")));
            this.btnCartelera.Location = new System.Drawing.Point(85, 29);
            this.btnCartelera.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCartelera.Name = "btnCartelera";
            this.btnCartelera.Size = new System.Drawing.Size(116, 110);
            this.btnCartelera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCartelera.TabIndex = 0;
            this.btnCartelera.TabStop = false;
            // 
            // P_contenido
            // 
            this.P_contenido.Location = new System.Drawing.Point(290, 50);
            this.P_contenido.Name = "P_contenido";
            this.P_contenido.Size = new System.Drawing.Size(910, 496);
            this.P_contenido.TabIndex = 2;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = global::wfBiblioteca.Properties.Resources.minimizar_signo;
            this.btnMin.Location = new System.Drawing.Point(833, 11);
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
            this.btnCerrar.Location = new System.Drawing.Point(878, 11);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 27);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Image = global::wfBiblioteca.Properties.Resources.hogar;
            this.btnvolver.Location = new System.Drawing.Point(88, 12);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(65, 39);
            this.btnvolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnvolver.TabIndex = 10;
            this.btnvolver.TabStop = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.btnIniciarSesion);
            this.panel1.Controls.Add(this.btnvolver);
            this.panel1.Controls.Add(this.btnCerrarSes);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Location = new System.Drawing.Point(290, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 52);
            this.panel1.TabIndex = 3;
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
            this.btnIniciarSesion.Location = new System.Drawing.Point(533, 9);
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
            this.btnCerrarSes.Location = new System.Drawing.Point(533, 9);
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
            this.ClientSize = new System.Drawing.Size(1200, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.P_contenido);
            this.Controls.Add(this.P_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.P_Menu.ResumeLayout(false);
            this.pSubmenu2.ResumeLayout(false);
            this.pSubMenu.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCartelera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private Panel P_Menu;
        private Panel P_contenido;
        private PictureBox btnCartelera;
        private Panel pSubmenu2;
        private Panel panel2;
        public Button btnEpre;
        private Panel panel3;
        private Panel panel4;
        public Button btnEUsuario;
        public Button btnEMat;
        public Button btnEditar;
        private Panel pSubMenu;
        private Panel panel13;
        public Button btnRegistarPresupuesto;
        private Panel panel14;
        private Panel panel15;
        public Button btnRegistarUsuario;
        public Button btnRegistarMaterial;
        public Button btnRegistrar;
        public Button btnInformesEstadisticos;
        public Button btnBuscarMaterial;
        public Button btnPrestamos;
        private Panel panel8;
        private Panel panel1;
        private PictureBox btnvolver;
        private PictureBox btnCerrar;
        private PictureBox btnMin;
        public Classes.BotonesPersonalizados btnIniciarSesion;
        public Classes.BotonesPersonalizados btnCerrarSes;
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

