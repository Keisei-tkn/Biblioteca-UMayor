
namespace wfBiblioteca.Ventanas
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imagen1 = new System.Windows.Forms.PictureBox();
            this.Aaa = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rdbUno = new System.Windows.Forms.RadioButton();
            this.rdbDos = new System.Windows.Forms.RadioButton();
            this.rdbTres = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(173, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "¡Bienvenido a Biblioteca Mayor!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.imagen1);
            this.panel1.Controls.Add(this.Aaa);
            this.panel1.Location = new System.Drawing.Point(152, 155);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 184);
            this.panel1.TabIndex = 2;
            // 
            // imagen1
            // 
            this.imagen1.Image = global::wfBiblioteca.Properties.Resources.descarga;
            this.imagen1.Location = new System.Drawing.Point(4, 2);
            this.imagen1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imagen1.Name = "imagen1";
            this.imagen1.Size = new System.Drawing.Size(407, 180);
            this.imagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagen1.TabIndex = 0;
            this.imagen1.TabStop = false;
            // 
            // Aaa
            // 
            this.Aaa.AutoSize = true;
            this.Aaa.Location = new System.Drawing.Point(16, 12);
            this.Aaa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Aaa.Name = "Aaa";
            this.Aaa.Size = new System.Drawing.Size(13, 13);
            this.Aaa.TabIndex = 1;
            this.Aaa.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rdbUno
            // 
            this.rdbUno.AutoSize = true;
            this.rdbUno.Checked = true;
            this.rdbUno.Location = new System.Drawing.Point(320, 344);
            this.rdbUno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbUno.Name = "rdbUno";
            this.rdbUno.Size = new System.Drawing.Size(14, 13);
            this.rdbUno.TabIndex = 3;
            this.rdbUno.TabStop = true;
            this.rdbUno.UseVisualStyleBackColor = true;
            // 
            // rdbDos
            // 
            this.rdbDos.AutoSize = true;
            this.rdbDos.Location = new System.Drawing.Point(344, 344);
            this.rdbDos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbDos.Name = "rdbDos";
            this.rdbDos.Size = new System.Drawing.Size(14, 13);
            this.rdbDos.TabIndex = 4;
            this.rdbDos.UseVisualStyleBackColor = true;
            // 
            // rdbTres
            // 
            this.rdbTres.AutoSize = true;
            this.rdbTres.Location = new System.Drawing.Point(368, 344);
            this.rdbTres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbTres.Name = "rdbTres";
            this.rdbTres.Size = new System.Drawing.Size(14, 13);
            this.rdbTres.TabIndex = 5;
            this.rdbTres.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(716, 456);
            this.Controls.Add(this.rdbTres);
            this.Controls.Add(this.rdbDos);
            this.Controls.Add(this.rdbUno);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imagen1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Aaa;
        private System.Windows.Forms.RadioButton rdbUno;
        private System.Windows.Forms.RadioButton rdbDos;
        private System.Windows.Forms.RadioButton rdbTres;
    }
}