using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Modelos
{
    public class Venta
    {
        public int VentaID { get; set; }
        public string ProductoID { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
    }
}

