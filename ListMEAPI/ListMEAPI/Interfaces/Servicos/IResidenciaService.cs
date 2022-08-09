using ListMEAPI.DTOs.Request.Residencia;
using ListMEAPI.DTOs.Response.Residencia;
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
