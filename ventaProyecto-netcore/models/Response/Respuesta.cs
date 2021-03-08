using System;



namespace ventaProyecto_netcore.models.Responde
{
    public class Respuesta
    {

        public int Exito { get; set; }
        public string Mensaje { get; set; }
        public object Data { get; set; }


        public Respuesta()
        {

            this.Exito = 0;

        }

    }



}