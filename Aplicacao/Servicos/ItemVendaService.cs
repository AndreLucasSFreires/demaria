using Aplicacao.DTO;
using Aplicacao.Mapeamento;
using AutoMapper;
using Dominio.Entidades;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Servicos
{
    public class ItemVendaService
    {
        private readonly IItemVendaRepository _itemVendaRepository;
        readonly MapperConfiguration configAutomapper = Mappings.ConfigurarAutoMapper();

        public ItemVendaService(IItemVendaRepository itemVendaRepository)
        {
            _itemVendaRepository = itemVendaRepository;
        }

        public bool InserirItemVenda(ItemVendaDto itemVendaDto)
        {
            var mapper = configAutomapper.CreateMapper();
            var venda = mapper.Map<Venda>(itemVendaDto.Venda);
            var produto = mapper.Map<Produto>(itemVendaDto.ProdutoDto);

            var itemVenda = new ItemVenda(itemVendaDto.ValorUnitario, itemVendaDto.Quantidade, itemVendaDto.ValorTotal,
                venda, produto);

            return _itemVendaRepository.Inserir(itemVenda);
        }

        
        public void ExcluirItemVenda(int id)
        {
            _itemVendaRepository.Excluir(id);
        }
        public List<ItemVendaDto> ObterTodosPorVenda(int id)
        {
            var itensVendaDto = new List<ItemVendaDto>();
            var itensVenda = _itemVendaRepository.ObterTodosPorVenda(id);
            foreach (var itemVenda in itensVenda)
            {
                itensVendaDto.Add(new ItemVendaDto
                {
                    Id = itemVenda.Id,
                    Quantidade = itemVenda.Quantidade,
                    ValorTotal = itemVenda.ValorTotal,
                    ValorUnitario = itemVenda.ValorUnitario
                });
            }
            return itensVendaDto;
        }
    }
}
