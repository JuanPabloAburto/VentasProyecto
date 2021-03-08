using System;
using System.Collections.Generic;

#nullable disable

namespace ventaProyecto_netcore.models
{
    public partial class Producto
    {
        public Producto()
        {
            Detalles = new HashSet<Detalle>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? Costo { get; set; }

        public virtual ICollection<Detalle> Detalles { get; set; }
    }
}
