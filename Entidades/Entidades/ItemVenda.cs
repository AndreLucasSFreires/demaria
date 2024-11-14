namespace Dominio.Entidades
{
    public class ItemVenda
    {
        public ItemVenda() { }

        public ItemVenda(int codigoVenda, int codigoProduto, double valorUnitario, double quantidade, double valorTotal)
        {
            CodigoVenda = codigoVenda;
            CodigoProduto = codigoProduto;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
            ValorTotal = valorTotal;
        }

        public int Id { get; set; }
        public int CodigoVenda { get; set; }
        public int CodigoProduto { get; set; }
        public double ValorUnitario { get; set; }
        public double Quantidade { get; set; }
        public double ValorTotal { get; set; }
    }
}
