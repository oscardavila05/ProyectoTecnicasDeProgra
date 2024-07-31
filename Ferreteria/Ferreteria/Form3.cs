using System;
using System.Windows.Forms;
using Ferreteria.Modelos;
using Ferreteria.Controladores;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Eventing.Reader;

namespace Ferreteria
{
    public partial class Form3 : Form
    {   
        /// <summary>
        /// instancia del controlador para manejar los productos 
        /// </summary>
        private ControladorProducto controladorProducto;

        /// <summary>
        /// contructor del formulario
        /// </summary>
        public Form3()
        {
            InitializeComponent();

            //crea la instancia del controlador de productos
            controladorProducto = new ControladorProducto();
        }

        /// <summary>
        /// evento que se ejecuta cuando el formulario se incia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void Form3_Load(object sender, EventArgs e)
        {
            //carga los datos en el datagrid
            CargarProductos();
        }
        /// <summary>
        /// boton para agregar los productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmitProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto
            {
                ProductoId = txtProductoId.Text,
                Nombre = txtNombreProducto.Text,
                Marca = txtMarcaProducto.Text,
                PrecioCompra = decimal.Parse(txtPrecioCompraProducto.Text),
                PrecioVenta = decimal.Parse(txtPrecioVentaProducto.Text),
                Stock = int.Parse(txtStockProducto.Text),
                Estado = chkEstadoProducto.Checked
            };

            ///agrega el producto desde el controlador al csv

            controladorProducto.AgregarProducto(producto);
            MessageBox.Show("Información del producto guardada en el archivo CSV");
            CargarProductos();
        }
        /// <summary>
        /// boton para actualizar info del producto 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto
            {
                ProductoId = txtProductoId.Text,
                Nombre = txtNombreProducto.Text,
                Marca = txtMarcaProducto.Text,
                PrecioCompra = decimal.Parse(txtPrecioCompraProducto.Text),
                PrecioVenta = decimal.Parse(txtPrecioVentaProducto.Text),
                Stock = int.Parse(txtStockProducto.Text),
                Estado = chkEstadoProducto.Checked
            };

            controladorProducto.ActualizarProducto(producto);
            MessageBox.Show("Información del producto actualizada en el archivo CSV");
            CargarProductos();
        }
        /// <summary>
        /// metodo para cargar los productos en el data grid
        /// </summary>
        private void CargarProductos()
        {
            dgvProductos.DataSource = null;
            List<Producto> productos = controladorProducto.ObtenerProductos();
            dgvProductos.DataSource = productos;
        }

        /// <summary>
        /// Evento que se ejecuta cuando se hace clic en una celda del DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

                // Rellena los campos del formulario con los datos del producto seleccionado
                txtProductoId.Text = row.Cells["ProductoId"].Value.ToString();
                txtNombreProducto.Text = row.Cells["Nombre"].Value.ToString();
                txtMarcaProducto.Text = row.Cells["Marca"].Value.ToString();
                txtPrecioCompraProducto.Text = row.Cells["PrecioCompra"].Value.ToString();
                txtPrecioVentaProducto.Text = row.Cells["PrecioVenta"].Value.ToString();
                txtStockProducto.Text = row.Cells["Stock"].Value.ToString();
                chkEstadoProducto.Checked = (bool)row.Cells["Estado"].Value;
            }
        }
    }
}
