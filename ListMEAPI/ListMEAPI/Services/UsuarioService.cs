using ListMEAPI.DTOs.Request;
using ListMEAPI.DTOs.Response;
using ListMEAPI.Interfaces.Repositorios;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Mapper;
using ListMEAPI.Models;

namespace ListMEAPI.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        //put
        public void Atualizar(int id, UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        //POST

        public void Cadastrar(CadastroUsuarioRequest usuario)
        {
            var user = new UsuarioModel(usuario.Nome_Usuario, usuario.Sobrenome, usuario.Telefone, usuario.Data_Nascimento, usuario.Email, usuario.Foto_Perfil, usuario.Senha);

            _usuarioRepository.Create(user);
        }

        //DELETE
        public void Deletar(int id)
        {
            _usuarioRepository.Delete(id);
        }

        //GET POR ID
        public UsuarioModel ExibirUsuario(int id)
        {
           return _usuarioRepository.GetOne(id);
        }

        //GET
        public List<UsuarioResponse> Listar()
        {
            var list = _usuarioRepository.GetAll();

            return list.Select(c => UsuarioMapper.From(c)).ToList();
        }





    }
}
