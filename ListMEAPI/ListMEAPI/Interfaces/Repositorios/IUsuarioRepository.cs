using ListMEAPI.DTOs.Request;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Repositorios
{
    public interface IUsuarioRepository
    {
        //Create e list do usuariomodel
        void Create(UsuarioModel usuario); //POST
        List<UsuarioModel> GetAll(); //GET 

        void Update(int id, UsuarioModel usuarioNovo); //PUT

        void Delete(int id); //DELETE

        void Save();

        UsuarioModel GetOne(int id);
    }
}
