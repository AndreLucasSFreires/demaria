using Aplicacao.DTO;
using Dominio.Entidades;
using Dominio.Entidades.Interfaces;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Servicos
{
    public class VendaService
    {
        private readonly IVendaRepository _vendaRepository;
        private readonly IClienteRepository _clienteRepository;

        public VendaService(IVendaRepository vendaRepository, IClienteRepository clienteRepository)
        {
            _vendaRepository = vendaRepository;
            _clienteRepository = clienteRepository;
        }

        public bool InserirVenda(VendaDto vendaDto)
        {
            var venda = new Venda(vendaDto.CodigoCliente, null, vendaDto.DataEmissao, vendaDto.Valor);
            return _vendaRepository.Inserir(venda);
        }

        public bool AtualizarVenda(VendaDto vendaDto)
        {
            var venda = new Venda(vendaDto.CodigoCliente, null, vendaDto.DataEmissao, vendaDto.Valor)
            {
                Id = vendaDto.Id
            };
            return _vendaRepository.Inserir(venda);
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

        public ClienteDto ObterCliente(int id)
        {
            return MapearCliente(_clienteRepository.ObterCliente(id));
        }

        public ClienteDto MapearCliente(Cliente cliente)
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
