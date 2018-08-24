using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Segfy_HandsOn.Models;

namespace Segfy_HandsOn.Services.Validacao
{
    public class CarroValidacao : IValidacao
    {
        public TipoSeguro tipoSeguro
        {
            get => TipoSeguro.Automovel;
        }

        //Seguros automotivos são linkados com a placa do veículo
        //Placas contem 3 letras e 4 numeros, descontado o traço central
        public bool EntradaValida(string valor)
        {
            valor = valor.Replace("-", "");

            var mask = @"^([a-z]){3}(\d){4}$";

            Regex r = new Regex(mask, RegexOptions.IgnoreCase);

            return (r.Match(valor).Success);
        }
    }
}