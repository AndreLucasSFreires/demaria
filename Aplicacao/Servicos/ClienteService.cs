using Aplicacao.DTO;
using Dominio.Entidades;
using Dominio.Entidades.Interfaces;
using System.Collections.Generic;

namespace Aplicacao.Servicos
{
    public class ClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public bool InserirCliente(ClienteDto clienteDto)
        {
            //realizar validações
            var cliente = new Cliente(clienteDto.Nome, clienteDto.Telefone, clienteDto.Endereco, clienteDto.Email);
            return _clienteRepository.Inserir(cliente);
        }

        public bool AtualizarCliente(ClienteDto clienteDto)
        {
            //realizar validações
            var cliente = new Cliente(clienteDto.Nome, clienteDto.Telefone, clienteDto.Endereco, clienteDto.Email)
            {
                Id = clienteDto.Id
            };
            return _clienteRepository.Atualizar(cliente);
        }

        public bool Excluir(int id)
        {
            return _clienteRepository.Excluir(id);
        }

        public List<ClienteDto> ObterTodos()
        {
            var clientesDto = new List<ClienteDto>();
            var clientes = _clienteRepository.ObterTodos();
            foreach (var cliente in clientes)
            {
                clientesDto.Add(new ClienteDto
                {
                    Id = cliente.Id,
                    Nome = cliente.Nome,
                    Endereco = cliente.Endereco,
                    Telefone = cliente.Telefone,
                    Email = cliente.Email
                });
            }
            return clientesDto;
        }
    }
}
