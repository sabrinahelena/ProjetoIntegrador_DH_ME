namespace ListMEAPI.DTOs.Request.Produtos
{
    public class CadastroProdutosRequest
    {
        public string Nome_Produtos { get; set; }
        public string? Descricao_Produtos { get; set; }
        public float Preco { get; set; }
    }
}
