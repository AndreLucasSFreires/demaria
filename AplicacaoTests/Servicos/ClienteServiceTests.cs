using Aplicacao.Servicos;
using Dominio.Entidades;
using Dominio.Entidades.Interfaces;
using Moq;
using Xunit;

namespace AplicacaoTests.Servicos
{
    public class ClienteServiceTests
    {
        Mock<IClienteRepository> clienteRepositorio = new Mock<IClienteRepository>();
        [Fact]
        public void ClienteInserirDeveExecutarComSucesso()
        {
            Setup();
            //Arrange
            var clienteDto = DadosBogus.GerarClienteDtoValido();
            var clienteService = new ClienteService(clienteRepositorio.Object);

            //Act
            var ok = clienteService.InserirCliente(clienteDto);

            //Assert
            Assert.True(ok);
        }

        private void Setup()
        {
            clienteRepositorio.Setup(x => x.Inserir(It.IsAny<Cliente>())).Returns(true);
        }
    }
}
