using Aplicacao.DTO;
using Dominio.Entidades;
using Dominio.Entidades.Interfaces;
using Entidades.Interfaces;
using System.Collections.Generic;

namespace Aplicacao.Servicos
{
    public class VendaService
    {
        private readonly IVendaRepository _vendaRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly IProdutoRepository _produtoRepository;

        public VendaService(IVendaRepository vendaRepository, IClienteRepository clienteRepository, IProdutoRepository produtoRepository)
        {
            _vendaRepository = vendaRepository;
            _clienteRepository = clienteRepository;
            _produtoRepository = produtoRepository;
        }

        public bool InserirVenda(VendaDto vendaDto)
        {
            var venda = new Venda(vendaDto.Cliente.Id, ObterCliente(vendaDto.Cliente), vendaDto.DataEmissao, vendaDto.Valor);
            bool inserido = _vendaRepository.Inserir(venda);
            return inserido;
        }

        public int ObterProximoIdVenda()
        {
            return _vendaRepository.ObterUltimoIdInserido() + 1;
        }

        public bool AtualizarVenda(VendaDto vendaDto)
        {
            var venda = new Venda(vendaDto.CodigoCliente, null, vendaDto.DataEmissao, vendaDto.Valor)
            {
                Id = vendaDto.Id
            };
            return _vendaRepository.Atualizar(venda);
        }

        public bool Excluir(int id)
        {
            return _vendaRepository.Excluir(id);
        }

        public List<VendaDto> ObterTodos()
        {
            var vendasDto = new List<VendaDto>();
            var vendas = _vendaRepository.ObterTodos();
            foreach (var venda in vendas)
            {
                vendasDto.Add(new VendaDto
                {
                    Id = venda.Id,
                    CodigoCliente = venda.CodigoCliente,
                    Cliente = MapearCliente(_clienteRepository.ObterCliente(venda.CodigoCliente)),
                    DataEmissao = venda.DataEmissao,
                    Valor = venda.Valor
                });
            }
            return vendasDto;
        }

        public Cliente ObterCliente(ClienteDto cliente)
        {
            return new Cliente
            {
                Id = cliente.Id,
                Email = cliente.Email,
                Endereco = cliente.Endereco,
                Nome = cliente.Nome,
                Telefone = cliente.Telefone
            };
        }

        public ClienteDto ObterCliente(int id)
        {
            return MapearCliente(_clienteRepository.ObterCliente(id));
        }

        public ProdutoDto ObterProduto(int id)
        {
            return MapearProduto(_produtoRepository.ObterProduto(id));
        }

        private ProdutoDto MapearProduto(Produto produto)
        {
            return new ProdutoDto
            {
                Id = produto.Id,
                Descricao = produto.Descricao,
                Estoque = produto.Estoque,
                Nome = produto.Nome,
                Preco = produto.Preco
            };
        }

        private ClienteDto MapearCliente(Cliente cliente)
        {
            return new ClienteDto
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Endereco = cliente.Endereco,
                Telefone = cliente.Telefone,
                Email = cliente.Email
            };
        }
        
    }
}
