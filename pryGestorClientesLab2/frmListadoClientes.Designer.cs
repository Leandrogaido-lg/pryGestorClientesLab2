namespace pryGestorClientesLab2
{
    partial class frmListadoClientes
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
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.lblPromedioRTA = new System.Windows.Forms.Label();
            this.lblCantidadRTA = new System.Windows.Forms.Label();
            this.lblTotalRTA = new System.Windows.Forms.Label();
            this.btnReportar = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.lblPromedioRTA);
            this.gbListado.Controls.Add(this.lblCantidadRTA);
            this.gbListado.Controls.Add(this.lblTotalRTA);
            this.gbListado.Controls.Add(this.btnReportar);
            this.gbListado.Controls.Add(this.lblPromedio);
            this.gbListado.Controls.Add(this.lblCantidadClientes);
            this.gbListado.Controls.Add(this.lblTotalDeuda);
            this.gbListado.Controls.Add(this.dgvClientes);
            this.gbListado.Location = new System.Drawing.Point(12, 12);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(549, 416);
            this.gbListado.TabIndex = 0;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Consulta de Datos";
            // 
            // lblPromedioRTA
            // 
            this.lblPromedioRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioRTA.Location = new System.Drawing.Point(443, 369);
            this.lblPromedioRTA.Name = "lblPromedioRTA";
            this.lblPromedioRTA.Size = new System.Drawing.Size(100, 23);
            this.lblPromedioRTA.TabIndex = 11;
            // 
            // lblCantidadRTA
            // 
            this.lblCantidadRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadRTA.Location = new System.Drawing.Point(443, 331);
            this.lblCantidadRTA.Name = "lblCantidadRTA";
            this.lblCantidadRTA.Size = new System.Drawing.Size(100, 23);
            this.lblCantidadRTA.TabIndex = 10;
            // 
            // lblTotalRTA
            // 
            this.lblTotalRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalRTA.Location = new System.Drawing.Point(443, 292);
            this.lblTotalRTA.Name = "lblTotalRTA";
            this.lblTotalRTA.Size = new System.Drawing.Size(100, 23);
            this.lblTotalRTA.TabIndex = 9;
            // 
            // btnReportar
            // 
            this.btnReportar.Location = new System.Drawing.Point(468, 396);
            this.btnReportar.Name = "btnReportar";
            this.btnReportar.Size = new System.Drawing.Size(75, 23);
            this.btnReportar.TabIndex = 8;
            this.btnReportar.Text = "Reportar";
            this.btnReportar.UseVisualStyleBackColor = true;
            this.btnReportar.Click += new System.EventHandler(this.btnReportar_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(333, 370);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(101, 13);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio de Deuda";
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Location = new System.Drawing.Point(333, 332);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(104, 13);
            this.lblCantidadClientes.TabIndex = 2;
            this.lblCantidadClientes.Text = "Cantidad de Clientes";
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Location = new System.Drawing.Point(356, 293);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(81, 13);
            this.lblTotalDeuda.TabIndex = 1;
            this.lblTotalDeuda.Text = "Total de Deuda";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvClientes.Location = new System.Drawing.Point(6, 19);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(537, 248);
            this.dgvClientes.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Còdigo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre y Apellido";
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Limite de Credito";
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deuda";
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(399, 408);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 12;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 440);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.gbListado);
            this.Name = "frmListadoClientes";
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.frmListadoClientes_Load);
            this.gbListado.ResumeLayout(false);
            this.gbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Button btnReportar;
        private System.Windows.Forms.Label lblPromedioRTA;
        private System.Windows.Forms.Label lblCantidadRTA;
        private System.Windows.Forms.Label lblTotalRTA;
        private System.Windows.Forms.Button btnOrdenar;
    }
}