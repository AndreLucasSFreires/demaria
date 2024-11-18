using Aplicacao.Servicos;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeMaria.Relatorios.Estoque
{
    public partial class frmRelatorioEstoque : Form
    {
        private readonly ProdutoService _produtoService;
        const string nomeDataSourceEstoque = "dsEstoque";

        public frmRelatorioEstoque(ProdutoService produtoService)
        {
            InitializeComponent();
            _produtoService = produtoService;
        }

        private void frmRelatorioEstoque_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            var produtos = _produtoService.ObterTodos();

            if (!produtos.Any())
                MessageBox.Show("Não há nenhum produto cadastrado",
                    "Relatório de Produtos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            var produtosDs = new ReportDataSource(nomeDataSourceEstoque, produtos);
            reportViewer1.LocalReport.DataSources.Add(produtosDs);
            this.reportViewer1.RefreshReport();
        }
    }
}
