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

        //POST
        public void Create(EstoqueModel estoque, ResidenciaModel residencia)
        {
            residencia.AddEstoque(estoque);
           
            _context.Add(estoque);
            
            _context.SaveChanges();
        }

        //POST DE ESTOQUE E DA LISTA DE COMPRAS
        public void CreateWhithLista(EstoqueModel estoque, ResidenciaModel residencia, EstoqueModel ListaCompras)
        {
            residencia.AddEstoque(estoque);
            residencia.AddListaCompras(ListaCompras);
            _context.Add(estoque);
            _context.Add(ListaCompras);
            _context.SaveChanges();
        }

        //GET ALL
        public List<EstoqueModel> GetAll()
        {
            return _context.Estoques.Include(i => i.Produto).ToList();
        }

        //GET POR ID DE RESIDENCIA
        public List<EstoqueModel> GetByIdFromResidencia(int IdResidencia)
        {
            return _context.Estoques.Where(i => i.IdResidencia == IdResidencia && i.Id_Lista == 0).Include(i => i.Produto).ToList();
        }

        //DELETE
        public void Delete(EstoqueModel estoque)
        {
                _context.Estoques.Remove(estoque);
                _context.SaveChanges();
        }

        //PATCH
        public EstoqueModel PatchEstoque(AlterarQuantidadeEDataRequest alteracoes, ProdutosModel Produto, EstoqueModel Estoque)
        {
            var adiciona = Estoque.AdicionarQuantidadeEData(alteracoes, Produto);
            if (adiciona)
            {
                _context.SaveChanges();
                return Estoque;
            }
            else
            {
                return null;
            }
        }
    }
}
