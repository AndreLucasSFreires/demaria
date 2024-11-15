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
        IMapper mapper;

        public VendaService(IVendaRepository vendaRepository, IClienteRepository clienteRepository, IProdutoRepository produtoRepository, IItemVendaRepository itemVendaRepository)
        {
            _vendaRepository = vendaRepository;
            _clienteRepository = clienteRepository;
            _produtoRepository = produtoRepository;
            _itemVendaRepository = itemVendaRepository;
            mapper = configAutomapper.CreateMapper();
        }

        public bool InserirVenda(VendaDto vendaDto)
        {
            var cliente = mapper.Map<Cliente>(vendaDto.Cliente);

            var venda = new Venda(vendaDto.Cliente.Id, 
                cliente, 
                vendaDto.DataEmissao,
                vendaDto.Valor);

            bool inserido = _vendaRepository.Inserir(venda, out var idInserido);
            vendaDto.Id = idInserido;
            return inserido;
        }

        public bool AtualizarVenda(VendaDto vendaDto)
        {
            var cliente = mapper.Map<Cliente>(vendaDto.Cliente);
            var venda = new Venda
                (
                    vendaDto.Id, 
                    cliente, 
                    vendaDto.DataEmissao, 
                    vendaDto.Valor
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
                itens.Select(itemVenda => itemVenda.Produto = ObterProduto(itemVenda.CodigoProduto)).ToList();

                var itensVenda = itens.Select(x => mapper.Map<ItemVendaDto>(x)).ToList();

                vendaDto.ItensVenda = itensVenda;
                vendasDto.Add(vendaDto);
            }
            return vendasDto;
        }

        public ClienteDto ObterCliente(int id)
        {
            var cliente = _clienteRepository.ObterCliente(id);
            var clienteDto = mapper.Map<ClienteDto>(cliente);
            return clienteDto;
        }

        public Produto ObterProduto(int id)
        {
            return _produtoRepository.ObterProduto(id);
        }

        public ProdutoDto ObterProdutoDto(int id)
        {
            var produto = _produtoRepository.ObterProduto(id);
            var produtoDto = mapper.Map<ProdutoDto>(produto);
            return produtoDto;
        }

        
        
    }
}
