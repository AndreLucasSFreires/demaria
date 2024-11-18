using Aplicacao.DTO;
using Aplicacao.Servicos;
using CrossCutting;
using DeMaria.Formularios.Enums;
using System;
using System.Windows.Forms;

namespace DeMaria.Formularios.Produtos
{
    public partial class frmCadastroProdutos : Form
    {
        EstadoBotao estadoBotaoNovo = EstadoBotao.Default;
        EstadoBotao estadoBotaoEditar = EstadoBotao.Default;
        const string textoBotaoNovoDefault = "Novo";
        const string textoBotaoEditarDefault = "Editar";
        const string textoSalvar = "Salvar";
        const string dicaListagem = "Dê um duplo-clique p/ Editar";
        const string dicaCadastro = "A tecla enter avança o próx. campo";

        private ProdutoDto produtoSelecionado = null;

        private readonly ProdutoService _produtoService;
        public frmCadastroProdutos(ProdutoService produtoService)
        {
            InitializeComponent();
            _produtoService = produtoService;
            DefinirHabilitacaoTxts(habilitar: false);
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

        private int ObterIdProduto()
        {
            int id = 0;
            if (produtoSelecionado != null) id = produtoSelecionado.Id;
            return id;
        }

        private ProdutoDto ObterProdutoDto()
        {
            return new ProdutoDto
            {
                Id = ObterIdProduto(),
                Nome = txtNomeProduto.Text.Trim(),
                Descricao = txtDescricao.Text.Trim(),
                Preco = txtPreco.Text.Trim().ToDouble(),
                Estoque = txtEstoque.Text.Trim().ToDouble()
            };
        }

        private void DefinirHabilitacaoTxts(bool habilitar)
        {
            txtNomeProduto.Enabled = habilitar;
            txtDescricao.Enabled = habilitar;
            txtPreco.Enabled = habilitar;
            txtEstoque.Enabled = habilitar;
        }

        private void LimparConteudoControles()
        {
            txtNomeProduto.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();
        }

        private void ExibirProdutosCadastrados()
        {
            var produtos = _produtoService.ObterTodos();
            dgvProdutosListagem.DataSource = produtos;
        }

        private void ControlarBotoesTelaCadastro(EnumBotoesCadastro botao)
        {
            var produto = ObterProdutoDto();
            switch (botao)
            {
                case EnumBotoesCadastro.Novo:
                    DefinirHabilitacaoTxts(habilitar: true);
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnVoltar.Enabled = true;
                    estadoBotaoNovo = EstadoBotao.Salvar;
                    btnNovo.Text = textoSalvar;
                    LimparConteudoControles();
                    txtNomeProduto.Focus();
                    break;


                case EnumBotoesCadastro.SalvarDoBotaoNovo:
                    var inserido = _produtoService.InserirProduto(produto);
                    if (inserido)
                    {
                        MessageBox.Show("Novo Produto foi cadastrado com sucesso",
                            "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Produto não foi inserido, contate o suporte:\r\n\r\n" +
                            $"{_produtoService.ObterMensagemFalha()}");
                        return;
                    }

                    btnNovo.Text = textoBotaoNovoDefault;
                    btnExcluir.Enabled = true;
                    btnEditar.Text = textoBotaoEditarDefault;
                    btnEditar.Enabled = true;
                    estadoBotaoNovo = EstadoBotao.Default;
                    ExibirProdutosCadastrados();
                    DefinirHabilitacaoTxts(habilitar: false);
                    btnNovo.Focus();
                    break;

                case EnumBotoesCadastro.Editar:
                    DefinirHabilitacaoTxts(habilitar: true);
                    btnEditar.Text = textoSalvar;
                    btnNovo.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnVoltar.Enabled = true;
                    estadoBotaoEditar = EstadoBotao.Salvar;
                    txtNomeProduto.Focus();
                    break;

                case EnumBotoesCadastro.SalvarDoBotaoEditar:
                    var atualizado = _produtoService.AtualizarProduto(produto);

                    if (atualizado)
                    {
                        MessageBox.Show("Produto foi Atualizado com sucesso",
                            "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Produto não foi atualizado, contate o suporte!\r\n\r\n" +
                            $"{_produtoService.ObterMensagemFalha()}");
                        return;
                    }

                    btnEditar.Text = textoBotaoEditarDefault;
                    btnExcluir.Enabled = true;
                    btnNovo.Enabled = true;
                    btnNovo.Text = textoBotaoNovoDefault;
                    estadoBotaoEditar = EstadoBotao.Default;
                    DefinirHabilitacaoTxts(habilitar: false);
                    ExibirProdutosCadastrados();
                    btnNovo.Focus();
                    break;

                case EnumBotoesCadastro.Pesquisar:
                    break;

                case EnumBotoesCadastro.Excluir:

                    var dlg = MessageBox.Show($"Você realmente deseja excluir o seguinte Produto:\r\n\r\n" +
                        $"Nome: {produtoSelecionado.Nome}\r\n" +
                        $"Identificacao: {produtoSelecionado.Id}", "Produtos", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (dlg == DialogResult.No) return;

                    var excluido = _produtoService.Excluir(produtoSelecionado.Id);
                    if (!excluido)
                    {
                        MessageBox.Show("Produto não foi excluído, contate o suporte" +
                            "\r\n\r\n" +
                            $"{_produtoService.ObterMensagemFalha()}");
                        return;
                    }

                    DefinirHabilitacaoTxts(habilitar: false);
                    ExibirProdutosCadastrados();
                    tabControl.SelectedTab = tabPageListagem;
                    produtoSelecionado = null;
                    break;

                case EnumBotoesCadastro.Voltar:
                    btnNovo.Enabled = true;
                    btnNovo.Text = textoBotaoNovoDefault;
                    btnEditar.Enabled = true;
                    btnEditar.Text = textoBotaoEditarDefault;
                    btnExcluir.Enabled = true;
                    LimparConteudoControles();
                    DefinirHabilitacaoTxts(habilitar: false);
                    tabControl.SelectedTab = tabPageListagem;
                    produtoSelecionado = null;
                    break;


                default:
                    break;
            }
        }

        private void frmCadastroProdutos_Load(object sender, EventArgs e)
        {
            ExibirProdutosCadastrados();
        }

        private void frmCadastroProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    tabControl.SelectedTab = tabPageListagem;
                    break;
                case Keys.F2:
                    tabControl.SelectedTab = tabPageCadastro;
                    break;
                case Keys.F12:
                    Close();
                    break;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!VerificarProdutoSelecionado()) return;

            if (estadoBotaoEditar == EstadoBotao.Default)
            {
                ControlarBotoesTelaCadastro(EnumBotoesCadastro.Editar);
            }
            else if (estadoBotaoEditar == EstadoBotao.Salvar)
            {
                ControlarBotoesTelaCadastro(EnumBotoesCadastro.SalvarDoBotaoEditar);
            }
        }
        private bool VerificarProdutoSelecionado()
        {
            if (produtoSelecionado == null)
                MessageBox.Show("Selecione um produto", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return produtoSelecionado != null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!VerificarProdutoSelecionado()) return;
            ControlarBotoesTelaCadastro(EnumBotoesCadastro.Excluir);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ControlarBotoesTelaCadastro(EnumBotoesCadastro.Voltar);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageCadastro)
            {
                txtNomeProduto.Focus();
                lblDica.Text = dicaCadastro;
            }
            if (tabControl.SelectedTab == tabPageListagem)
            {
                dgvProdutosListagem.Focus();
                lblDica.Text = dicaListagem;
            }
        }

        private void ManipularGerenciamentoPressionamentoTecla(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) return;

            TextBox txt = (TextBox)sender;
            if (txt == txtNomeProduto)
                txtDescricao.Focus();

            if (txt == txtDescricao)
                txtPreco.Focus();

            if (txt == txtPreco)
                txtEstoque.Focus();

            if (txt == txtEstoque)
                SelecionarBotaoSalvar();

            e.Handled = true;
        }
        private void SelecionarBotaoSalvar()
        {
            if (estadoBotaoNovo == EstadoBotao.Salvar)
                btnNovo.Focus();
            else if (estadoBotaoEditar == EstadoBotao.Salvar)
                btnEditar.Focus();
        }

        private void dgvProdutosListagem_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                produtoSelecionado = (ProdutoDto)dgvProdutosListagem.SelectedRows[0].DataBoundItem;
                ExibirDadosCadastro();
            }
            catch { }
        }

        private void ExibirDadosCadastro()
        {
            if (produtoSelecionado == null) return;
            txtNomeProduto.Text = produtoSelecionado.Nome;
            txtDescricao.Text = produtoSelecionado.Descricao;
            txtPreco.Text = produtoSelecionado.Preco.ToString("N2");
            txtEstoque.Text = produtoSelecionado.Estoque.ToString("N2");
        }

        private void dgvProdutosListagem_DoubleClick(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageCadastro;
        }

        private void txtSaldoEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtSaldoEstoquePrevisao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TravarDigitacao(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
