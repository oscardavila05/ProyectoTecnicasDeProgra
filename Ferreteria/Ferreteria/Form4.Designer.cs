namespace Ferreteria
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControlForms;

        private void InitializeComponent()
        {
            tabControlForms = new TabControl();
            SuspendLayout();
            // 
            // tabControlForms
            // 
            tabControlForms.Dock = DockStyle.Fill;
            tabControlForms.Location = new Point(0, 0);
            tabControlForms.Name = "tabControlForms";
            tabControlForms.SelectedIndex = 0;
            tabControlForms.Size = new Size(1309, 573);
            tabControlForms.TabIndex = 0;
            // 
            // Form4
            // 
            ClientSize = new Size(1309, 573);
            Controls.Add(tabControlForms);
            Name = "Form4";
            Text = "Formulario Principal";
            Load += Form4_Load;
            ResumeLayout(false);
        }
    }
}
