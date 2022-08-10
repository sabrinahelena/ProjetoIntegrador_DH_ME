using ListMEAPI.DTOs.Request.Produtos;
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
            if (result != null)
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
            return _context.Estoques.Include(i => i.Produtos).ToList();
        }

        public EstoqueModel PatchEstoque(AlterarQuantidadeEDataRequest produtos, int IdProduto, int IdEstoque)
        {
            var estoque = _context.Estoques.Find(IdEstoque);
            var produtoDb = _context.Produtos.Find(IdProduto);
            var estoqueProdutoVerify = _context.Estoques.Find(IdEstoque).Produtos.Contains(produtoDb);
            if (produtoDb != null && estoque != null && estoqueProdutoVerify == true)
            {
         
                var adiciona = estoque.AdicionarQuantidadeEData(produtos,produtoDb);
                if (adiciona)
                {
                    _context.SaveChanges();
                    return estoque;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public EstoqueModel PutOnEstoque(int IdProduto, int IdEstoque)
        {
            var searchEstoque = _context.Estoques.Find(IdEstoque);
            var searchProduto = _context.Produtos.Find(IdProduto);
            if (searchEstoque != null && searchProduto != null && searchEstoque.Produtos.Contains(searchProduto)==false)
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

        public EstoqueModel RemoveFromEstoque(int IdProduto, int IdEstoque)
        {
            var searchEstoque = _context.Estoques.Find(IdEstoque);
            var searchProduto = _context.Produtos.Find(IdProduto);
            if (searchEstoque != null && searchProduto != null)
            {
                searchEstoque.RemoverProdutoNaLista(searchProduto);
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
