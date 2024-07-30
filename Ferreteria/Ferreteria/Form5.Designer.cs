namespace Ferreteria
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtProductoID;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label labelProductoID;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelTotal;

        private void InitializeComponent()
        {
            this.txtProductoID = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.labelProductoID = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductoID
            // 
            this.txtProductoID.Location = new System.Drawing.Point(150, 12);
            this.txtProductoID.Name = "txtProductoID";
            this.txtProductoID.Size = new System.Drawing.Size(178, 27);
            this.txtProductoID.TabIndex = 0;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(150, 45);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(178, 27);
            this.txtCantidad.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(150, 78);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(178, 27);
            this.txtTotal.TabIndex = 2;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(150, 111);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(178, 35);
            this.btnRegistrarVenta.TabIndex = 3;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(12, 160);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 29;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(400, 200);
            this.dgvVentas.TabIndex = 4;
            // 
            // labelProductoID
            // 
            this.labelProductoID.AutoSize = true;
            this.labelProductoID.Location = new System.Drawing.Point(12, 15);
            this.labelProductoID.Name = "labelProductoID";
            this.labelProductoID.Size = new System.Drawing.Size(83, 20);
            this.labelProductoID.TabIndex = 5;
            this.labelProductoID.Text = "Producto ID:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(12, 48);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(71, 20);
            this.labelCantidad.TabIndex = 6;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(12, 81);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(43, 20);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "Total:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 372);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelProductoID);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProductoID);
            this.Name = "Form5";
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
