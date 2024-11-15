using CrossCutting;
using Dominio.Entidades;
using Entidades.Interfaces;
using Npgsql;
using System.Collections.Generic;

namespace Infraestrutura.Repositorios
{
    public class ItemVendaRepository : IItemVendaRepository
    {
        public const string colunas = "codvenda, codproduto, valorunitario, quantidade, valortotal";
        public const string parametros = "@codvenda, @codproduto, @valorunitario, @quantidade, @valortotal";

        public bool Excluir(int id)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(Informacoes.connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"DELETE FROM Itensvenda Where Id = @id", conexao);
                comando.Parameters.AddWithValue("@id", id);
                return comando.ExecuteNonQuery() > 0;
            }
        }

        public bool Inserir(ItemVenda itemVenda)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(Informacoes.connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"INSERT INTO Itensvenda({colunas}) VALUES({parametros})", conexao);
                comando.Parameters.AddWithValue("@codvenda", itemVenda.Venda.Id);
                comando.Parameters.AddWithValue("@codproduto", itemVenda.Produto.Id);
                comando.Parameters.AddWithValue("@valorunitario", itemVenda.ValorUnitario);
                comando.Parameters.AddWithValue("@quantidade", itemVenda.Quantidade);
                comando.Parameters.AddWithValue("@valortotal", itemVenda.ValorTotal);
                return comando.ExecuteNonQuery() > 0;
            }
        }

        public List<ItemVenda> ObterTodosPorVenda(int id)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(Informacoes.connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"SELECT id, {colunas} From Itensvenda Where codvenda = @id", conexao);
                comando.Parameters.AddWithValue("@id", id);
                var dataReader = comando.ExecuteReader();
                var itensVenda = PreencherListagem(dataReader);
                return itensVenda;
            }
        }

        private List<ItemVenda> PreencherListagem(NpgsqlDataReader dataReader)
        {
            var itensVenda = new List<ItemVenda>();
            while (dataReader.Read())
            {
                itensVenda.Add(new ItemVenda
                {
                    Id = dataReader["id"].ToInt(),
                    CodigoVenda = dataReader["codvenda"].ToInt(),
                    CodigoProduto = dataReader["codproduto"].ToInt(),
                    ValorUnitario = dataReader["valorunitario"].ToDouble(),
                    Quantidade = dataReader["quantidade"].ToDouble(),
                    ValorTotal = dataReader["valortotal"].ToDouble()
                });
            }
            return itensVenda;
        }
    }
}
