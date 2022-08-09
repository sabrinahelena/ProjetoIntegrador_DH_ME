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

        public void Create(ResidenciaModel residencia)
        {
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

        public ResidenciaModel GetOneResidencia(int Id)
        {
            var residenciaRequerida = _context.Residencias.Find(Id);
            return residenciaRequerida;
        }
        public void Save()
        {
            _context.SaveChanges();

        }
    }
}
