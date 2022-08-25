using ListMEAPI.Interfaces.Repositorios.Usuario;
using ListMEAPI.Mapper;
using ListMEAPI.Services;
using Moq;
using Xunit;

namespace ListMEAPI.Tests.Services
{
    public class UsuarioServiceTest
    {
        private UsuarioService usarioService;

        public UsuarioServiceTest()
        {
            usarioService = new UsuarioService(new Mock<IUsuarioRepository>().Object);
        }

        [Fact]
        public void Cadastrar_SendingValidId()
        {
            Assert.True(true);
        }
    }
}
