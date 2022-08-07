using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Repositorios
{
    public interface IUsuarioRepository
    {
        //Create e list do usuariomodel
        void Create(UsuarioModel usuario); //POST
        List<UsuarioModel> GetAll(); //GET 

        void Update(UsuarioModel usuario); //PUT
    }
}
