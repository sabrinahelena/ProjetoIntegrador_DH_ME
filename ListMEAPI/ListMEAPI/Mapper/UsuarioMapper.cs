using ListMEAPI.DTOs.Response.Usuario;
using ListMEAPI.Models;

namespace ListMEAPI.Mapper
{
    public class UsuarioMapper
    {
        public static UsuarioResponse From(UsuarioModel usuario)
        {
            var dto = new UsuarioResponse();
            dto.Id_Usuario = usuario.Id_Usuario;
            dto.Nome_Usuario = usuario.Nome_Usuario;
            dto.Sobrenome = usuario.Sobrenome;
            dto.Data_Nascimento = usuario.Data_Nascimento;
            dto.Telefone = usuario.Telefone;
            dto.Email = usuario.Email;

            

            return dto;

        }
    }
}
