using DeMaria.Formularios.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public frmVenda()
        {
            InitializeComponent();
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
                txtCodCliente.Focus();
            }
            if (botao == EnumBotoesCadastro.SalvarDoBotaoNovo)
            {
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
                btnEditar.Text = textoBotaoEditarDefault;
                btnNovo.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                HabilitarControles(habilitar: false);
                estadoBotaoEditar = EstadoBotao.Default;
            }
            if (botao == EnumBotoesCadastro.Voltar)
            {
                LimparConteudoControles();
                btnNovo.Text = textoBotaoNovoDefault;
                btnEditar.Text = textoBotaoEditarDefault;
                btnNovo.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                HabilitarControles(habilitar: false);
                estadoBotaoEditar = EstadoBotao.Default;
                estadoBotaoNovo = EstadoBotao.Default;
            }

        }

        private void LimparConteudoControles()
        {
            txtCodCliente.Clear();
            txtNomeCliente.Clear();
            txtEndereco.Clear();
            txtEmail.Clear();
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
    }
}
