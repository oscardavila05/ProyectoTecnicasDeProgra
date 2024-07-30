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
            this.txtCajeroID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.btnSubmitCajero = new System.Windows.Forms.Button();
            this.dgvCajeros = new System.Windows.Forms.DataGridView();
            this.btnUpdateCajero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCajeroID
            // 
            this.txtCajeroID.Location = new System.Drawing.Point(150, 12);
            this.txtCajeroID.Name = "txtCajeroID";
            this.txtCajeroID.Size = new System.Drawing.Size(178, 27);
            this.txtCajeroID.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(150, 78);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(178, 27);
            this.txtApellido1.TabIndex = 2;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(150, 111);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(178, 27);
            this.txtApellido2.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(150, 144);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(178, 27);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(150, 177);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(178, 27);
            this.txtCorreoElectronico.TabIndex = 5;
            // 
            // btnSubmitCajero
            // 
            this.btnSubmitCajero.Location = new System.Drawing.Point(150, 210);
            this.btnSubmitCajero.Name = "btnSubmitCajero";
            this.btnSubmitCajero.Size = new System.Drawing.Size(178, 35);
            this.btnSubmitCajero.TabIndex = 6;
            this.btnSubmitCajero.Text = "Agregar Cajero";
            this.btnSubmitCajero.UseVisualStyleBackColor = true;
            this.btnSubmitCajero.Click += new System.EventHandler(this.btnSubmitCajero_Click);
            // 
            // dgvCajeros
            // 
            this.dgvCajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCajeros.Location = new System.Drawing.Point(12, 255);
            this.dgvCajeros.Name = "dgvCajeros";
            this.dgvCajeros.RowHeadersWidth = 51;
            this.dgvCajeros.RowTemplate.Height = 29;
            this.dgvCajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCajeros.Size = new System.Drawing.Size(400, 200);
            this.dgvCajeros.TabIndex = 7;
            this.dgvCajeros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCajeros_CellClick);
            // 
            // btnUpdateCajero
            // 
            this.btnUpdateCajero.Location = new System.Drawing.Point(150, 470);
            this.btnUpdateCajero.Name = "btnUpdateCajero";
            this.btnUpdateCajero.Size = new System.Drawing.Size(178, 35);
            this.btnUpdateCajero.TabIndex = 8;
            this.btnUpdateCajero.Text = "Actualizar Cajero";
            this.btnUpdateCajero.UseVisualStyleBackColor = true;
            this.btnUpdateCajero.Click += new System.EventHandler(this.btnUpdateCajero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cajero ID:";
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
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Apellido 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Apellido 2:";
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
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Correo Electrónico:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 517);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateCajero);
            this.Controls.Add(this.dgvCajeros);
            this.Controls.Add(this.btnSubmitCajero);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCajeroID);
            this.Name = "Form1";
            this.Text = "Formulario de Cajero";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
