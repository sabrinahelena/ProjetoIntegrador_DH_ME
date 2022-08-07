using ListMEAPI.DTOs.Request;
using ListMEAPI.DTOs.Response;

namespace ListMEAPI.Interfaces.Servicos
{
    public interface IUsuarioService
    {
        //Create e List para o DTOs, request e response
        void Cadastrar(CadastroUsuarioRequest usuario);

        List<UsuarioResponse> Listar();
    }
}
