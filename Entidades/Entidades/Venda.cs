using System;

namespace Dominio.Entidades
{
    public class Venda
    {
        public Venda() { }
        public Venda(int id, Cliente cliente, DateTime dataEmissao, double valor)
        {
            Id = id;
            CodigoCliente = cliente.Id;
            Cliente = cliente;
            DataEmissao = dataEmissao;
            Valor = valor;
        }

        public int Id { get; set; }
        public int CodigoCliente { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataEmissao { get; set; }
        public double Valor { get; set; }
    }
}
