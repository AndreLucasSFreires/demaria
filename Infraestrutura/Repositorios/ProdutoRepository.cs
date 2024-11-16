using CrossCutting;
using Dominio.Entidades;
using Dominio.Entidades.Interfaces;
using Npgsql;
using System.Collections.Generic;
using System.Data;

namespace Infraestrutura.Repositorios
{
    public class ProdutoRepository : IProdutoRepository
    {
        private const string colunas = "nome, descricao, preco, estoque";
        private const string parametros = "@nome, @descricao, @preco, @estoque";

        public double ObterQuantidadeVendida(int id)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(Informacoes.connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"SELECT funcaoquantidadevendida({id})", conexao);
                return (double)comando.ExecuteScalar();
            }
        }

        public bool Atualizar(Produto produto)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(Informacoes.connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"UPDATE Produtos SET nome = @nome, descricao = @descricao, preco = " +
                    $"@preco, estoque = @estoque Where Id = @id", conexao);
                comando.Parameters.AddWithValue("@nome", produto.Nome);
                comando.Parameters.AddWithValue("@descricao", produto.Descricao);
                comando.Parameters.AddWithValue("@preco", produto.Preco);
                comando.Parameters.AddWithValue("@estoque", produto.Estoque);
                comando.Parameters.AddWithValue("@id", produto.Id);
                return comando.ExecuteNonQuery() > 0;
            }
        }

        public bool Excluir(int id)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(Informacoes.connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"DELETE FROM Produtos Where Id = @id", conexao);
                comando.Parameters.AddWithValue("@id", id);
                return comando.ExecuteNonQuery() > 0;
            }
        }

        public bool Inserir(Produto produto)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(Informacoes.connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"INSERT INTO Produtos({colunas}) VALUES({parametros})", conexao);
                comando.Parameters.AddWithValue("@nome", produto.Nome);
                comando.Parameters.AddWithValue("@descricao", produto.Descricao);
                comando.Parameters.AddWithValue("@preco", produto.Preco);
                comando.Parameters.AddWithValue("@estoque", produto.Estoque);
                return comando.ExecuteNonQuery() > 0;
            }
        }

        public List<Produto> ObterTodos()
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(Informacoes.connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"SELECT id, {colunas} " +
                    $"From Produtos", conexao);
                var dataReader = comando.ExecuteReader();
                var produtos = PreencherListagem(dataReader);
                return produtos;
            }
        }

        public Produto ObterProduto(int id)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(Informacoes.connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"SELECT id, {colunas} From Produtos Where Id = @id", conexao);
                comando.Parameters.AddWithValue("@id", id);
                var dataReader = comando.ExecuteReader();
                var produtos = PreencherListagem(dataReader);
                return produtos.Count > 0 ? produtos[0] : new Produto();
            }
        }

        private List<Produto> PreencherListagem(NpgsqlDataReader dataReader)
        {
            var produtos = new List<Produto>();
            while (dataReader.Read())
            {
                produtos.Add(new Produto
                {
                    Id = dataReader["id"].ToInt(),
                    Nome = dataReader["nome"].ToString(),
                    Descricao = dataReader["descricao"].ToString(),
                    Preco = dataReader["preco"].ToDouble(),
                    Estoque = dataReader["estoque"].ToDouble()
                });
            }
            return produtos;
        }
    }

}
