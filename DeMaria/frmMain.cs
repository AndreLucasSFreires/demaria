using System;
using System.Windows.Forms;
using DeMaria.Formularios.Clientes;
using Infraestrutura.Repositorios;

namespace DeMaria
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFormularioClientes_Click(object sender, EventArgs e)
        {
            var repositorio = new ClienteRepository();
            var clienteService = new Aplicacao.Servicos.ClienteService(repositorio);
            var frmClientes = new frmCadastroCliente(clienteService);
            frmClientes.Show();
        }
    }
}
