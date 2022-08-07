using ListMEAPI.DTOs.Request;
using ListMEAPI.DTOs.Response;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Servicos
{
    public interface IUsuarioService
    {
        //Create e List para o DTOs, request e response
        void Cadastrar(CadastroUsuarioRequest usuario);

        List<UsuarioResponse> Listar();

        void Atualizar(int id, UsuarioModel usuario);

        void Deletar(int id);

        UsuarioModel ExibirUsuario(int id);
    }
}
