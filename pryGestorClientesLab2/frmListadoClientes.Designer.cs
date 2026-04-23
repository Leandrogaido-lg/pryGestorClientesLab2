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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.btnListar);
            this.gbListado.Controls.Add(this.txtTotal);
            this.gbListado.Controls.Add(this.txtCantidad);
            this.gbListado.Controls.Add(this.txtPromedio);
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
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Location = new System.Drawing.Point(356, 293);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(81, 13);
            this.lblTotalDeuda.TabIndex = 1;
            this.lblTotalDeuda.Text = "Total de Deuda";
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
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(333, 370);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(101, 13);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio de Deuda";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(443, 370);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(100, 20);
            this.txtPromedio.TabIndex = 4;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(443, 329);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(443, 293);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(468, 396);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 440);
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
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Button btnListar;
    }
}