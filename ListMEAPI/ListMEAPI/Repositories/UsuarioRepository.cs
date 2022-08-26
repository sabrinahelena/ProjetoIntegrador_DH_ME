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
        public void Delete(UsuarioModel usuario)
        {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
                
        }

        //GET ALL
        public List<UsuarioModel> GetAll()
        {
            return _context.Usuarios.Include(i => i.Residencias).ToList();
        }
        
        //GET por Id
        public UsuarioModel GetOne(int id)
        {
            //var requerimento = _context.Usuarios.Find(id);
            var result = _context.Usuarios.Include(i => i.Residencias).Where(i => i.Id_Usuario == id).FirstOrDefault();
            return result;
        }
        //PUT
        public UsuarioModel Update(UsuarioModel usuario, AtualizacaoUsuarioRequest usuarioAtualizado)
        {   
                usuario.Nome_Usuario = usuarioAtualizado.Nome_Usuario;
                usuario.Sobrenome = usuarioAtualizado.Sobrenome;
                usuario.Telefone = usuarioAtualizado.Telefone;
                usuario.Foto_Perfil = usuarioAtualizado.Foto_Perfil;
                usuario.Data_Nascimento = usuarioAtualizado.Data_Nascimento;
                usuario.Email = usuarioAtualizado.Email;
                usuario.Senha = usuarioAtualizado.Senha;
                _context.SaveChanges();
                return usuario;
        }
    }
}


