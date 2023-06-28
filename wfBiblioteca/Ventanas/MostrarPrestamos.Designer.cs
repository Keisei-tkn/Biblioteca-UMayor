
namespace wfBiblioteca.Ventanas
{
    partial class MostrarPrestamos
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
            this.lsvPrestamos = new System.Windows.Forms.ListView();
            this.cID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMaterial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cFechaDevolucion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAtrasado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMulta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(718, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prestamos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsvPrestamos
            // 
            this.lsvPrestamos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cID,
            this.cUsuario,
            this.cMaterial,
            this.cFechaDevolucion,
            this.cAtrasado,
            this.cMulta});
            this.lsvPrestamos.HideSelection = false;
            this.lsvPrestamos.Location = new System.Drawing.Point(45, 56);
            this.lsvPrestamos.Name = "lsvPrestamos";
            this.lsvPrestamos.Size = new System.Drawing.Size(630, 350);
            this.lsvPrestamos.TabIndex = 3;
            this.lsvPrestamos.UseCompatibleStateImageBehavior = false;
            this.lsvPrestamos.View = System.Windows.Forms.View.Details;
            this.lsvPrestamos.Click += new System.EventHandler(this.lsvPrestamos_SelectedIndexChanged);
            // 
            // cID
            // 
            this.cID.Text = "ID";
            this.cID.Width = 105;
            // 
            // cUsuario
            // 
            this.cUsuario.Text = "Usuario";
            this.cUsuario.Width = 105;
            // 
            // cMaterial
            // 
            this.cMaterial.Text = "Material";
            this.cMaterial.Width = 105;
            // 
            // cFechaDevolucion
            // 
            this.cFechaDevolucion.Text = "Fecha Devolucion";
            this.cFechaDevolucion.Width = 105;
            // 
            // cAtrasado
            // 
            this.cAtrasado.Text = "¿Atrasado?";
            this.cAtrasado.Width = 105;
            // 
            // cMulta
            // 
            this.cMulta.Text = "Multa";
            this.cMulta.Width = 105;
            // 
            // MostrarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(716, 456);
            this.Controls.Add(this.lsvPrestamos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MostrarPrestamos";
            this.Text = "MostrarPrestamos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvPrestamos;
        private System.Windows.Forms.ColumnHeader cID;
        private System.Windows.Forms.ColumnHeader cUsuario;
        private System.Windows.Forms.ColumnHeader cMaterial;
        private System.Windows.Forms.ColumnHeader cFechaDevolucion;
        private System.Windows.Forms.ColumnHeader cAtrasado;
        private System.Windows.Forms.ColumnHeader cMulta;
    }
}