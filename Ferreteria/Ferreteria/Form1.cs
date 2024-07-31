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

        /// <summary>
        /// metodo que se ejecuta al inciar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCajeros();
        }

        /// <summary>
        /// ejecuta el boton al darle click agregar cajero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// boton para actualizar los cajeros la info 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateCajero_Click(object sender, EventArgs e)
        {
            //valida que los campos esten llenos
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

                //actualiza los datos del cajero con el controlador
                
                controladorCajero.ActualizarCajero(cajero);
                MessageBox.Show("Información del cajero actualizada en el archivo CSV");
                
                //carga los datos en el data grid
                CargarCajeros();
            }
        }

        /// <summary>
        /// Validars los campos.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// metodo para Cargars los cajeros.
        /// </summary>
        private void CargarCajeros()
        {
            dgvCajeros.DataSource = null;
            List<Cajero> cajeros = controladorCajero.ObtenerCajeros();
            dgvCajeros.DataSource = cajeros;
        }

        /// <summary>
        /// metodo para hacer click en el form y ver la info del cajero 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
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
