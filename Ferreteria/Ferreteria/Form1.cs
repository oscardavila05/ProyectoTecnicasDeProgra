using System;
using System.Windows.Forms;
using Ferreteria.Modelos;
using Ferreteria.Controladores;

namespace Ferreteria
{
    public partial class Form1 : Form
    {
        private ControladorCajero controladorCajero;

        public Form1()
        {
            InitializeComponent();
            controladorCajero = new ControladorCajero();
        }

        private void btnSubmitCajero_Click(object sender, EventArgs e)
        {
            Cajero cajero = new Cajero
            {
                CajeroID = txtCajeroID.Text,
                Nombre = txtNombre.Text,
                Apellido1 = txtApellido1.Text,
                Apellido2 = txtApellido2.Text
            };

            controladorCajero.AgregarCajero(cajero);
            MessageBox.Show("Información del cajero guardada en el archivo CSV");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
