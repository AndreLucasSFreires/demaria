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

namespace DeMaria.Relatorios.Clientes
{
    public partial class frmRelatorioClientes : Form
    {
        const string nomeDataSourceVendas = "dsClientes";
        private readonly ClienteService _clienteService;
        public frmRelatorioClientes(ClienteService clienteService)
        {
            InitializeComponent();
            _clienteService = clienteService;
        }

        private void frmRelatorioClientes_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            var clientes = _clienteService.ObterTodos();

            if (!clientes.Any())
                MessageBox.Show("Não há nenhum cliente cadastrado",
                    "Relatório de Clientes",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            var clientesDs = new ReportDataSource(nomeDataSourceVendas, clientes);
            reportViewer1.LocalReport.DataSources.Add(clientesDs);
            this.reportViewer1.RefreshReport();
        }
    }
}
