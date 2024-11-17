using Aplicacao.DTO;
using Bogus;
using Bogus.DataSets;

namespace AplicacaoTests.Servicos
{
    public class DadosBogus
    {
        public static ClienteDto GerarClienteDtoValido()
        {
            var genero = new Faker().PickRandom<Name.Gender>();
            var cliente = new Faker<ClienteDto>(locale: "pt_BR");
            cliente.RuleFor(c => c.Nome, (f,c) => f.Name.FirstName(genero));
            cliente.RuleFor(c => c.Telefone, (f, c) => f.Phone.PhoneNumber());
            cliente.RuleFor(c => c.Endereco, (f, c) => f.Address.StreetName());
            cliente.RuleFor(c => c.Email, (f, c) => f.Internet.Email(c.Nome.ToLower()));
            return cliente;
        }
    }
}
