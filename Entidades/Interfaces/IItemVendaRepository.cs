using Dominio.Entidades;
using System.Collections.Generic;

namespace Entidades.Interfaces
{
    public interface IItemVendaRepository
    {
        bool Inserir(ItemVenda itemVenda);
        bool Excluir(int id);
        List<ItemVenda> ObterTodosPorVenda(int id);
    }
}
