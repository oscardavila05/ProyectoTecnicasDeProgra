using System;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class Form4 : Form
    {
        private Form1 form1;  // Suponiendo que Form1 es el formulario de Cajero
        private Form2 form2;  // Suponiendo que Form2 es el formulario de Cliente
        private Form3 form3;  // Suponiendo que Form3 es el formulario de Producto
        private Form5 form5;  // Suponiendo que Form5 es el formulario de Ventas

        /// <summary>
        /// Constructor del formulario Form4. Inicializa los componentes y los formularios.
        /// </summary>
        public Form4()
        {
            InitializeComponent();
            InicializarFormularios();
        }

        /// <summary>
        /// Inicializa los formularios Cajero, Cliente, Producto y Ventas y los agrega a los TabPages.
        /// </summary>
        private void InicializarFormularios()
        {
            
            form1 = new Form1();  
            form2 = new Form2();  
            form3 = new Form3();  
            form5 = new Form5();  

            // Agregar los formularios a las pestañas del TabControl solo si no están ya presentes
            if (tabControlForms.TabPages.Count == 0)
            {
                AgregarFormularioATabPage(form1, "Cajero");
                AgregarFormularioATabPage(form2, "Cliente");
                AgregarFormularioATabPage(form3, "Producto");
                AgregarFormularioATabPage(form5, "Registrar Ventas");
            }
        }

        /// <summary>
        /// Agrega un formulario a un TabPage y lo agrega al TabControl.
        /// </summary>
        /// <param name="form">El formulario a agregar.</param>
        /// <param name="tabTitle">El título del TabPage.</param>
        private void AgregarFormularioATabPage(Form form, string tabTitle)
        {
            TabPage tabPage = new TabPage(tabTitle);
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tabPage.Controls.Add(form);
            tabControlForms.TabPages.Add(tabPage);
            form.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void tabControlForms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
