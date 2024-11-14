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
        public string connectionString = "Server=127.0.0.1;Port=5432;Database=demaria;User Id=postgres;Password=123;";
        public const string colunas = "nome, descricao, preco, estoque";
        public const string parametros = "@nome, @descricao, @preco, @estoque";
        public bool Atualizar(Produto produto)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
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
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"DELETE FROM Produtos Where Id = @id", conexao);
                comando.Parameters.AddWithValue("@id", id);
                return comando.ExecuteNonQuery() > 0;
            }
        }

        public bool Inserir(Produto produto)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
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
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"SELECT id, {colunas} From Produtos", conexao);
                var dataTable = new DataTable();
                var dataAdapter = new NpgsqlDataAdapter(comando.CommandText, conexao);
                dataAdapter.Fill(dataTable);
                MapearProdutos(dataTable, out var produtos);
                return produtos;
            }
        }

        private void MapearProdutos(DataTable dataTable, out List<Produto> produtos)
        {
            produtos = new List<Produto>();
            foreach (DataRow row in dataTable.Rows)
            {
                produtos.Add(new Produto
                {
                    Id = row["id"].ToInt(),
                    Nome = row["nome"].ToString(),
                    Descricao = row["descricao"].ToString(),
                    Preco = row["preco"].ToDouble(),
                    Estoque = row["estoque"].ToDouble()
                });
            }
        }
    }

}
