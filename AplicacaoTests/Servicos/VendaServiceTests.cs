using Aplicacao.Servicos;
using Dominio.Entidades;
using Entidades.Interfaces;
using Moq;
using Moq.AutoMock;
using Xunit;

namespace AplicacaoTests.Servicos
{
    public class VendaServiceTests
    {
        [Fact]
        public void InserirClienteDeveRetornarSucesso()
        {
            //Arrange
            var mocker = new AutoMocker();
            var vendaService = mocker.CreateInstance<VendaService>();
            var vendaDto = DadosBogus.GerarVendaDtoValido();
            //Act
            vendaService.InserirVenda(vendaDto);
            //Assert
            mocker.GetMock<IVendaRepository>()
            .Verify(repo => repo.Inserir(It.Is<Venda>(venda =>
            venda.Cliente.Id == vendaDto.Cliente.Id &&
            venda.Cliente.Email == vendaDto.Cliente.Email &&
            venda.Cliente.Endereco == vendaDto.Cliente.Endereco &&
            venda.Cliente.Nome == vendaDto.Cliente.Nome &&
            venda.Cliente.Telefone == vendaDto.Cliente.Telefone &&
            venda.DataEmissao == vendaDto.DataEmissao &&
            venda.Valor == vendaDto.Valor)),Times.Once);
        }
    }
}
