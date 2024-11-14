using System.Collections.Generic;

namespace Dominio.Entidades.Interfaces
{
    public interface IClienteRepository
    {
        bool Inserir(Cliente cliente);
        bool Atualizar(Cliente cliente);
        bool Excluir(int id);
        List<Cliente> ObterTodos();
    }
}
