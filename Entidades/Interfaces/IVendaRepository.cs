﻿using Dominio.Entidades;
using System.Collections.Generic;

namespace Entidades.Interfaces
{
    public interface IVendaRepository
    {
        int Inserir(Venda venda);
        bool Atualizar(Venda venda);
        bool Excluir(int id);
        List<Venda> ObterTodasAsVendas();
    }
}
