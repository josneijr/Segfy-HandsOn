using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Segfy_HandsOn.Models
{
    public enum TipoSeguro
    {
        Automovel,
        Residencial,
        Vida
    }

    public class Seguro
    {
        public int id { get; set; }

        public string clienteId { get; set; }

        public TipoSeguro tipoSeguro { get; set; }

        public string objetoId { get; set; }

    }
}