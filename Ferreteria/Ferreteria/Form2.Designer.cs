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
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellido1Cliente = new System.Windows.Forms.TextBox();
            this.txtApellido2Cliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronicoCliente = new System.Windows.Forms.TextBox();
            this.btnSubmitCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnUpdateCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(150, 12);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(178, 27);
            this.txtClienteID.TabIndex = 0;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(150, 45);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(178, 27);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // txtApellido1Cliente
            // 
            this.txtApellido1Cliente.Location = new System.Drawing.Point(150, 78);
            this.txtApellido1Cliente.Name = "txtApellido1Cliente";
            this.txtApellido1Cliente.Size = new System.Drawing.Size(178, 27);
            this.txtApellido1Cliente.TabIndex = 2;
            // 
            // txtApellido2Cliente
            // 
            this.txtApellido2Cliente.Location = new System.Drawing.Point(150, 111);
            this.txtApellido2Cliente.Name = "txtApellido2Cliente";
            this.txtApellido2Cliente.Size = new System.Drawing.Size(178, 27);
            this.txtApellido2Cliente.TabIndex = 3;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(150, 144);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(178, 27);
            this.txtTelefonoCliente.TabIndex = 4;
            // 
            // txtCorreoElectronicoCliente
            // 
            this.txtCorreoElectronicoCliente.Location = new System.Drawing.Point(150, 177);
            this.txtCorreoElectronicoCliente.Name = "txtCorreoElectronicoCliente";
            this.txtCorreoElectronicoCliente.Size = new System.Drawing.Size(178, 27);
            this.txtCorreoElectronicoCliente.TabIndex = 5;
            // 
            // btnSubmitCliente
            // 
            this.btnSubmitCliente.Location = new System.Drawing.Point(150, 210);
            this.btnSubmitCliente.Name = "btnSubmitCliente";
            this.btnSubmitCliente.Size = new System.Drawing.Size(178, 35);
            this.btnSubmitCliente.TabIndex = 6;
            this.btnSubmitCliente.Text = "Agregar Cliente";
            this.btnSubmitCliente.UseVisualStyleBackColor = true;
            this.btnSubmitCliente.Click += new System.EventHandler(this.btnSubmitCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 260);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 29;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(400, 200);
            this.dgvClientes.TabIndex = 7;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // btnUpdateCliente
            // 
            this.btnUpdateCliente.Location = new System.Drawing.Point(150, 470);
            this.btnUpdateCliente.Name = "btnUpdateCliente";
            this.btnUpdateCliente.Size = new System.Drawing.Size(178, 35);
            this.btnUpdateCliente.TabIndex = 8;
            this.btnUpdateCliente.Text = "Actualizar Cliente";
            this.btnUpdateCliente.UseVisualStyleBackColor = true;
            this.btnUpdateCliente.Click += new System.EventHandler(this.btnUpdateCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cliente ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Apellido1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Apellido2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Correo Electrónico:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 521);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateCliente);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnSubmitCliente);
            this.Controls.Add(this.txtCorreoElectronicoCliente);
            this.Controls.Add(this.txtTelefonoCliente);
            this.Controls.Add(this.txtApellido2Cliente);
            this.Controls.Add(this.txtApellido1Cliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtClienteID);
            this.Name = "Form2";
            this.Text = "Formulario de Cliente";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
