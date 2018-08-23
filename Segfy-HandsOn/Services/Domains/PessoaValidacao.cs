using Segfy_HandsOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Segfy_HandsOn.Services.Validacao
{
    public class PessoaValidacao : IValidacao
    {
        public TipoSeguro tipoSeguro
        {
            get => TipoSeguro.Vida;
        }

        //Em um seguro de vida, atrelamos � um CPF
        //Para validar um CPF, ele precisa:
        //1) Ter 11 d�gitos num�ricos, descontando pontos e tra�o
        //2) Ser divis�vel por 11
        public bool EntradaValida(string valor)
        {
            valor = valor.Replace(".", "").Replace("-","");

            var mask = @"^(\d){11}$";

            Regex r = new Regex(mask, RegexOptions.IgnoreCase);

            if(!r.Match(valor).Success)
            {
                return false;
            }

            var resto = valor.Select(t => Int32.Parse(t.ToString())).Sum() % 11;

            return (resto == 0);
        }
    }
}