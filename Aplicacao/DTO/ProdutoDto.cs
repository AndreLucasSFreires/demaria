namespace Aplicacao.DTO
{
    public class ProdutoDto
    {
        public int Id { get; set; } = 0;
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public double Estoque { get; set; }
    }
}
