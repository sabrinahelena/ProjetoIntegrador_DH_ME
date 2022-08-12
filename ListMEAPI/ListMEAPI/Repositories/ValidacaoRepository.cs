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
        public EstoqueModel FindEstoque(int IdEstoque)
        {
            return _context.Estoques.Find(IdEstoque);
        }

        public EstoqueModel FindEstoqueWithProduto(ProdutosModel produto)
        {
            return _context.Estoques.Where(i => i.Produto == produto).FirstOrDefault();
        }

    }
}
