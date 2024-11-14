using CrossCutting;
using Dominio.Entidades;
using Entidades.Interfaces;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repositorios
{
    public class VendaRepository : IVendaRepository
    {
        public string connectionString = "Server=127.0.0.1;Port=5432;Database=demaria;User Id=postgres;Password=123;";
        public const string colunas = "codcliente, dataemissao, valor";
        public const string parametros = "@codcliente, @dataemissao, @valor";
        public bool Atualizar(Venda venda)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"UPDATE Vendas SET codcliente = @codcliente, dataemissao = @dataemissao, " +
                    $"valor = @valor Where Id = @id", conexao);
                comando.Parameters.AddWithValue("@codcliente", venda.CodigoCliente);
                comando.Parameters.AddWithValue("@dataemissao", venda.DataEmissao);
                comando.Parameters.AddWithValue("@valor", venda.Valor);
                comando.Parameters.AddWithValue("@id", venda.Id);
                return comando.ExecuteNonQuery() > 0;
            }
        }

        public bool Excluir(int id)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"DELETE FROM Vendas Where Id = @id", conexao);
                comando.Parameters.AddWithValue("@id", id);
                return comando.ExecuteNonQuery() > 0;
            }
        }

        public bool Inserir(Venda venda)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"INSERT INTO Vendas({colunas}) VALUES({parametros})", conexao);
                comando.Parameters.AddWithValue("@codcliente", venda.CodigoCliente);
                comando.Parameters.AddWithValue("@dataemissao", venda.DataEmissao);
                comando.Parameters.AddWithValue("@valor", venda.Valor);
                return comando.ExecuteNonQuery() > 0;
            }
        }

        public List<Venda> ObterTodos()
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"SELECT id, {colunas} From Vendas", conexao);
                var dataTable = new DataTable();
                var dataAdapter = new NpgsqlDataAdapter(comando.CommandText, conexao);
                dataAdapter.Fill(dataTable);
                MapearVenda(dataTable, out var clientes);
                return clientes;
            }
        }

        private void MapearVenda(DataTable dataTable, out List<Venda> vendas)
        {
            vendas = new List<Venda>();
            foreach (DataRow row in dataTable.Rows)
            {
                vendas.Add(new Venda
                {
                    Id = row["id"].ToInt(),
                    CodigoCliente = row["codcliente"].ToInt(),
                    DataEmissao = row["dataemissao"].ToDateTime(),
                    Valor = row["valor"].ToDouble()
                });
            }
        }
    }
}
