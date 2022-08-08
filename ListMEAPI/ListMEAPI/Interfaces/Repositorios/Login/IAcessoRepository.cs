using ListMEAPI.DTOs.Request.Login;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Repositorios.Login
{
    public interface IAcessoRepository
    {
        void Create(AcessoModel usuario); //POST
        List<AcessoModel> GetAll(); //GET 

        void Delete(int id); //DELETE

        void Save();

        AcessoModel GetOne(int id);

        AcessoModel Update(int id, CadastroAcessoRequest acessoNovo); //PUT

    }
}
