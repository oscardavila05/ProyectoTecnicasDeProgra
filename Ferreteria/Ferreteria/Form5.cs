using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ferreteria.Modelos;
using Ferreteria.Controladores;

namespace Ferreteria
{
    public partial class Form5 : Form
    {
        private ControladorVenta controladorVenta;
        /// <summary>
        /// inicia los componetes y el controlador  
        /// </summary>
        public Form5()
        {
            InitializeComponent();
            controladorVenta = new ControladorVenta();
        }

        /// <summary>
        /// carga las ventas desde el csv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form5_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }


        /// <summary>
        /// se registra la venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                Venta venta = new Venta
                {
                    ProductoID = txtProductoID.Text,
                    Cantidad = int.Parse(txtCantidad.Text),
                    Total = decimal.Parse(txtTotal.Text)
                };

                controladorVenta.AgregarVenta(venta);
                CargarVentas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la venta: {ex.Message}");
            }
        }
        /// <summary>
        /// boton para actualizar info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarVenta_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                try
                {
                    int ventaID = (int)dgvVentas.SelectedRows[0].Cells["VentaID"].Value;
                    Venta venta = new Venta
                    {
                        VentaID = ventaID,
                        ProductoID = txtProductoID.Text,
                        Cantidad = int.Parse(txtCantidad.Text),
                        Total = decimal.Parse(txtTotal.Text)
                    };

                    controladorVenta.ActualizarVenta(venta);
                    CargarVentas();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la venta: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una venta para actualizar.");
            }
        }

        /// <summary>
        /// carga las celdas al tocar cada venta en el grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVentas.Rows[e.RowIndex];
                txtProductoID.Text = row.Cells["ProductoID"].Value.ToString();
                txtCantidad.Text = row.Cells["Cantidad"].Value.ToString();
                txtTotal.Text = row.Cells["Total"].Value.ToString();
            }
        }

        /// <summary>
        /// obtiene la lista ventas del csv
        /// </summary>
        private void CargarVentas()
        {
            var ventas = controladorVenta.ObtenerVentas();
            dgvVentas.DataSource = ventas.Select(v => new { v.VentaID, v.ProductoID, v.Cantidad, v.Total }).ToList();
        }

        /// <summary>
        /// limpia los campos
        /// </summary>
        private void LimpiarCampos()
        {
            txtProductoID.Clear();
            txtCantidad.Clear();
            txtTotal.Clear();
        }
    }
}
