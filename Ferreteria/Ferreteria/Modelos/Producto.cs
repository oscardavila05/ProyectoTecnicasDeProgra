namespace Ferreteria
{
    public class Producto
    {
        public string ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public bool Estado { get; set; }
    }
}
