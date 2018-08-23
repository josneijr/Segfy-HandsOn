using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Segfy_HandsOn.Models.DB;
using Segfy_HandsOn.Models;

namespace Segfy_HandsOn.Controllers
{
    public class Teste
    {
        public string nome = "Josnei";
    }


    [Route("api/[controller]")]
    [ApiController]
    public class DBController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Seguro>> GetAll()
        {
            var newSeguro = new Seguro()
            {
                clienteId = "1234",
                objetoSegurado = new CarroSegurado() { Identificacao = "FLV-9999"},
                tipoSeguro = TipoSeguro.Automovel
            };

            using (var context = new SegurosDbContext())
            {
                context.Seguros.Add(newSeguro);

                context.SaveChanges();

                return context.Seguros.ToList();
            }
        }
    }
}