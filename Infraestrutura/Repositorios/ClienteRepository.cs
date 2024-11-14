using CrossCutting;
using Dominio.Entidades;
using Dominio.Entidades.Interfaces;
using Npgsql;
using System.Collections.Generic;

namespace Infraestrutura.Repositorios
{
    public class ClienteRepository : IClienteRepository
    {
        public const string colunas = "nome, endereco, telefone, email";
        public const string parametros = "@nome, @endereco, @telefone, @email";
        public bool Atualizar(Cliente cliente)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(Informacoes.connectionString))
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
            using (NpgsqlConnection conexao = new NpgsqlConnection(Informacoes.connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"DELETE FROM Clientes Where Id = @id", conexao);
                comando.Parameters.AddWithValue("@id", id);
                return comando.ExecuteNonQuery() > 0;
            }
        }

        public bool Inserir(Cliente cliente)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(Informacoes.connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"INSERT INTO Clientes({colunas}) VALUES({parametros})", conexao);
                comando.Parameters.AddWithValue("@nome", cliente.Nome);
                comando.Parameters.AddWithValue("@endereco", cliente.Endereco);
                comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                comando.Parameters.AddWithValue("@email", cliente.Email);
                return comando.ExecuteNonQuery() > 0;
            }
        }

        public List<Cliente> ObterTodos()
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(Informacoes.connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"SELECT id, {colunas} From Clientes", conexao);
                var dataReader = comando.ExecuteReader();
                var clientes = PreencherListagem(dataReader);
                return clientes;
            }
        }

        public Cliente ObterCliente(int id)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(Informacoes.connectionString))
            {
                conexao.Open();
                var comando = new NpgsqlCommand($"SELECT id, {colunas} From Clientes Where Id = @id", conexao);
                comando.Parameters.AddWithValue("@id", id);

                var dataReader = comando.ExecuteReader();
                var clientes = PreencherListagem(dataReader);
                return clientes.Count > 0 ? clientes[0] : new Cliente();
            }
        }

        private List<Cliente> PreencherListagem(NpgsqlDataReader dataReader)
        {
            var clientes = new List<Cliente>();
            while (dataReader.Read())
            {
                clientes.Add(new Cliente
                {
                    Id = dataReader["id"].ToInt(),
                    Nome = dataReader["nome"].ToString(),
                    Email = dataReader["email"].ToString(),
                    Endereco = dataReader["endereco"].ToString(),
                    Telefone = dataReader["telefone"].ToString()
                });
            }
            return clientes;
        }
    }
}
