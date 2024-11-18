using System;
using System.ComponentModel;

namespace Aplicacao.DTO
{
    public class ProdutoDto
    {
        private double _preco;
        public int Id { get; set; } = 0;
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco
        {
            get { return _preco; }
            set { _preco = Math.Round(value, 2); }
        }
        public double Estoque { get; set; }
    }
}
