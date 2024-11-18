using System;
using System.ComponentModel;

namespace Aplicacao.DTO
{
    public class ItemVendaDto
    {
        private double _quantidade;
        private double _valorUnitario;
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

        public double Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = Math.Round(value, 2); }
        }

        public double ValorUnitario
        {
            get { return _valorUnitario; }
            set { _valorUnitario = Math.Round(value, 2); }
        }

        public double ValorTotal
        {
            get { return Math.Round(Quantidade * ValorUnitario,2); }
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
