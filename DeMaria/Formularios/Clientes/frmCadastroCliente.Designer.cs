namespace DeMaria.Formularios.Clientes
{
    partial class frmCadastroCliente
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
            this.lblDigiteNomeClientePesquisar = new System.Windows.Forms.Label();
            this.dgvClientesListagem = new System.Windows.Forms.DataGridView();
            this.dgvClientesListagemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClientesListagemNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClientesListagemTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClientesListagemEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClientesListagemEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.tblLayCadastro = new System.Windows.Forms.TableLayoutPanel();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblDica = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesListagem)).BeginInit();
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
            this.tabControl.Size = new System.Drawing.Size(892, 504);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageListagem
            // 
            this.tabPageListagem.Controls.Add(this.txtPesquisa);
            this.tabPageListagem.Controls.Add(this.lblDigiteNomeClientePesquisar);
            this.tabPageListagem.Controls.Add(this.dgvClientesListagem);
            this.tabPageListagem.Location = new System.Drawing.Point(4, 25);
            this.tabPageListagem.Name = "tabPageListagem";
            this.tabPageListagem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListagem.Size = new System.Drawing.Size(884, 475);
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
            this.txtPesquisa.Size = new System.Drawing.Size(872, 30);
            this.txtPesquisa.TabIndex = 5;
            // 
            // lblDigiteNomeClientePesquisar
            // 
            this.lblDigiteNomeClientePesquisar.AutoSize = true;
            this.lblDigiteNomeClientePesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteNomeClientePesquisar.Location = new System.Drawing.Point(6, 15);
            this.lblDigiteNomeClientePesquisar.Name = "lblDigiteNomeClientePesquisar";
            this.lblDigiteNomeClientePesquisar.Size = new System.Drawing.Size(467, 23);
            this.lblDigiteNomeClientePesquisar.TabIndex = 1;
            this.lblDigiteNomeClientePesquisar.Text = "Digite o nome ou parte do nome do Cliente para pesquisar:";
            // 
            // dgvClientesListagem
            // 
            this.dgvClientesListagem.AllowUserToAddRows = false;
            this.dgvClientesListagem.AllowUserToDeleteRows = false;
            this.dgvClientesListagem.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgvClientesListagem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientesListagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientesListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesListagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvClientesListagemId,
            this.dgvClientesListagemNome,
            this.dgvClientesListagemTelefone,
            this.dgvClientesListagemEndereco,
            this.dgvClientesListagemEmail});
            this.dgvClientesListagem.Location = new System.Drawing.Point(6, 83);
            this.dgvClientesListagem.MultiSelect = false;
            this.dgvClientesListagem.Name = "dgvClientesListagem";
            this.dgvClientesListagem.RowHeadersVisible = false;
            this.dgvClientesListagem.RowTemplate.Height = 24;
            this.dgvClientesListagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientesListagem.ShowCellErrors = false;
            this.dgvClientesListagem.ShowCellToolTips = false;
            this.dgvClientesListagem.ShowEditingIcon = false;
            this.dgvClientesListagem.ShowRowErrors = false;
            this.dgvClientesListagem.Size = new System.Drawing.Size(872, 386);
            this.dgvClientesListagem.TabIndex = 0;
            this.dgvClientesListagem.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientesListagem_RowEnter);
            this.dgvClientesListagem.DoubleClick += new System.EventHandler(this.dgvClientesListagem_DoubleClick);
            // 
            // dgvClientesListagemId
            // 
            this.dgvClientesListagemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvClientesListagemId.DataPropertyName = "Id";
            this.dgvClientesListagemId.FillWeight = 30F;
            this.dgvClientesListagemId.HeaderText = "Id";
            this.dgvClientesListagemId.Name = "dgvClientesListagemId";
            // 
            // dgvClientesListagemNome
            // 
            this.dgvClientesListagemNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvClientesListagemNome.DataPropertyName = "Nome";
            this.dgvClientesListagemNome.HeaderText = "Nome";
            this.dgvClientesListagemNome.Name = "dgvClientesListagemNome";
            // 
            // dgvClientesListagemTelefone
            // 
            this.dgvClientesListagemTelefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvClientesListagemTelefone.DataPropertyName = "Telefone";
            this.dgvClientesListagemTelefone.HeaderText = "Telefone";
            this.dgvClientesListagemTelefone.Name = "dgvClientesListagemTelefone";
            // 
            // dgvClientesListagemEndereco
            // 
            this.dgvClientesListagemEndereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvClientesListagemEndereco.DataPropertyName = "Endereco";
            this.dgvClientesListagemEndereco.HeaderText = "Endereço";
            this.dgvClientesListagemEndereco.Name = "dgvClientesListagemEndereco";
            // 
            // dgvClientesListagemEmail
            // 
            this.dgvClientesListagemEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvClientesListagemEmail.DataPropertyName = "Email";
            this.dgvClientesListagemEmail.HeaderText = "E-mail";
            this.dgvClientesListagemEmail.Name = "dgvClientesListagemEmail";
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.tblLayCadastro);
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 25);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastro.Size = new System.Drawing.Size(884, 475);
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
            this.tblLayCadastro.Controls.Add(this.lblTelefone, 0, 2);
            this.tblLayCadastro.Controls.Add(this.txtNomeCliente, 0, 1);
            this.tblLayCadastro.Controls.Add(this.txtTelefoneCliente, 0, 3);
            this.tblLayCadastro.Controls.Add(this.lblEndereco, 3, 0);
            this.tblLayCadastro.Controls.Add(this.txtEnderecoCliente, 3, 1);
            this.tblLayCadastro.Controls.Add(this.lblEmail, 3, 2);
            this.tblLayCadastro.Controls.Add(this.txtEmailCliente, 3, 3);
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
            this.tblLayCadastro.Size = new System.Drawing.Size(872, 463);
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
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(3, 86);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(74, 23);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayCadastro.SetColumnSpan(this.txtNomeCliente, 3);
            this.txtNomeCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(3, 41);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(429, 30);
            this.txtNomeCliente.TabIndex = 4;
            this.txtNomeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ManipularGerenciamentoPressionamentoTecla);
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayCadastro.SetColumnSpan(this.txtTelefoneCliente, 3);
            this.txtTelefoneCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneCliente.Location = new System.Drawing.Point(3, 114);
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(429, 30);
            this.txtTelefoneCliente.TabIndex = 6;
            this.txtTelefoneCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ManipularGerenciamentoPressionamentoTecla);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(438, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(81, 23);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayCadastro.SetColumnSpan(this.txtEnderecoCliente, 3);
            this.txtEnderecoCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoCliente.Location = new System.Drawing.Point(438, 41);
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(431, 30);
            this.txtEnderecoCliente.TabIndex = 5;
            this.txtEnderecoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ManipularGerenciamentoPressionamentoTecla);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(438, 86);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayCadastro.SetColumnSpan(this.txtEmailCliente, 3);
            this.txtEmailCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.Location = new System.Drawing.Point(438, 114);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(431, 30);
            this.txtEmailCliente.TabIndex = 7;
            this.txtEmailCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ManipularGerenciamentoPressionamentoTecla);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(3, 415);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(139, 45);
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
            this.btnEditar.Location = new System.Drawing.Point(148, 415);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(139, 45);
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
            this.btnExcluir.Location = new System.Drawing.Point(293, 415);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(139, 45);
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
            this.btnVoltar.Location = new System.Drawing.Point(438, 415);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(139, 45);
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
            this.lblDica.Location = new System.Drawing.Point(655, 8);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(192, 19);
            this.lblDica.TabIndex = 7;
            this.lblDica.Text = "Dê um duplo-clique p/ Editar";
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 528);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.tabControl);
            this.KeyPreview = true;
            this.Name = "frmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualização e Cadastro de Clientes - Pressione a tecla F12 para fechar a tela";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroCliente_KeyDown);
            this.tabControl.ResumeLayout(false);
            this.tabPageListagem.ResumeLayout(false);
            this.tabPageListagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesListagem)).EndInit();
            this.tabPageCadastro.ResumeLayout(false);
            this.tblLayCadastro.ResumeLayout(false);
            this.tblLayCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageListagem;
        private System.Windows.Forms.TabPage tabPageCadastro;
        private System.Windows.Forms.TableLayoutPanel tblLayCadastro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtEnderecoCliente;
        private System.Windows.Forms.TextBox txtTelefoneCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvClientesListagem;
        private System.Windows.Forms.Label lblDigiteNomeClientePesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClientesListagemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClientesListagemNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClientesListagemTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClientesListagemEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClientesListagemEmail;
    }
}