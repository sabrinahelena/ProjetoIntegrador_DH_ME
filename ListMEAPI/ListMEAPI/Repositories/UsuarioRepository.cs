using ListMEAPI.DTOs.Request.Usuario;
using ListMEAPI.Interfaces.Repositorios.Usuario;
using ListMEAPI.Models;
using Microsoft.AspNetCore.Mvc;
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

        // POST
        public dynamic Create(UsuarioModel usuario)
        {
            var busca = _context.Usuarios.Any(a => a.Email == usuario.Email);
            if (busca == true) {

                return busca;

            }               
            
            _context.Add(usuario);
            _context.SaveChanges();

            return null;

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

        public UsuarioModel Update(int Id, AtualizacaoUsuarioRequest usuarioAtualizado)
        {
            UsuarioModel usuarioAntigo = _context.Usuarios.Find(Id);
            if (usuarioAntigo != null)
            {
                usuarioAntigo.Nome_Usuario = usuarioAtualizado.Nome_Usuario;
                usuarioAntigo.Sobrenome = usuarioAtualizado.Sobrenome;
                usuarioAntigo.Telefone = usuarioAtualizado.Telefone;
                usuarioAntigo.Foto_Perfil = usuarioAtualizado.Foto_Perfil;
                usuarioAntigo.Data_Nascimento = usuarioAtualizado.Data_Nascimento;
                usuarioAntigo.Email = usuarioAtualizado.Email;
                usuarioAntigo.Senha = usuarioAtualizado.Senha;
                _context.SaveChanges();
                return usuarioAntigo;
            }
            return usuarioAntigo;

        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}


