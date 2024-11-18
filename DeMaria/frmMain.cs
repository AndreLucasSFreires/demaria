using System;
using System.Windows.Forms;
using Aplicacao.Servicos;
using DeMaria.Formularios.Clientes;
using DeMaria.Formularios.Produtos;
using DeMaria.Formularios.Vendas;
using DeMaria.Relatorios.Clientes;
using DeMaria.Relatorios.Estoque;
using DeMaria.Relatorios.Vendas;
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
            var clienteService = ObterClienteService();
            var frmClientes = new frmCadastroCliente(clienteService);
            frmClientes.Show();
        }

        private ClienteService ObterClienteService()
        {
            return new ClienteService(ClienteRepository);
        }

        private void btnFormularioProdutos_Click(object sender, EventArgs e)
        {
            var produtoService = ObterProdutoService();
            var frmProdutos = new frmCadastroProdutos(produtoService);
            frmProdutos.Show();
        }

        private ProdutoService ObterProdutoService()
        {
            return new ProdutoService(ProdutoRepository);
        }

        private void btnFormularioVendas_Click(object sender, EventArgs e)
        {
            var vendaService = ObterVendaService();
            var itemVendaService = new ItemVendaService(ItemVendaRepository);

            frmVenda frmVenda = new frmVenda(vendaService, itemVendaService);
            frmVenda.Show();
        }

        private VendaService ObterVendaService()
        {
            VendaService vendaService = new VendaService(VendaRepository,
                ClienteRepository, ProdutoRepository, ItemVendaRepository);
            return vendaService;
        }

        private void btnFormularioRelatorios_Click(object sender, EventArgs e)
        {
            var vendaService = ObterVendaService();
            var relatorioVendas = new frmRelatorioVendas(vendaService);
            relatorioVendas.Show();
        }

        private void btnRelatorioClientes_Click(object sender, EventArgs e)
        {
            var relatorioClientes = new frmRelatorioClientes(ObterClienteService());
            relatorioClientes.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var produtoService = ObterProdutoService();
            var relatorioEstoque = new frmRelatorioEstoque(produtoService);
            relatorioEstoque.Show();
        }
    }
}
