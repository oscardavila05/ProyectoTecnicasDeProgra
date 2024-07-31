using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Ferreteria.Modelos;

namespace Ferreteria.Controladores
{
    public class ControladorVenta
    {
        private List<Venta> ventas;
        private int nextVentaID;

        public ControladorVenta()
        {
            ventas = new List<Venta>();
            CargarVentasDesdeCsv();
            nextVentaID = ventas.Count > 0 ? ventas.Max(v => v.VentaID) + 1 : 1;
        }

        public void AgregarVenta(Venta venta)
        {
            venta.VentaID = nextVentaID++;
            ventas.Add(venta);
            GuardarVentasEnCsv();
        }

        public void ActualizarVenta(Venta ventaActualizada)
        {
            var venta = ventas.FirstOrDefault(v => v.VentaID == ventaActualizada.VentaID);
            if (venta != null)
            {
                venta.ProductoID = ventaActualizada.ProductoID;
                venta.Cantidad = ventaActualizada.Cantidad;
                venta.Total = ventaActualizada.Total;
                GuardarVentasEnCsv();
            }
        }

        public List<Venta> ObtenerVentas()
        {
            return ventas;
        }

        private void GuardarVentasEnCsv()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ventas.csv");

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine("VentaID,ProductoID,Cantidad,Total");
                foreach (var venta in ventas)
                {
                    writer.WriteLine($"{venta.VentaID},{venta.ProductoID},{venta.Cantidad},{venta.Total}");
                }
            }
        }

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
                            VentaID = int.Parse(values[0]),
                            ProductoID = values[1],
                            Cantidad = int.Parse(values[2]),
                            Total = decimal.Parse(values[3])
                        };
                        ventas.Add(venta);
                    }
                }
            }
        }
    }
}
