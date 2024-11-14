﻿using Aplicacao.DTO;
using Aplicacao.Servicos;
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

        private readonly VendaService _vendaService;

        VendaDto vendaSelecionada = null;
        ClienteDto clienteSelecionado = null;
        ProdutoDto produtosSelecionado = null;

        public frmVenda(VendaService vendaService)
        {
            InitializeComponent();
            _vendaService = vendaService;
        }

        private int ObterIdVenda()
        {
            int id = 0;
            if (vendaSelecionada != null) id = vendaSelecionada.Id;
            return id;
        }

        private VendaDto ObterClienteDto()
        {
            return new VendaDto
            {
                Id = ObterIdVenda(),

            };
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
                LimparConteudoControlesCliente();
                LimparConteudoControlesProduto();
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

        private void LimparConteudoControlesCliente()
        {
            txtCodCliente.Clear();
            txtNomeCliente.Clear();
            txtEndereco.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
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
            produtosSelecionado = _vendaService.ObterProduto(codigoProduto);

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

        private bool DefinirCliente(int codigoCliente)
        {
            clienteSelecionado = _vendaService.ObterCliente(codigoCliente);
            if (clienteSelecionado.Id == 0)
            {
                MessageBox.Show("Por favor, digite o código de um cliente existente!");
                LimparConteudoControlesCliente();
                return false;
            }

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
            double.TryParse(txtQuant.Text, out double quantidade);
            double.TryParse(txtVUnit.Text, out double unitario);
            txtVTot.Text = (quantidade * unitario).ToString("N2");
        }
    }
}
