using ListMEAPI.DTOs.Request.Login;
using ListMEAPI.DTOs.Response.Login;
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
            
            var usuario = _context.Usuarios.Where(Usuario => Usuario.Email == acesso.email && Usuario.Senha == acesso.senha).FirstOrDefault();
            
            if (usuario == null)
            {
                return null;
            }
            else
            {
                var chaveToken = TokenService.GerarChaveToken();
                var acessoResponse = new AcessoResponse(usuario.Email);
                return new { token = chaveToken, user = acessoResponse };
            }
        }  
    }
}

