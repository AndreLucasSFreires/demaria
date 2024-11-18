using Aplicacao.DTO;
using Aplicacao.Servicos;
using DeMaria.Formularios.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DeMaria.Formularios.Vendas
{
    public partial class frmVenda : Form
    {
        EstadoBotao estadoBotaoNovo = EstadoBotao.Default;
        EstadoBotao estadoBotaoEditar = EstadoBotao.Default;
        const string textoBotaoNovoDefault = "Novo";
        const string textoBotaoEditarDefault = "Editar";
        const string textoSalvar = "Salvar";

        private readonly VendaService _vendaService;
        private readonly ItemVendaService _itemVendaService;

        VendaDto vendaAtual = null;
        ClienteDto clienteSelecionado = null;
        ProdutoDto produtosSelecionado = null;

        public frmVenda(VendaService vendaService, ItemVendaService itemVendaService)
        {
            InitializeComponent();
            _vendaService = vendaService;
            _itemVendaService = itemVendaService;
        }

        public VendaDto IniciarNovaVenda()
        {
            clienteSelecionado = null;
            produtosSelecionado = null;
            return new VendaDto { DataEmissao = DateTime.Now };
        }

        private int ObterIdVenda()
        {
            int id = 0;
            if (vendaAtual != null) id = vendaAtual.Id;
            return id;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (estadoBotaoNovo == EstadoBotao.Default)
            {
                ControlarBotoesTelaCadastro(EnumBotoesCadastro.Novo);
            }
            else if (estadoBotaoNovo == EstadoBotao.Salvar)
            {
                ControlarBotoesTelaCadastro(EnumBotoesCadastro.SalvarDoBotaoNovo);
            }
        }

        private void ControlarBotoesTelaCadastro(EnumBotoesCadastro botao)
        {
            if (botao == EnumBotoesCadastro.Novo)
            {
                HabilitarControles(habilitar: true);
                btnNovo.Text = textoSalvar;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                estadoBotaoNovo = EstadoBotao.Salvar;
                vendaAtual = IniciarNovaVenda();
                LimparConteudoControlesCliente();
                LimparConteudoControlesProduto();
                LimparConteudoGrid();
                txtCodCliente.Focus();
            }
            if (botao == EnumBotoesCadastro.SalvarDoBotaoNovo)
            {
                if (!GravarVenda())
                    return;
                else
                    MessageBox.Show("Venda Gravada com sucesso!");

                btnNovo.Text = textoBotaoNovoDefault;
                btnEditar.Text = textoBotaoEditarDefault;
                btnNovo.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                HabilitarControles(habilitar: false);
                estadoBotaoNovo = EstadoBotao.Default;
            }
            if (botao == EnumBotoesCadastro.Editar)
            {
                HabilitarControles(habilitar: true);
                btnEditar.Text = textoSalvar;
                btnNovo.Enabled = false;
                btnExcluir.Enabled = false;
                estadoBotaoEditar = EstadoBotao.Salvar;
                txtCodCliente.Focus();
            }
            if (botao == EnumBotoesCadastro.SalvarDoBotaoEditar)
            {
                bool atualizado = _vendaService.AtualizarVenda(vendaAtual);
                if (!atualizado)
                {
                    MessageBox.Show("Houve falha na atualização, contate o suporte!");
                    return;
                }

                btnEditar.Text = textoBotaoEditarDefault;
                btnNovo.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                HabilitarControles(habilitar: false);
                estadoBotaoEditar = EstadoBotao.Default;
            }
            if (botao == EnumBotoesCadastro.Voltar)
            {
                LimparConteudoControlesCliente();
                LimparConteudoControlesProduto();
                btnNovo.Text = textoBotaoNovoDefault;
                btnEditar.Text = textoBotaoEditarDefault;
                btnNovo.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                HabilitarControles(habilitar: false);
                LimparConteudoGrid();
                estadoBotaoEditar = EstadoBotao.Default;
                estadoBotaoNovo = EstadoBotao.Default;
            }
            if (botao == EnumBotoesCadastro.Excluir)
            {
                var itensExcluidos = _itemVendaService.ExcluirItensPorVenda(vendaAtual.Id);
                var excluido = _vendaService.Excluir(vendaAtual.Id);

                if (!excluido)
                    ExibirMensagemQuandoHouverFalha();

                if (itensExcluidos && excluido)
                {
                    MessageBox.Show("Venda excluída com sucesso!");
                    LimparConteudoControlesCliente();
                    LimparConteudoGrid();
                }
            }
        }

        private bool ExibirMensagemQuandoHouverFalha(string mensagemAdicional = "")
        {
            MessageBox.Show($"Houve falha, contate o suporte!\r\n\r\nExcecao: {mensagemAdicional}\r\n" +
                        $"{_vendaService.MensagemFalha}", "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        private bool GravarVenda()
        {
            try
            {
                bool vendaInserida = _vendaService.InserirVenda(vendaAtual);
                if (vendaInserida)
                {
                    foreach (var item in vendaAtual.ItensVenda)
                        _itemVendaService.InserirItemVenda(item);
                }
                return true;
            }
            catch (Exception e)
            {
                _itemVendaService.ExcluirItensPorVenda(vendaAtual.Id);
                _vendaService.Excluir(vendaAtual.Id);

                ExibirMensagemQuandoHouverFalha(e.Message.ToString());
                return false;
            }
        }

        private void LimparConteudoControlesCliente()
        {
            txtCodCliente.Clear();
            txtNomeCliente.Clear();
            txtEndereco.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtDoc.Clear();
            txtTotalDocumento.Clear();
        }

        private void LimparConteudoControlesProduto()
        {
            txtCodProd.Clear();
            txtNomeProd.Clear();
            txtQuant.Clear();
            txtVUnit.Clear();
            txtVTot.Clear();
        }

        private void HabilitarControles(bool habilitar)
        {
            txtCodCliente.Enabled = habilitar;
            txtNomeCliente.Enabled = habilitar;
            txtEndereco.Enabled = habilitar;
            txtEmail.Enabled = habilitar;
            txtTelefone.Enabled = habilitar;
            tblLayProdutos.Enabled = habilitar;
            dgvProdutosLancamento.Enabled = habilitar;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (estadoBotaoEditar == EstadoBotao.Default)
            {
                ControlarBotoesTelaCadastro(EnumBotoesCadastro.Editar);
            }
            else if (estadoBotaoEditar == EstadoBotao.Salvar)
            {
                ControlarBotoesTelaCadastro(EnumBotoesCadastro.SalvarDoBotaoEditar);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ControlarBotoesTelaCadastro(EnumBotoesCadastro.Voltar);
        }

        private void txtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int.TryParse(txtCodCliente.Text.Trim(), out int codigoCliente);
                if (codigoCliente > 0)
                {
                    if (DefinirCliente(codigoCliente))
                        txtCodProd.Focus();
                    else
                        txtCodCliente.Focus();
                }
                else
                {
                    MessageBox.Show("Digite o código/identificação do cliente que se deseja realizar a venda");
                }
                e.Handled = true;
            }
        }

        private bool DefinirProduto(int codigoProduto)
        {
            produtosSelecionado = _vendaService.ObterProdutoDto(codigoProduto);

            if (produtosSelecionado.Id == 0)
            {
                MessageBox.Show("Digite um código de produto existente");
                LimparConteudoControlesProduto();
                return false;
            }

            string nomeDescricao = $"{produtosSelecionado.Nome} // {produtosSelecionado.Descricao}";
            txtNomeProd.Text = nomeDescricao;
            txtCodProd.Text = produtosSelecionado.Id.ToString().PadLeft(5, '0');
            txtVUnit.Text = produtosSelecionado.Preco.ToString("N2");
            return true;
        }

        private bool DefinirCliente(int codigoCliente, bool carregamentoPorEdicao = false)
        {
            if (!carregamentoPorEdicao)
                clienteSelecionado = _vendaService.ObterCliente(codigoCliente);
            else
                clienteSelecionado = vendaAtual.Cliente;

            if (clienteSelecionado.Id == 0)
            {
                MessageBox.Show("Por favor, digite o código de um cliente existente!");
                LimparConteudoControlesCliente();
                return false;
            }

            vendaAtual.Cliente = clienteSelecionado;
            txtCodCliente.Text = clienteSelecionado.Id.ToString().PadLeft(5, '0');
            txtNomeCliente.Text = clienteSelecionado.Nome;
            txtEndereco.Text = clienteSelecionado.Endereco;
            txtEmail.Text = clienteSelecionado.Email;
            txtTelefone.Text = clienteSelecionado.Telefone;
            return clienteSelecionado.Id > 0;
        }

        private void txtCodProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int.TryParse(txtCodProd.Text.Trim(), out int codigoProduto);
                if (codigoProduto > 0)
                {
                    if (DefinirProduto(codigoProduto))
                        txtQuant.Focus();
                    else
                        txtCodProd.Focus();
                }
                else
                {
                    MessageBox.Show("Digite o código/identificação do produto que se deseja inserir na venda");
                }
                e.Handled = true;
            }
        }

        private void CalcularValorTotal(object sender, EventArgs e)
        {
            var quantidade = ObterQuantidadeLancamento();
            var unitario = ObterValorUnitarioLancamento();
            txtVTot.Text = (quantidade * unitario).ToString("N2");
        }

        private double ObterQuantidadeLancamento()
        {
            double.TryParse(txtQuant.Text, out var quantidade);
            return Math.Round(quantidade, 2);
        }
        private double ObterValorUnitarioLancamento()
        {
            double.TryParse(txtVUnit.Text, out var valorUnitario);
            return Math.Round(valorUnitario, 2);
        }

        private void CalcularValorTotalLancamentosProdutos()
        {
            var valorTotal = vendaAtual.ItensVenda.Sum(x => x.ValorTotal);
            vendaAtual.Valor = valorTotal;
            txtTotalDocumento.Text = valorTotal.ToString("N2");
        }

        private void txtVUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!LancarProdutoVenda())
                    return;

                txtCodProd.Focus();
                e.Handled = true;
            }
        }

        private bool LancarProdutoVenda()
        {
            if (produtosSelecionado == null || produtosSelecionado.Id == 0)
            {
                MessageBox.Show("Por favor, selecione um produto para lançar na venda");
                txtCodProd.Focus();
                return false;
            }

            vendaAtual.ItensVenda.Add(ObterItemVendaDtoLancamento());
            CalcularValorTotalLancamentosProdutos();
            LimparConteudoControlesProduto();
            CarregarGridItensProdutos();
            produtosSelecionado = null;
            return true;
        }

        private void CarregarGridItensProdutos()
        {
            LimparConteudoGrid();
            dgvProdutosLancamento.DataSource = vendaAtual.ItensVenda;
            dgvProdutosLancamento.Refresh();
        }

        private void LimparConteudoGrid()
        {
            dgvProdutosLancamento.DataSource = new List<ItemVendaDto> { };
            dgvProdutosLancamento.Refresh();
        }

        private ItemVendaDto ObterItemVendaDtoLancamento()
        {
            ItemVendaDto itemVendaDto = new ItemVendaDto
            {
                ProdutoDto = produtosSelecionado,
                Quantidade = ObterQuantidadeLancamento(),
                ValorUnitario = ObterValorUnitarioLancamento(),
                Venda = vendaAtual
            };
            return itemVendaDto;
        }

        private void TravarDigitacao(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtVUnit.Focus();
                e.Handled = true;
            }
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            ExibirVendas();
        }
        private void ExibirVendas()
        {
            var clientes = _vendaService.ObterTodasAsVendas();
            dgvVendas.DataSource = clientes;
        }

        private void dgvVendas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vendaAtual = (VendaDto)dgvVendas.SelectedRows[0].DataBoundItem;
                ExibirDadosVenda();
            }
            catch { }
        }
        private void ExibirDadosVenda()
        {
            DefinirCliente(codigoCliente: 0, carregamentoPorEdicao: true);
            CarregarGridItensProdutos();
            txtDoc.Text = vendaAtual.Id.ToString("00000");
            txtTotalDocumento.Text = vendaAtual.Valor.ToString("N2");
        }

        private void dgvVendas_DoubleClick(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageLancamento;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageVisualizacao)
                ExibirVendas();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ControlarBotoesTelaCadastro(EnumBotoesCadastro.Excluir);
        }
    }
}
