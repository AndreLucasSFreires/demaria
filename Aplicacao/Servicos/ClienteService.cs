using Aplicacao.DTO;
using Aplicacao.DTO.Clientes;
using Dominio.Entidades;
using Dominio.Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace Aplicacao.Servicos
{
    public class ClienteService : ServicoBase
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public bool InserirCliente(ClienteDto clienteDto)
        {
            Validar(clienteDto);

            try
            {
                LancarExcecaoValidacao();
                var cliente = new Cliente(clienteDto.Nome, clienteDto.Telefone, clienteDto.Endereco, clienteDto.Email);
                return _clienteRepository.Inserir(cliente);
            }
            catch (Exception e)
            {
                MensagemFalha = e.Message.ToString(); return false;
            }
        }

        private void Validar(ClienteDto clienteDto)
        {
            var validacao = new ValidacaoClienteDto();
            resultadoValidacao = validacao.Validate(clienteDto);
        }

        public bool AtualizarCliente(ClienteDto clienteDto)
        {
            Validar(clienteDto);
            try
            {
                LancarExcecaoValidacao();
                var cliente = new Cliente(clienteDto.Nome, clienteDto.Telefone, clienteDto.Endereco, clienteDto.Email)
                {
                    Id = clienteDto.Id
                };
                return _clienteRepository.Atualizar(cliente);
            }
            catch (Exception e)
            {
                MensagemFalha = e.Message.ToString(); return false;
            }
        }

        public bool Excluir(int id)
        {
            try
            {
                return _clienteRepository.Excluir(id);
            }
            catch (Exception e)
            {
                MensagemFalha = e.Message.ToString(); return false;
            }
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
