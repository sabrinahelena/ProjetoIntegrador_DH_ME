using ListMEAPI.DTOs.Response.Estoque;
using ListMEAPI.DTOs.Response.ProdutoNoEstoque;
using ListMEAPI.Models;

namespace ListMEAPI.Mapper
{
    public class ProdutoNoEstoqueMapper
    {
        /*
    * O mapper funciona para relacionar o response ao model
    * O DTO armazena os dados, e transferência desses dados é feita no mapper
    */

        public static ProdutoNoEstoqueResponse From(ProdutosNoEstoqueModel produtosNoEstoque)
        {
            var dto = new ProdutoNoEstoqueResponse();
            dto.Quantidade_Produto = produtosNoEstoque.Quantidade_Produto;
            dto.Data_Validade = produtosNoEstoque.Data_Validade;
            dto.Produto = produtosNoEstoque.Produto;
            
            return dto;
        }
    }

}
