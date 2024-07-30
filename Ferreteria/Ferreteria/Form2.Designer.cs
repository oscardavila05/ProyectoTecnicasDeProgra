namespace Ferreteria
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtApellido1Cliente;
        private System.Windows.Forms.TextBox txtApellido2Cliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txtCorreoElectronicoCliente;
        private System.Windows.Forms.Button btnSubmitCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnUpdateCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private void InitializeComponent()
        {
            txtClienteID = new TextBox();
            txtNombreCliente = new TextBox();
            txtApellido1Cliente = new TextBox();
            txtApellido2Cliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtCorreoElectronicoCliente = new TextBox();
            btnSubmitCliente = new Button();
            dgvClientes = new DataGridView();
            btnUpdateCliente = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtClienteID
            // 
            txtClienteID.Location = new Point(150, 12);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.Size = new Size(178, 27);
            txtClienteID.TabIndex = 0;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(150, 45);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(178, 27);
            txtNombreCliente.TabIndex = 1;
            // 
            // txtApellido1Cliente
            // 
            txtApellido1Cliente.Location = new Point(150, 78);
            txtApellido1Cliente.Name = "txtApellido1Cliente";
            txtApellido1Cliente.Size = new Size(178, 27);
            txtApellido1Cliente.TabIndex = 2;
            // 
            // txtApellido2Cliente
            // 
            txtApellido2Cliente.Location = new Point(150, 111);
            txtApellido2Cliente.Name = "txtApellido2Cliente";
            txtApellido2Cliente.Size = new Size(178, 27);
            txtApellido2Cliente.TabIndex = 3;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(150, 144);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(178, 27);
            txtTelefonoCliente.TabIndex = 4;
            // 
            // txtCorreoElectronicoCliente
            // 
            txtCorreoElectronicoCliente.Location = new Point(150, 177);
            txtCorreoElectronicoCliente.Name = "txtCorreoElectronicoCliente";
            txtCorreoElectronicoCliente.Size = new Size(178, 27);
            txtCorreoElectronicoCliente.TabIndex = 5;
            // 
            // btnSubmitCliente
            // 
            btnSubmitCliente.Location = new Point(150, 210);
            btnSubmitCliente.Name = "btnSubmitCliente";
            btnSubmitCliente.Size = new Size(178, 35);
            btnSubmitCliente.TabIndex = 6;
            btnSubmitCliente.Text = "Agregar Cliente";
            btnSubmitCliente.UseVisualStyleBackColor = true;
            btnSubmitCliente.Click += btnSubmitCliente_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 260);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(820, 200);
            dgvClientes.TabIndex = 7;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // btnUpdateCliente
            // 
            btnUpdateCliente.Location = new Point(150, 470);
            btnUpdateCliente.Name = "btnUpdateCliente";
            btnUpdateCliente.Size = new Size(178, 35);
            btnUpdateCliente.TabIndex = 8;
            btnUpdateCliente.Text = "Actualizar Cliente";
            btnUpdateCliente.UseVisualStyleBackColor = true;
            btnUpdateCliente.Click += btnUpdateCliente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 9;
            label1.Text = "Cliente ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 10;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 11;
            label3.Text = "Apellido1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 12;
            label4.Text = "Apellido2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 147);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 13;
            label5.Text = "Teléfono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 180);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 14;
            label6.Text = "Correo Electrónico:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 521);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdateCliente);
            Controls.Add(dgvClientes);
            Controls.Add(btnSubmitCliente);
            Controls.Add(txtCorreoElectronicoCliente);
            Controls.Add(txtTelefonoCliente);
            Controls.Add(txtApellido2Cliente);
            Controls.Add(txtApellido1Cliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(txtClienteID);
            Name = "Form2";
            Text = "Formulario de Cliente";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
