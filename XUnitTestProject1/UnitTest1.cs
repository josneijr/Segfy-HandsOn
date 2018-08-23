using System;
using Xunit;
using Segfy_HandsOn.Services.Validacao;

namespace XUnitTestProject1
{
    public class CPF_Testes
    {
        [Fact]
        public void CPF_Valido1()
        {
            var cpf = "99607999053";

            PessoaValidacao pessoaValidacao = new PessoaValidacao();

            Assert.True(pessoaValidacao.EntradaValida(cpf));
        }

        [Fact]
        public void CPF_Valido2()
        {
            var cpf = "799.958.720-64";

            PessoaValidacao pessoaValidacao = new PessoaValidacao();

            Assert.True(pessoaValidacao.EntradaValida(cpf));
        }

        [Fact]
        public void CPF_Invalido1()
        {
            var cpf = "41805028870";

            PessoaValidacao pessoaValidacao = new PessoaValidacao();

            Assert.False(pessoaValidacao.EntradaValida(cpf));
        }
    }

    public class Placas_Testes
    {
        [Fact]
        public void PlacaValida1()
        {
            var placa = "AAA-0000";

            CarroValidacao carroValidacao = new CarroValidacao();

            Assert.True(carroValidacao.EntradaValida(placa));
        }

        [Fact]
        public void PlacaValida2()
        {
            var placa = "AAA0000";

            CarroValidacao carroValidacao = new CarroValidacao();

            Assert.True(carroValidacao.EntradaValida(placa));
        }

        [Fact]
        public void PlacaInvalida1()
        {
            var placa = "000AAAA";

            CarroValidacao carroValidacao = new CarroValidacao();

            Assert.False(carroValidacao.EntradaValida(placa));
        }
    }

    public class Enderecos_Testes
    {
        [Fact]
        public void EnderecoValido1()
        {
            var endereco = "Rua X, 000";

            ResidenciaValidacao enderecoValidacao = new ResidenciaValidacao();

            Assert.True(enderecoValidacao.EntradaValida(endereco));
        }

        [Fact]
        public void EnderecoValido2()
        {
            var endereco = "Av. Lalala, 123";

            ResidenciaValidacao enderecoValidacao = new ResidenciaValidacao();

            Assert.True(enderecoValidacao.EntradaValida(endereco));
        }

        [Fact]
        public void EnderecoInvalido1()
        {
            var endereco = "Curitiba, 123";

            ResidenciaValidacao enderecoValidacao = new ResidenciaValidacao();

            Assert.False(enderecoValidacao.EntradaValida(endereco));
        }
    }
}
