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

        

        //Manipulação da Lista De Compras
        public List<EstoqueModel> GetListaDeCompras(int IdResidencia)
        {
            return _context.Estoques.Where(i => i.IdResidencia == IdResidencia && i.Id_Lista == IdResidencia)
                .Include(i => i.Produto).ToList();
        }
        public void Create(EstoqueModel Cadastro, ResidenciaModel residencia)
        {
            residencia.AddListaCompras(Cadastro);
            _context.Add(Cadastro);
            _context.SaveChanges();
        }
        public bool Patch(EstoqueModel lista,int quantidade)
        {
            var boolean = lista.AdicionarQuantidadeLista(quantidade);
            _context.SaveChanges();
            return boolean;
        }

        public void Delete(EstoqueModel lista)
        {
            _context.Estoques.Remove(lista);
        }
    }
}
