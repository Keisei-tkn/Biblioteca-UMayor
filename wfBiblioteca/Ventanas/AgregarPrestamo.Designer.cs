
namespace wfBiblioteca.Ventanas
{
    partial class AgregarPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lsvMaterial = new System.Windows.Forms.ListView();
            this.cCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvUsuarios = new System.Windows.Forms.ListView();
            this.cRut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.cboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoMaterial = new System.Windows.Forms.ComboBox();
            this.LblMaterial = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnPrestamo1 = new System.Windows.Forms.Button();
            this.txtContraSeguridad = new System.Windows.Forms.TextBox();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agregar Prestamo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsvMaterial
            // 
            this.lsvMaterial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cCodigo,
            this.cTitulo});
            this.lsvMaterial.HideSelection = false;
            this.lsvMaterial.Location = new System.Drawing.Point(41, 294);
            this.lsvMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.lsvMaterial.Name = "lsvMaterial";
            this.lsvMaterial.Size = new System.Drawing.Size(338, 107);
            this.lsvMaterial.TabIndex = 5;
            this.lsvMaterial.UseCompatibleStateImageBehavior = false;
            this.lsvMaterial.View = System.Windows.Forms.View.Details;
            this.lsvMaterial.Click += new System.EventHandler(this.lsvMaterial_Click);
            // 
            // cCodigo
            // 
            this.cCodigo.Text = "Codigo";
            this.cCodigo.Width = 97;
            // 
            // cTitulo
            // 
            this.cTitulo.Text = "Titulo";
            this.cTitulo.Width = 197;
            // 
            // lsvUsuarios
            // 
            this.lsvUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cRut,
            this.cNombre,
            this.cApellido});
            this.lsvUsuarios.HideSelection = false;
            this.lsvUsuarios.Location = new System.Drawing.Point(41, 126);
            this.lsvUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.lsvUsuarios.Name = "lsvUsuarios";
            this.lsvUsuarios.Size = new System.Drawing.Size(338, 107);
            this.lsvUsuarios.TabIndex = 6;
            this.lsvUsuarios.UseCompatibleStateImageBehavior = false;
            this.lsvUsuarios.View = System.Windows.Forms.View.Details;
            this.lsvUsuarios.Click += new System.EventHandler(this.lsvUsuarios_Click);
            // 
            // cRut
            // 
            this.cRut.Text = "Rut";
            this.cRut.Width = 95;
            // 
            // cNombre
            // 
            this.cNombre.Text = "Nombre";
            this.cNombre.Width = 110;
            // 
            // cApellido
            // 
            this.cApellido.Text = "Apellido";
            this.cApellido.Width = 95;
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnPrestamo.FlatAppearance.BorderSize = 0;
            this.btnPrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnPrestamo.Location = new System.Drawing.Point(456, 325);
            this.btnPrestamo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(149, 66);
            this.btnPrestamo.TabIndex = 93;
            this.btnPrestamo.Text = "Registrar Prestamo";
            this.btnPrestamo.UseVisualStyleBackColor = false;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // cboTipoUsuario
            // 
            this.cboTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoUsuario.FormattingEnabled = true;
            this.cboTipoUsuario.Location = new System.Drawing.Point(41, 82);
            this.cboTipoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoUsuario.Name = "cboTipoUsuario";
            this.cboTipoUsuario.Size = new System.Drawing.Size(136, 25);
            this.cboTipoUsuario.TabIndex = 94;
            this.cboTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cboTipoUsuario_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 95;
            this.label2.Text = "Tipo de Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 97;
            this.label3.Text = "Tipo de Material:";
            // 
            // cboTipoMaterial
            // 
            this.cboTipoMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoMaterial.FormattingEnabled = true;
            this.cboTipoMaterial.Location = new System.Drawing.Point(40, 258);
            this.cboTipoMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoMaterial.Name = "cboTipoMaterial";
            this.cboTipoMaterial.Size = new System.Drawing.Size(137, 25);
            this.cboTipoMaterial.TabIndex = 96;
            this.cboTipoMaterial.SelectedIndexChanged += new System.EventHandler(this.cboTipoMaterial_SelectedIndexChanged);
            // 
            // LblMaterial
            // 
            this.LblMaterial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblMaterial.AutoSize = true;
            this.LblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMaterial.ForeColor = System.Drawing.Color.White;
            this.LblMaterial.Location = new System.Drawing.Point(452, 203);
            this.LblMaterial.Name = "LblMaterial";
            this.LblMaterial.Size = new System.Drawing.Size(165, 20);
            this.LblMaterial.TabIndex = 101;
            this.LblMaterial.Text = "Material Seleccionado";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(453, 126);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(164, 20);
            this.lblUser.TabIndex = 100;
            this.lblUser.Text = "Usuario Seleccionado";
            // 
            // lblM
            // 
            this.lblM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblM.BackColor = System.Drawing.Color.White;
            this.lblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.ForeColor = System.Drawing.Color.Black;
            this.lblM.Location = new System.Drawing.Point(453, 223);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(156, 28);
            this.lblM.TabIndex = 102;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(453, 146);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(156, 28);
            this.lblUsuario.TabIndex = 103;
            // 
            // btnPrestamo1
            // 
            this.btnPrestamo1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrestamo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnPrestamo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestamo1.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnPrestamo1.FlatAppearance.BorderSize = 0;
            this.btnPrestamo1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnPrestamo1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPrestamo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamo1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnPrestamo1.ForeColor = System.Drawing.Color.White;
            this.btnPrestamo1.Location = new System.Drawing.Point(456, 325);
            this.btnPrestamo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrestamo1.Name = "btnPrestamo1";
            this.btnPrestamo1.Size = new System.Drawing.Size(149, 66);
            this.btnPrestamo1.TabIndex = 104;
            this.btnPrestamo1.Text = "Registrar Prestamo";
            this.btnPrestamo1.UseVisualStyleBackColor = false;
            this.btnPrestamo1.Visible = false;
            this.btnPrestamo1.Click += new System.EventHandler(this.btnPrestamo1_Click);
            // 
            // txtContraSeguridad
            // 
            this.txtContraSeguridad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContraSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraSeguridad.Location = new System.Drawing.Point(450, 294);
            this.txtContraSeguridad.Name = "txtContraSeguridad";
            this.txtContraSeguridad.Size = new System.Drawing.Size(167, 26);
            this.txtContraSeguridad.TabIndex = 106;
            this.txtContraSeguridad.Visible = false;
            this.txtContraSeguridad.Enter += new System.EventHandler(this.txtContraSeguridad_Enter);
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacion.ForeColor = System.Drawing.Color.White;
            this.lblConfirmacion.Location = new System.Drawing.Point(446, 271);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(174, 20);
            this.lblConfirmacion.TabIndex = 105;
            this.lblConfirmacion.Text = "Ingrese Su Contraseña";
            this.lblConfirmacion.Visible = false;
            // 
            // AgregarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(703, 456);
            this.Controls.Add(this.txtContraSeguridad);
            this.Controls.Add(this.lblConfirmacion);
            this.Controls.Add(this.btnPrestamo1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.LblMaterial);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTipoMaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTipoUsuario);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.lsvUsuarios);
            this.Controls.Add(this.lsvMaterial);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarPrestamo";
            this.Text = "AgregarPrestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvMaterial;
        private System.Windows.Forms.ColumnHeader cCodigo;
        private System.Windows.Forms.ColumnHeader cTitulo;
        private System.Windows.Forms.ListView lsvUsuarios;
        private System.Windows.Forms.ColumnHeader cRut;
        private System.Windows.Forms.ColumnHeader cNombre;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.ComboBox cboTipoUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTipoMaterial;
        private System.Windows.Forms.ColumnHeader cApellido;
        private System.Windows.Forms.Label LblMaterial;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnPrestamo1;
        private System.Windows.Forms.TextBox txtContraSeguridad;
        private System.Windows.Forms.Label lblConfirmacion;
    }
}