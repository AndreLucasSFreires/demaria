using Bogus;
using Bogus.DataSets;
using Dominio.Entidades;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DominioTests
{
    public class ClienteTests
    {
        [Fact]
        public void ClienteNovoDeveEstarInvalido()
        {
            var cliente = DadosBogus.GerarClienteInvalido();
            var result = cliente.EhValido();
            result.Should().BeFalse();
        }

        [Fact]
        public void ClienteNovoDeveEstarValido()
        {
            var cliente = DadosBogus.GerarClienteValido();
            var result = cliente.EhValido();
            result.Should().BeTrue();
        }
    }
}
