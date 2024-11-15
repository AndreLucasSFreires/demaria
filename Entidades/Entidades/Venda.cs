using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Venda
    {
        public Venda() { }
        public Venda(int id, Cliente cliente, DateTime dataEmissao, double valor)
        {
            Id = id;
            Cliente = cliente;
            DataEmissao = dataEmissao;
            Valor = valor;
        }

        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataEmissao { get; set; }
        public double Valor { get; set; }
        public List<ItemVenda> ItensVenda { get; set; }
        public int CodigoCliente { get; set; }
    }
}
