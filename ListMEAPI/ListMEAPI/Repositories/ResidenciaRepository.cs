using ListMEAPI.Interfaces.Repositorios.Residencia;
using ListMEAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.Repositories
{
    public class ResidenciaRepository : IResidenciaRepository
    {
        //LEITURA DO BANCO DE DADOS
        private readonly ListMEContext _context;

        public ResidenciaRepository(ListMEContext ctx)
        {
            //INSERÇÃO NO BANCO DE DADOS
            _context = ctx;
        }

        public void Create(ResidenciaModel residencia, UsuarioModel usuario)
        {
            usuario.AdicionarResidencia(residencia);
            _context.Add(residencia);
            _context.SaveChanges();
        }

        public List<ResidenciaModel> GetAll()
        {
            
            return _context.Residencias.ToList();
        }

        public UsuarioModel GetUsuario(int Id)
        {
            var usuarioRequerido = _context.Usuarios.Find(Id);
            return usuarioRequerido;
        }
        public void Save()
        {
            _context.SaveChanges();

        }
        public ResidenciaModel GetOneResidencia(int Id)
        {
            return _context.Residencias.Find(Id);
        }

        public void Delete(ResidenciaModel residencia)
        {
            _context.Residencias.Remove(residencia);
            _context.SaveChanges();
        }
    }
}
