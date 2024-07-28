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
            txtCajeroID = new TextBox();
            txtNombre = new TextBox();
            txtApellido1 = new TextBox();
            txtApellido2 = new TextBox();
            btnSubmitCajero = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtCajeroID
            // 
            txtCajeroID.Location = new Point(94, 36);
            txtCajeroID.Margin = new Padding(4, 5, 4, 5);
            txtCajeroID.Name = "txtCajeroID";
            txtCajeroID.PlaceholderText = "Cajero ID";
            txtCajeroID.Size = new Size(178, 27);
            txtCajeroID.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(94, 76);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(178, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido1
            // 
            txtApellido1.Location = new Point(94, 116);
            txtApellido1.Margin = new Padding(4, 5, 4, 5);
            txtApellido1.Name = "txtApellido1";
            txtApellido1.PlaceholderText = "Apellido 1";
            txtApellido1.Size = new Size(178, 27);
            txtApellido1.TabIndex = 2;
            // 
            // txtApellido2
            // 
            txtApellido2.Location = new Point(94, 156);
            txtApellido2.Margin = new Padding(4, 5, 4, 5);
            txtApellido2.Name = "txtApellido2";
            txtApellido2.PlaceholderText = "Apellido 2";
            txtApellido2.Size = new Size(178, 27);
            txtApellido2.TabIndex = 3;
            // 
            // btnSubmitCajero
            // 
            btnSubmitCajero.Location = new Point(94, 196);
            btnSubmitCajero.Margin = new Padding(4, 5, 4, 5);
            btnSubmitCajero.Name = "btnSubmitCajero";
            btnSubmitCajero.Size = new Size(178, 35);
            btnSubmitCajero.TabIndex = 4;
            btnSubmitCajero.Text = "Guardar Cajero";
            btnSubmitCajero.UseVisualStyleBackColor = true;
            btnSubmitCajero.Click += btnSubmitCajero_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 5;
            label1.Text = "CajeroID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 119);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 7;
            label3.Text = "Apellido1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 159);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 8;
            label4.Text = "Apellido2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 311);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCajeroID);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido1);
            Controls.Add(txtApellido2);
            Controls.Add(btnSubmitCajero);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Agregar Cajero";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
