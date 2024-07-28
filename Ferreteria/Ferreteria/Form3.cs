using System;
using System.Windows.Forms;
using Ferreteria.Controladores;

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
        }

        private void btnSubmitProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto
            {
                ProductoId = txtProductoID.Text,
                Nombre = txtNombreProducto.Text,
                Marca = txtMarcaProducto.Text,
                PrecioCompra = decimal.Parse(txtPrecioCompra.Text),
                PrecioVenta = decimal.Parse(txtPrecioVenta.Text),
                Stock = int.Parse(txtStock.Text),
                Estado = chkEstado.Checked
            };

            controladorProducto.AgregarProducto(producto);
            MessageBox.Show("Información del producto guardada en el archivo CSV");
        }
    }
}
