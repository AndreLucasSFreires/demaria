using Aplicacao.DTO;
using Aplicacao.DTO.Produtos;
using Dominio.Entidades;
using Dominio.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aplicacao.Servicos
{
    public class ProdutoService : ServicoBase
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public bool InserirProduto(ProdutoDto produtoDto)
        {
            Validar(produtoDto);
            try
            {
                LancarExcecaoValidacao();
                var produto = new Produto(produtoDto.Nome, produtoDto.Descricao, produtoDto.Preco, produtoDto.Estoque);
                return _produtoRepository.Inserir(produto);
            }
            catch (Exception e)
            {
                MensagemFalha = e.Message.ToString(); return false;
            }
        }

        public bool AtualizarProduto(ProdutoDto produtoDto)
        {
            Validar(produtoDto);
            try
            {
                LancarExcecaoValidacao();
                var produto = new Produto(produtoDto.Nome, produtoDto.Descricao, produtoDto.Preco, produtoDto.Estoque)
                {
                    Id = produtoDto.Id
                };
                return _produtoRepository.Atualizar(produto);
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
                return _produtoRepository.Excluir(id);
            }
            catch (Exception e)
            {
                MensagemFalha = e.Message.ToString(); return false;
            }
        }

        public double ObterQuantidadeVendida(int id)
        {
            var quantidadeVendida = _produtoRepository.ObterQuantidadeVendida(id);
            return quantidadeVendida;
        }

        public List<ProdutoDto> ObterTodos()
        {
            var produtosDto = new List<ProdutoDto>();
            var produtos = _produtoRepository.ObterTodos();
            foreach (var produto in produtos)
            {
                produtosDto.Add(new ProdutoDto
                {
                    Id = produto.Id,
                    Nome = produto.Nome,
                    Descricao = produto.Descricao,
                    Preco = produto.Preco,
                    Estoque = produto.Estoque
                });
            }
            return produtosDto;
        }

        private void Validar(ProdutoDto produtoDto)
        {
            var validacao = new ValidacaoProdutoDto();
            resultadoValidacao = validacao.Validate(produtoDto);
        }
    }
}
