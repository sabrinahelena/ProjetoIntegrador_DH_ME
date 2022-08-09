using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Repositorios.Residencia
{
    public interface IResidenciaRepository
    {

        //Create da residenciamodel
        void Create(ResidenciaModel residencia); //POST
        List<ResidenciaModel> GetAll(); //GET 

        UsuarioModel GetUsuario(int id);

        ResidenciaModel GetOneResidencia(int Id);

        void Save();

        //void Update(ResidenciaModel residencia);
        //ResidenciaModel Delete(int Id);

    }
}
