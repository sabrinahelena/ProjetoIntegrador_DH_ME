using ListMEAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.Repositories
{
    public class ValidacaoRepository
    {
        //LEITURA DO BANCO DE DADOS
        private readonly ListMEContext _context;

        public ValidacaoRepository(ListMEContext ctx)
        {
            //INSERÇÃO NO BANCO DE DADOS
            _context = ctx;
        }
        public ProdutosModel FindProduto(int IdProduto)
        {
            var search = _context.Produtos.Find(IdProduto);
            return search;
        }
        public UsuarioModel FindUsuario(int IdUsuario)
        {
            return _context.Usuarios.Find(IdUsuario);
        }
        public ResidenciaModel FindResidencia(int IdResidencia)
        {
            return _context.Residencias.Find(IdResidencia);
        }
       
        public EstoqueModel FindListaDeCompras(int IdResidencia, int IdProduto)
        {
            return _context.Estoques.Where(i => i.Produto.Id_Produtos == IdProduto 
                 && i.IdResidencia == IdResidencia && i.Id_Lista == IdResidencia).FirstOrDefault();
        }
            public EstoqueModel FindEstoque(int IdEstoque)
        {
            return _context.Estoques.Find(IdEstoque);
        }

        public EstoqueModel FindEstoqueWithProduto(ProdutosModel produto,int IdResidencia)
        {
            return _context.Estoques.Where(i => i.Produto == produto && 
                 i.IdResidencia == IdResidencia && i.Id_Lista ==0 ).FirstOrDefault();
        }

    }
}
