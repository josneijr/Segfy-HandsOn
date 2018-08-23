using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult<List<Teste>> GetAll()
        {
            List<Teste> novaLista = new List<Teste>();

            novaLista.Add(new Teste() { nome="josnei"});
            novaLista.Add(new Teste() { nome = "luke" });

            return novaLista;
        }
    }
}