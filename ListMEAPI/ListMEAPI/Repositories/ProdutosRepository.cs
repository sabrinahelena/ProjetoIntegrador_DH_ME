using ListMEAPI.Interfaces.Repositorios.Produtos;
using ListMEAPI.Models;

namespace ListMEAPI.Repositories
{
    public class ProdutosRepository : IProdutosRepository
    {
        private readonly ListMEContext _context;

        public ProdutosRepository(ListMEContext ctx)
        {
            //INSERÇÃO NO BANCO DE DADOS
            _context = ctx;
        }
        public void Create(ProdutosModel produto)
        {
            _context.Add(produto);
            _context.SaveChanges();
        }

        public List<ProdutosModel> GetAll()
        {
            return _context.Produtos.ToList();
        }

        public ProdutosModel GetUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
