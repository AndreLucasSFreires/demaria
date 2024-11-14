namespace Aplicacao.DTO
{
    public class ItemVendaDto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public int CodigoVenda { get; set; }
        public int CodigoProduto { get; set; }
        public double Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal { get; set; }
    }
}
