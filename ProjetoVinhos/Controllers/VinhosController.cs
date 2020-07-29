using ProjetoVinhos.Models;
using ProjetoVinhos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetoVinhos.Controllers
{
    
    public class VinhosController : ApiController
    {
        IRepositoryVinhos repository;

        public VinhosController(RepositoryVinhos repository)
        {
            this.repository = repository;
        }
        

        public IEnumerable<Vinhos> Getvinhos()
        {
            return repository.GetVinhos();
        }

        public IHttpActionResult GetVinho(int id)
        {


            Vinhos vinho = repository.GetVinhosByID(id);

            if (vinho == null)
            {
                return NotFound();
            }

            return Ok(vinho);
        }

        
        public IHttpActionResult PutVinho(int id, Vinhos vinho)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vinho.cod_vinho)
            {
                return BadRequest();
            }

            try
            {
                repository.UpdateVinho(vinho);
            }
            catch
            {
                throw;
            }
            return StatusCode(HttpStatusCode.NoContent);
        }


        public IHttpActionResult Postvinho(Vinhos vinho)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                repository.InsertVinho(vinho);
            }
            catch
            {
                throw;
            }

            return CreatedAtRoute("DefaultApi", new { id = vinho.cod_vinho }, vinho);
        }

        public IHttpActionResult DeleteVinho(int id)
        {
            Vinhos vinho = repository.GetVinhosByID(id);
            if (vinho == null)
            {
                return NotFound();
            }

            try
            {
                repository.DeleteVinho(vinho);
            }
            catch
            {
                throw;
            }

            return Ok(vinho);
        }






    }
}
