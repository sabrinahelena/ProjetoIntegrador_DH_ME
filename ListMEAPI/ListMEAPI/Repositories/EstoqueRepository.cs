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
        public void Create(EstoqueModel estoque, ResidenciaModel residencia)
        {
            residencia.AddEstoque(estoque);
           
            _context.Add(estoque);
            
            _context.SaveChanges();
        }

        public void CreateWhithLista(EstoqueModel estoque, ResidenciaModel residencia, EstoqueModel ListaCompras)
        {
            residencia.AddEstoque(estoque);
            residencia.AddListaCompras(ListaCompras);
            _context.Add(estoque);
            _context.Add(ListaCompras);
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
            return _context.Estoques.Include(i => i.Produto).ToList();
        }
        public List<EstoqueModel> GetByIdFromResidencia(int IdResidencia)
        {
            return _context.Estoques.Where(i => i.IdResidencia == IdResidencia && i.Id_Lista == 0).Include(i => i.Produto).ToList();
        }
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
