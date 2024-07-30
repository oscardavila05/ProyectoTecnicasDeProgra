namespace Ferreteria
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtProductoId;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtMarcaProducto;
        private System.Windows.Forms.TextBox txtPrecioCompraProducto;
        private System.Windows.Forms.TextBox txtPrecioVentaProducto;
        private System.Windows.Forms.TextBox txtStockProducto;
        private System.Windows.Forms.CheckBox chkEstadoProducto;
        private System.Windows.Forms.Button btnSubmitProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnUpdateProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private void InitializeComponent()
        {
            this.txtProductoId = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtMarcaProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioCompraProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioVentaProducto = new System.Windows.Forms.TextBox();
            this.txtStockProducto = new System.Windows.Forms.TextBox();
            this.chkEstadoProducto = new System.Windows.Forms.CheckBox();
            this.btnSubmitProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnUpdateProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductoId
            // 
            this.txtProductoId.Location = new System.Drawing.Point(150, 12);
            this.txtProductoId.Name = "txtProductoId";
            this.txtProductoId.Size = new System.Drawing.Size(178, 27);
            this.txtProductoId.TabIndex = 0;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(150, 45);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(178, 27);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // txtMarcaProducto
            // 
            this.txtMarcaProducto.Location = new System.Drawing.Point(150, 78);
            this.txtMarcaProducto.Name = "txtMarcaProducto";
            this.txtMarcaProducto.Size = new System.Drawing.Size(178, 27);
            this.txtMarcaProducto.TabIndex = 2;
            // 
            // txtPrecioCompraProducto
            // 
            this.txtPrecioCompraProducto.Location = new System.Drawing.Point(150, 111);
            this.txtPrecioCompraProducto.Name = "txtPrecioCompraProducto";
            this.txtPrecioCompraProducto.Size = new System.Drawing.Size(178, 27);
            this.txtPrecioCompraProducto.TabIndex = 3;
            // 
            // txtPrecioVentaProducto
            // 
            this.txtPrecioVentaProducto.Location = new System.Drawing.Point(150, 144);
            this.txtPrecioVentaProducto.Name = "txtPrecioVentaProducto";
            this.txtPrecioVentaProducto.Size = new System.Drawing.Size(178, 27);
            this.txtPrecioVentaProducto.TabIndex = 4;
            // 
            // txtStockProducto
            // 
            this.txtStockProducto.Location = new System.Drawing.Point(150, 177);
            this.txtStockProducto.Name = "txtStockProducto";
            this.txtStockProducto.Size = new System.Drawing.Size(178, 27);
            this.txtStockProducto.TabIndex = 5;
            // 
            // chkEstadoProducto
            // 
            this.chkEstadoProducto.AutoSize = true;
            this.chkEstadoProducto.Location = new System.Drawing.Point(150, 210);
            this.chkEstadoProducto.Name = "chkEstadoProducto";
            this.chkEstadoProducto.Size = new System.Drawing.Size(78, 24);
            this.chkEstadoProducto.TabIndex = 6;
            this.chkEstadoProducto.Text = "Estado";
            this.chkEstadoProducto.UseVisualStyleBackColor = true;
            // 
            // btnSubmitProducto
            // 
            this.btnSubmitProducto.Location = new System.Drawing.Point(150, 240);
            this.btnSubmitProducto.Name = "btnSubmitProducto";
            this.btnSubmitProducto.Size = new System.Drawing.Size(178, 35);
            this.btnSubmitProducto.TabIndex = 7;
            this.btnSubmitProducto.Text = "Agregar Producto";
            this.btnSubmitProducto.UseVisualStyleBackColor = true;
            this.btnSubmitProducto.Click += new System.EventHandler(this.btnSubmitProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 290);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 29;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(400, 200);
            this.dgvProductos.TabIndex = 8;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // btnUpdateProducto
            // 
            this.btnUpdateProducto.Location = new System.Drawing.Point(150, 500);
            this.btnUpdateProducto.Name = "btnUpdateProducto";
            this.btnUpdateProducto.Size = new System.Drawing.Size(178, 35);
            this.btnUpdateProducto.TabIndex = 9;
            this.btnUpdateProducto.Text = "Actualizar Producto";
            this.btnUpdateProducto.UseVisualStyleBackColor = true;
            this.btnUpdateProducto.Click += new System.EventHandler(this.btnUpdateProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Producto ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Precio Compra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Precio Venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Stock:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Estado:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 552);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateProducto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnSubmitProducto);
            this.Controls.Add(this.chkEstadoProducto);
            this.Controls.Add(this.txtStockProducto);
            this.Controls.Add(this.txtPrecioVentaProducto);
            this.Controls.Add(this.txtPrecioCompraProducto);
            this.Controls.Add(this.txtMarcaProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtProductoId);
            this.Name = "Form3";
            this.Text = "Formulario de Producto";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
