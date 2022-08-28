using ListMEAPI.Interfaces.Repositorios.Lista_de_compras;
using ListMEAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.Repositories
{
    public class ListaDeComprasRepository : IListaDeComprasRepository
    {
        //LEITURA DO BANCO DE DADOS
        private readonly ListMEContext _context;

        public ListaDeComprasRepository(ListMEContext ctx)
        {
            //INSERÇÃO NO BANCO DE DADOS
            _context = ctx;
        }

        //POST
        public void Create(EstoqueModel Cadastro, ResidenciaModel residencia)
        {
            residencia.AddListaCompras(Cadastro);
            _context.Add(Cadastro);
            _context.SaveChanges();
        }

        //GET ALL LISTAS DE COMPRAS DE UM USUÁRIO
        public List<EstoqueModel> GetListaDeCompras(int IdResidencia)
        {
            return _context.Estoques.Where(i => i.IdResidencia == IdResidencia && i.Id_Lista == IdResidencia)
                .Include(i => i.Produto).ToList();
        }
        
        //DELETE
        public void Delete(EstoqueModel lista)
        {
            _context.Estoques.Remove(lista);
            _context.SaveChanges();
        }

        //PATCH
        public bool Patch(EstoqueModel lista, int quantidade)
        {
            var boolean = lista.AdicionarQuantidadeLista(quantidade);
            _context.SaveChanges();
            return boolean;
        }

    }
}
