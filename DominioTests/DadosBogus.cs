using Bogus;
using Bogus.DataSets;
using Dominio.Entidades;

namespace DominioTests
{
    public class DadosBogus
    {
        public static Cliente GerarClienteValido()
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
        public static Cliente GerarClienteInvalido()
        {
            var genero = new Faker().PickRandom<Name.Gender>();
            var cliente = new Faker<Cliente>(locale: "pt_BR").
                CustomInstantiator(f => new Cliente(
                    "",
                    f.Phone.PhoneNumber(),
                    f.Address.StreetName(),
                    ""))
                    .RuleFor(c => c.Email, (f, c) =>
                     f.Internet.Email(c.Nome.ToLower()));
            return cliente;
        }
    }
}
