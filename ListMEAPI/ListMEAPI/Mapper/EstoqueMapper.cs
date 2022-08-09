using ListMEAPI.DTOs.Response.Estoque;
using ListMEAPI.Models;

namespace ListMEAPI.Mapper
{
    public class EstoqueMapper
    {
        /*
    * O mapper funciona para relacionar o response ao model
    * O DTO armazena os dados, e transferência desses dados é feita no mapper
    */

        public static EstoqueResponse From(EstoqueModel estoque)
        {
            var dto = new EstoqueResponse();
            dto.Id_Estoque = estoque.Id_Estoque;
            dto.Produtos = estoque.Produtos;

            return dto;
        }
    }

}
