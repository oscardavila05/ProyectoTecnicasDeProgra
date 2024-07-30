using System;
using System.Windows.Forms;
using Ferreteria.Modelos;
using Ferreteria.Controladores;
using System.Collections.Generic;
using System.Linq;

namespace Ferreteria
{
    public partial class Form3 : Form
    {
        private ControladorProducto controladorProducto;

        public Form3()
        {
            InitializeComponent();
            controladorProducto = new ControladorProducto();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

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

            controladorProducto.AgregarProducto(producto);
            MessageBox.Show("Información del producto guardada en el archivo CSV");
            CargarProductos();
        }

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

        private void CargarProductos()
        {
            dgvProductos.DataSource = null;
            List<Producto> productos = controladorProducto.ObtenerProductos();
            dgvProductos.DataSource = productos;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
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
