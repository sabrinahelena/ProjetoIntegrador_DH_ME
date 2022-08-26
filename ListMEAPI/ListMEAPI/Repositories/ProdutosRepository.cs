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
        
        //POST
        public void Create(ProdutosModel produto)
        {
            _context.Add(produto);
            _context.SaveChanges();
        }

        //GET ALL
        public List<ProdutosModel> GetAll()
        {
            return _context.Produtos.ToList();
        }

        //DELETE
        public void DeleteProduto(ProdutosModel produto)
        {
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }
        
        //PUT
        public void PutProduto(ProdutosModel produto, CadastroProdutosRequest alteracoes)
        {
                produto.Preco = alteracoes.Preco;
                produto.Descricao_Produtos = alteracoes.Descricao_Produtos;
                produto.Nome_Produtos = alteracoes.Nome_Produtos;
                _context.SaveChanges();
        }
    }
}
