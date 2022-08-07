using ListMEAPI.Interfaces.Repositorios;
using ListMEAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        //LEITURA DO BANCO DE DADOS
        private readonly ListMEContext _context;

        public UsuarioRepository(ListMEContext ctx)
        {
            //INSERÇÃO NO BANCO DE DADOS
            _context = ctx;
        }

        public void Create(UsuarioModel usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
        }

        public List<UsuarioModel> GetAll()
        {
            return _context.Usuarios.Include(i => i.Residencias).ToList();
        }

    }
}
