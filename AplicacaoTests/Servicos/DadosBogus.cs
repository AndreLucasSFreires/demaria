    using Aplicacao.DTO;
    using Bogus;
    using Bogus.DataSets;
    using System;
using System.Linq;

namespace AplicacaoTests.Servicos
{
    public partial class DadosBogus
    {
        public static VendaDto GerarVendaDtoInvalido()
        {
            var vendaDto = new VendaDto
            {
                Cliente = GerarClienteDtoValido(),
                DataEmissao = DateTime.Now,
            };

            vendaDto.Valor = vendaDto.ItensVenda.Sum(i => i.ValorTotal);
            return vendaDto;
        }

        public static VendaDto GerarVendaDtoValido()
        {
            var vendaDto = new VendaDto
            {
                Cliente = GerarClienteDtoValido(),
                DataEmissao = DateTime.Now,
            };

            int max = new Random().Next(1, 5);
            for (int i = 1; i <= max; i++)
                vendaDto.ItensVenda.Add(ObterItemDtoValido());
            
            vendaDto.Valor = vendaDto.ItensVenda.Sum(i => i.ValorTotal);
            return vendaDto;
        }

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
