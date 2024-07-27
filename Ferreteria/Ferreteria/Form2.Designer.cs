// Ferreteria/Form2.Designer.cs
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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellido1Cliente = new System.Windows.Forms.TextBox();
            this.txtApellido2Cliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronicoCliente = new System.Windows.Forms.TextBox();
            this.btnSubmitCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(12, 12);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(260, 20);
            this.txtClienteID.TabIndex = 0;
            this.txtClienteID.PlaceholderText = "Cliente ID";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(12, 38);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(260, 20);
            this.txtNombreCliente.TabIndex = 1;
            this.txtNombreCliente.PlaceholderText = "Nombre";
            // 
            // txtApellido1Cliente
            // 
            this.txtApellido1Cliente.Location = new System.Drawing.Point(12, 64);
            this.txtApellido1Cliente.Name = "txtApellido1Cliente";
            this.txtApellido1Cliente.Size = new System.Drawing.Size(260, 20);
            this.txtApellido1Cliente.TabIndex = 2;
            this.txtApellido1Cliente.PlaceholderText = "Primer Apellido";
            // 
            // txtApellido2Cliente
            // 
            this.txtApellido2Cliente.Location = new System.Drawing.Point(12, 90);
            this.txtApellido2Cliente.Name = "txtApellido2Cliente";
            this.txtApellido2Cliente.Size = new System.Drawing.Size(260, 20);
            this.txtApellido2Cliente.TabIndex = 3;
            this.txtApellido2Cliente.PlaceholderText = "Segundo Apellido";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(12, 116);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(260, 20);
            this.txtTelefonoCliente.TabIndex = 4;
            this.txtTelefonoCliente.PlaceholderText = "Teléfono";
            // 
            // txtCorreoElectronicoCliente
            // 
            this.txtCorreoElectronicoCliente.Location = new System.Drawing.Point(12, 142);
            this.txtCorreoElectronicoCliente.Name = "txtCorreoElectronicoCliente";
            this.txtCorreoElectronicoCliente.Size = new System.Drawing.Size(260, 20);
            this.txtCorreoElectronicoCliente.TabIndex = 5;
            this.txtCorreoElectronicoCliente.PlaceholderText = "Correo Electrónico";
            // 
            // btnSubmitCliente
            // 
            this.btnSubmitCliente.Location = new System.Drawing.Point(197, 168);
            this.btnSubmitCliente.Name = "btnSubmitCliente";
            this.btnSubmitCliente.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitCliente.TabIndex = 6;
            this.btnSubmitCliente.Text = "Agregar Cliente";
            this.btnSubmitCliente.UseVisualStyleBackColor = true;
            this.btnSubmitCliente.Click += new System.EventHandler(this.btnSubmitCliente_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
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
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
