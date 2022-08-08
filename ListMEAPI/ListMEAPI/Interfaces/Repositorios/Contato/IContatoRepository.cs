using ListMEAPI.DTOs.Request.Contato;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Repositorios.Contato
{
    public interface IContatoRepository
    {
        void Create(ContatoModel usuario); //POST
        List<ContatoModel> GetAll(); //GET 

        void Delete(int id); //DELETE

        void Save();

        ContatoModel GetOne(int id);
    }
}
