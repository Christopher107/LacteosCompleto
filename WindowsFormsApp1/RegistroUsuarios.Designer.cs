namespace WindowsFormsApp1
{
    partial class RegistroUsuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuarios));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxSeccion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GuardarUsuario = new System.Windows.Forms.Button();
            this.cbxRegTipoUsuario = new System.Windows.Forms.ComboBox();
            this.txtRegClave = new System.Windows.Forms.TextBox();
            this.txtRegUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BuscarUsuario = new System.Windows.Forms.Button();
            this.cbxBuscUsuario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ActualizarUsuario = new System.Windows.Forms.Button();
            this.BorrarUsuario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHome1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Usuario,
            this.Contraseña,
            this.TipoUsuario,
            this.Seccion});
            this.dgvUsuarios.Location = new System.Drawing.Point(294, 550);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(821, 190);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick_1);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Contraseña
            // 
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.HeaderText = "Tipo de usuario";
            this.TipoUsuario.Name = "TipoUsuario";
            // 
            // Seccion
            // 
            this.Seccion.HeaderText = "Seccion";
            this.Seccion.Name = "Seccion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxSeccion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.GuardarUsuario);
            this.groupBox1.Controls.Add(this.cbxRegTipoUsuario);
            this.groupBox1.Controls.Add(this.txtRegClave);
            this.groupBox1.Controls.Add(this.txtRegUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(132, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 296);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GUARDAR USUARIO";
            // 
            // cbxSeccion
            // 
            this.cbxSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSeccion.FormattingEnabled = true;
            this.cbxSeccion.Items.AddRange(new object[] {
            "Super Usuario",
            "Usuario"});
            this.cbxSeccion.Location = new System.Drawing.Point(240, 173);
            this.cbxSeccion.Name = "cbxSeccion";
            this.cbxSeccion.Size = new System.Drawing.Size(272, 24);
            this.cbxSeccion.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Seccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(402, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Guardar";
            // 
            // GuardarUsuario
            // 
            this.GuardarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("GuardarUsuario.Image")));
            this.GuardarUsuario.Location = new System.Drawing.Point(469, 214);
            this.GuardarUsuario.Name = "GuardarUsuario";
            this.GuardarUsuario.Size = new System.Drawing.Size(57, 54);
            this.GuardarUsuario.TabIndex = 7;
            this.GuardarUsuario.UseVisualStyleBackColor = true;
            this.GuardarUsuario.Click += new System.EventHandler(this.GuardarUsuario_Click);
            // 
            // cbxRegTipoUsuario
            // 
            this.cbxRegTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRegTipoUsuario.FormattingEnabled = true;
            this.cbxRegTipoUsuario.Items.AddRange(new object[] {
            "Super Usuario",
            "Usuario"});
            this.cbxRegTipoUsuario.Location = new System.Drawing.Point(240, 128);
            this.cbxRegTipoUsuario.Name = "cbxRegTipoUsuario";
            this.cbxRegTipoUsuario.Size = new System.Drawing.Size(272, 24);
            this.cbxRegTipoUsuario.TabIndex = 6;
            // 
            // txtRegClave
            // 
            this.txtRegClave.Location = new System.Drawing.Point(240, 85);
            this.txtRegClave.Name = "txtRegClave";
            this.txtRegClave.Size = new System.Drawing.Size(272, 22);
            this.txtRegClave.TabIndex = 4;            // 
            // txtRegUsuario
            // 
            this.txtRegUsuario.Location = new System.Drawing.Point(240, 39);
            this.txtRegUsuario.Name = "txtRegUsuario";
            this.txtRegUsuario.Size = new System.Drawing.Size(272, 22);
            this.txtRegUsuario.TabIndex = 3;
            this.txtRegUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegUsuario_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.BuscarUsuario);
            this.groupBox2.Controls.Add(this.cbxBuscUsuario);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(716, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 296);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSQUEDA USUARIO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(377, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Buscar";
            // 
            // BuscarUsuario
            // 
            this.BuscarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("BuscarUsuario.Image")));
            this.BuscarUsuario.Location = new System.Drawing.Point(314, 213);
            this.BuscarUsuario.Name = "BuscarUsuario";
            this.BuscarUsuario.Size = new System.Drawing.Size(57, 55);
            this.BuscarUsuario.TabIndex = 10;
            this.BuscarUsuario.UseVisualStyleBackColor = true;
            this.BuscarUsuario.Click += new System.EventHandler(this.BuscarUsuario_Click);
            // 
            // cbxBuscUsuario
            // 
            this.cbxBuscUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuscUsuario.FormattingEnabled = true;
            this.cbxBuscUsuario.Location = new System.Drawing.Point(208, 41);
            this.cbxBuscUsuario.Name = "cbxBuscUsuario";
            this.cbxBuscUsuario.Size = new System.Drawing.Size(272, 24);
            this.cbxBuscUsuario.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario";
            // 
            // ActualizarUsuario
            // 
            this.ActualizarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("ActualizarUsuario.Image")));
            this.ActualizarUsuario.Location = new System.Drawing.Point(880, 474);
            this.ActualizarUsuario.Name = "ActualizarUsuario";
            this.ActualizarUsuario.Size = new System.Drawing.Size(57, 54);
            this.ActualizarUsuario.TabIndex = 8;
            this.ActualizarUsuario.UseVisualStyleBackColor = true;
            this.ActualizarUsuario.Click += new System.EventHandler(this.ActualizarUsuario_Click);
            // 
            // BorrarUsuario
            // 
            this.BorrarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("BorrarUsuario.Image")));
            this.BorrarUsuario.Location = new System.Drawing.Point(1058, 474);
            this.BorrarUsuario.Name = "BorrarUsuario";
            this.BorrarUsuario.Size = new System.Drawing.Size(57, 54);
            this.BorrarUsuario.TabIndex = 9;
            this.BorrarUsuario.UseVisualStyleBackColor = true;
            this.BorrarUsuario.Click += new System.EventHandler(this.BorrarUsuario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(622, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "CRUD USUARIOS";
            // 
            // btnHome1
            // 
            this.btnHome1.Image = ((System.Drawing.Image)(resources.GetObject("btnHome1.Image")));
            this.btnHome1.Location = new System.Drawing.Point(33, 71);
            this.btnHome1.Name = "btnHome1";
            this.btnHome1.Size = new System.Drawing.Size(57, 54);
            this.btnHome1.TabIndex = 10;
            this.btnHome1.UseVisualStyleBackColor = true;
            this.btnHome1.Click += new System.EventHandler(this.btnHome1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Home";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(804, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Actualizar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1004, 493);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Borrar";
            // 
            // RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1432, 841);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnHome1);
            this.Controls.Add(this.BorrarUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ActualizarUsuario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroUsuarios";
            this.Text = "REGISTRO DE USUARIOS";
            this.Load += new System.EventHandler(this.RegistroUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GuardarUsuario;
        private System.Windows.Forms.ComboBox cbxRegTipoUsuario;
        private System.Windows.Forms.TextBox txtRegClave;
        private System.Windows.Forms.TextBox txtRegUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BuscarUsuario;
        private System.Windows.Forms.ComboBox cbxBuscUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ActualizarUsuario;
        private System.Windows.Forms.Button BorrarUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuario;
        private System.Windows.Forms.Button btnHome1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seccion;
        private System.Windows.Forms.ComboBox cbxSeccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

