using ListMEAPI.Models;

namespace ListMEAPI.DTOs.Response.Estoque
{
    public class ListaDeComprasResponse
    {
        public ProdutosModel Produto { get; set; }
        public int Quantidade_Para_Comprar { get; set; }
    }
}
