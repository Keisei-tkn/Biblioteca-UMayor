
namespace wfBiblioteca.Ventanas
{
    partial class EditarU
    {/// <summary>
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
            this.label5 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRut = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cboTipoU = new System.Windows.Forms.ComboBox();
            this.btnActualizar2 = new System.Windows.Forms.Button();
            this.txtContraSeguridad = new System.Windows.Forms.TextBox();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.lblSede = new System.Windows.Forms.Label();
            this.txtSede = new System.Windows.Forms.TextBox();
            this.lblNucleo = new System.Windows.Forms.Label();
            this.lblVerificacion = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lsvUsuarios = new System.Windows.Forms.ListView();
            this.Funcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboDep = new System.Windows.Forms.ComboBox();
            this.lblRut1 = new System.Windows.Forms.Label();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblNom1 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtVerificacion = new System.Windows.Forms.TextBox();
            this.cboNucleo = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnEliminar2 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Editar Usuarios";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tipo de Usuario:*";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblApellido.BackColor = System.Drawing.Color.White;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.Black;
            this.lblApellido.Location = new System.Drawing.Point(243, 233);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(156, 28);
            this.lblApellido.TabIndex = 29;
            this.lblApellido.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(45, 233);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(156, 28);
            this.lblNombre.TabIndex = 28;
            this.lblNombre.Visible = false;
            // 
            // lblRut
            // 
            this.lblRut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRut.BackColor = System.Drawing.Color.White;
            this.lblRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRut.ForeColor = System.Drawing.Color.Black;
            this.lblRut.Location = new System.Drawing.Point(243, 159);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(156, 28);
            this.lblRut.TabIndex = 27;
            this.lblRut.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(506, 403);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(118, 37);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cboTipoU
            // 
            this.cboTipoU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTipoU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoU.FormattingEnabled = true;
            this.cboTipoU.Location = new System.Drawing.Point(47, 159);
            this.cboTipoU.Name = "cboTipoU";
            this.cboTipoU.Size = new System.Drawing.Size(169, 28);
            this.cboTipoU.TabIndex = 41;
            this.cboTipoU.SelectedIndexChanged += new System.EventHandler(this.cboTipoU_SelectedIndexChanged);
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
            this.btnActualizar2.Location = new System.Drawing.Point(506, 403);
            this.btnActualizar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar2.Name = "btnActualizar2";
            this.btnActualizar2.Size = new System.Drawing.Size(118, 37);
            this.btnActualizar2.TabIndex = 43;
            this.btnActualizar2.Text = "Actualizar";
            this.btnActualizar2.UseVisualStyleBackColor = false;
            this.btnActualizar2.Visible = false;
            this.btnActualizar2.Click += new System.EventHandler(this.btnActualizar2_Click);
            // 
            // txtContraSeguridad
            // 
            this.txtContraSeguridad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContraSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraSeguridad.Location = new System.Drawing.Point(487, 360);
            this.txtContraSeguridad.Name = "txtContraSeguridad";
            this.txtContraSeguridad.Size = new System.Drawing.Size(167, 26);
            this.txtContraSeguridad.TabIndex = 45;
            this.txtContraSeguridad.Visible = false;
            this.txtContraSeguridad.Enter += new System.EventHandler(this.txtContraSeguridad_Enter);
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacion.ForeColor = System.Drawing.Color.White;
            this.lblConfirmacion.Location = new System.Drawing.Point(483, 337);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(174, 20);
            this.lblConfirmacion.TabIndex = 44;
            this.lblConfirmacion.Text = "Ingrese Su Contraseña";
            this.lblConfirmacion.Visible = false;
            // 
            // lblSede
            // 
            this.lblSede.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSede.AutoSize = true;
            this.lblSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSede.ForeColor = System.Drawing.Color.White;
            this.lblSede.Location = new System.Drawing.Point(45, 324);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(57, 20);
            this.lblSede.TabIndex = 46;
            this.lblSede.Text = "Sede:*";
            this.lblSede.Visible = false;
            // 
            // txtSede
            // 
            this.txtSede.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSede.Location = new System.Drawing.Point(49, 347);
            this.txtSede.Name = "txtSede";
            this.txtSede.Size = new System.Drawing.Size(167, 26);
            this.txtSede.TabIndex = 47;
            this.txtSede.Visible = false;
            // 
            // lblNucleo
            // 
            this.lblNucleo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNucleo.AutoSize = true;
            this.lblNucleo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNucleo.ForeColor = System.Drawing.Color.White;
            this.lblNucleo.Location = new System.Drawing.Point(45, 324);
            this.lblNucleo.Name = "lblNucleo";
            this.lblNucleo.Size = new System.Drawing.Size(68, 20);
            this.lblNucleo.TabIndex = 48;
            this.lblNucleo.Text = "Nucleo:*";
            this.lblNucleo.Visible = false;
            // 
            // lblVerificacion
            // 
            this.lblVerificacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVerificacion.AutoSize = true;
            this.lblVerificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificacion.ForeColor = System.Drawing.Color.White;
            this.lblVerificacion.Location = new System.Drawing.Point(45, 324);
            this.lblVerificacion.Name = "lblVerificacion";
            this.lblVerificacion.Size = new System.Drawing.Size(160, 20);
            this.lblVerificacion.TabIndex = 50;
            this.lblVerificacion.Text = "Estado Verificacion: *";
            this.lblVerificacion.Visible = false;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.Color.White;
            this.lblDepartamento.Location = new System.Drawing.Point(45, 324);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(122, 20);
            this.lblDepartamento.TabIndex = 54;
            this.lblDepartamento.Text = "Departamento:*";
            this.lblDepartamento.Visible = false;
            // 
            // lsvUsuarios
            // 
            this.lsvUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lsvUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Funcion,
            this.columnHeader1,
            this.columnHeader2});
            this.lsvUsuarios.HideSelection = false;
            this.lsvUsuarios.Location = new System.Drawing.Point(445, 94);
            this.lsvUsuarios.Name = "lsvUsuarios";
            this.lsvUsuarios.Size = new System.Drawing.Size(241, 231);
            this.lsvUsuarios.TabIndex = 58;
            this.lsvUsuarios.UseCompatibleStateImageBehavior = false;
            this.lsvUsuarios.View = System.Windows.Forms.View.Details;
            this.lsvUsuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvUsuarios_MouseClick);
            // 
            // Funcion
            // 
            this.Funcion.Text = "Rut";
            this.Funcion.Width = 79;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellido";
            this.columnHeader2.Width = 70;
            // 
            // cboDep
            // 
            this.cboDep.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDep.FormattingEnabled = true;
            this.cboDep.Location = new System.Drawing.Point(49, 347);
            this.cboDep.Name = "cboDep";
            this.cboDep.Size = new System.Drawing.Size(169, 28);
            this.cboDep.TabIndex = 59;
            this.cboDep.Visible = false;
            // 
            // lblRut1
            // 
            this.lblRut1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRut1.AutoSize = true;
            this.lblRut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRut1.ForeColor = System.Drawing.Color.White;
            this.lblRut1.Location = new System.Drawing.Point(243, 136);
            this.lblRut1.Name = "lblRut1";
            this.lblRut1.Size = new System.Drawing.Size(45, 20);
            this.lblRut1.TabIndex = 60;
            this.lblRut1.Text = "Rut:*";
            this.lblRut1.Visible = false;
            // 
            // lblApellido1
            // 
            this.lblApellido1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.ForeColor = System.Drawing.Color.White;
            this.lblApellido1.Location = new System.Drawing.Point(243, 204);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(75, 20);
            this.lblApellido1.TabIndex = 61;
            this.lblApellido1.Text = "Apellido:*";
            this.lblApellido1.Visible = false;
            // 
            // lblNom1
            // 
            this.lblNom1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNom1.AutoSize = true;
            this.lblNom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom1.ForeColor = System.Drawing.Color.White;
            this.lblNom1.Location = new System.Drawing.Point(43, 204);
            this.lblNom1.Name = "lblNom1";
            this.lblNom1.Size = new System.Drawing.Size(75, 20);
            this.lblNom1.TabIndex = 62;
            this.lblNom1.Text = "Nombre:*";
            this.lblNom1.Visible = false;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(43, 265);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(67, 20);
            this.lblCorreo.TabIndex = 63;
            this.lblCorreo.Text = "Correo:*";
            this.lblCorreo.Visible = false;
            // 
            // txtVerificacion
            // 
            this.txtVerificacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVerificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerificacion.Location = new System.Drawing.Point(49, 347);
            this.txtVerificacion.Name = "txtVerificacion";
            this.txtVerificacion.Size = new System.Drawing.Size(167, 26);
            this.txtVerificacion.TabIndex = 51;
            this.txtVerificacion.Visible = false;
            // 
            // cboNucleo
            // 
            this.cboNucleo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboNucleo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNucleo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNucleo.FormattingEnabled = true;
            this.cboNucleo.Location = new System.Drawing.Point(49, 347);
            this.cboNucleo.Name = "cboNucleo";
            this.cboNucleo.Size = new System.Drawing.Size(169, 28);
            this.cboNucleo.TabIndex = 56;
            this.cboNucleo.Visible = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(47, 288);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(241, 26);
            this.txtCorreo.TabIndex = 64;
            this.txtCorreo.Visible = false;
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
            this.btnEliminar2.Location = new System.Drawing.Point(506, 403);
            this.btnEliminar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar2.Name = "btnEliminar2";
            this.btnEliminar2.Size = new System.Drawing.Size(118, 37);
            this.btnEliminar2.TabIndex = 66;
            this.btnEliminar2.Text = "Eliminar";
            this.btnEliminar2.UseVisualStyleBackColor = false;
            this.btnEliminar2.Visible = false;
            this.btnEliminar2.Click += new System.EventHandler(this.btnEliminar2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(354, 403);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 37);
            this.btnEliminar.TabIndex = 65;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // EditarU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(716, 456);
            this.Controls.Add(this.btnEliminar2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNom1);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.lblRut1);
            this.Controls.Add(this.cboDep);
            this.Controls.Add(this.lsvUsuarios);
            this.Controls.Add(this.cboNucleo);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.txtVerificacion);
            this.Controls.Add(this.lblVerificacion);
            this.Controls.Add(this.lblNucleo);
            this.Controls.Add(this.txtSede);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.txtContraSeguridad);
            this.Controls.Add(this.lblConfirmacion);
            this.Controls.Add(this.btnActualizar2);
            this.Controls.Add(this.cboTipoU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRut);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarU";
            this.Text = "Edit2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cboTipoU;
        private System.Windows.Forms.Button btnActualizar2;
        private System.Windows.Forms.TextBox txtContraSeguridad;
        private System.Windows.Forms.Label lblConfirmacion;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.TextBox txtSede;
        private System.Windows.Forms.Label lblNucleo;
        private System.Windows.Forms.Label lblVerificacion;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ListView lsvUsuarios;
        public System.Windows.Forms.ColumnHeader Funcion;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cboDep;
        private System.Windows.Forms.Label lblRut1;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblNom1;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtVerificacion;
        private System.Windows.Forms.ComboBox cboNucleo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnEliminar2;
        private System.Windows.Forms.Button btnEliminar;
    }
}