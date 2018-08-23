using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class CarroSegurado : IObjetoSegurado
{
    private string _identificacao;

    public string Identificacao
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public bool IdentificacaoValida(string valor)
    {
        throw new NotImplementedException();
    }
}