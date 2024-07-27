// Ferreteria/Form2.cs
using System;
using System.Windows.Forms;
using Ferreteria.Modelos;
using Ferreteria.Controladores;

namespace Ferreteria
{
    public partial class Form2 : Form
    {
        private ControladorCliente controladorCliente;

        public Form2()
        {
            InitializeComponent();
            controladorCliente = new ControladorCliente();
        }

        private void btnSubmitCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                ClienteID = txtClienteID.Text,
                Nombre = txtNombreCliente.Text,
                Apellido1 = txtApellido1Cliente.Text,
                Apellido2 = txtApellido2Cliente.Text,
                Telefono = txtTelefonoCliente.Text,
                CorreoElectronico = txtCorreoElectronicoCliente.Text
            };

            controladorCliente.AgregarCliente(cliente);
            MessageBox.Show("Información del cliente guardada en el archivo CSV");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Aquí puedes inicializar cosas si es necesario al cargar el formulario
        }
    }
}
