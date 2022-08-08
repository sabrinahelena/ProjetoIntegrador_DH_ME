using ListMEAPI.DTOs.Response.Login;
using ListMEAPI.Models;

namespace ListMEAPI.Mapper
{
    public class AcessoMapper
    {
        public static AcessoResponse From(AcessoModel acesso)
        {
            var dto = new AcessoResponse();
            dto.Id_Acesso = acesso.Id_Acesso;
            dto.usuario = acesso.usuario;
            dto.senha = acesso.senha;

            return dto;

        }
    }
}
