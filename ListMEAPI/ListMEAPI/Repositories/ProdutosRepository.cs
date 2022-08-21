using ListMEAPI.DTOs.Request.Produtos;
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

        public bool DeleteProduto(ProdutosModel produto)
        {
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            return true;
        }

        public List<ProdutosModel> GetAll()
        {
            return _context.Produtos.ToList();
        }

        public ProdutosModel GetUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public ProdutosModel PutProduto(int IdProduto, CadastroProdutosRequest alteracoes)
        {
            var produtoAlterado = _context.Produtos.Find(IdProduto);
            if (produtoAlterado != null)
            {
                produtoAlterado.Preco = alteracoes.Preco;
                produtoAlterado.Descricao_Produtos = alteracoes.Descricao_Produtos;
                produtoAlterado.Nome_Produtos = alteracoes.Nome_Produtos;
                _context.SaveChanges();
                return produtoAlterado;
            }
            else{
                return null;
            }
        }
    }
}
