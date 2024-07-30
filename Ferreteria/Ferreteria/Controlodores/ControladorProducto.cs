using System;
using System.Collections.Generic;
using System.IO;
using Ferreteria.Modelos;
using System.Linq;

namespace Ferreteria.Controladores
{
    public class ControladorProducto
    {
        private List<Producto> productos;

        public ControladorProducto()
        {
            productos = new List<Producto>();
            CargarProductosDesdeCsv();
        }

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
            GuardarProductosEnCsv();
        }

        public void ActualizarProducto(Producto productoActualizado)
        {
            var producto = productos.FirstOrDefault(p => p.ProductoId == productoActualizado.ProductoId);
            if (producto != null)
            {
                producto.Nombre = productoActualizado.Nombre;
                producto.Marca = productoActualizado.Marca;
                producto.PrecioCompra = productoActualizado.PrecioCompra;
                producto.PrecioVenta = productoActualizado.PrecioVenta;
                producto.Stock = productoActualizado.Stock;
                producto.Estado = productoActualizado.Estado;
                GuardarProductosEnCsv();
            }
        }

        public List<Producto> ObtenerProductos()
        {
            return productos;
        }

        private void GuardarProductosEnCsv()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "productos.csv");

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine("ProductoId,Nombre,Marca,PrecioCompra,PrecioVenta,Stock,Estado");
                foreach (var producto in productos)
                {
                    writer.WriteLine($"{producto.ProductoId},{producto.Nombre},{producto.Marca},{producto.PrecioCompra},{producto.PrecioVenta},{producto.Stock},{producto.Estado}");
                }
            }
        }

        private void CargarProductosDesdeCsv()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "productos.csv");

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
                        var producto = new Producto
                        {
                            ProductoId = values[0],
                            Nombre = values[1],
                            Marca = values[2],
                            PrecioCompra = decimal.Parse(values[3]),
                            PrecioVenta = decimal.Parse(values[4]),
                            Stock = int.Parse(values[5]),
                            Estado = bool.Parse(values[6])
                        };
                        productos.Add(producto);
                    }
                }
            }
        }
    }
}
