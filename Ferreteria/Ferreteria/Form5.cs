using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ferreteria.Modelos;
using System.IO;

namespace Ferreteria
{
    public partial class Form5 : Form
    {
        private List<Venta> ventas;

        /// <summary>
        /// Constructor del formulario Form5. Inicializa los componentes y carga las ventas.
        /// </summary>
        public Form5()
        {
            InitializeComponent();
            ventas = new List<Venta>();
        }

        /// <summary>
        /// Carga las ventas desde el archivo CSV cuando se carga el formulario.
        /// </summary>
        private void Form5_Load(object sender, EventArgs e)
        {
            CargarVentasDesdeCsv();
            ActualizarDataGridView();
        }

        /// <summary>
        /// Registra una venta y guarda la información en un archivo CSV.
        /// </summary>
        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                var venta = new Venta
                {
                    ProductoID = txtProductoID.Text,
                    Cantidad = int.Parse(txtCantidad.Text),
                    Total = decimal.Parse(txtTotal.Text)
                };

                ventas.Add(venta);
                GuardarVentasEnCsv();
                ActualizarDataGridView();
                MessageBox.Show("Venta registrada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la venta: {ex.Message}");
            }
        }

        /// <summary>
        /// Actualiza el DataGridView con la lista de ventas.
        /// </summary>
        private void ActualizarDataGridView()
        {
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = ventas;
        }

        /// <summary>
        /// Guarda la lista de ventas en un archivo CSV.
        /// </summary>
        private void GuardarVentasEnCsv()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ventas.csv");

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine("ProductoID,Cantidad,Total");
                foreach (var venta in ventas)
                {
                    writer.WriteLine($"{venta.ProductoID},{venta.Cantidad},{venta.Total}");
                }
            }
        }

        /// <summary>
        /// Carga las ventas desde un archivo CSV.
        /// </summary>
        private void CargarVentasDesdeCsv()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ventas.csv");

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    bool isFirstLine = true;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (isFirstLine)
                        {
                            isFirstLine = false;
                            continue;
                        }

                        var values = line.Split(',');
                        var venta = new Venta
                        {
                            ProductoID = values[0],
                            Cantidad = int.Parse(values[1]),
                            Total = decimal.Parse(values[2])
                        };
                        ventas.Add(venta);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Clase que representa una venta de producto.
    /// </summary>
    public class Venta
    {
        public string ProductoID { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
    }
}
