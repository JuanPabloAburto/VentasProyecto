using System;



namespace ventaProyecto_netcore.models.Request
{
    public class ClienteRequest
    {   
        public int id {get; set;}
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }


    }
}