namespace WindowsFormsApp1
{
    partial class RegistroHoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroHoras));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHorasRealizadas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxRutHoras = new System.Windows.Forms.ComboBox();
            this.dtFechaHoras = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarHoras = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarHoras = new System.Windows.Forms.Button();
            this.cbxBuscHora = new System.Windows.Forms.ComboBox();
            this.dgvHoras = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasExtas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizarHoras = new System.Windows.Forms.Button();
            this.btnHome2 = new System.Windows.Forms.Button();
            this.btnBorrarHoras = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnTotalHoras = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtHorasRealizadas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxRutHoras);
            this.groupBox1.Controls.Add(this.dtFechaHoras);
            this.groupBox1.Controls.Add(this.btnGuardarHoras);
            this.groupBox1.Location = new System.Drawing.Point(92, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESO HORAS EXTRAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Guardar";
            // 
            // txtHorasRealizadas
            // 
            this.txtHorasRealizadas.Location = new System.Drawing.Point(211, 136);
            this.txtHorasRealizadas.Name = "txtHorasRealizadas";
            this.txtHorasRealizadas.Size = new System.Drawing.Size(308, 22);
            this.txtHorasRealizadas.TabIndex = 12;
            this.txtHorasRealizadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasRealizadas_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Horas Realizadas";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(70, 98);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(47, 17);
            this.label.TabIndex = 10;
            this.label.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rut";
            // 
            // cbxRutHoras
            // 
            this.cbxRutHoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRutHoras.FormattingEnabled = true;
            this.cbxRutHoras.Location = new System.Drawing.Point(211, 56);
            this.cbxRutHoras.Name = "cbxRutHoras";
            this.cbxRutHoras.Size = new System.Drawing.Size(308, 24);
            this.cbxRutHoras.TabIndex = 8;
            // 
            // dtFechaHoras
            // 
            this.dtFechaHoras.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaHoras.Location = new System.Drawing.Point(211, 98);
            this.dtFechaHoras.Name = "dtFechaHoras";
            this.dtFechaHoras.Size = new System.Drawing.Size(308, 22);
            this.dtFechaHoras.TabIndex = 7;
            // 
            // btnGuardarHoras
            // 
            this.btnGuardarHoras.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarHoras.Image")));
            this.btnGuardarHoras.Location = new System.Drawing.Point(494, 221);
            this.btnGuardarHoras.Name = "btnGuardarHoras";
            this.btnGuardarHoras.Size = new System.Drawing.Size(56, 52);
            this.btnGuardarHoras.TabIndex = 6;
            this.btnGuardarHoras.UseVisualStyleBackColor = true;
            this.btnGuardarHoras.Click += new System.EventHandler(this.btnGuardarHoras_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnBuscarHoras);
            this.groupBox2.Controls.Add(this.cbxBuscHora);
            this.groupBox2.Location = new System.Drawing.Point(709, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(613, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR HORAS EXTRAS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(510, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Buscar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Rut";
            // 
            // btnBuscarHoras
            // 
            this.btnBuscarHoras.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarHoras.Image")));
            this.btnBuscarHoras.Location = new System.Drawing.Point(448, 221);
            this.btnBuscarHoras.Name = "btnBuscarHoras";
            this.btnBuscarHoras.Size = new System.Drawing.Size(56, 52);
            this.btnBuscarHoras.TabIndex = 5;
            this.btnBuscarHoras.UseVisualStyleBackColor = true;
            this.btnBuscarHoras.Click += new System.EventHandler(this.btnBuscarHoras_Click);
            // 
            // cbxBuscHora
            // 
            this.cbxBuscHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuscHora.FormattingEnabled = true;
            this.cbxBuscHora.Location = new System.Drawing.Point(224, 56);
            this.cbxBuscHora.Name = "cbxBuscHora";
            this.cbxBuscHora.Size = new System.Drawing.Size(308, 24);
            this.cbxBuscHora.TabIndex = 13;
            // 
            // dgvHoras
            // 
            this.dgvHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Rut,
            this.HorasExtas,
            this.Fecha});
            this.dgvHoras.Location = new System.Drawing.Point(242, 558);
            this.dgvHoras.Name = "dgvHoras";
            this.dgvHoras.RowTemplate.Height = 24;
            this.dgvHoras.Size = new System.Drawing.Size(946, 236);
            this.dgvHoras.TabIndex = 2;
            this.dgvHoras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoras_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Rut
            // 
            this.Rut.HeaderText = "Rut";
            this.Rut.Name = "Rut";
            // 
            // HorasExtas
            // 
            this.HorasExtas.HeaderText = "Horas Extras";
            this.HorasExtas.Name = "HorasExtas";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(611, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "CRUD HORAS EXTRAS";
            // 
            // btnActualizarHoras
            // 
            this.btnActualizarHoras.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarHoras.Image")));
            this.btnActualizarHoras.Location = new System.Drawing.Point(971, 451);
            this.btnActualizarHoras.Name = "btnActualizarHoras";
            this.btnActualizarHoras.Size = new System.Drawing.Size(56, 52);
            this.btnActualizarHoras.TabIndex = 4;
            this.btnActualizarHoras.UseVisualStyleBackColor = true;
            this.btnActualizarHoras.Click += new System.EventHandler(this.btnActualizarHoras_Click);
            // 
            // btnHome2
            // 
            this.btnHome2.Image = ((System.Drawing.Image)(resources.GetObject("btnHome2.Image")));
            this.btnHome2.Location = new System.Drawing.Point(27, 56);
            this.btnHome2.Name = "btnHome2";
            this.btnHome2.Size = new System.Drawing.Size(56, 52);
            this.btnHome2.TabIndex = 11;
            this.btnHome2.UseVisualStyleBackColor = true;
            this.btnHome2.Click += new System.EventHandler(this.btnHome2_Click);
            // 
            // btnBorrarHoras
            // 
            this.btnBorrarHoras.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarHoras.Image")));
            this.btnBorrarHoras.Location = new System.Drawing.Point(1132, 451);
            this.btnBorrarHoras.Name = "btnBorrarHoras";
            this.btnBorrarHoras.Size = new System.Drawing.Size(56, 52);
            this.btnBorrarHoras.TabIndex = 12;
            this.btnBorrarHoras.UseVisualStyleBackColor = true;
            this.btnBorrarHoras.Click += new System.EventHandler(this.btnBorrarHoras_Click_1);
            // 
            // btnExportar
            // 
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.Location = new System.Drawing.Point(814, 451);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(56, 52);
            this.btnExportar.TabIndex = 13;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnTotalHoras
            // 
            this.btnTotalHoras.Image = ((System.Drawing.Image)(resources.GetObject("btnTotalHoras.Image")));
            this.btnTotalHoras.Location = new System.Drawing.Point(1347, 56);
            this.btnTotalHoras.Name = "btnTotalHoras";
            this.btnTotalHoras.Size = new System.Drawing.Size(56, 52);
            this.btnTotalHoras.TabIndex = 14;
            this.btnTotalHoras.UseVisualStyleBackColor = true;
            this.btnTotalHoras.Click += new System.EventHandler(this.btnTotalHoras_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(683, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Exportar a Excel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(895, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Actualizar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1078, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Borrar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Home";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1259, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Total Horas";
            // 
            // RegistroHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1432, 841);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTotalHoras);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnBorrarHoras);
            this.Controls.Add(this.btnHome2);
            this.Controls.Add(this.btnActualizarHoras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHoras);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroHoras";
            this.Text = "Registro Horas";
            this.Load += new System.EventHandler(this.RegistroHoras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHoras;
        private System.Windows.Forms.TextBox txtHorasRealizadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxRutHoras;
        private System.Windows.Forms.DateTimePicker dtFechaHoras;
        private System.Windows.Forms.Button btnGuardarHoras;
        private System.Windows.Forms.Button btnBuscarHoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizarHoras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxBuscHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasExtas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button btnHome2;
        private System.Windows.Forms.Button btnBorrarHoras;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnTotalHoras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}