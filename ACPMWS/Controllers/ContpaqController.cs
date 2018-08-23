using ACPMWS.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ACPMWS.Controllers
{
    public class ContpaqController : ApiController
    {
        adAguaInmaculadaPruebaEntities entities;

        public ContpaqController()
        {
            entities = new adAguaInmaculadaPruebaEntities();
        }

        [Route("acpm/post/factura/agregarFactura")]
        [HttpPost]
        public object AgregarFacturaContpaq(JObject factura)
        {
            try
            {
                return new
                {
                    success = true,
                    response = 1
                };
            }
            catch (Exception ex)
            {
                return new
                {
                    success = false,
                    response = ex
                };
            }
        }

        public IHttpActionResult PutPersonalDetails(int id, admMovimientos
personaldetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != personaldetails.CIDMOVIMIENTO)
            {
                return BadRequest("Sorry, seems something wrong. Couldn't determine record to update.");
            }

            entities.Entry(personaldetails).State = EntityState.Modified;

            try
            {
                entities.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                
            }

            return Ok(personaldetails);
        }

    }
}
