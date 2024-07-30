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
            txtProductoId = new TextBox();
            txtNombreProducto = new TextBox();
            txtMarcaProducto = new TextBox();
            txtPrecioCompraProducto = new TextBox();
            txtPrecioVentaProducto = new TextBox();
            txtStockProducto = new TextBox();
            chkEstadoProducto = new CheckBox();
            btnSubmitProducto = new Button();
            dgvProductos = new DataGridView();
            btnUpdateProducto = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtProductoId
            // 
            txtProductoId.Location = new Point(150, 12);
            txtProductoId.Name = "txtProductoId";
            txtProductoId.Size = new Size(178, 27);
            txtProductoId.TabIndex = 0;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(150, 45);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(178, 27);
            txtNombreProducto.TabIndex = 1;
            // 
            // txtMarcaProducto
            // 
            txtMarcaProducto.Location = new Point(150, 78);
            txtMarcaProducto.Name = "txtMarcaProducto";
            txtMarcaProducto.Size = new Size(178, 27);
            txtMarcaProducto.TabIndex = 2;
            // 
            // txtPrecioCompraProducto
            // 
            txtPrecioCompraProducto.Location = new Point(150, 111);
            txtPrecioCompraProducto.Name = "txtPrecioCompraProducto";
            txtPrecioCompraProducto.Size = new Size(178, 27);
            txtPrecioCompraProducto.TabIndex = 3;
            // 
            // txtPrecioVentaProducto
            // 
            txtPrecioVentaProducto.Location = new Point(150, 144);
            txtPrecioVentaProducto.Name = "txtPrecioVentaProducto";
            txtPrecioVentaProducto.Size = new Size(178, 27);
            txtPrecioVentaProducto.TabIndex = 4;
            // 
            // txtStockProducto
            // 
            txtStockProducto.Location = new Point(150, 177);
            txtStockProducto.Name = "txtStockProducto";
            txtStockProducto.Size = new Size(178, 27);
            txtStockProducto.TabIndex = 5;
            // 
            // chkEstadoProducto
            // 
            chkEstadoProducto.AutoSize = true;
            chkEstadoProducto.Location = new Point(150, 210);
            chkEstadoProducto.Name = "chkEstadoProducto";
            chkEstadoProducto.Size = new Size(76, 24);
            chkEstadoProducto.TabIndex = 6;
            chkEstadoProducto.Text = "Estado";
            chkEstadoProducto.UseVisualStyleBackColor = true;
            // 
            // btnSubmitProducto
            // 
            btnSubmitProducto.Location = new Point(150, 240);
            btnSubmitProducto.Name = "btnSubmitProducto";
            btnSubmitProducto.Size = new Size(178, 35);
            btnSubmitProducto.TabIndex = 7;
            btnSubmitProducto.Text = "Agregar Producto";
            btnSubmitProducto.UseVisualStyleBackColor = true;
            btnSubmitProducto.Click += btnSubmitProducto_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 290);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(858, 200);
            dgvProductos.TabIndex = 8;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // btnUpdateProducto
            // 
            btnUpdateProducto.Location = new Point(150, 500);
            btnUpdateProducto.Name = "btnUpdateProducto";
            btnUpdateProducto.Size = new Size(178, 35);
            btnUpdateProducto.TabIndex = 9;
            btnUpdateProducto.Text = "Actualizar Producto";
            btnUpdateProducto.UseVisualStyleBackColor = true;
            btnUpdateProducto.Click += btnUpdateProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 10;
            label1.Text = "Producto ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 11;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 12;
            label3.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 13;
            label4.Text = "Precio Compra:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 147);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 14;
            label5.Text = "Precio Venta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 180);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 15;
            label6.Text = "Stock:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 213);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 16;
            label7.Text = "Estado:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 552);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdateProducto);
            Controls.Add(dgvProductos);
            Controls.Add(btnSubmitProducto);
            Controls.Add(chkEstadoProducto);
            Controls.Add(txtStockProducto);
            Controls.Add(txtPrecioVentaProducto);
            Controls.Add(txtPrecioCompraProducto);
            Controls.Add(txtMarcaProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtProductoId);
            Name = "Form3";
            Text = "Formulario de Producto";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
