using ListMEAPI.DTOs.Request.Login;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Servicos
{
    public interface IAcessoService
    {
        dynamic Cadastrar(CadastroAcessoRequest acesso); //POST
        
    }
}
