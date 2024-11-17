using Bogus;
using Bogus.DataSets;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DominioTests
{
    public class ClienteTests
    {
        [Fact]
        public void ClienteNovoDeveEstarValido()
        {
            var cliente = GerarClienteValido();
            var result = cliente.EhValido();
            Assert.True(result);
        }

        private Cliente GerarClienteValido()
        {
            var genero = new Faker().PickRandom<Name.Gender>();
            var cliente = new Faker<Cliente>(locale: "pt_BR").
                CustomInstantiator(f => new Cliente(
                    f.Name.FirstName(genero),
                    f.Phone.PhoneNumber(),
                    f.Address.StreetName(),
                    ""))
                    .RuleFor(c => c.Email, (f, c) =>
                     f.Internet.Email(c.Nome.ToLower()));
            return cliente;
        }
    }
}
