﻿
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
            this.Aaa = new System.Windows.Forms.Label();
            this.imagen1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rdbUno = new System.Windows.Forms.RadioButton();
            this.rdbDos = new System.Windows.Forms.RadioButton();
            this.rdbTres = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.imagen1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(245, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "¡Bienvenido a Biblioteca Mayor!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Aaa
            // 
            this.Aaa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aaa.AutoSize = true;
            this.Aaa.Location = new System.Drawing.Point(230, 166);
            this.Aaa.Name = "Aaa";
            this.Aaa.Size = new System.Drawing.Size(16, 17);
            this.Aaa.TabIndex = 1;
            this.Aaa.Text = "0";
            // 
            // imagen1
            // 
            this.imagen1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imagen1.Image = global::wfBiblioteca.Properties.Resources.descarga;
            this.imagen1.Location = new System.Drawing.Point(223, 145);
            this.imagen1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagen1.Name = "imagen1";
            this.imagen1.Size = new System.Drawing.Size(550, 284);
            this.imagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen1.TabIndex = 0;
            this.imagen1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rdbUno
            // 
            this.rdbUno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbUno.AutoSize = true;
            this.rdbUno.Checked = true;
            this.rdbUno.Location = new System.Drawing.Point(459, 448);
            this.rdbUno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbUno.Name = "rdbUno";
            this.rdbUno.Size = new System.Drawing.Size(17, 16);
            this.rdbUno.TabIndex = 3;
            this.rdbUno.TabStop = true;
            this.rdbUno.UseVisualStyleBackColor = true;
            // 
            // rdbDos
            // 
            this.rdbDos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbDos.AutoSize = true;
            this.rdbDos.Location = new System.Drawing.Point(491, 448);
            this.rdbDos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbDos.Name = "rdbDos";
            this.rdbDos.Size = new System.Drawing.Size(17, 16);
            this.rdbDos.TabIndex = 4;
            this.rdbDos.UseVisualStyleBackColor = true;
            // 
            // rdbTres
            // 
            this.rdbTres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbTres.AutoSize = true;
            this.rdbTres.Location = new System.Drawing.Point(523, 448);
            this.rdbTres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbTres.Name = "rdbTres";
            this.rdbTres.Size = new System.Drawing.Size(17, 16);
            this.rdbTres.TabIndex = 5;
            this.rdbTres.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(955, 561);
            this.Controls.Add(this.rdbTres);
            this.Controls.Add(this.imagen1);
            this.Controls.Add(this.rdbDos);
            this.Controls.Add(this.rdbUno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Aaa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagen1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imagen1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Aaa;
        private System.Windows.Forms.RadioButton rdbUno;
        private System.Windows.Forms.RadioButton rdbDos;
        private System.Windows.Forms.RadioButton rdbTres;
    }
}