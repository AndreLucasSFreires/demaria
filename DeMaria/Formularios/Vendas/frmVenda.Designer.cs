namespace DeMaria.Formularios.Vendas
{
    partial class frmVenda
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
            this.tblLayCabecalho = new System.Windows.Forms.TableLayoutPanel();
            this.tblLancamento = new System.Windows.Forms.TableLayoutPanel();
            this.dgvProdutosLancamento = new System.Windows.Forms.DataGridView();
            this.tblLayProdutos = new System.Windows.Forms.TableLayoutPanel();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.lblProdutosLancamento = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.txtVUnit = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtVTot = new System.Windows.Forms.TextBox();
            this.tblBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCodigoENomeCli = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblTotalDocumento = new System.Windows.Forms.Label();
            this.txtTotalDocumento = new System.Windows.Forms.TextBox();
            this.colItensProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGridItensSeguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cofins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItensID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItensProdutoCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItensXProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItensNCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItensCSOSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItensCFOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItensUnidadeTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItensQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItensUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItensDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItensTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItensAleatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItensProdutoGuidID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItensnfeGuidId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoEnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.convEmbalagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BICMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VLICMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VLICMSST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VLIPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGridItensOrigCST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AliqICMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AliqIPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGridItensUsarCST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGridItensValorVendaLiq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGridItensCST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGridItensFrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGridItensIdLancamentoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNFGridTentativaNCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageVisualizacao = new System.Windows.Forms.TabPage();
            this.tblVisualizacaoVendas = new System.Windows.Forms.TableLayoutPanel();
            this.lblVisualizacaoVendas = new System.Windows.Forms.Label();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.dgvVendasColClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVendasColClienteCodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVendasColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVendasColClienteDataEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVendasColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageLancamento = new System.Windows.Forms.TabPage();
            this.colDgvProdutosLancamentoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDgvProdutosLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProdutosLancamentoColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProdutosLancamentoColNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDgvProdutosLancamentoQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDgvProdutosLancamentoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDgvProdutosLancamentoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLayCabecalho.SuspendLayout();
            this.tblLancamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosLancamento)).BeginInit();
            this.tblLayProdutos.SuspendLayout();
            this.tblBotoes.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageVisualizacao.SuspendLayout();
            this.tblVisualizacaoVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.tabPageLancamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayCabecalho
            // 
            this.tblLayCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayCabecalho.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tblLayCabecalho.ColumnCount = 12;
            this.tblLayCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.347782F));
            this.tblLayCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.347782F));
            this.tblLayCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.347782F));
            this.tblLayCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.347782F));
            this.tblLayCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.347782F));
            this.tblLayCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.22404F));
            this.tblLayCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.408423F));
            this.tblLayCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.935656F));
            this.tblLayCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.324078F));
            this.tblLayCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.022351F));
            this.tblLayCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.998765F));
            this.tblLayCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.347782F));
            this.tblLayCabecalho.Controls.Add(this.tblLancamento, 0, 4);
            this.tblLayCabecalho.Controls.Add(this.lblCodigoENomeCli, 0, 0);
            this.tblLayCabecalho.Controls.Add(this.txtCodCliente, 0, 1);
            this.tblLayCabecalho.Controls.Add(this.txtNomeCliente, 1, 1);
            this.tblLayCabecalho.Controls.Add(this.lblTelefone, 0, 2);
            this.tblLayCabecalho.Controls.Add(this.txtTelefone, 0, 3);
            this.tblLayCabecalho.Controls.Add(this.txtEmail, 5, 3);
            this.tblLayCabecalho.Controls.Add(this.lblEmail, 5, 2);
            this.tblLayCabecalho.Controls.Add(this.txtDoc, 11, 0);
            this.tblLayCabecalho.Controls.Add(this.labelDocumento, 9, 0);
            this.tblLayCabecalho.Controls.Add(this.lblEndereco, 5, 0);
            this.tblLayCabecalho.Controls.Add(this.txtEndereco, 5, 1);
            this.tblLayCabecalho.Controls.Add(this.lblTotalDocumento, 9, 2);
            this.tblLayCabecalho.Controls.Add(this.txtTotalDocumento, 9, 3);
            this.tblLayCabecalho.Location = new System.Drawing.Point(7, 7);
            this.tblLayCabecalho.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayCabecalho.Name = "tblLayCabecalho";
            this.tblLayCabecalho.RowCount = 5;
            this.tblLayCabecalho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.740061F));
            this.tblLayCabecalho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.12844F));
            this.tblLayCabecalho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.12844F));
            this.tblLayCabecalho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.801921F));
            this.tblLayCabecalho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.82927F));
            this.tblLayCabecalho.Size = new System.Drawing.Size(1433, 654);
            this.tblLayCabecalho.TabIndex = 4;
            // 
            // tblLancamento
            // 
            this.tblLancamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLancamento.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tblLancamento.ColumnCount = 1;
            this.tblLayCabecalho.SetColumnSpan(this.tblLancamento, 12);
            this.tblLancamento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLancamento.Controls.Add(this.dgvProdutosLancamento, 0, 1);
            this.tblLancamento.Controls.Add(this.tblLayProdutos, 0, 0);
            this.tblLancamento.Controls.Add(this.tblBotoes, 0, 2);
            this.tblLancamento.Location = new System.Drawing.Point(3, 119);
            this.tblLancamento.Name = "tblLancamento";
            this.tblLancamento.RowCount = 3;
            this.tblLancamento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLancamento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblLancamento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLancamento.Size = new System.Drawing.Size(1427, 532);
            this.tblLancamento.TabIndex = 48;
            // 
            // dgvProdutosLancamento
            // 
            this.dgvProdutosLancamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutosLancamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosLancamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDgvProdutosLancamentoId,
            this.colDgvProdutosLancamento,
            this.dgvProdutosLancamentoColCodigo,
            this.dgvProdutosLancamentoColNomeProduto,
            this.colDgvProdutosLancamentoQuantidade,
            this.colDgvProdutosLancamentoUnitario,
            this.colDgvProdutosLancamentoTotal});
            this.dgvProdutosLancamento.Enabled = false;
            this.dgvProdutosLancamento.EnableHeadersVisualStyles = false;
            this.dgvProdutosLancamento.Location = new System.Drawing.Point(3, 109);
            this.dgvProdutosLancamento.MultiSelect = false;
            this.dgvProdutosLancamento.Name = "dgvProdutosLancamento";
            this.dgvProdutosLancamento.RowHeadersVisible = false;
            this.dgvProdutosLancamento.RowTemplate.Height = 24;
            this.dgvProdutosLancamento.ShowCellErrors = false;
            this.dgvProdutosLancamento.ShowCellToolTips = false;
            this.dgvProdutosLancamento.ShowEditingIcon = false;
            this.dgvProdutosLancamento.ShowRowErrors = false;
            this.dgvProdutosLancamento.Size = new System.Drawing.Size(1421, 366);
            this.dgvProdutosLancamento.TabIndex = 47;
            // 
            // tblLayProdutos
            // 
            this.tblLayProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayProdutos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tblLayProdutos.ColumnCount = 5;
            this.tblLayProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.41032F));
            this.tblLayProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.10155F));
            this.tblLayProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.927031F));
            this.tblLayProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.455399F));
            this.tblLayProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.981221F));
            this.tblLayProdutos.Controls.Add(this.lblNomeProduto, 1, 1);
            this.tblLayProdutos.Controls.Add(this.txtCodProd, 0, 2);
            this.tblLayProdutos.Controls.Add(this.txtNomeProd, 1, 2);
            this.tblLayProdutos.Controls.Add(this.lblCodigoProduto, 0, 1);
            this.tblLayProdutos.Controls.Add(this.lblProdutosLancamento, 0, 0);
            this.tblLayProdutos.Controls.Add(this.lblQuant, 2, 1);
            this.tblLayProdutos.Controls.Add(this.txtQuant, 2, 2);
            this.tblLayProdutos.Controls.Add(this.lblValorUnitario, 3, 1);
            this.tblLayProdutos.Controls.Add(this.txtVUnit, 3, 2);
            this.tblLayProdutos.Controls.Add(this.lblTotal, 4, 1);
            this.tblLayProdutos.Controls.Add(this.txtVTot, 4, 2);
            this.tblLayProdutos.Enabled = false;
            this.tblLayProdutos.Location = new System.Drawing.Point(4, 4);
            this.tblLayProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayProdutos.Name = "tblLayProdutos";
            this.tblLayProdutos.RowCount = 3;
            this.tblLayProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLayProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblLayProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayProdutos.Size = new System.Drawing.Size(1419, 98);
            this.tblLayProdutos.TabIndex = 46;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(279, 33);
            this.lblNomeProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(196, 19);
            this.lblNomeProduto.TabIndex = 19;
            this.lblNomeProduto.Text = "Nome do Produto / Descrição";
            // 
            // txtCodProd
            // 
            this.txtCodProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodProd.Location = new System.Drawing.Point(4, 65);
            this.txtCodProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(267, 22);
            this.txtCodProd.TabIndex = 23;
            this.txtCodProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProd_KeyPress);
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProd.Location = new System.Drawing.Point(279, 65);
            this.txtNomeProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(789, 23);
            this.txtNomeProd.TabIndex = 24;
            this.txtNomeProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TravarDigitacao);
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProduto.Location = new System.Drawing.Point(4, 33);
            this.lblCodigoProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(54, 19);
            this.lblCodigoProduto.TabIndex = 47;
            this.lblCodigoProduto.Text = "Código";
            // 
            // lblProdutosLancamento
            // 
            this.lblProdutosLancamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdutosLancamento.AutoSize = true;
            this.tblLayProdutos.SetColumnSpan(this.lblProdutosLancamento, 2);
            this.lblProdutosLancamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProdutosLancamento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutosLancamento.Location = new System.Drawing.Point(4, 0);
            this.lblProdutosLancamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdutosLancamento.Name = "lblProdutosLancamento";
            this.lblProdutosLancamento.Size = new System.Drawing.Size(1064, 28);
            this.lblProdutosLancamento.TabIndex = 3;
            this.lblProdutosLancamento.Text = "Produtos - Lancamento";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuant.Location = new System.Drawing.Point(1076, 33);
            this.lblQuant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(48, 19);
            this.lblQuant.TabIndex = 31;
            this.lblQuant.Text = "Quant";
            // 
            // txtQuant
            // 
            this.txtQuant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.Location = new System.Drawing.Point(1076, 65);
            this.txtQuant.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(133, 23);
            this.txtQuant.TabIndex = 35;
            this.txtQuant.TextChanged += new System.EventHandler(this.CalcularValorTotal);
            this.txtQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuant_KeyPress);
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorUnitario.Location = new System.Drawing.Point(1217, 33);
            this.lblValorUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(60, 19);
            this.lblValorUnitario.TabIndex = 32;
            this.lblValorUnitario.Text = "Unitario";
            // 
            // txtVUnit
            // 
            this.txtVUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVUnit.Location = new System.Drawing.Point(1217, 65);
            this.txtVUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtVUnit.Name = "txtVUnit";
            this.txtVUnit.Size = new System.Drawing.Size(83, 23);
            this.txtVUnit.TabIndex = 36;
            this.txtVUnit.TextChanged += new System.EventHandler(this.CalcularValorTotal);
            this.txtVUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVUnit_KeyPress);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1308, 33);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 19);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Total";
            // 
            // txtVTot
            // 
            this.txtVTot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVTot.Enabled = false;
            this.txtVTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVTot.Location = new System.Drawing.Point(1308, 65);
            this.txtVTot.Margin = new System.Windows.Forms.Padding(4);
            this.txtVTot.Name = "txtVTot";
            this.txtVTot.Size = new System.Drawing.Size(107, 23);
            this.txtVTot.TabIndex = 38;
            // 
            // tblBotoes
            // 
            this.tblBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblBotoes.BackColor = System.Drawing.Color.SteelBlue;
            this.tblBotoes.ColumnCount = 4;
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBotoes.Controls.Add(this.btnNovo, 0, 0);
            this.tblBotoes.Controls.Add(this.btnEditar, 1, 0);
            this.tblBotoes.Controls.Add(this.btnExcluir, 2, 0);
            this.tblBotoes.Controls.Add(this.btnVoltar, 3, 0);
            this.tblBotoes.Location = new System.Drawing.Point(3, 481);
            this.tblBotoes.Name = "tblBotoes";
            this.tblBotoes.RowCount = 1;
            this.tblBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBotoes.Size = new System.Drawing.Size(1421, 48);
            this.tblBotoes.TabIndex = 48;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(3, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(349, 42);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(358, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(349, 42);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(713, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(349, 42);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(1068, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(350, 42);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCodigoENomeCli
            // 
            this.lblCodigoENomeCli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoENomeCli.AutoSize = true;
            this.tblLayCabecalho.SetColumnSpan(this.lblCodigoENomeCli, 4);
            this.lblCodigoENomeCli.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoENomeCli.Location = new System.Drawing.Point(4, 0);
            this.lblCodigoENomeCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoENomeCli.Name = "lblCodigoENomeCli";
            this.lblCodigoENomeCli.Size = new System.Drawing.Size(468, 28);
            this.lblCodigoENomeCli.TabIndex = 2;
            this.lblCodigoENomeCli.Text = "Código   /   Nome do cliente";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCodCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCliente.Enabled = false;
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(4, 35);
            this.txtCodCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(111, 28);
            this.txtCodCliente.TabIndex = 3;
            this.txtCodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCliente_KeyPress);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tblLayCabecalho.SetColumnSpan(this.txtNomeCliente, 4);
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(123, 35);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(468, 28);
            this.txtNomeCliente.TabIndex = 4;
            this.txtNomeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TravarDigitacao);
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefone.AutoSize = true;
            this.tblLayCabecalho.SetColumnSpan(this.lblTelefone, 4);
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(4, 58);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(468, 27);
            this.lblTelefone.TabIndex = 7;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tblLayCabecalho.SetColumnSpan(this.txtTelefone, 5);
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(4, 89);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(587, 28);
            this.txtTelefone.TabIndex = 8;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TravarDigitacao);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tblLayCabecalho.SetColumnSpan(this.txtEmail, 4);
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(599, 89);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(548, 28);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TravarDigitacao);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.tblLayCabecalho.SetColumnSpan(this.lblEmail, 2);
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(599, 58);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(330, 27);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-mail";
            // 
            // txtDoc
            // 
            this.txtDoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDoc.Enabled = false;
            this.txtDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoc.Location = new System.Drawing.Point(1312, 4);
            this.txtDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(117, 28);
            this.txtDoc.TabIndex = 6;
            this.txtDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TravarDigitacao);
            // 
            // labelDocumento
            // 
            this.labelDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDocumento.AutoSize = true;
            this.tblLayCabecalho.SetColumnSpan(this.labelDocumento, 2);
            this.labelDocumento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocumento.Location = new System.Drawing.Point(1155, 0);
            this.labelDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDocumento.Name = "labelDocumento";
            this.labelDocumento.Size = new System.Drawing.Size(149, 28);
            this.labelDocumento.TabIndex = 5;
            this.labelDocumento.Text = "Documento:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndereco.AutoSize = true;
            this.tblLayCabecalho.SetColumnSpan(this.lblEndereco, 2);
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(599, 0);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(330, 28);
            this.lblEndereco.TabIndex = 15;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tblLayCabecalho.SetColumnSpan(this.txtEndereco, 7);
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(599, 35);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(830, 28);
            this.txtEndereco.TabIndex = 16;
            this.txtEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TravarDigitacao);
            // 
            // lblTotalDocumento
            // 
            this.lblTotalDocumento.AutoSize = true;
            this.lblTotalDocumento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDocumento.Location = new System.Drawing.Point(1154, 58);
            this.lblTotalDocumento.Name = "lblTotalDocumento";
            this.lblTotalDocumento.Size = new System.Drawing.Size(60, 27);
            this.lblTotalDocumento.TabIndex = 49;
            this.lblTotalDocumento.Text = "Total:";
            // 
            // txtTotalDocumento
            // 
            this.txtTotalDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayCabecalho.SetColumnSpan(this.txtTotalDocumento, 3);
            this.txtTotalDocumento.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDocumento.Location = new System.Drawing.Point(1154, 88);
            this.txtTotalDocumento.Name = "txtTotalDocumento";
            this.txtTotalDocumento.Size = new System.Drawing.Size(276, 31);
            this.txtTotalDocumento.TabIndex = 50;
            this.txtTotalDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TravarDigitacao);
            // 
            // colItensProd
            // 
            this.colItensProd.DataPropertyName = "prod";
            this.colItensProd.HeaderText = "prod";
            this.colItensProd.Name = "colItensProd";
            this.colItensProd.ReadOnly = true;
            this.colItensProd.Visible = false;
            // 
            // colGridItensSeguro
            // 
            this.colGridItensSeguro.DataPropertyName = "seguro";
            this.colGridItensSeguro.HeaderText = "Seguro";
            this.colGridItensSeguro.Name = "colGridItensSeguro";
            this.colGridItensSeguro.ReadOnly = true;
            this.colGridItensSeguro.Visible = false;
            // 
            // pis
            // 
            this.pis.DataPropertyName = "pis";
            this.pis.HeaderText = "pis";
            this.pis.Name = "pis";
            this.pis.ReadOnly = true;
            this.pis.Visible = false;
            // 
            // cofins
            // 
            this.cofins.DataPropertyName = "cofins";
            this.cofins.HeaderText = "cofins";
            this.cofins.Name = "cofins";
            this.cofins.ReadOnly = true;
            this.cofins.Visible = false;
            // 
            // ipi
            // 
            this.ipi.DataPropertyName = "ipi";
            this.ipi.HeaderText = "ipi";
            this.ipi.Name = "ipi";
            this.ipi.ReadOnly = true;
            this.ipi.Visible = false;
            // 
            // icms
            // 
            this.icms.DataPropertyName = "icms";
            this.icms.HeaderText = "Icms";
            this.icms.Name = "icms";
            this.icms.ReadOnly = true;
            this.icms.Visible = false;
            // 
            // colItensID
            // 
            this.colItensID.DataPropertyName = "ID";
            this.colItensID.HeaderText = "ID";
            this.colItensID.Name = "colItensID";
            this.colItensID.ReadOnly = true;
            this.colItensID.Visible = false;
            // 
            // colItensProdutoCod
            // 
            this.colItensProdutoCod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItensProdutoCod.DataPropertyName = "Produto";
            this.colItensProdutoCod.FillWeight = 5F;
            this.colItensProdutoCod.HeaderText = "Codigo";
            this.colItensProdutoCod.Name = "colItensProdutoCod";
            this.colItensProdutoCod.ReadOnly = true;
            // 
            // colItensXProd
            // 
            this.colItensXProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItensXProd.DataPropertyName = "xProd";
            this.colItensXProd.FillWeight = 35F;
            this.colItensXProd.HeaderText = "Nome do Produto";
            this.colItensXProd.Name = "colItensXProd";
            this.colItensXProd.ReadOnly = true;
            // 
            // colItensNCM
            // 
            this.colItensNCM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItensNCM.DataPropertyName = "NCM";
            this.colItensNCM.FillWeight = 5F;
            this.colItensNCM.HeaderText = "NCM";
            this.colItensNCM.Name = "colItensNCM";
            this.colItensNCM.ReadOnly = true;
            // 
            // colItensCSOSN
            // 
            this.colItensCSOSN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItensCSOSN.DataPropertyName = "CSOSN";
            this.colItensCSOSN.FillWeight = 5F;
            this.colItensCSOSN.HeaderText = "CSOSN";
            this.colItensCSOSN.Name = "colItensCSOSN";
            this.colItensCSOSN.ReadOnly = true;
            // 
            // colItensCFOP
            // 
            this.colItensCFOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItensCFOP.DataPropertyName = "CFOP";
            this.colItensCFOP.FillWeight = 5F;
            this.colItensCFOP.HeaderText = "CFOP";
            this.colItensCFOP.Name = "colItensCFOP";
            this.colItensCFOP.ReadOnly = true;
            // 
            // colItensUnidadeTipo
            // 
            this.colItensUnidadeTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItensUnidadeTipo.DataPropertyName = "UnidadeTipo";
            this.colItensUnidadeTipo.FillWeight = 5F;
            this.colItensUnidadeTipo.HeaderText = "Unidade";
            this.colItensUnidadeTipo.Name = "colItensUnidadeTipo";
            this.colItensUnidadeTipo.ReadOnly = true;
            // 
            // colItensQuantidade
            // 
            this.colItensQuantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItensQuantidade.DataPropertyName = "Quantidade";
            this.colItensQuantidade.FillWeight = 10F;
            this.colItensQuantidade.HeaderText = "Quantidade";
            this.colItensQuantidade.Name = "colItensQuantidade";
            this.colItensQuantidade.ReadOnly = true;
            // 
            // colItensUnitario
            // 
            this.colItensUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItensUnitario.DataPropertyName = "Unitario";
            this.colItensUnitario.FillWeight = 10F;
            this.colItensUnitario.HeaderText = "Unitario";
            this.colItensUnitario.Name = "colItensUnitario";
            this.colItensUnitario.ReadOnly = true;
            // 
            // colItensDesconto
            // 
            this.colItensDesconto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItensDesconto.DataPropertyName = "Desconto";
            this.colItensDesconto.FillWeight = 10F;
            this.colItensDesconto.HeaderText = "Desc";
            this.colItensDesconto.Name = "colItensDesconto";
            this.colItensDesconto.ReadOnly = true;
            // 
            // colItensTotal
            // 
            this.colItensTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItensTotal.DataPropertyName = "Total";
            this.colItensTotal.FillWeight = 10F;
            this.colItensTotal.HeaderText = "Total";
            this.colItensTotal.Name = "colItensTotal";
            this.colItensTotal.ReadOnly = true;
            // 
            // colItensAleatorio
            // 
            this.colItensAleatorio.DataPropertyName = "Aleatorio";
            this.colItensAleatorio.HeaderText = "Aleatorio";
            this.colItensAleatorio.Name = "colItensAleatorio";
            this.colItensAleatorio.ReadOnly = true;
            this.colItensAleatorio.Visible = false;
            // 
            // colItensProdutoGuidID
            // 
            this.colItensProdutoGuidID.DataPropertyName = "ProdutoGuidID";
            this.colItensProdutoGuidID.HeaderText = "ProdutoGuidID";
            this.colItensProdutoGuidID.Name = "colItensProdutoGuidID";
            this.colItensProdutoGuidID.ReadOnly = true;
            this.colItensProdutoGuidID.Visible = false;
            // 
            // colItensnfeGuidId
            // 
            this.colItensnfeGuidId.DataPropertyName = "nfeGuidId";
            this.colItensnfeGuidId.HeaderText = "nfeGuidId";
            this.colItensnfeGuidId.Name = "colItensnfeGuidId";
            this.colItensnfeGuidId.ReadOnly = true;
            this.colItensnfeGuidId.Visible = false;
            // 
            // CodigoBarras
            // 
            this.CodigoBarras.DataPropertyName = "CodigoBarras";
            this.CodigoBarras.HeaderText = "CodigoBarras";
            this.CodigoBarras.Name = "CodigoBarras";
            this.CodigoBarras.ReadOnly = true;
            this.CodigoBarras.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // ProdutoEnt
            // 
            this.ProdutoEnt.DataPropertyName = "ProdutoEnt";
            this.ProdutoEnt.HeaderText = "ProdutoEnt";
            this.ProdutoEnt.Name = "ProdutoEnt";
            this.ProdutoEnt.ReadOnly = true;
            this.ProdutoEnt.Visible = false;
            // 
            // convEmbalagem
            // 
            this.convEmbalagem.DataPropertyName = "convEmbalagem";
            this.convEmbalagem.HeaderText = "convEmbalagem";
            this.convEmbalagem.Name = "convEmbalagem";
            this.convEmbalagem.ReadOnly = true;
            this.convEmbalagem.Visible = false;
            // 
            // BICMS
            // 
            this.BICMS.DataPropertyName = "BICMS";
            this.BICMS.HeaderText = "BICMS";
            this.BICMS.Name = "BICMS";
            this.BICMS.ReadOnly = true;
            this.BICMS.Visible = false;
            // 
            // VLICMS
            // 
            this.VLICMS.DataPropertyName = "VLICMS";
            this.VLICMS.HeaderText = "VLICMS";
            this.VLICMS.Name = "VLICMS";
            this.VLICMS.ReadOnly = true;
            this.VLICMS.Visible = false;
            // 
            // VLICMSST
            // 
            this.VLICMSST.DataPropertyName = "VLICMSST";
            this.VLICMSST.HeaderText = "VLICMSST";
            this.VLICMSST.Name = "VLICMSST";
            this.VLICMSST.ReadOnly = true;
            this.VLICMSST.Visible = false;
            // 
            // VLIPI
            // 
            this.VLIPI.DataPropertyName = "VLIPI";
            this.VLIPI.HeaderText = "VLIPI";
            this.VLIPI.Name = "VLIPI";
            this.VLIPI.ReadOnly = true;
            this.VLIPI.Visible = false;
            // 
            // colGridItensOrigCST
            // 
            this.colGridItensOrigCST.DataPropertyName = "OrigCST";
            this.colGridItensOrigCST.HeaderText = "OrigCST";
            this.colGridItensOrigCST.Name = "colGridItensOrigCST";
            this.colGridItensOrigCST.ReadOnly = true;
            this.colGridItensOrigCST.Visible = false;
            // 
            // AliqICMS
            // 
            this.AliqICMS.DataPropertyName = "AliqICMS";
            this.AliqICMS.HeaderText = "AliqICMS";
            this.AliqICMS.Name = "AliqICMS";
            this.AliqICMS.ReadOnly = true;
            this.AliqICMS.Visible = false;
            // 
            // AliqIPI
            // 
            this.AliqIPI.DataPropertyName = "AliqIPI";
            this.AliqIPI.HeaderText = "AliqIPI";
            this.AliqIPI.Name = "AliqIPI";
            this.AliqIPI.ReadOnly = true;
            this.AliqIPI.Visible = false;
            // 
            // ValorVenda
            // 
            this.ValorVenda.DataPropertyName = "ValorVenda";
            this.ValorVenda.HeaderText = "ValorVenda";
            this.ValorVenda.Name = "ValorVenda";
            this.ValorVenda.ReadOnly = true;
            this.ValorVenda.Visible = false;
            // 
            // Ref
            // 
            this.Ref.DataPropertyName = "Ref";
            this.Ref.HeaderText = "Ref";
            this.Ref.Name = "Ref";
            this.Ref.ReadOnly = true;
            this.Ref.Visible = false;
            // 
            // colGridItensUsarCST
            // 
            this.colGridItensUsarCST.DataPropertyName = "UsarCST";
            this.colGridItensUsarCST.HeaderText = "UsarCST";
            this.colGridItensUsarCST.Name = "colGridItensUsarCST";
            this.colGridItensUsarCST.ReadOnly = true;
            this.colGridItensUsarCST.Visible = false;
            // 
            // colGridItensValorVendaLiq
            // 
            this.colGridItensValorVendaLiq.DataPropertyName = "ValorVendaLiq";
            this.colGridItensValorVendaLiq.HeaderText = "ValorVendaLiq";
            this.colGridItensValorVendaLiq.Name = "colGridItensValorVendaLiq";
            this.colGridItensValorVendaLiq.ReadOnly = true;
            this.colGridItensValorVendaLiq.Visible = false;
            // 
            // colGridItensCST
            // 
            this.colGridItensCST.DataPropertyName = "CST";
            this.colGridItensCST.HeaderText = "CST";
            this.colGridItensCST.Name = "colGridItensCST";
            this.colGridItensCST.ReadOnly = true;
            this.colGridItensCST.Visible = false;
            // 
            // colGridItensFrete
            // 
            this.colGridItensFrete.DataPropertyName = "frete";
            this.colGridItensFrete.HeaderText = "Frete";
            this.colGridItensFrete.Name = "colGridItensFrete";
            this.colGridItensFrete.ReadOnly = true;
            this.colGridItensFrete.Visible = false;
            // 
            // colGridItensIdLancamentoProduto
            // 
            this.colGridItensIdLancamentoProduto.DataPropertyName = "IdLancamentoProduto";
            this.colGridItensIdLancamentoProduto.HeaderText = "IdLancamentoProduto";
            this.colGridItensIdLancamentoProduto.Name = "colGridItensIdLancamentoProduto";
            this.colGridItensIdLancamentoProduto.ReadOnly = true;
            this.colGridItensIdLancamentoProduto.Visible = false;
            // 
            // colNFGridTentativaNCM
            // 
            this.colNFGridTentativaNCM.DataPropertyName = "TentativaNCM";
            this.colNFGridTentativaNCM.HeaderText = "TentativaNCM";
            this.colNFGridTentativaNCM.Name = "colNFGridTentativaNCM";
            this.colNFGridTentativaNCM.ReadOnly = true;
            this.colNFGridTentativaNCM.Visible = false;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageVisualizacao);
            this.tabControl.Controls.Add(this.tabPageLancamento);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1448, 697);
            this.tabControl.TabIndex = 5;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageVisualizacao
            // 
            this.tabPageVisualizacao.Controls.Add(this.tblVisualizacaoVendas);
            this.tabPageVisualizacao.Location = new System.Drawing.Point(4, 25);
            this.tabPageVisualizacao.Name = "tabPageVisualizacao";
            this.tabPageVisualizacao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVisualizacao.Size = new System.Drawing.Size(1440, 668);
            this.tabPageVisualizacao.TabIndex = 0;
            this.tabPageVisualizacao.Text = "F1 - Visualização";
            this.tabPageVisualizacao.UseVisualStyleBackColor = true;
            // 
            // tblVisualizacaoVendas
            // 
            this.tblVisualizacaoVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblVisualizacaoVendas.ColumnCount = 2;
            this.tblVisualizacaoVendas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblVisualizacaoVendas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblVisualizacaoVendas.Controls.Add(this.lblVisualizacaoVendas, 0, 0);
            this.tblVisualizacaoVendas.Controls.Add(this.dgvVendas, 0, 1);
            this.tblVisualizacaoVendas.Location = new System.Drawing.Point(14, 16);
            this.tblVisualizacaoVendas.Name = "tblVisualizacaoVendas";
            this.tblVisualizacaoVendas.RowCount = 2;
            this.tblVisualizacaoVendas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.680251F));
            this.tblVisualizacaoVendas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.31975F));
            this.tblVisualizacaoVendas.Size = new System.Drawing.Size(1411, 638);
            this.tblVisualizacaoVendas.TabIndex = 0;
            // 
            // lblVisualizacaoVendas
            // 
            this.lblVisualizacaoVendas.AutoSize = true;
            this.lblVisualizacaoVendas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizacaoVendas.Location = new System.Drawing.Point(3, 0);
            this.lblVisualizacaoVendas.Name = "lblVisualizacaoVendas";
            this.lblVisualizacaoVendas.Size = new System.Drawing.Size(160, 25);
            this.lblVisualizacaoVendas.TabIndex = 0;
            this.lblVisualizacaoVendas.Text = "Visualizar Vendas";
            this.lblVisualizacaoVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dgvVendas
            // 
            this.dgvVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvVendasColClienteId,
            this.dgvVendasColClienteCodigoCliente,
            this.dgvVendasColCliente,
            this.dgvVendasColClienteDataEmissao,
            this.dgvVendasColValor});
            this.tblVisualizacaoVendas.SetColumnSpan(this.dgvVendas, 2);
            this.dgvVendas.EnableHeadersVisualStyles = false;
            this.dgvVendas.Location = new System.Drawing.Point(3, 52);
            this.dgvVendas.MultiSelect = false;
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.RowHeadersVisible = false;
            this.dgvVendas.RowTemplate.Height = 24;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.ShowCellErrors = false;
            this.dgvVendas.ShowCellToolTips = false;
            this.dgvVendas.ShowEditingIcon = false;
            this.dgvVendas.ShowRowErrors = false;
            this.dgvVendas.Size = new System.Drawing.Size(1405, 583);
            this.dgvVendas.TabIndex = 1;
            this.dgvVendas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendas_RowEnter);
            this.dgvVendas.DoubleClick += new System.EventHandler(this.dgvVendas_DoubleClick);
            // 
            // dgvVendasColClienteId
            // 
            this.dgvVendasColClienteId.DataPropertyName = "Id";
            this.dgvVendasColClienteId.HeaderText = "Id";
            this.dgvVendasColClienteId.Name = "dgvVendasColClienteId";
            this.dgvVendasColClienteId.Visible = false;
            // 
            // dgvVendasColClienteCodigoCliente
            // 
            this.dgvVendasColClienteCodigoCliente.DataPropertyName = "CodigoCliente";
            this.dgvVendasColClienteCodigoCliente.HeaderText = "CodigoCliente";
            this.dgvVendasColClienteCodigoCliente.Name = "dgvVendasColClienteCodigoCliente";
            this.dgvVendasColClienteCodigoCliente.Visible = false;
            // 
            // dgvVendasColCliente
            // 
            this.dgvVendasColCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvVendasColCliente.DataPropertyName = "Cliente";
            this.dgvVendasColCliente.HeaderText = "Cliente";
            this.dgvVendasColCliente.Name = "dgvVendasColCliente";
            // 
            // dgvVendasColClienteDataEmissao
            // 
            this.dgvVendasColClienteDataEmissao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvVendasColClienteDataEmissao.DataPropertyName = "DataEmissao";
            this.dgvVendasColClienteDataEmissao.HeaderText = "Data Emissão";
            this.dgvVendasColClienteDataEmissao.Name = "dgvVendasColClienteDataEmissao";
            // 
            // dgvVendasColValor
            // 
            this.dgvVendasColValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvVendasColValor.DataPropertyName = "Valor";
            this.dgvVendasColValor.HeaderText = "Valor";
            this.dgvVendasColValor.Name = "dgvVendasColValor";
            // 
            // tabPageLancamento
            // 
            this.tabPageLancamento.Controls.Add(this.tblLayCabecalho);
            this.tabPageLancamento.Location = new System.Drawing.Point(4, 25);
            this.tabPageLancamento.Name = "tabPageLancamento";
            this.tabPageLancamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLancamento.Size = new System.Drawing.Size(1440, 668);
            this.tabPageLancamento.TabIndex = 1;
            this.tabPageLancamento.Text = "F2 - Lançamento e visualização";
            this.tabPageLancamento.UseVisualStyleBackColor = true;
            // 
            // colDgvProdutosLancamentoId
            // 
            this.colDgvProdutosLancamentoId.DataPropertyName = "Id";
            this.colDgvProdutosLancamentoId.HeaderText = "Id";
            this.colDgvProdutosLancamentoId.Name = "colDgvProdutosLancamentoId";
            this.colDgvProdutosLancamentoId.Visible = false;
            // 
            // colDgvProdutosLancamento
            // 
            this.colDgvProdutosLancamento.DataPropertyName = "CodigoVenda";
            this.colDgvProdutosLancamento.HeaderText = "CodigoVenda";
            this.colDgvProdutosLancamento.Name = "colDgvProdutosLancamento";
            this.colDgvProdutosLancamento.Visible = false;
            // 
            // dgvProdutosLancamentoColCodigo
            // 
            this.dgvProdutosLancamentoColCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProdutosLancamentoColCodigo.DataPropertyName = "CodigoProduto";
            this.dgvProdutosLancamentoColCodigo.HeaderText = "Codigo do Produto";
            this.dgvProdutosLancamentoColCodigo.Name = "dgvProdutosLancamentoColCodigo";
            // 
            // dgvProdutosLancamentoColNomeProduto
            // 
            this.dgvProdutosLancamentoColNomeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProdutosLancamentoColNomeProduto.DataPropertyName = "NomeProduto";
            this.dgvProdutosLancamentoColNomeProduto.HeaderText = "Nome do Produto";
            this.dgvProdutosLancamentoColNomeProduto.Name = "dgvProdutosLancamentoColNomeProduto";
            // 
            // colDgvProdutosLancamentoQuantidade
            // 
            this.colDgvProdutosLancamentoQuantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDgvProdutosLancamentoQuantidade.DataPropertyName = "Quantidade";
            this.colDgvProdutosLancamentoQuantidade.HeaderText = "Quantidade";
            this.colDgvProdutosLancamentoQuantidade.Name = "colDgvProdutosLancamentoQuantidade";
            // 
            // colDgvProdutosLancamentoUnitario
            // 
            this.colDgvProdutosLancamentoUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDgvProdutosLancamentoUnitario.DataPropertyName = "ValorUnitario";
            this.colDgvProdutosLancamentoUnitario.HeaderText = "Unitario";
            this.colDgvProdutosLancamentoUnitario.Name = "colDgvProdutosLancamentoUnitario";
            // 
            // colDgvProdutosLancamentoTotal
            // 
            this.colDgvProdutosLancamentoTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDgvProdutosLancamentoTotal.DataPropertyName = "ValorTotal";
            this.colDgvProdutosLancamentoTotal.HeaderText = "Total";
            this.colDgvProdutosLancamentoTotal.Name = "colDgvProdutosLancamentoTotal";
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 716);
            this.Controls.Add(this.tabControl);
            this.KeyPreview = true;
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realize Vendas!";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            this.tblLayCabecalho.ResumeLayout(false);
            this.tblLayCabecalho.PerformLayout();
            this.tblLancamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosLancamento)).EndInit();
            this.tblLayProdutos.ResumeLayout(false);
            this.tblLayProdutos.PerformLayout();
            this.tblBotoes.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageVisualizacao.ResumeLayout(false);
            this.tblVisualizacaoVendas.ResumeLayout(false);
            this.tblVisualizacaoVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.tabPageLancamento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayCabecalho;
        private System.Windows.Forms.Label lblCodigoENomeCli;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label labelDocumento;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TableLayoutPanel tblLayProdutos;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.Label lblProdutosLancamento;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.TextBox txtVUnit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtVTot;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItensProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGridItensSeguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn pis;
        private System.Windows.Forms.DataGridViewTextBoxColumn cofins;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn icms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItensID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItensProdutoCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItensXProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItensNCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItensCSOSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItensCFOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItensUnidadeTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItensQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItensUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItensDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItensTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItensAleatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItensProdutoGuidID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItensnfeGuidId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoEnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn convEmbalagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn BICMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn VLICMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn VLICMSST;
        private System.Windows.Forms.DataGridViewTextBoxColumn VLIPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGridItensOrigCST;
        private System.Windows.Forms.DataGridViewTextBoxColumn AliqICMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn AliqIPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGridItensUsarCST;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGridItensValorVendaLiq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGridItensCST;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGridItensFrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGridItensIdLancamentoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNFGridTentativaNCM;
        private System.Windows.Forms.DataGridView dgvProdutosLancamento;
        private System.Windows.Forms.TableLayoutPanel tblLancamento;
        private System.Windows.Forms.TableLayoutPanel tblBotoes;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTotalDocumento;
        private System.Windows.Forms.TextBox txtTotalDocumento;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageVisualizacao;
        private System.Windows.Forms.TabPage tabPageLancamento;
        private System.Windows.Forms.TableLayoutPanel tblVisualizacaoVendas;
        private System.Windows.Forms.Label lblVisualizacaoVendas;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVendasColClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVendasColClienteCodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVendasColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVendasColClienteDataEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVendasColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDgvProdutosLancamentoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDgvProdutosLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProdutosLancamentoColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProdutosLancamentoColNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDgvProdutosLancamentoQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDgvProdutosLancamentoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDgvProdutosLancamentoTotal;
    }
}