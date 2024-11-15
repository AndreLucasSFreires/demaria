namespace Dominio.Entidades
{
    public class ItemVenda
    {
        public ItemVenda() { }

        public ItemVenda(double valorUnitario, double quantidade, double valorTotal, Venda venda, Produto produto)
        {
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
            ValorTotal = valorTotal;
            Venda = venda;
            Produto = produto;
        }

        public int Id { get; set; }
        public double ValorUnitario { get; set; }
        public double Quantidade { get; set; }
        public double ValorTotal { get; set; }
        public Produto Produto { get; set; }
        public Venda Venda { get; set; }
        public int CodigoVenda { get; set; }
        public int CodigoProduto { get; set; }
    }
}
