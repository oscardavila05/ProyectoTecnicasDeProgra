using System;
using System.Collections.Generic;
using System.IO;

namespace Ferreteria.Controladores
{
    public class ControladorProducto
    {
        private List<Producto> productos;

        public ControladorProducto()
        {
            productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
            SaveToCsv(producto);
        }

        private void SaveToCsv(Producto producto)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "productos.csv");
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{producto.ProductoId},{producto.Nombre},{producto.Marca},{producto.PrecioCompra},{producto.PrecioVenta},{producto.Stock},{producto.Estado}");
            }
        }
    }
}


