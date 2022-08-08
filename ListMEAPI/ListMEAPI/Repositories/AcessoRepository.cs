using ListMEAPI.DTOs.Request.Login;
using ListMEAPI.Interfaces.Repositorios.Login;
using ListMEAPI.Models;

namespace ListMEAPI.Repositories
{
    public class AcessoRepository : IAcessoRepository
    {
        //LEITURA DO BANCO DE DADOS
        private readonly ListMEContext _context;

        public AcessoRepository(ListMEContext ctx)
        {
            //INSERÇÃO NO BANCO DE DADOS
            _context = ctx;
        }

        public void Create(AcessoModel acesso)
        {
            _context.Add(acesso);
            _context.SaveChanges();
        }

        //DELETE
        public void Delete(int id)
        {
            var result = _context.Acessos.Find(id);
            _context.Acessos.Remove(result);
            _context.SaveChanges();

        }

       

        public void Save()
        {
            _context.SaveChanges();
        }

        public AcessoModel Update(int id, CadastroAcessoRequest acessoNovo)
        {
            AcessoModel acessoAntigo = _context.Acessos.Find(id);
            if (acessoAntigo != null)
            {
                acessoAntigo.usuario = acessoNovo.usuario;
                acessoAntigo.senha = acessoAntigo.senha;

                _context.SaveChanges();
                return acessoAntigo;
            }
            return acessoAntigo;
        }

        List<AcessoModel> IAcessoRepository.GetAll()
        {
            return _context.Acessos.ToList();
        }

        AcessoModel IAcessoRepository.GetOne(int id)
        {
            //var requerimento = _context.Usuarios.Find(id);
            var result = _context.Acessos.FirstOrDefault();
            return result;
        }
    }
}

