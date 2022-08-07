using ListMEAPI.Interfaces.Repositorios;
using ListMEAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ListMEAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        //LEITURA DO BANCO DE DADOS
        private readonly ListMEContext _context;

        public UsuarioRepository(ListMEContext ctx)
        {
            //INSERÇÃO NO BANCO DE DADOS
            _context = ctx;
        }

        public void Create(UsuarioModel usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
        }


        public void AlterarUsuario(int id, UsuarioModel usuario)
        {
            var result = _context.Usuarios.Find(id);
            _context.Entry(usuario).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Update(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        //DELETE
        public void Delete(int id)
        {
            var result = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(result);
            _context.SaveChanges();

        }

        public List<UsuarioModel> GetAll()
        {
            return _context.Usuarios.Include(i => i.Residencias).ToList();
        }
        /*
         * 
         * PUXA USUÁRIO SEM RESIDENCIA
         */
        public UsuarioModel GetOne(int id)
        {
            //var requerimento = _context.Usuarios.Find(id);
            var result = _context.Usuarios.Include(i => i.Residencias).Where(i => i.Id_Usuario == id).FirstOrDefault();
            return result;
        }


    }
}

