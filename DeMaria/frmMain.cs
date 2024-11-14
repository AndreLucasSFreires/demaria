using System;
using System.Windows.Forms;
using DeMaria.Formularios.Clientes;
using DeMaria.Formularios.Produtos;
using DeMaria.Formularios.Vendas;
using Infraestrutura.Repositorios;

namespace DeMaria
{
    public partial class frmMain : Form
    {
        ClienteRepository ClienteRepository = new ClienteRepository();
        ProdutoRepository ProdutoRepository = new ProdutoRepository();
        VendaRepository VendaRepository = new VendaRepository();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFormularioClientes_Click(object sender, EventArgs e)
        {
            var clienteService = new Aplicacao.Servicos.ClienteService(ClienteRepository);
            var frmClientes = new frmCadastroCliente(clienteService);
            frmClientes.ShowDialog();
        }

        private void btnFormularioProdutos_Click(object sender, EventArgs e)
        {
            var produtoService = new Aplicacao.Servicos.ProdutoService(ProdutoRepository);
            var frmProdutos = new frmCadastroProdutos(produtoService);
            frmProdutos.ShowDialog();
        }

        private void btnFormularioVendas_Click(object sender, EventArgs e)
        {
            var vendaService = new Aplicacao.Servicos.VendaService(VendaRepository, ClienteRepository);
            frmVenda frmVenda = new frmVenda(vendaService);
            frmVenda.ShowDialog();
        }
    }
}
