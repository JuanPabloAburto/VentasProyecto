using System;
using System.Collections.Generic;

#nullable disable

namespace ventaProyecto_netcore.models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Venta = new HashSet<Ventum>();
        }

        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string NombreCompleto { get; set; }

        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
