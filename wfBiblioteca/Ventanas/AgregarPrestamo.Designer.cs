
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
            this.lsvUsuarios = new System.Windows.Forms.ListView();
            this.cCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cRut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.cboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoMaterial = new System.Windows.Forms.ComboBox();
            this.cApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(932, 46);
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
            this.lsvMaterial.Location = new System.Drawing.Point(591, 198);
            this.lsvMaterial.Name = "lsvMaterial";
            this.lsvMaterial.Size = new System.Drawing.Size(309, 309);
            this.lsvMaterial.TabIndex = 5;
            this.lsvMaterial.UseCompatibleStateImageBehavior = false;
            this.lsvMaterial.View = System.Windows.Forms.View.Details;
            // 
            // lsvUsuarios
            // 
            this.lsvUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cRut,
            this.cNombre,
            this.cApellido});
            this.lsvUsuarios.HideSelection = false;
            this.lsvUsuarios.Location = new System.Drawing.Point(49, 198);
            this.lsvUsuarios.Name = "lsvUsuarios";
            this.lsvUsuarios.Size = new System.Drawing.Size(307, 309);
            this.lsvUsuarios.TabIndex = 6;
            this.lsvUsuarios.UseCompatibleStateImageBehavior = false;
            this.lsvUsuarios.View = System.Windows.Forms.View.Details;
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
            this.btnPrestamo.Location = new System.Drawing.Point(392, 335);
            this.btnPrestamo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(157, 52);
            this.btnPrestamo.TabIndex = 93;
            this.btnPrestamo.Text = "Registrar";
            this.btnPrestamo.UseVisualStyleBackColor = false;
            this.btnPrestamo.Visible = false;
            // 
            // cboTipoUsuario
            // 
            this.cboTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoUsuario.FormattingEnabled = true;
            this.cboTipoUsuario.Location = new System.Drawing.Point(50, 154);
            this.cboTipoUsuario.Name = "cboTipoUsuario";
            this.cboTipoUsuario.Size = new System.Drawing.Size(181, 28);
            this.cboTipoUsuario.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 95;
            this.label2.Text = "Tipo de Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(588, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 97;
            this.label3.Text = "Tipo de Material:";
            // 
            // cboTipoMaterial
            // 
            this.cboTipoMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoMaterial.FormattingEnabled = true;
            this.cboTipoMaterial.Location = new System.Drawing.Point(591, 154);
            this.cboTipoMaterial.Name = "cboTipoMaterial";
            this.cboTipoMaterial.Size = new System.Drawing.Size(181, 28);
            this.cboTipoMaterial.TabIndex = 96;
            // 
            // cApellido
            // 
            this.cApellido.Text = "Apellido";
            this.cApellido.Width = 95;
            // 
            // AgregarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(937, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTipoMaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTipoUsuario);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.lsvUsuarios);
            this.Controls.Add(this.lsvMaterial);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}