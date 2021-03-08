using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ventaProyecto_netcore.models;
using ventaProyecto_netcore.models.Responde;
using ventaProyecto_netcore.models.Request;

namespace ventaProyecto_netcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        // GET: api/Cliente
        [HttpGet]

        public IActionResult Get()
        {
            Respuesta respuesta = new Respuesta();

            try
            {

                using (VentasBDContext db = new VentasBDContext())
                {
                    var lst = db.Clientes.ToList();
                    respuesta.Exito = 1;
                    respuesta.Data = lst;

                }
            }
            catch (Exception ex)
            {

                respuesta.Mensaje = ex.Message;
            }

            return Ok(respuesta);

        }



        // POST: api/Cliente
        [HttpPost]
        public IActionResult Agregar(ClienteRequest oModel)
        {
            Respuesta respuesta = new Respuesta();


            try
            {
                using (VentasBDContext db = new VentasBDContext())
                {
                    Cliente oCliente = new Cliente();
                    oCliente.PrimerNombre = oModel.PrimerNombre;
                    db.Clientes.Add(oCliente);
                    db.SaveChanges();
                    respuesta.Exito = 1;

                }




            }
            catch (Exception ex)
            {

                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);

        }

        // PUT: api/Cliente/5
        [HttpPut]
        public IActionResult Edit(ClienteRequest oModel)
        {
            Respuesta respuesta = new Respuesta();


            try
            {
                using (VentasBDContext db = new VentasBDContext())
                {
                    Cliente oCliente = db.Clientes.Find(oModel.id);
                    oCliente.PrimerNombre = oModel.PrimerNombre;
                    db.Entry(oCliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    respuesta.Exito = 1;

                }




            }
            catch (Exception ex)
            {

                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);

        }

        [HttpPut]
        public IActionResult Edit(Int16 id)
        {
            Respuesta respuesta = new Respuesta();


            try
            {
                using (VentasBDContext db = new VentasBDContext())
                {
                    Cliente oCliente = db.Clientes.Find(id);
                    db.Remove(oCliente);
                    db.SaveChanges();
                    respuesta.Exito = 1;

                }




            }
            catch (Exception ex)
            {

                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);

        }
    }
}
