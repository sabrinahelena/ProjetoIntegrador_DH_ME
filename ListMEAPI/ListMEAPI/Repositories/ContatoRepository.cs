using ListMEAPI.DTOs.Request.Contato;
using ListMEAPI.Interfaces.Repositorios.Contato;
using ListMEAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.Repositories
{
    public class ContatoRepository :IContatoRepository
    {
        //LEITURA DO BANCO DE DADOS
        private readonly ListMEContext _context;

        public ContatoRepository(ListMEContext ctx)
        {
            //INSERÇÃO NO BANCO DE DADOS
            _context = ctx;
        }

        public void Create(ContatoModel contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
        }


        //DELETE
        public void Delete(int id)
        {
            var result = _context.Contatos.Find(id);
            _context.Contatos.Remove(result);
            _context.SaveChanges();

        }

        public List<ContatoModel> GetAll()
        {
            return _context.Contatos.ToList();

        }
        

        public ContatoModel GetOne(int id)
        {
            //var requerimento = _context.Usuarios.Find(id);
            var result = _context.Contatos.Find(id);
            return result;
        }   

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
