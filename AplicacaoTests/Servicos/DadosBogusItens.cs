using Aplicacao.DTO;
using Bogus;
using Bogus.DataSets;
using System;

namespace AplicacaoTests.Servicos
{
    public partial class DadosBogus
    {
        public static ItemVendaDto ObterItemDtoValido()
        {
            var itemDto = GerarItemVendaValido();
            itemDto.ProdutoDto = ObterProdutoDtoValido();
            itemDto.ValorUnitario = itemDto.ProdutoDto.Preco;
            return itemDto;
        }

        private static ItemVendaDto GerarItemVendaValido()
        {
            var itemVendaDto = new Faker<ItemVendaDto>();
            itemVendaDto.RuleFor(i => i.Quantidade,
                (f, i) => f.Random.Int(1, 9));
            itemVendaDto.RuleFor(i => i.CodigoProduto,
                (f, i) => f.Random.Int(1, 20000));

            return itemVendaDto;
        }
        public static ProdutoDto ObterProdutoDtoValido()
        {
            var produtoDto = new Faker<ProdutoDto>(locale:"pt_BR");
            produtoDto.RuleFor(p=> p.Id, (f, i) => f.Random.Int(1, 20000));
            produtoDto.RuleFor(p => p.Nome, (f, i) => f.Commerce.ProductName());
            produtoDto.RuleFor(p => p.Preco, (f, i) => f.Random.Double(1, 2000));
            return produtoDto;
        }
    }
}
