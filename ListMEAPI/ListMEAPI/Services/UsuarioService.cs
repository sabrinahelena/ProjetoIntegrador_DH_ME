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

        public void Cadastrar(CadastroUsuarioRequest usuario)
        {
            var user = new UsuarioModel(usuario.Nome_Usuario, usuario.Sobrenome, usuario.Telefone, usuario.Data_Nascimento, usuario.Email, usuario.Foto_Perfil, usuario.Senha);

            var residencia = new ResidenciaModel(usuario.Nome_Residencias, usuario.Descricao_Residencias, usuario.Foto_Residencias);

            user.AdicionarResidencia(residencia);

            _usuarioRepository.Create(user);
        }

        public List<UsuarioResponse> Listar()
        {
            var list = _usuarioRepository.GetAll();

            return list.Select(c => UsuarioMapper.From(c)).ToList();
        }

    }
}
