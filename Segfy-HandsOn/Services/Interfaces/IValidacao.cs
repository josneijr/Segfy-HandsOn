using Segfy_HandsOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Segfy_HandsOn.Services.Validacao
{
    public interface IValidacao
    {
        TipoSeguro tipoSeguro { get; }

        //Para cada identificacao, vamos precisar realizar uma checagem diferente
        bool EntradaValida(string valor);
    }
}