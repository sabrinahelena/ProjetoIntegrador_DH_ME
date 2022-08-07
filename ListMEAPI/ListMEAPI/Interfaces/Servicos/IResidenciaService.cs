using ListMEAPI.DTOs.Request;
using ListMEAPI.DTOs.Response;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Servicos
{
    public interface IResidenciaService
    {
        void Cadastrar(CadastroResidenciaRequest residencia, int id);

        List<ResidenciaResponse> Listar();

        UsuarioModel RetornarUm(int id);

        void Salvar();







    }
}
