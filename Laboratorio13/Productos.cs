using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio13
{
    public class Productos
    {
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }

        public double precioCompra { get; set; }
        public double precioVenta { get; set; }
        public Productos()
        {
            CodigoProducto = string.Empty;
            NombreProducto = string.Empty;
            Descripcion = string.Empty;
            precioCompra = 0;
            precioVenta = 0;
        }
    }
}
