
public interface IObjetoSegurado
{
    //Cada tipo de seguro demanda uma identificacao diferente.
    //Vida: CPF do segurado
    //Residencial: endereço
    //Automotivo: placa
    string Identificacao {get; set;}    

    //Para cada identificacao, vamos precisar realizar uma checagem diferente
    bool IdentificacaoValida(string valor);
}