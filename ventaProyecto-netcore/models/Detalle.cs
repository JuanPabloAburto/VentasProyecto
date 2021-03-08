using System;
using System.Collections.Generic;

#nullable disable

namespace ventaProyecto_netcore.models
{
    public partial class Detalle
    {
        public long Id { get; set; }
        public long IdVenta { get; set; }
        public int IdProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Importe { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
        public virtual Ventum IdVentaNavigation { get; set; }
    }
}
