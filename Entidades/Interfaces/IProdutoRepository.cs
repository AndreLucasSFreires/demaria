using System.Collections.Generic;

namespace Dominio.Entidades.Interfaces
{
    public interface IProdutoRepository
    {
        bool Inserir(Produto produto);
        bool Atualizar(Produto produto);
        bool Excluir(int id);
        List<Produto> ObterTodos();
        Produto ObterProduto(int id);
    }
}
