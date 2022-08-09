using ListMEAPI.Interfaces.Repositorios.Estoque;
using ListMEAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.Repositories
{
    public class EstoqueRepository : IEstoqueRepository
    {
        //LEITURA DO BANCO DE DADOS
        private readonly ListMEContext _context;

        public EstoqueRepository(ListMEContext ctx)
        {
            //INSERÇÃO NO BANCO DE DADOS
            _context = ctx;
        }
        public void Create(EstoqueModel estoque)
        {
            _context.Add(estoque);
            _context.SaveChanges();
        }

        public bool Delete(int Id)
        {
            var result = _context.Estoques.Find(Id);
            if(result != null)
            {
                _context.Estoques.Remove(result);
                _context.SaveChanges();
                return true;
            }
            {
                return false;
            }
        }

        public List<EstoqueModel> GetAll()
        {
            return _context.Estoques.Include(i=>i.Produtos).ToList();
        }

        public EstoqueModel PutOnEstoque(int IdProduto, int IdEstoque)
        {
            var searchEstoque = _context.Estoques.Find(IdEstoque);
            var searchProduto = _context.Produtos.Find(IdProduto);
            if(searchEstoque != null && searchProduto != null)
            {
                searchEstoque.AdicionarProdutoNaLista(searchProduto);
                _context.SaveChanges();
                return (searchEstoque);
            }
            else
            {
                return null;
            }
        }
    }
}
