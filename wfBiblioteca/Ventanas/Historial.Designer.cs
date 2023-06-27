
namespace wfBiblioteca.Ventanas
{
    partial class Historial
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
            this.lsvHistorial = new System.Windows.Forms.ListView();
            this.cFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(957, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsvHistorial
            // 
            this.lsvHistorial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cFecha,
            this.cTitulo});
            this.lsvHistorial.HideSelection = false;
            this.lsvHistorial.Location = new System.Drawing.Point(220, 107);
            this.lsvHistorial.Name = "lsvHistorial";
            this.lsvHistorial.Size = new System.Drawing.Size(517, 416);
            this.lsvHistorial.TabIndex = 1;
            this.lsvHistorial.UseCompatibleStateImageBehavior = false;
            this.lsvHistorial.View = System.Windows.Forms.View.Details;
            // 
            // cFecha
            // 
            this.cFecha.Text = "Fecha";
            // 
            // cTitulo
            // 
            this.cTitulo.Text = "Titulo";
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(955, 561);
            this.Controls.Add(this.lsvHistorial);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historial";
            this.Text = "Historial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvHistorial;
        private System.Windows.Forms.ColumnHeader cFecha;
        private System.Windows.Forms.ColumnHeader cTitulo;
    }
}