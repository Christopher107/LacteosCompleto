namespace WindowsFormsApp1
{
    partial class VistaTotalHoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaTotalHoras));
            this.dgvVwSumaHoras = new System.Windows.Forms.DataGridView();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.cbxVwRut = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVwBuscar = new System.Windows.Forms.Button();
            this.dtVwHasta = new System.Windows.Forms.DateTimePicker();
            this.dtVwDesde = new System.Windows.Forms.DateTimePicker();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVwSumaHoras)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVwSumaHoras
            // 
            this.dgvVwSumaHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVwSumaHoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rut,
            this.Nombre,
            this.Apellido,
            this.Seccion,
            this.Mes,
            this.TotalHoras});
            this.dgvVwSumaHoras.Location = new System.Drawing.Point(260, 431);
            this.dgvVwSumaHoras.Name = "dgvVwSumaHoras";
            this.dgvVwSumaHoras.RowTemplate.Height = 24;
            this.dgvVwSumaHoras.Size = new System.Drawing.Size(874, 150);
            this.dgvVwSumaHoras.TabIndex = 0;
            // 
            // Rut
            // 
            this.Rut.HeaderText = "RUT";
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
            // Mes
            // 
            this.Mes.HeaderText = "Mes";
            this.Mes.Name = "Mes";
            // 
            // TotalHoras
            // 
            this.TotalHoras.HeaderText = "Total Horas";
            this.TotalHoras.Name = "TotalHoras";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.cbxVwRut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnVwBuscar);
            this.groupBox1.Controls.Add(this.dtVwHasta);
            this.groupBox1.Controls.Add(this.dtVwDesde);
            this.groupBox1.Location = new System.Drawing.Point(180, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1039, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRO BUSQUEDA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(912, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Buscar";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(27, 71);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(99, 17);
            this.label.TabIndex = 6;
            this.label.Text = "Rut trabajador";
            // 
            // cbxVwRut
            // 
            this.cbxVwRut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVwRut.FormattingEnabled = true;
            this.cbxVwRut.Location = new System.Drawing.Point(154, 71);
            this.cbxVwRut.Name = "cbxVwRut";
            this.cbxVwRut.Size = new System.Drawing.Size(178, 24);
            this.cbxVwRut.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde";
            // 
            // btnVwBuscar
            // 
            this.btnVwBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnVwBuscar.Image")));
            this.btnVwBuscar.Location = new System.Drawing.Point(907, 58);
            this.btnVwBuscar.Name = "btnVwBuscar";
            this.btnVwBuscar.Size = new System.Drawing.Size(57, 50);
            this.btnVwBuscar.TabIndex = 2;
            this.btnVwBuscar.UseVisualStyleBackColor = true;
            this.btnVwBuscar.Click += new System.EventHandler(this.btnVwBuscar_Click);
            // 
            // dtVwHasta
            // 
            this.dtVwHasta.CustomFormat = "";
            this.dtVwHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVwHasta.Location = new System.Drawing.Point(739, 75);
            this.dtVwHasta.Name = "dtVwHasta";
            this.dtVwHasta.Size = new System.Drawing.Size(128, 22);
            this.dtVwHasta.TabIndex = 1;
            // 
            // dtVwDesde
            // 
            this.dtVwDesde.CustomFormat = "";
            this.dtVwDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVwDesde.Location = new System.Drawing.Point(483, 74);
            this.dtVwDesde.Name = "dtVwDesde";
            this.dtVwDesde.Size = new System.Drawing.Size(128, 22);
            this.dtVwDesde.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(12, 61);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(59, 54);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(649, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "TOTAL HORAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Atras";
            // 
            // VistaTotalHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1432, 841);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvVwSumaHoras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaTotalHoras";
            this.Text = "TOTAL HORAS";
            this.Load += new System.EventHandler(this.VistaTotalHoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVwSumaHoras)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVwSumaHoras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cbxVwRut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVwBuscar;
        private System.Windows.Forms.DateTimePicker dtVwHasta;
        private System.Windows.Forms.DateTimePicker dtVwDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHoras;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}