using ListMEAPI.DTOs.Request.Usuario;
using ListMEAPI.DTOs.Response.Usuario;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Servicos
{
    public interface IUsuarioService
    {
        //Create e List para o DTOs, request e response
        dynamic Cadastrar(CadastroUsuarioRequest usuario);

        List<UsuarioResponse> Listar();
        bool Deletar(int id);

        UsuarioModel ExibirUsuario(int id);

        void Salvar();
        UsuarioModel Atualizar(int id, AtualizacaoUsuarioRequest usuarioAtualizado);
    }
}
