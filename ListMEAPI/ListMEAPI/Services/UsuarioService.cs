using ListMEAPI.DTOs.Request.Usuario;
using ListMEAPI.DTOs.Response.Usuario;
using ListMEAPI.Interfaces.Repositorios.Usuario;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Mapper;
using ListMEAPI.Models;
using ListMEAPI.Repositories;

namespace ListMEAPI.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _usuarioRepository;
        private ValidacaoRepository _validacaoRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository, ValidacaoRepository validacao)
        {
            _usuarioRepository = usuarioRepository;
            _validacaoRepository = validacao;
        }

        //POST
        public dynamic Cadastrar(CadastroUsuarioRequest usuario)
        {
            var user = new UsuarioModel(usuario.Nome_Usuario, usuario.Sobrenome, usuario.Telefone, usuario.Data_Nascimento, usuario.Email, usuario.Foto_Perfil, usuario.Senha);

            return _usuarioRepository.Create(user);
        }

        //GET
        public List<UsuarioResponse> Listar()
        {
            var list = _usuarioRepository.GetAll();

            return list.Select(c => UsuarioMapper.From(c)).ToList();
        }

        //GET POR ID
        public UsuarioResponse ExibirUsuario(int id)
        {
            var response = _usuarioRepository.GetOne(id);

            return UsuarioMapper.From(response);
        }

        //DELETE
        public bool Deletar(int id)
        {
            var searchUsuario = _validacaoRepository.FindUsuario(id);
            if(searchUsuario == null)
            {
                return false;
            }
            else
            {
                _usuarioRepository.Delete(searchUsuario);
                 return true;
            }    
        }

        //PUT
        UsuarioModel IUsuarioService.Atualizar(int Id, AtualizacaoUsuarioRequest usuarioAtualizado)
        {
            var searchUsuario = _validacaoRepository.FindUsuario(Id);
            if (searchUsuario == null)
            {
                return null;
            }
            else
            {
                return _usuarioRepository.Update(searchUsuario, usuarioAtualizado);
            }
        }
    }
}
