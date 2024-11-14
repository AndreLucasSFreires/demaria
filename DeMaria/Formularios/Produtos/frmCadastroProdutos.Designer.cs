namespace DeMaria.Formularios.Produtos
{
    partial class frmCadastroProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageListagem = new System.Windows.Forms.TabPage();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblDigiteNomeProdutoPesquisar = new System.Windows.Forms.Label();
            this.dgvProdutosListagem = new System.Windows.Forms.DataGridView();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.tblLayCadastro = new System.Windows.Forms.TableLayoutPanel();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPreço = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblDica = new System.Windows.Forms.Label();
            this.dgvProdutosListagemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProdutosListagemNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProdutosListagemTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProdutosListagemEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProdutosListagemEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPageListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosListagem)).BeginInit();
            this.tabPageCadastro.SuspendLayout();
            this.tblLayCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageListagem);
            this.tabControl.Controls.Add(this.tabPageCadastro);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(897, 504);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageListagem
            // 
            this.tabPageListagem.Controls.Add(this.txtPesquisa);
            this.tabPageListagem.Controls.Add(this.lblDigiteNomeProdutoPesquisar);
            this.tabPageListagem.Controls.Add(this.dgvProdutosListagem);
            this.tabPageListagem.Location = new System.Drawing.Point(4, 25);
            this.tabPageListagem.Name = "tabPageListagem";
            this.tabPageListagem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListagem.Size = new System.Drawing.Size(889, 475);
            this.tabPageListagem.TabIndex = 0;
            this.tabPageListagem.Text = "F1 - Listagem";
            this.tabPageListagem.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(6, 41);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(877, 30);
            this.txtPesquisa.TabIndex = 5;
            // 
            // lblDigiteNomeProdutoPesquisar
            // 
            this.lblDigiteNomeProdutoPesquisar.AutoSize = true;
            this.lblDigiteNomeProdutoPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteNomeProdutoPesquisar.Location = new System.Drawing.Point(6, 15);
            this.lblDigiteNomeProdutoPesquisar.Name = "lblDigiteNomeProdutoPesquisar";
            this.lblDigiteNomeProdutoPesquisar.Size = new System.Drawing.Size(476, 23);
            this.lblDigiteNomeProdutoPesquisar.TabIndex = 1;
            this.lblDigiteNomeProdutoPesquisar.Text = "Digite o nome ou parte do nome do Produto para pesquisar:";
            // 
            // dgvProdutosListagem
            // 
            this.dgvProdutosListagem.AllowUserToAddRows = false;
            this.dgvProdutosListagem.AllowUserToDeleteRows = false;
            this.dgvProdutosListagem.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProdutosListagem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutosListagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutosListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosListagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProdutosListagemId,
            this.dgvProdutosListagemNome,
            this.dgvProdutosListagemTelefone,
            this.dgvProdutosListagemEndereco,
            this.dgvProdutosListagemEmail});
            this.dgvProdutosListagem.Location = new System.Drawing.Point(6, 83);
            this.dgvProdutosListagem.MultiSelect = false;
            this.dgvProdutosListagem.Name = "dgvProdutosListagem";
            this.dgvProdutosListagem.RowHeadersVisible = false;
            this.dgvProdutosListagem.RowTemplate.Height = 24;
            this.dgvProdutosListagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosListagem.ShowCellErrors = false;
            this.dgvProdutosListagem.ShowCellToolTips = false;
            this.dgvProdutosListagem.ShowEditingIcon = false;
            this.dgvProdutosListagem.ShowRowErrors = false;
            this.dgvProdutosListagem.Size = new System.Drawing.Size(877, 386);
            this.dgvProdutosListagem.TabIndex = 0;
            this.dgvProdutosListagem.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutosListagem_RowEnter);
            this.dgvProdutosListagem.DoubleClick += new System.EventHandler(this.dgvProdutosListagem_DoubleClick);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.tblLayCadastro);
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 25);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastro.Size = new System.Drawing.Size(889, 475);
            this.tabPageCadastro.TabIndex = 1;
            this.tabPageCadastro.Text = "F2 - Cadastro";
            this.tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // tblLayCadastro
            // 
            this.tblLayCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayCadastro.ColumnCount = 6;
            this.tblLayCadastro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayCadastro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayCadastro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayCadastro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayCadastro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayCadastro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayCadastro.Controls.Add(this.lblNome, 0, 0);
            this.tblLayCadastro.Controls.Add(this.lblPreço, 0, 2);
            this.tblLayCadastro.Controls.Add(this.txtNomeProduto, 0, 1);
            this.tblLayCadastro.Controls.Add(this.txtPreco, 0, 3);
            this.tblLayCadastro.Controls.Add(this.lblDescricao, 3, 0);
            this.tblLayCadastro.Controls.Add(this.txtDescricao, 3, 1);
            this.tblLayCadastro.Controls.Add(this.lblEstoque, 3, 2);
            this.tblLayCadastro.Controls.Add(this.txtEstoque, 3, 3);
            this.tblLayCadastro.Controls.Add(this.btnNovo, 0, 4);
            this.tblLayCadastro.Controls.Add(this.btnEditar, 1, 4);
            this.tblLayCadastro.Controls.Add(this.btnExcluir, 2, 4);
            this.tblLayCadastro.Controls.Add(this.btnVoltar, 3, 4);
            this.tblLayCadastro.Location = new System.Drawing.Point(6, 6);
            this.tblLayCadastro.Name = "tblLayCadastro";
            this.tblLayCadastro.RowCount = 5;
            this.tblLayCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.302325F));
            this.tblLayCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.67883F));
            this.tblLayCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.067961F));
            this.tblLayCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.05825F));
            this.tblLayCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLayCadastro.Size = new System.Drawing.Size(877, 463);
            this.tblLayCadastro.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(3, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 23);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblPreço
            // 
            this.lblPreço.AutoSize = true;
            this.lblPreço.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreço.Location = new System.Drawing.Point(3, 86);
            this.lblPreço.Name = "lblPreço";
            this.lblPreço.Size = new System.Drawing.Size(53, 23);
            this.lblPreço.TabIndex = 2;
            this.lblPreço.Text = "Preço";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayCadastro.SetColumnSpan(this.txtNomeProduto, 3);
            this.txtNomeProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(3, 41);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(432, 30);
            this.txtNomeProduto.TabIndex = 4;
            this.txtNomeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ManipularGerenciamentoPressionamentoTecla);
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayCadastro.SetColumnSpan(this.txtPreco, 3);
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(3, 114);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(432, 30);
            this.txtPreco.TabIndex = 6;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ManipularGerenciamentoPressionamentoTecla);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(441, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(83, 23);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayCadastro.SetColumnSpan(this.txtDescricao, 3);
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(441, 41);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(433, 30);
            this.txtDescricao.TabIndex = 5;
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ManipularGerenciamentoPressionamentoTecla);
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(441, 86);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(71, 23);
            this.lblEstoque.TabIndex = 3;
            this.lblEstoque.Text = "Estoque";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayCadastro.SetColumnSpan(this.txtEstoque, 3);
            this.txtEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoque.Location = new System.Drawing.Point(441, 114);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(433, 30);
            this.txtEstoque.TabIndex = 7;
            this.txtEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ManipularGerenciamentoPressionamentoTecla);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(3, 415);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(140, 45);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(149, 415);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(140, 45);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(295, 415);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(140, 45);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(441, 415);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(140, 45);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblDica
            // 
            this.lblDica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDica.AutoSize = true;
            this.lblDica.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDica.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDica.Location = new System.Drawing.Point(655, 13);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(192, 19);
            this.lblDica.TabIndex = 8;
            this.lblDica.Text = "Dê um duplo-clique p/ Editar";
            // 
            // dgvProdutosListagemId
            // 
            this.dgvProdutosListagemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProdutosListagemId.DataPropertyName = "Id";
            this.dgvProdutosListagemId.FillWeight = 30F;
            this.dgvProdutosListagemId.HeaderText = "Id";
            this.dgvProdutosListagemId.Name = "dgvProdutosListagemId";
            // 
            // dgvProdutosListagemNome
            // 
            this.dgvProdutosListagemNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProdutosListagemNome.DataPropertyName = "Nome";
            this.dgvProdutosListagemNome.HeaderText = "Nome";
            this.dgvProdutosListagemNome.Name = "dgvProdutosListagemNome";
            // 
            // dgvProdutosListagemTelefone
            // 
            this.dgvProdutosListagemTelefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProdutosListagemTelefone.DataPropertyName = "Descricao";
            this.dgvProdutosListagemTelefone.HeaderText = "Descricao";
            this.dgvProdutosListagemTelefone.Name = "dgvProdutosListagemTelefone";
            // 
            // dgvProdutosListagemEndereco
            // 
            this.dgvProdutosListagemEndereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProdutosListagemEndereco.DataPropertyName = "Preco";
            this.dgvProdutosListagemEndereco.HeaderText = "Preço";
            this.dgvProdutosListagemEndereco.Name = "dgvProdutosListagemEndereco";
            // 
            // dgvProdutosListagemEmail
            // 
            this.dgvProdutosListagemEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProdutosListagemEmail.DataPropertyName = "Estoque";
            this.dgvProdutosListagemEmail.HeaderText = "Estoque";
            this.dgvProdutosListagemEmail.Name = "dgvProdutosListagemEmail";
            // 
            // frmCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 528);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.tabControl);
            this.KeyPreview = true;
            this.Name = "frmCadastroProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualização e Cadastro de Produtos - Pressione a tecla F12 para fechar a tela";
            this.Load += new System.EventHandler(this.frmCadastroProdutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroProdutos_KeyDown);
            this.tabControl.ResumeLayout(false);
            this.tabPageListagem.ResumeLayout(false);
            this.tabPageListagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosListagem)).EndInit();
            this.tabPageCadastro.ResumeLayout(false);
            this.tblLayCadastro.ResumeLayout(false);
            this.tblLayCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageListagem;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblDigiteNomeProdutoPesquisar;
        private System.Windows.Forms.DataGridView dgvProdutosListagem;
        private System.Windows.Forms.TabPage tabPageCadastro;
        private System.Windows.Forms.TableLayoutPanel tblLayCadastro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPreço;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProdutosListagemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProdutosListagemNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProdutosListagemTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProdutosListagemEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProdutosListagemEmail;
    }
}