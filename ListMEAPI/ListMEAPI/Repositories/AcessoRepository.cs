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
            
            var usuario = _context.Usuarios.Where(Usuario => Usuario.Email == acesso.email && Usuario.Senha == acesso.senha).FirstOrDefault();
            if (usuario == null)
            {

            }
            else
            {
                var chaveToken = TokenService.GerarChaveToken();
                return new { token = chaveToken, user = usuario };
            }
        }  
    }
}

