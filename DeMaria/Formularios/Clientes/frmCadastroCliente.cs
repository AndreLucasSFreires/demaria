using Aplicacao.DTO;
using Aplicacao.Servicos;
using DeMaria.Formularios.Enums;
using System;
using System.Windows.Forms;

namespace DeMaria.Formularios.Clientes
{
    public partial class frmCadastroCliente : Form
    {
        EstadoBotao estadoBotaoNovo = EstadoBotao.Default;
        EstadoBotao estadoBotaoEditar = EstadoBotao.Default;
        const string textoBotaoNovoDefault = "Novo";
        const string textoBotaoEditarDefault = "Editar";
        const string textoSalvar = "Salvar";
        const string dicaListagem = "Dê um duplo-clique p/ Editar";
        const string dicaCadastro = "A tecla enter avança o próx. campo";

        private ClienteDto clienteSelecionado = null;

        private readonly ClienteService _clienteService;
        public frmCadastroCliente(ClienteService clienteService)
        {
            InitializeComponent();
            _clienteService = clienteService;
            DefinirHabilitacaoTxts(habilitar: false);
        }

        private void ManipularGerenciamentoPressionamentoTecla(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) return;

            TextBox txt = (TextBox)sender;
            if (txt == txtNomeCliente)
                txtEnderecoCliente.Focus();

            if (txt == txtEnderecoCliente)
                txtTelefoneCliente.Focus();

            if (txt == txtTelefoneCliente)
                txtEmailCliente.Focus();

            if (txt == txtEmailCliente)
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

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageCadastro)
            {
                txtNomeCliente.Focus();
                lblDica.Text = dicaCadastro;
            }
            if (tabControl.SelectedTab == tabPageListagem)
            {
                dgvClientesListagem.Focus();
                lblDica.Text = dicaListagem;
            }
        }

        private void DefinirHabilitacaoTxts(bool habilitar)
        {
            txtNomeCliente.Enabled = habilitar;
            txtTelefoneCliente.Enabled = habilitar;
            txtEnderecoCliente.Enabled = habilitar;
            txtEmailCliente.Enabled = habilitar;
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

        private int ObterIdCliente()
        {
            int id = 0;
            if (clienteSelecionado != null) id = clienteSelecionado.Id;
            return id;
        }

        private ClienteDto ObterClienteDto()
        {
            return new ClienteDto
            {
                Id = ObterIdCliente(),
                Nome = txtNomeCliente.Text.Trim(),
                Endereco = txtEnderecoCliente.Text.Trim(),
                Telefone = txtTelefoneCliente.Text.Trim(),
                Email = txtEmailCliente.Text.Trim()
            };
        }

        private void ControlarBotoesTelaCadastro(EnumBotoesCadastro botao)
        {
            var cliente = ObterClienteDto();
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
                    txtNomeCliente.Focus();
                    break;


                case EnumBotoesCadastro.SalvarDoBotaoNovo:
                    var inserido = _clienteService.InserirCliente(cliente);
                    if (inserido)
                    {
                        MessageBox.Show("Novo cliente foi cadastrado com sucesso",
                            "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cliente não foi inserido, contate o suporte!\r\n\r\n" +
                            $"{_clienteService.ObterMensagemFalha()}");
                        return;
                    }

                    btnNovo.Text = textoBotaoNovoDefault;
                    btnExcluir.Enabled = true;
                    btnEditar.Text = textoBotaoEditarDefault;
                    btnEditar.Enabled = true;
                    estadoBotaoNovo = EstadoBotao.Default;
                    ExibirClientesCadastrados();
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
                    txtNomeCliente.Focus();
                    break;

                case EnumBotoesCadastro.SalvarDoBotaoEditar:
                    var atualizado = _clienteService.AtualizarCliente(cliente);

                    if (atualizado)
                    {
                        MessageBox.Show("Cliente foi Atualizado com sucesso",
                            "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cliente não foi atualizado, contate o suporte!\r\n\r\n" +
                            $"{_clienteService.ObterMensagemFalha()}");
                        return;
                    }

                    btnEditar.Text = textoBotaoEditarDefault;
                    btnExcluir.Enabled = true;
                    btnNovo.Enabled = true;
                    btnNovo.Text = textoBotaoNovoDefault;
                    estadoBotaoEditar = EstadoBotao.Default;
                    DefinirHabilitacaoTxts(habilitar: false);
                    ExibirClientesCadastrados();
                    btnNovo.Focus();
                    break;

                case EnumBotoesCadastro.Pesquisar:
                    break;

                case EnumBotoesCadastro.Excluir:

                    var dlg = MessageBox.Show($"Você realmente deseja excluir o seguinte cliente:\r\n\r\n" +
                        $"Nome: {clienteSelecionado.Nome}\r\n" +
                        $"Identificacao: {clienteSelecionado.Id}","Clientes",MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (dlg == DialogResult.No) return;

                    var excluido = _clienteService.Excluir(clienteSelecionado.Id);
                    if (!excluido)
                    {
                        MessageBox.Show("Cliente não foi excluido, contate o suporte!\r\n\r\n" +
                            $"{_clienteService.ObterMensagemFalha()}");
                        return;
                    }

                    DefinirHabilitacaoTxts(habilitar: false);
                    ExibirClientesCadastrados();
                    clienteSelecionado = null;
                    tabControl.SelectedTab = tabPageListagem;
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
                    clienteSelecionado = null;
                    break;


                default:
                    break;
            }
        }

        private void LimparConteudoControles()
        {
            txtNomeCliente.Clear();
            txtEnderecoCliente.Clear();
            txtTelefoneCliente.Clear();
            txtEmailCliente.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!VerificarClienteSelecionado()) return;

            if (estadoBotaoEditar == EstadoBotao.Default)
            {
                ControlarBotoesTelaCadastro(EnumBotoesCadastro.Editar);
            }
            else if (estadoBotaoEditar == EstadoBotao.Salvar)
            {
                ControlarBotoesTelaCadastro(EnumBotoesCadastro.SalvarDoBotaoEditar);
            }
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            ExibirClientesCadastrados();
        }
        private void ExibirClientesCadastrados()
        {
            var clientes = _clienteService.ObterTodos();
            dgvClientesListagem.DataSource = clientes;
        }

        private void frmCadastroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmCadastroCliente_KeyDown(object sender, KeyEventArgs e)
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

        private void ExibirDadosCadastro()
        {
            if (clienteSelecionado == null) return;
            txtNomeCliente.Text = clienteSelecionado.Nome;
            txtEnderecoCliente.Text = clienteSelecionado.Endereco;
            txtTelefoneCliente.Text = clienteSelecionado.Telefone;
            txtEmailCliente.Text = clienteSelecionado.Email;
        }

        private void dgvClientesListagem_DoubleClick(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageCadastro;
        }

        private void dgvClientesListagem_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clienteSelecionado = (ClienteDto)dgvClientesListagem.SelectedRows[0].DataBoundItem;
                ExibirDadosCadastro();
            }
            catch { }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ControlarBotoesTelaCadastro(EnumBotoesCadastro.Voltar);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!VerificarClienteSelecionado()) return;
            ControlarBotoesTelaCadastro(EnumBotoesCadastro.Excluir);
        }

        private bool VerificarClienteSelecionado()
        {
            if (clienteSelecionado == null)
                MessageBox.Show("Selecione um cliente", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            return clienteSelecionado != null;
        }
    }
    
}
