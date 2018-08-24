using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Segfy_HandsOn.Models.DB;
using Segfy_HandsOn.Models;
using System.Net.Http;
using System.Net;

using Segfy_HandsOn.Services.Validacao;

namespace Segfy_HandsOn.Controllers
{
    [ApiController]
    [Route("api/DB")]
    public class DBController : ControllerBase
    {
        List<IValidacao> validadoresDeDados = new List<IValidacao>(new IValidacao[] {
            new CarroValidacao(),
            new PessoaValidacao(),
            new ResidenciaValidacao()
        });

        [HttpGet]
        public ActionResult<List<Seguro>> GetAll()
        {
            using (var context = new SegurosDbContext())
            {
                return context.Seguros.ToList();
            }
        }

        [HttpPost]
        public ActionResult<HttpResponseMessage> Create(Seguro novoSeguro)
        {
            var validador = validadoresDeDados.Where(t=> t.tipoSeguro == novoSeguro.tipoSeguro)
                                                .FirstOrDefault();

              if(!validador.EntradaValida(novoSeguro.objetoId))
              {
                    return StatusCode(400); 
            }

              using (var context = new SegurosDbContext())
              {
                  context.Seguros.Add(novoSeguro);

                  context.SaveChanges();

                  return new HttpResponseMessage(HttpStatusCode.OK);
              }
        }

        [HttpDelete("{id}")]
        public ActionResult<HttpResponseMessage> Delete(int id)
        {
            using (var context = new SegurosDbContext())
            {
                Seguro seguroApagar = context.Seguros.Where(t => t.id == id).FirstOrDefault();

                if(seguroApagar == null)
                {
                    return StatusCode(400);
                }

                context.Seguros.Remove(seguroApagar);

                context.SaveChanges();

                return new HttpResponseMessage(HttpStatusCode.OK);
            }
        }
    }
}