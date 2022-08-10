using ListMEAPI.DTOs.Request.Login;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Repositorios.Login
{
    public interface IAcessoRepository
    {
        dynamic Create(AcessoModel usuario); //POST
       

    }
}
