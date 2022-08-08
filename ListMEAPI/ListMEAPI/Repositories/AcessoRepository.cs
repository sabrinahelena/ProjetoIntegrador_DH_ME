using ListMEAPI.DTOs.Request.Login;
using ListMEAPI.Interfaces.Repositorios.Login;
using ListMEAPI.Models;
using ListMEAPI.Services;

namespace ListMEAPI.Repositories
{
    public class AcessoRepository : IAcessoRepository
    {
        //LEITURA DO BANCO DE DADOS
        private readonly ListMEContext _context;

        public AcessoRepository(ListMEContext ctx)
        {
            //INSERÇÃO NO BANCO DE DADOS
            _context = ctx;
        }
        public dynamic Create(AcessoModel acesso)
        {
            var usuario = _context.Usuarios.Where(Usuario => Usuario.Nome_Usuario == acesso.usuario && Usuario.Senha == acesso.senha).FirstOrDefault();
            var chaveToken = TokenService.GerarChaveToken();
            var usuarioEx = _context.Usuarios.Where(Usuario => Usuario.Nome_Usuario == acesso.usuario && Usuario.Senha == acesso.senha).FirstOrDefault();
            usuarioEx.Senha = "";
            return new { token = chaveToken, user = usuarioEx };
        }  
    }
}

