using ListMEAPI.Models;

namespace ListMEAPI.DTOs.Response.ProdutoNoEstoque
{
    public class ProdutoNoEstoqueResponse
    {
        public int Quantidade_Produto { get; set; }
        public string? Data_Validade { get; set; }
        public ProdutosModel? Produto { get; set; }
    }
}
