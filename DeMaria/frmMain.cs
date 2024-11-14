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
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFormularioClientes_Click(object sender, EventArgs e)
        {
            var repositorio = new ClienteRepository();
            var clienteService = new Aplicacao.Servicos.ClienteService(repositorio);
            var frmClientes = new frmCadastroCliente(clienteService);
            frmClientes.ShowDialog();
        }

        private void btnFormularioProdutos_Click(object sender, EventArgs e)
        {
            var repositorio = new ProdutoRepository();
            var produtoService = new Aplicacao.Servicos.ProdutoService(repositorio);
            var frmProdutos = new frmCadastroProdutos(produtoService);
            frmProdutos.ShowDialog();
        }

        private void btnFormularioVendas_Click(object sender, EventArgs e)
        {
            frmVenda frmVenda = new frmVenda();
            frmVenda.ShowDialog();
        }
    }
}
