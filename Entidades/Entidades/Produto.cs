namespace Dominio.Entidades
{
    public class Produto
    {
        public int Id { get; set; } = 0;
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public double Estoque { get; set; }

        public Produto() { }

        public Produto(string nome, string descricao, double preco, double estoque)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
        }
    }
}
