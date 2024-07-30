using System;
using System.Collections.Generic;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCajeros();
        }

        private void btnSubmitCajero_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Cajero cajero = new Cajero
                {
                    CajeroID = txtCajeroID.Text,
                    Nombre = txtNombre.Text,
                    Apellido1 = txtApellido1.Text,
                    Apellido2 = txtApellido2.Text,
                    Telefono = txtTelefono.Text,
                    CorreoElectronico = txtCorreoElectronico.Text
                };

                controladorCajero.AgregarCajero(cajero);
                MessageBox.Show("Información del cajero guardada en el archivo CSV");
                CargarCajeros();
            }
        }

        private void btnUpdateCajero_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Cajero cajero = new Cajero
                {
                    CajeroID = txtCajeroID.Text,
                    Nombre = txtNombre.Text,
                    Apellido1 = txtApellido1.Text,
                    Apellido2 = txtApellido2.Text,
                    Telefono = txtTelefono.Text,
                    CorreoElectronico = txtCorreoElectronico.Text
                };

                controladorCajero.ActualizarCajero(cajero);
                MessageBox.Show("Información del cajero actualizada en el archivo CSV");
                CargarCajeros();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCajeroID.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido1.Text) ||
                string.IsNullOrWhiteSpace(txtApellido2.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreoElectronico.Text))
            {
                MessageBox.Show("Todos los campos deben ser llenados.");
                return false;
            }

            return true;
        }

        private void CargarCajeros()
        {
            dgvCajeros.DataSource = null;
            List<Cajero> cajeros = controladorCajero.ObtenerCajeros();
            dgvCajeros.DataSource = cajeros;
        }

        private void dgvCajeros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCajeros.Rows[e.RowIndex];
                txtCajeroID.Text = row.Cells["CajeroID"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido1.Text = row.Cells["Apellido1"].Value.ToString();
                txtApellido2.Text = row.Cells["Apellido2"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtCorreoElectronico.Text = row.Cells["CorreoElectronico"].Value.ToString();
            }
        }
    }
}
