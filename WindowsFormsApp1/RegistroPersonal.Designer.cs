﻿namespace WindowsFormsApp1
{
    partial class RegistroPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPersonal));
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSeccion = new System.Windows.Forms.ComboBox();
            this.dtIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarPersonal = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grupo = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkNombre = new System.Windows.Forms.CheckBox();
            this.chkApellido = new System.Windows.Forms.CheckBox();
            this.chkRut = new System.Windows.Forms.CheckBox();
            this.cbxNombre = new System.Windows.Forms.ComboBox();
            this.cbxApellido = new System.Windows.Forms.ComboBox();
            this.cbxRut = new System.Windows.Forms.ComboBox();
            this.btnBuscarPersonal = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizarPersonal = new System.Windows.Forms.Button();
            this.btnBorrarPersonal = new System.Windows.Forms.Button();
            this.btnHome3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rut,
            this.Nombre,
            this.Apellido,
            this.Seccion,
            this.FechaIngreso});
            this.dgvPersonal.Location = new System.Drawing.Point(337, 535);
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.RowTemplate.Height = 24;
            this.dgvPersonal.Size = new System.Drawing.Size(752, 217);
            this.dgvPersonal.TabIndex = 0;
            this.dgvPersonal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonal_CellClick);
            // 
            // Rut
            // 
            this.Rut.HeaderText = "Rut";
            this.Rut.Name = "Rut";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Seccion
            // 
            this.Seccion.HeaderText = "Seccion";
            this.Seccion.Name = "Seccion";
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "Fecha de Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxSeccion);
            this.groupBox1.Controls.Add(this.dtIngreso);
            this.groupBox1.Controls.Add(this.btnGuardarPersonal);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(118, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 321);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AGREGAR PERSONAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Guardar";
            // 
            // cbxSeccion
            // 
            this.cbxSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSeccion.FormattingEnabled = true;
            this.cbxSeccion.Location = new System.Drawing.Point(269, 181);
            this.cbxSeccion.Name = "cbxSeccion";
            this.cbxSeccion.Size = new System.Drawing.Size(268, 24);
            this.cbxSeccion.TabIndex = 20;
            // 
            // dtIngreso
            // 
            this.dtIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIngreso.Location = new System.Drawing.Point(269, 152);
            this.dtIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.dtIngreso.Name = "dtIngreso";
            this.dtIngreso.Size = new System.Drawing.Size(268, 22);
            this.dtIngreso.TabIndex = 12;
            // 
            // btnGuardarPersonal
            // 
            this.btnGuardarPersonal.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarPersonal.Image")));
            this.btnGuardarPersonal.Location = new System.Drawing.Point(494, 253);
            this.btnGuardarPersonal.Name = "btnGuardarPersonal";
            this.btnGuardarPersonal.Size = new System.Drawing.Size(57, 54);
            this.btnGuardarPersonal.TabIndex = 18;
            this.btnGuardarPersonal.UseVisualStyleBackColor = true;
            this.btnGuardarPersonal.Click += new System.EventHandler(this.btnGuardarPersonal_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(269, 95);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(268, 22);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(269, 123);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(268, 22);
            this.txtApellido.TabIndex = 16;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(269, 67);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(268, 22);
            this.txtRut.TabIndex = 11;
            this.txtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRut_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha Ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "RUT";
            // 
            // grupo
            // 
            this.grupo.Controls.Add(this.label13);
            this.grupo.Controls.Add(this.chkNombre);
            this.grupo.Controls.Add(this.chkApellido);
            this.grupo.Controls.Add(this.chkRut);
            this.grupo.Controls.Add(this.cbxNombre);
            this.grupo.Controls.Add(this.cbxApellido);
            this.grupo.Controls.Add(this.cbxRut);
            this.grupo.Controls.Add(this.btnBuscarPersonal);
            this.grupo.Controls.Add(this.label11);
            this.grupo.Controls.Add(this.label10);
            this.grupo.Controls.Add(this.label9);
            this.grupo.Location = new System.Drawing.Point(724, 125);
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(593, 321);
            this.grupo.TabIndex = 2;
            this.grupo.TabStop = false;
            this.grupo.Text = "BUSCAR PERSONAL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(414, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Buscar";
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.Location = new System.Drawing.Point(47, 124);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(153, 21);
            this.chkNombre.TabIndex = 27;
            this.chkNombre.Text = "Buscar por Nombre";
            this.chkNombre.UseVisualStyleBackColor = true;
            this.chkNombre.CheckedChanged += new System.EventHandler(this.chkNombre_CheckedChanged);
            // 
            // chkApellido
            // 
            this.chkApellido.AutoSize = true;
            this.chkApellido.Location = new System.Drawing.Point(47, 192);
            this.chkApellido.Name = "chkApellido";
            this.chkApellido.Size = new System.Drawing.Size(153, 21);
            this.chkApellido.TabIndex = 26;
            this.chkApellido.Text = "Buscar por Apellido";
            this.chkApellido.UseVisualStyleBackColor = true;
            this.chkApellido.CheckedChanged += new System.EventHandler(this.chkApellido_CheckedChanged);
            // 
            // chkRut
            // 
            this.chkRut.AutoSize = true;
            this.chkRut.Location = new System.Drawing.Point(47, 59);
            this.chkRut.Name = "chkRut";
            this.chkRut.Size = new System.Drawing.Size(125, 21);
            this.chkRut.TabIndex = 25;
            this.chkRut.Text = "Buscar por Rut";
            this.chkRut.UseVisualStyleBackColor = true;
            this.chkRut.CheckedChanged += new System.EventHandler(this.chkRut_CheckedChanged);
            // 
            // cbxNombre
            // 
            this.cbxNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNombre.FormattingEnabled = true;
            this.cbxNombre.Location = new System.Drawing.Point(260, 150);
            this.cbxNombre.Name = "cbxNombre";
            this.cbxNombre.Size = new System.Drawing.Size(284, 24);
            this.cbxNombre.TabIndex = 24;
            // 
            // cbxApellido
            // 
            this.cbxApellido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxApellido.FormattingEnabled = true;
            this.cbxApellido.Location = new System.Drawing.Point(260, 216);
            this.cbxApellido.Name = "cbxApellido";
            this.cbxApellido.Size = new System.Drawing.Size(284, 24);
            this.cbxApellido.TabIndex = 23;
            // 
            // cbxRut
            // 
            this.cbxRut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRut.FormattingEnabled = true;
            this.cbxRut.Location = new System.Drawing.Point(260, 83);
            this.cbxRut.Name = "cbxRut";
            this.cbxRut.Size = new System.Drawing.Size(284, 24);
            this.cbxRut.TabIndex = 22;
            // 
            // btnBuscarPersonal
            // 
            this.btnBuscarPersonal.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPersonal.Image")));
            this.btnBuscarPersonal.Location = new System.Drawing.Point(472, 253);
            this.btnBuscarPersonal.Name = "btnBuscarPersonal";
            this.btnBuscarPersonal.Size = new System.Drawing.Size(57, 54);
            this.btnBuscarPersonal.TabIndex = 21;
            this.btnBuscarPersonal.UseVisualStyleBackColor = true;
            this.btnBuscarPersonal.Click += new System.EventHandler(this.btnBuscarPersonal_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "RUT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(623, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "CRUD PERSONAL";
            // 
            // btnActualizarPersonal
            // 
            this.btnActualizarPersonal.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarPersonal.Image")));
            this.btnActualizarPersonal.Location = new System.Drawing.Point(876, 462);
            this.btnActualizarPersonal.Name = "btnActualizarPersonal";
            this.btnActualizarPersonal.Size = new System.Drawing.Size(57, 54);
            this.btnActualizarPersonal.TabIndex = 19;
            this.btnActualizarPersonal.UseVisualStyleBackColor = true;
            this.btnActualizarPersonal.Click += new System.EventHandler(this.btnActualizarPersonal_Click);
            // 
            // btnBorrarPersonal
            // 
            this.btnBorrarPersonal.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarPersonal.Image")));
            this.btnBorrarPersonal.Location = new System.Drawing.Point(1032, 462);
            this.btnBorrarPersonal.Name = "btnBorrarPersonal";
            this.btnBorrarPersonal.Size = new System.Drawing.Size(57, 54);
            this.btnBorrarPersonal.TabIndex = 20;
            this.btnBorrarPersonal.UseVisualStyleBackColor = true;
            this.btnBorrarPersonal.Click += new System.EventHandler(this.btnBorrarPersonal_Click);
            // 
            // btnHome3
            // 
            this.btnHome3.Image = ((System.Drawing.Image)(resources.GetObject("btnHome3.Image")));
            this.btnHome3.Location = new System.Drawing.Point(35, 61);
            this.btnHome3.Name = "btnHome3";
            this.btnHome3.Size = new System.Drawing.Size(57, 54);
            this.btnHome3.TabIndex = 21;
            this.btnHome3.UseVisualStyleBackColor = true;
            this.btnHome3.Click += new System.EventHandler(this.btnHome3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(800, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Actualizar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(978, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Borrar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(98, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "Home";
            // 
            // RegistroPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1432, 841);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnHome3);
            this.Controls.Add(this.btnActualizarPersonal);
            this.Controls.Add(this.btnBorrarPersonal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grupo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPersonal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroPersonal";
            this.Text = "Registro Personal";
            this.Load += new System.EventHandler(this.RegistroPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grupo.ResumeLayout(false);
            this.grupo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardarPersonal;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grupo;
        private System.Windows.Forms.Button btnBuscarPersonal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizarPersonal;
        private System.Windows.Forms.Button btnBorrarPersonal;
        private System.Windows.Forms.DateTimePicker dtIngreso;
        private System.Windows.Forms.ComboBox cbxNombre;
        private System.Windows.Forms.ComboBox cbxApellido;
        private System.Windows.Forms.ComboBox cbxRut;
        private System.Windows.Forms.CheckBox chkRut;
        private System.Windows.Forms.CheckBox chkNombre;
        private System.Windows.Forms.CheckBox chkApellido;
        private System.Windows.Forms.ComboBox cbxSeccion;
        private System.Windows.Forms.Button btnHome3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
    }
}