namespace Ferreteria
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCajeroID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Button btnSubmitCajero;
        private System.Windows.Forms.DataGridView dgvCajeros;
        private System.Windows.Forms.Button btnUpdateCajero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private void InitializeComponent()
        {
            txtCajeroID = new TextBox();
            txtNombre = new TextBox();
            txtApellido1 = new TextBox();
            txtApellido2 = new TextBox();
            txtTelefono = new TextBox();
            txtCorreoElectronico = new TextBox();
            btnSubmitCajero = new Button();
            dgvCajeros = new DataGridView();
            btnUpdateCajero = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCajeros).BeginInit();
            SuspendLayout();
            // 
            // txtCajeroID
            // 
            txtCajeroID.Location = new Point(150, 12);
            txtCajeroID.Name = "txtCajeroID";
            txtCajeroID.Size = new Size(178, 27);
            txtCajeroID.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(178, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido1
            // 
            txtApellido1.Location = new Point(150, 78);
            txtApellido1.Name = "txtApellido1";
            txtApellido1.Size = new Size(178, 27);
            txtApellido1.TabIndex = 2;
            // 
            // txtApellido2
            // 
            txtApellido2.Location = new Point(150, 111);
            txtApellido2.Name = "txtApellido2";
            txtApellido2.Size = new Size(178, 27);
            txtApellido2.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(150, 144);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(178, 27);
            txtTelefono.TabIndex = 4;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(150, 177);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(178, 27);
            txtCorreoElectronico.TabIndex = 5;
            // 
            // btnSubmitCajero
            // 
            btnSubmitCajero.Location = new Point(150, 210);
            btnSubmitCajero.Name = "btnSubmitCajero";
            btnSubmitCajero.Size = new Size(178, 35);
            btnSubmitCajero.TabIndex = 6;
            btnSubmitCajero.Text = "Agregar Cajero";
            btnSubmitCajero.UseVisualStyleBackColor = true;
            btnSubmitCajero.Click += btnSubmitCajero_Click;
            // 
            // dgvCajeros
            // 
            dgvCajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCajeros.Location = new Point(12, 255);
            dgvCajeros.Name = "dgvCajeros";
            dgvCajeros.RowHeadersWidth = 51;
            dgvCajeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCajeros.Size = new Size(826, 200);
            dgvCajeros.TabIndex = 7;
            dgvCajeros.CellClick += dgvCajeros_CellClick;
            // 
            // btnUpdateCajero
            // 
            btnUpdateCajero.Location = new Point(150, 470);
            btnUpdateCajero.Name = "btnUpdateCajero";
            btnUpdateCajero.Size = new Size(178, 35);
            btnUpdateCajero.TabIndex = 8;
            btnUpdateCajero.Text = "Actualizar Cajero";
            btnUpdateCajero.UseVisualStyleBackColor = true;
            btnUpdateCajero.Click += btnUpdateCajero_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 9;
            label1.Text = "Cajero ID:";
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
            label3.Size = new Size(81, 20);
            label3.TabIndex = 11;
            label3.Text = "Apellido 1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 12;
            label4.Text = "Apellido 2:";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 517);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdateCajero);
            Controls.Add(dgvCajeros);
            Controls.Add(btnSubmitCajero);
            Controls.Add(txtCorreoElectronico);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido2);
            Controls.Add(txtApellido1);
            Controls.Add(txtNombre);
            Controls.Add(txtCajeroID);
            Name = "Form1";
            Text = "Formulario de Cajero";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCajeros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
