using CrossCutting;
using Dominio.Entidades;
using Dominio.Entidades.Interfaces;
using Npgsql;
using System.Collections.Generic;
using System.Data;

namespace Infraestrutura.Repositorios
{
    public class ClienteRepository : IClienteRepository
    {
        public string connectionString = "Server=127.0.0.1;Port=5432;Database=demaria;User Id=postgres;Password=123;";
        public const string colunas = "nome, endereco, telefone, email";
        public const string parametros = "@nome, @endereco, @telefone, @email";
        public bool Atualizar(Cliente cliente)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"UPDATE Clientes SET nome = @nome, endereco = @endereco, telefone = " +
                    $"@telefone, email = @email Where Id = @id", conexao);
                comando.Parameters.AddWithValue("@nome", cliente.Nome);
                comando.Parameters.AddWithValue("@endereco", cliente.Endereco);
                comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                comando.Parameters.AddWithValue("@email", cliente.Email);
                comando.Parameters.AddWithValue("@id", cliente.Id);
                return comando.ExecuteNonQuery() > 0;
            }
        }

        public bool Excluir(int id)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"DELETE FROM Clientes Where Id = @id", conexao);
                comando.Parameters.AddWithValue("@id", id);
                return comando.ExecuteNonQuery() > 0;
            }
        }

        public bool Inserir(Cliente cliente)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"INSERT INTO Clientes({colunas}) VALUES({parametros})",conexao);
                comando.Parameters.AddWithValue("@nome", cliente.Nome);
                comando.Parameters.AddWithValue("@endereco", cliente.Endereco);
                comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                comando.Parameters.AddWithValue("@email", cliente.Email);
                return comando.ExecuteNonQuery() > 0;
            }
        }

        public List<Cliente> ObterTodos()
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"SELECT id, {colunas} From Clientes", conexao);
                var dataTable = new DataTable();
                var dataAdapter = new NpgsqlDataAdapter(comando.CommandText, conexao);
                dataAdapter.Fill(dataTable);
                MapearClientes(dataTable, out var clientes);
                return clientes;
            }
        }

        private void MapearClientes(DataTable dataTable, out List<Cliente> clientes)
        {
            clientes = new List<Cliente>();
            foreach (DataRow row in dataTable.Rows)
            {
                clientes.Add(new Cliente
                {
                    Id = row["id"].ToInt(),
                    Nome = row["nome"].ToString(),
                    Email = row["email"].ToString(),
                    Endereco = row["endereco"].ToString(),
                    Telefone = row["telefone"].ToString()
                });
            }
        }
    }
}
