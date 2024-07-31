using System;
using System.Windows.Forms;
using Ferreteria.Modelos;
using Ferreteria.Controladores;
using System.Collections.Generic;
using System.Linq;

namespace Ferreteria
{
    public partial class Form2 : Form
    {
        //contorlador para manejar operaciones del cliente 
        private ControladorCliente controladorCliente;


        /// <summary>
        /// contructor formulario
        /// </summary>
        public Form2()
        {

            //incializa el controlador de los clientes
            InitializeComponent();
            controladorCliente = new ControladorCliente();
        }

        /// <summary>
        /// evento que carga la lista de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        /// <summary>
        /// boton para agregar el cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
            CargarClientes();
        }
        /// <summary>
        /// boton para actualizar info del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateCliente_Click(object sender, EventArgs e)
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

            controladorCliente.ActualizarCliente(cliente);
            MessageBox.Show("Información del cliente actualizada en el archivo CSV");
            CargarClientes();
        }
        /// <summary>
        /// carga de clientes desde el csv
        /// </summary>
        private void CargarClientes()
        {
            dgvClientes.DataSource = null;
            List<Cliente> clientes = controladorCliente.ObtenerClientes();
            dgvClientes.DataSource = clientes;
        }

        /// <summary>
        /// evento para obtener los clientes en el data grid desde el csv 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];
                txtClienteID.Text = row.Cells["ClienteID"].Value.ToString();
                txtNombreCliente.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido1Cliente.Text = row.Cells["Apellido1"].Value.ToString();
                txtApellido2Cliente.Text = row.Cells["Apellido2"].Value.ToString();
                txtTelefonoCliente.Text = row.Cells["Telefono"].Value.ToString();
                txtCorreoElectronicoCliente.Text = row.Cells["CorreoElectronico"].Value.ToString();
            }
        }
    }
}
    