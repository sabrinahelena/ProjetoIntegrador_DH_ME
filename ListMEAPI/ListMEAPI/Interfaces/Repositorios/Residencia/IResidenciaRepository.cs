using ListMEAPI.DTOs.Request.Residencia;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Repositorios.Residencia
{
    public interface IResidenciaRepository
    {

        //Create da residenciamodel
        dynamic Create(ResidenciaModel residencia); //POST
        List<ResidenciaModel> GetAll(); //GET 

        UsuarioModel GetUsuario(int id); //GET

        ResidenciaModel GetOneResidencia(int Id); //GET

        bool Delete(int id); //DELETE

        ResidenciaModel Update(int id, CadastroResidenciaRequest residenciaNova); //PUT

        void Save();

        //void Update(ResidenciaModel residencia);
        //ResidenciaModel Delete(int Id);

    }
}
