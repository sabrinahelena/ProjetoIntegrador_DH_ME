using ListMEAPI.DTOs.Request.Residencia;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Repositorios.Residencia
{
    public interface IResidenciaRepository
    {

        //Create da residenciamodel
        dynamic Create(ResidenciaModel residencia); //POST
        List<ResidenciaModel> GetAll(); //GET 

        UsuarioModel GetUsuario(int id);
        ResidenciaModel GetOneResidencia(int id);

        void Delete(ResidenciaModel residencia);

        void Save();

        //void Update(ResidenciaModel residencia);
        //ResidenciaModel Delete(int Id);

    }
}
