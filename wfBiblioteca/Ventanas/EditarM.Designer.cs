
namespace wfBiblioteca.Ventanas
{
    partial class EditarM
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
            this.btnExaminar = new System.Windows.Forms.Button();
            this.ptbPoster = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvPeliculas = new System.Windows.Forms.ListView();
            this.Ccodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ctitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEliminar2 = new System.Windows.Forms.Button();
            this.btnActualizar2 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.brnEliminar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContraJefe = new System.Windows.Forms.TextBox();
            this.lblJefe = new System.Windows.Forms.Label();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPremios = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboRestriccion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExaminar
            // 
            this.btnExaminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExaminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnExaminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnExaminar.FlatAppearance.BorderSize = 0;
            this.btnExaminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnExaminar.ForeColor = System.Drawing.Color.White;
            this.btnExaminar.Location = new System.Drawing.Point(48, 364);
            this.btnExaminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(118, 40);
            this.btnExaminar.TabIndex = 85;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = false;
            // 
            // ptbPoster
            // 
            this.ptbPoster.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbPoster.BackColor = System.Drawing.Color.Transparent;
            this.ptbPoster.Location = new System.Drawing.Point(22, 124);
            this.ptbPoster.Name = "ptbPoster";
            this.ptbPoster.Size = new System.Drawing.Size(156, 231);
            this.ptbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPoster.TabIndex = 84;
            this.ptbPoster.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(234, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 86;
            this.label1.Text = "Editar/Modificar Material";
            // 
            // lsvPeliculas
            // 
            this.lsvPeliculas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lsvPeliculas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ccodigo,
            this.Ctitulo});
            this.lsvPeliculas.HideSelection = false;
            this.lsvPeliculas.Location = new System.Drawing.Point(519, 119);
            this.lsvPeliculas.Name = "lsvPeliculas";
            this.lsvPeliculas.Size = new System.Drawing.Size(208, 255);
            this.lsvPeliculas.TabIndex = 87;
            this.lsvPeliculas.UseCompatibleStateImageBehavior = false;
            this.lsvPeliculas.View = System.Windows.Forms.View.Details;
            // 
            // Ccodigo
            // 
            this.Ccodigo.Text = "Codigo";
            this.Ccodigo.Width = 50;
            // 
            // Ctitulo
            // 
            this.Ctitulo.Text = "Titulo";
            this.Ctitulo.Width = 164;
            // 
            // btnEliminar2
            // 
            this.btnEliminar2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnEliminar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar2.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEliminar2.FlatAppearance.BorderSize = 0;
            this.btnEliminar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEliminar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnEliminar2.ForeColor = System.Drawing.Color.White;
            this.btnEliminar2.Location = new System.Drawing.Point(375, 392);
            this.btnEliminar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar2.Name = "btnEliminar2";
            this.btnEliminar2.Size = new System.Drawing.Size(118, 37);
            this.btnEliminar2.TabIndex = 91;
            this.btnEliminar2.Text = "Eliminar";
            this.btnEliminar2.UseVisualStyleBackColor = false;
            this.btnEliminar2.Visible = false;
            // 
            // btnActualizar2
            // 
            this.btnActualizar2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnActualizar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar2.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnActualizar2.FlatAppearance.BorderSize = 0;
            this.btnActualizar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnActualizar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnActualizar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnActualizar2.ForeColor = System.Drawing.Color.White;
            this.btnActualizar2.Location = new System.Drawing.Point(515, 392);
            this.btnActualizar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar2.Name = "btnActualizar2";
            this.btnActualizar2.Size = new System.Drawing.Size(118, 37);
            this.btnActualizar2.TabIndex = 90;
            this.btnActualizar2.Text = "Actualizar";
            this.btnActualizar2.UseVisualStyleBackColor = false;
            this.btnActualizar2.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizar.BackColor = System.Drawing.Color.DarkRed;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(515, 392);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(118, 37);
            this.btnActualizar.TabIndex = 89;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // brnEliminar
            // 
            this.brnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.brnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.brnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.brnEliminar.FlatAppearance.BorderSize = 0;
            this.brnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.brnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.brnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnEliminar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.brnEliminar.ForeColor = System.Drawing.Color.White;
            this.brnEliminar.Location = new System.Drawing.Point(375, 392);
            this.brnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brnEliminar.Name = "brnEliminar";
            this.brnEliminar.Size = new System.Drawing.Size(118, 37);
            this.brnEliminar.TabIndex = 88;
            this.brnEliminar.Text = "Eliminar";
            this.brnEliminar.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(206, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 92;
            this.label8.Text = "Titulo ";
            // 
            // cboEstado
            // 
            this.cboEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(210, 203);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(148, 28);
            this.cboEstado.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(206, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 94;
            this.label4.Text = "Estado";
            // 
            // txtContraJefe
            // 
            this.txtContraJefe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContraJefe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraJefe.Location = new System.Drawing.Point(210, 329);
            this.txtContraJefe.Name = "txtContraJefe";
            this.txtContraJefe.Size = new System.Drawing.Size(169, 26);
            this.txtContraJefe.TabIndex = 97;
            this.txtContraJefe.Visible = false;
            // 
            // lblJefe
            // 
            this.lblJefe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblJefe.AutoSize = true;
            this.lblJefe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJefe.ForeColor = System.Drawing.Color.White;
            this.lblJefe.Location = new System.Drawing.Point(207, 304);
            this.lblJefe.Name = "lblJefe";
            this.lblJefe.Size = new System.Drawing.Size(174, 20);
            this.lblJefe.TabIndex = 96;
            this.lblJefe.Text = "Ingrese Su Contraseña";
            this.lblJefe.Visible = false;
            // 
            // cboCat
            // 
            this.cboCat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(210, 260);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(163, 28);
            this.cboCat.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(208, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 98;
            this.label5.Text = "Categoria";
            // 
            // txtPremios
            // 
            this.txtPremios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPremios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPremios.Location = new System.Drawing.Point(393, 262);
            this.txtPremios.Name = "txtPremios";
            this.txtPremios.Size = new System.Drawing.Size(95, 26);
            this.txtPremios.TabIndex = 101;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(391, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 100;
            this.label12.Text = "N°Premios";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(210, 143);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(279, 26);
            this.lblTitulo.TabIndex = 102;
            // 
            // cboRestriccion
            // 
            this.cboRestriccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboRestriccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRestriccion.FormattingEnabled = true;
            this.cboRestriccion.Location = new System.Drawing.Point(369, 206);
            this.cboRestriccion.Name = "cboRestriccion";
            this.cboRestriccion.Size = new System.Drawing.Size(113, 28);
            this.cboRestriccion.TabIndex = 104;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(365, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 20);
            this.label10.TabIndex = 103;
            this.label10.Text = "Restriccion de Edad";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos de Imagen(*jpg)(*jpeg)(*png)|*jpg;*jpeg;*png";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 16);
            this.label6.TabIndex = 105;
            this.label6.Text = "Nota: Siempre volver a cargar el poster";
            // 
            // EditarM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(750, 456);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboRestriccion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtPremios);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboCat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContraJefe);
            this.Controls.Add(this.lblJefe);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEliminar2);
            this.Controls.Add(this.btnActualizar2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.brnEliminar);
            this.Controls.Add(this.lsvPeliculas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.ptbPoster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarM";
            this.Text = "EditarP";
            ((System.ComponentModel.ISupportInitialize)(this.ptbPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.PictureBox ptbPoster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvPeliculas;
        private System.Windows.Forms.ColumnHeader Ccodigo;
        private System.Windows.Forms.ColumnHeader Ctitulo;
        private System.Windows.Forms.Button btnEliminar2;
        private System.Windows.Forms.Button btnActualizar2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button brnEliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContraJefe;
        private System.Windows.Forms.Label lblJefe;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPremios;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboRestriccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
    }
}