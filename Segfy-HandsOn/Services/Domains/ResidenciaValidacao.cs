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
            /*string IdentificacaoMask = @"(\d+){11}";
             * 
             * Regex r = new Regex(pat, RegexOptions.IgnoreCase);
             * Match m = r.Match(text);

            int digitos = Int32.Parse(valor);

            int soma = 0;

            while (valor != 0) 
            {
                soma += valor % 10;
                valor /= 10;
            }  

            return(soma%11 == 0);*/

            return true;
        }
    }
}