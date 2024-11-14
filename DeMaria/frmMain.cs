using System;
using System.Windows.Forms;
using Aplicacao.Servicos;
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
        ItemVendaRepository ItemVendaRepository = new ItemVendaRepository();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFormularioClientes_Click(object sender, EventArgs e)
        {
            var clienteService = new ClienteService(ClienteRepository);
            var frmClientes = new frmCadastroCliente(clienteService);
            frmClientes.ShowDialog();
        }

        private void btnFormularioProdutos_Click(object sender, EventArgs e)
        {
            var produtoService = new ProdutoService(ProdutoRepository);
            var frmProdutos = new frmCadastroProdutos(produtoService);
            frmProdutos.ShowDialog();
        }

        private void btnFormularioVendas_Click(object sender, EventArgs e)
        {
            var vendaService = new VendaService(VendaRepository, 
                ClienteRepository, ProdutoRepository);

            var itemVendaService = new ItemVendaService(ItemVendaRepository);

            frmVenda frmVenda = new frmVenda(vendaService, itemVendaService);
            frmVenda.ShowDialog();
        }
    }
}
