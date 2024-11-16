using Aplicacao.DTO;
using Dominio.Entidades;
using Dominio.Entidades.Interfaces;
using System.Collections.Generic;

namespace Aplicacao.Servicos
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public bool InserirProduto(ProdutoDto produtoDto)
        {
            //realizar validações
            var produto = new Produto(produtoDto.Nome, produtoDto.Descricao, produtoDto.Preco, produtoDto.Estoque);
            return _produtoRepository.Inserir(produto);
        }

        public bool AtualizarProduto(ProdutoDto ProdutoDto)
        {
            //realizar validações
            var produto = new Produto(ProdutoDto.Nome, ProdutoDto.Descricao, ProdutoDto.Preco, ProdutoDto.Estoque)
            {
                Id = ProdutoDto.Id
            };
            return _produtoRepository.Atualizar(produto);
        }

        public bool Excluir(int id)
        {
            return _produtoRepository.Excluir(id);
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
    }
}
