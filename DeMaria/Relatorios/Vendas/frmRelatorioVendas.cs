using Aplicacao.DTO;
using Aplicacao.Servicos;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DeMaria.Relatorios.Vendas
{
    public partial class frmRelatorioVendas : Form
    {
        private const string nomeDataSourceVendas = "dsVendas";
        private const string nomeTabelaDataSource = "Venda";
        private readonly VendaService _vendaService;

        public frmRelatorioVendas(VendaService vendaService)
        {
            InitializeComponent();
            _vendaService = vendaService;
        }

        private void DefinirFonteDadosVendas()
        {
            reportViewer1.LocalReport.DataSources.Clear();
            var vendas = _vendaService.ObterTodasAsVendas();
            var dados = new List<DadosRelatorioVenda>();

            dsVendas ds = new dsVendas();
            vendas.ForEach(venda =>
            {
                CriarNovoDadoRelatorio(venda, dados);
            });

            foreach (var item in dados)
            {
                ds.Tables[nomeTabelaDataSource].Rows.Add(item.Id, item.NomeCliente, item.DataEmissao, item.Valor,
                    item.CodigoProduto, item.NomeProduto, item.ValorUnitario, item.Quantidade, item.ValorTotal);
            }
            
            var vendasDs = new ReportDataSource(nomeDataSourceVendas, ds.Tables[nomeTabelaDataSource]);
            reportViewer1.LocalReport.DataSources.Add(vendasDs);
        }


        private static void CriarNovoDadoRelatorio(VendaDto venda, List<DadosRelatorioVenda> dados)
        {
            venda.ItensVenda.ForEach(itemVenda =>
            {
                dados.Add(new DadosRelatorioVenda
                {
                    CodigoProduto = itemVenda.CodigoProduto,
                    DataEmissao = venda.DataEmissao,
                    NomeCliente = venda.NomeCliente,
                    NomeProduto = itemVenda.NomeProduto,
                    Quantidade = itemVenda.Quantidade,
                    Valor = venda.Valor,
                    ValorUnitario = itemVenda.ValorUnitario,
                    ValorTotal = itemVenda.ValorTotal,
                    Id = venda.Id
                });
            });
        }

        private void frmRelatorioVendas_Load(object sender, EventArgs e)
        {
            DefinirFonteDadosVendas();
            this.reportViewer1.RefreshReport();
        }
    }
    public class DadosRelatorioVenda
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataEmissao { get; set; }
        public double Valor { get; set; }
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public double ValorUnitario { get; set; }
        public double Quantidade { get; set; }
        public double ValorTotal { get; set; }
    }
}
