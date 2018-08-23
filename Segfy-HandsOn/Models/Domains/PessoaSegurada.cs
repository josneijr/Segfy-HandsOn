using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class PessoaSegurada : IObjetoSegurado
{
    private string _identificacao;

    public string Identificacao 
    {
        get
        {
            return _identificacao;
        } 
        set
        {
            if(!IdentificacaoValida(value))
            {
                throw new Exception("Valor não corresponde a um CPF válido");
            }

            _identificacao = value;            
        }
    }

    public bool IdentificacaoValida(string valor)
    {
        /*var mask = "(\\d+){11}";

        var valorInt = Int32.Parse(valor);

        int digitos = valorInt.ToArray();

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