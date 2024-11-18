namespace DeMaria
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFormularioClientes = new System.Windows.Forms.Button();
            this.btnFormularioProdutos = new System.Windows.Forms.Button();
            this.btnFormularioVendas = new System.Windows.Forms.Button();
            this.btnRelatorioVendas = new System.Windows.Forms.Button();
            this.btnRelatorioClientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormularioClientes
            // 
            this.btnFormularioClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormularioClientes.Location = new System.Drawing.Point(12, 12);
            this.btnFormularioClientes.Name = "btnFormularioClientes";
            this.btnFormularioClientes.Size = new System.Drawing.Size(126, 98);
            this.btnFormularioClientes.TabIndex = 0;
            this.btnFormularioClientes.Text = "Gerenciar &Clientes";
            this.btnFormularioClientes.UseVisualStyleBackColor = true;
            this.btnFormularioClientes.Click += new System.EventHandler(this.btnFormularioClientes_Click);
            // 
            // btnFormularioProdutos
            // 
            this.btnFormularioProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormularioProdutos.Location = new System.Drawing.Point(144, 9);
            this.btnFormularioProdutos.Name = "btnFormularioProdutos";
            this.btnFormularioProdutos.Size = new System.Drawing.Size(126, 101);
            this.btnFormularioProdutos.TabIndex = 1;
            this.btnFormularioProdutos.Text = "Gerenciar &Produtos";
            this.btnFormularioProdutos.UseVisualStyleBackColor = true;
            this.btnFormularioProdutos.Click += new System.EventHandler(this.btnFormularioProdutos_Click);
            // 
            // btnFormularioVendas
            // 
            this.btnFormularioVendas.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormularioVendas.Location = new System.Drawing.Point(12, 126);
            this.btnFormularioVendas.Name = "btnFormularioVendas";
            this.btnFormularioVendas.Size = new System.Drawing.Size(126, 98);
            this.btnFormularioVendas.TabIndex = 2;
            this.btnFormularioVendas.Text = "&Vendas";
            this.btnFormularioVendas.UseVisualStyleBackColor = true;
            this.btnFormularioVendas.Click += new System.EventHandler(this.btnFormularioVendas_Click);
            // 
            // btnRelatorioVendas
            // 
            this.btnRelatorioVendas.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioVendas.Location = new System.Drawing.Point(420, 18);
            this.btnRelatorioVendas.Name = "btnRelatorioVendas";
            this.btnRelatorioVendas.Size = new System.Drawing.Size(126, 98);
            this.btnRelatorioVendas.TabIndex = 3;
            this.btnRelatorioVendas.Text = "Relatório&s Vendas ";
            this.btnRelatorioVendas.UseVisualStyleBackColor = true;
            this.btnRelatorioVendas.Click += new System.EventHandler(this.btnFormularioRelatorios_Click);
            // 
            // btnRelatorioClientes
            // 
            this.btnRelatorioClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioClientes.Location = new System.Drawing.Point(552, 18);
            this.btnRelatorioClientes.Name = "btnRelatorioClientes";
            this.btnRelatorioClientes.Size = new System.Drawing.Size(126, 98);
            this.btnRelatorioClientes.TabIndex = 4;
            this.btnRelatorioClientes.Text = "Relatório C&lientes";
            this.btnRelatorioClientes.UseVisualStyleBackColor = true;
            this.btnRelatorioClientes.Click += new System.EventHandler(this.btnRelatorioClientes_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(420, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 98);
            this.button1.TabIndex = 5;
            this.button1.Text = "Relatório& Estoque";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRelatorioClientes);
            this.Controls.Add(this.btnRelatorioVendas);
            this.Controls.Add(this.btnFormularioVendas);
            this.Controls.Add(this.btnFormularioProdutos);
            this.Controls.Add(this.btnFormularioClientes);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeMaria - Win Dev C#";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormularioClientes;
        private System.Windows.Forms.Button btnFormularioProdutos;
        private System.Windows.Forms.Button btnFormularioVendas;
        private System.Windows.Forms.Button btnRelatorioVendas;
        private System.Windows.Forms.Button btnRelatorioClientes;
        private System.Windows.Forms.Button button1;
    }
}

