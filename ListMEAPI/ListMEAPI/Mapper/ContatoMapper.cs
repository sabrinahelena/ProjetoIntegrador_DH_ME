using ListMEAPI.DTOs.Response.Contato;
using ListMEAPI.Models;

namespace ListMEAPI.Mapper
{
    public class ContatoMapper
    {
        public static ContatoResponse From(ContatoModel contato)
        {
            var dto = new ContatoResponse();
            dto.Id_Contato = contato.Id_Contato;
            dto.Nome = contato.Nome;
            dto.Email = contato.Email;
            dto.Mensagem = contato.Mensagem;
        
            return dto;

        }
    }
}
