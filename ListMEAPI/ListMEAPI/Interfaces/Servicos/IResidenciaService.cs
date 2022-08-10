using ListMEAPI.DTOs.Request.Residencia;
using ListMEAPI.DTOs.Response.Residencia;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Servicos
{
    public interface IResidenciaService
    {
        dynamic Cadastrar(CadastroResidenciaRequest residencia, int id); //POST

        List<ResidenciaResponse> Listar(); //GET

        UsuarioModel RetornarUm(int id); //GET

        ResidenciaModel ExibirResidencia(int id); //GET

        void Deletar(int id); //DELETE

        ResidenciaModel Atualizar(int id, CadastroResidenciaRequest residenciaAtualizada);

        void Salvar();







    }
}
