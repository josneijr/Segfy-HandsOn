using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class EmpresaSegurada : IObjetoSegurado
{
    private string _identificacao;

    public string Identificacao 
    {
        get => _identificacao;
        set
        {
            if(!IdentificacaoValida(value))
            {
                throw new Exception("Valor não corresponde a um CNPJ válido");
            }

            _identificacao = value;            
        }
    }

    public bool IdentificacaoValida(string valor)
    {
        /*string IdentificacaoMask = "(\\d+){11}";

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