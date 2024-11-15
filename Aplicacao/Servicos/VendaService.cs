using Aplicacao.DTO;
using Aplicacao.Mapeamento;
using AutoMapper;
using Dominio.Entidades;
using Dominio.Entidades.Interfaces;
using Entidades.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Aplicacao.Servicos
{
    public class VendaService
    {
        private readonly IVendaRepository _vendaRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IItemVendaRepository _itemVendaRepository;
        readonly MapperConfiguration configAutomapper = Mappings.ConfigurarAutoMapper();

        public VendaService(IVendaRepository vendaRepository, IClienteRepository clienteRepository, IProdutoRepository produtoRepository, IItemVendaRepository itemVendaRepository)
        {
            _vendaRepository = vendaRepository;
            _clienteRepository = clienteRepository;
            _produtoRepository = produtoRepository;
            _itemVendaRepository = itemVendaRepository;
        }

        public bool InserirVenda(VendaDto vendaDto)
        {
            var mapper = configAutomapper.CreateMapper();

            var cliente = mapper.Map<Cliente>(vendaDto.Cliente);

            var venda = new Venda(vendaDto.Cliente.Id, 
                cliente, 
                vendaDto.DataEmissao,
                vendaDto.Valor);

            bool inserido = _vendaRepository.Inserir(venda, out var idInserido);
            vendaDto.Id = idInserido;
            return inserido;
        }

        public bool AtualizarVenda(VendaDto dto)
        {
            var venda = new Venda
                (
                    dto.Id, 
                    Mapeamentos.MapearCliente(dto.Cliente), 
                    dto.DataEmissao, 
                    dto.Valor
                );

            return _vendaRepository.Atualizar(venda);
        }

        public bool Excluir(int id)
        {
            return _vendaRepository.Excluir(id);
        }

        public List<VendaDto> ObterTodasAsVendas()
        {
            var vendasDto = new List<VendaDto>();
            var vendasRepositorio = _vendaRepository.ObterTodasAsVendas();
            foreach (var vendaRepositorio in vendasRepositorio)
            {
                var vendaDto = new VendaDto
                {
                    Id = vendaRepositorio.Id,
                    DataEmissao = vendaRepositorio.DataEmissao,
                    Valor = vendaRepositorio.Valor,
                    Cliente = ObterCliente(vendaRepositorio.CodigoCliente)
                };
                var itens = _itemVendaRepository.ObterTodosPorVenda(vendaDto.Id);

                itens.Select(itemVenda =>
                    itemVenda.Produto = ObterProduto(itemVenda.CodigoProduto)).ToList();

                vendaDto.ItensVenda = itens.Select(x => Mapeamentos.MapearItemVendaDto(x)).ToList();
                vendasDto.Add(vendaDto);
            }
            return vendasDto;
        }

        public ClienteDto ObterCliente(int id)
        {
            return Mapeamentos.MapearClienteDto(_clienteRepository.ObterCliente(id));
        }

        public Produto ObterProduto(int id)
        {
            return _produtoRepository.ObterProduto(id);
        }

        public ProdutoDto ObterProdutoDto(int id)
        {
            return Mapeamentos.MapearProdutoDto(_produtoRepository.ObterProduto(id));
        }

        
        
    }
}
