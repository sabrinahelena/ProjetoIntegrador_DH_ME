using ListMEAPI.DTOs.Request.Residencia;
using ListMEAPI.DTOs.Response.Residencia;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Servicos
{
    public interface IResidenciaService
    {
        dynamic Cadastrar(CadastroResidenciaRequest residencia, int id); 

        List<ResidenciaResponse> Listar(); 

        ResidenciaModel Atualizar(int id, CadastroResidenciaRequest residenciaAtualizada); 

        List<ResidenciaModel> ListarPorIdUsuario(int IdUsuario);

        bool Deletar(int Id);

        ResidenciaModel AlterarResidencia(PatchResidencialRequest alteracoes, int IdResidencia);
    }
}
