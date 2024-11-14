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
            this.btnFormularioRelatorios = new System.Windows.Forms.Button();
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
            this.btnFormularioProdutos.Location = new System.Drawing.Point(12, 132);
            this.btnFormularioProdutos.Name = "btnFormularioProdutos";
            this.btnFormularioProdutos.Size = new System.Drawing.Size(126, 104);
            this.btnFormularioProdutos.TabIndex = 1;
            this.btnFormularioProdutos.Text = "Gerenciar &Produtos";
            this.btnFormularioProdutos.UseVisualStyleBackColor = true;
            this.btnFormularioProdutos.Click += new System.EventHandler(this.btnFormularioProdutos_Click);
            // 
            // btnFormularioVendas
            // 
            this.btnFormularioVendas.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormularioVendas.Location = new System.Drawing.Point(191, 12);
            this.btnFormularioVendas.Name = "btnFormularioVendas";
            this.btnFormularioVendas.Size = new System.Drawing.Size(126, 98);
            this.btnFormularioVendas.TabIndex = 2;
            this.btnFormularioVendas.Text = "&Vendas";
            this.btnFormularioVendas.UseVisualStyleBackColor = true;
            // 
            // btnFormularioRelatorios
            // 
            this.btnFormularioRelatorios.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormularioRelatorios.Location = new System.Drawing.Point(191, 138);
            this.btnFormularioRelatorios.Name = "btnFormularioRelatorios";
            this.btnFormularioRelatorios.Size = new System.Drawing.Size(126, 98);
            this.btnFormularioRelatorios.TabIndex = 3;
            this.btnFormularioRelatorios.Text = "&Relatórios";
            this.btnFormularioRelatorios.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 388);
            this.Controls.Add(this.btnFormularioRelatorios);
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
        private System.Windows.Forms.Button btnFormularioRelatorios;
    }
}

