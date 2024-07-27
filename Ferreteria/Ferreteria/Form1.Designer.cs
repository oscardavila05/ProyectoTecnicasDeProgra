namespace Ferreteria
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCajeroID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Button btnSubmitCajero;

        private void InitializeComponent()
        {
            this.txtCajeroID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.btnSubmitCajero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCajeroID
            // 
            this.txtCajeroID.Location = new System.Drawing.Point(12, 12);
            this.txtCajeroID.Name = "txtCajeroID";
            this.txtCajeroID.Size = new System.Drawing.Size(260, 20);
            this.txtCajeroID.TabIndex = 0;
            this.txtCajeroID.PlaceholderText = "Cajero ID";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(260, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.PlaceholderText = "Nombre";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(12, 64);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(260, 20);
            this.txtApellido1.TabIndex = 2;
            this.txtApellido1.PlaceholderText = "Apellido 1";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(12, 90);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(260, 20);
            this.txtApellido2.TabIndex = 3;
            this.txtApellido2.PlaceholderText = "Apellido 2";
            // 
            // btnSubmitCajero
            // 
            this.btnSubmitCajero.Location = new System.Drawing.Point(12, 116);
            this.btnSubmitCajero.Name = "btnSubmitCajero";
            this.btnSubmitCajero.Size = new System.Drawing.Size(260, 23);
            this.btnSubmitCajero.TabIndex = 4;
            this.btnSubmitCajero.Text = "Guardar Cajero";
            this.btnSubmitCajero.UseVisualStyleBackColor = true;
            this.btnSubmitCajero.Click += new System.EventHandler(this.btnSubmitCajero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.txtCajeroID);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.btnSubmitCajero);
            this.Name = "Form1";
            this.Text = "Agregar Cajero";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
