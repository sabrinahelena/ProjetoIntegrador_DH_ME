using ListMEAPI.DTOs.Request.Residencia;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Repositorios.Residencia
{
    public interface IResidenciaRepository
    {

        //Create da residenciamodel
        void Create(ResidenciaModel residencia, UsuarioModel usuario); //POST
        List<ResidenciaModel> GetAll(); //GET 

        ResidenciaModel Update(int Id, CadastroResidenciaRequest residenciaAtualizada);
        UsuarioModel GetUsuario(int id);
        ResidenciaModel GetOneResidencia(int id);

        void Delete(ResidenciaModel residencia);
        List<ResidenciaModel> GetAllResidenciasFromUsuario(int IdUsuario);
        void Save();

        //void Update(ResidenciaModel residencia);
        //ResidenciaModel Delete(int Id);

    }
}
