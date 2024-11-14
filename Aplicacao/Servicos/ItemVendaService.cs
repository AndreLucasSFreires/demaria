using Aplicacao.DTO;
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

        public ItemVendaService(IItemVendaRepository itemVendaRepository)
        {
            _itemVendaRepository = itemVendaRepository;
        }

        public bool InserirItemVenda(ItemVendaDto itemVendaDto)
        {
            var itemVenda = new ItemVenda(itemVendaDto.CodigoVenda, itemVendaDto.CodigoProduto, itemVendaDto.ValorUnitario, 
                itemVendaDto.Quantidade, itemVendaDto.ValorTotal);
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
                    CodigoProduto = itemVenda.CodigoProduto,
                    CodigoVenda = itemVenda.CodigoVenda,
                    Quantidade = itemVenda.Quantidade,
                    ValorTotal = itemVenda.ValorTotal,
                    ValorUnitario = itemVenda.ValorUnitario
                });
            }
            return itensVendaDto;
        }
    }
}
