using Segfy_HandsOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Segfy_HandsOn.Services.Validacao
{
    public class ResidenciaValidacao : IValidacao
    {
        public TipoSeguro tipoSeguro
        {
            get => TipoSeguro.Residencial;
        }

        public bool EntradaValida(string valor)
        {
            return (valor.Contains("Rua") ||
                    valor.Contains("R.") ||
                    valor.Contains("Av.") ||
                    valor.Contains("Avenida") ||
                    valor.Contains("Praça"));
        }
    }
}