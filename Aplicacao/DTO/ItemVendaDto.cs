using System;
using System.ComponentModel;

namespace Aplicacao.DTO
{
    public class ItemVendaDto
    {
        private double _valorTotal;

        public int Id { get; set; }

        [Browsable(false)]
        public int IdVenda
        {
            get
            {
                try
                {
                    return Venda.Id;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public double Quantidade { get; set; }

        public double ValorUnitario { get; set; }

        public double ValorTotal
        {
            get { return Math.Round(_valorTotal, 2); }
            set { _valorTotal = value; }
        }

        [Browsable(false)]
        public ProdutoDto ProdutoDto { get; set; }

        [Browsable(false)]
        public VendaDto Venda { get; set; }

        public int CodigoProduto
        {
            get { return ProdutoDto.Id; }
        }
        public string NomeProduto
        {
            get { return ProdutoDto.Nome; }
        }
    }
}
