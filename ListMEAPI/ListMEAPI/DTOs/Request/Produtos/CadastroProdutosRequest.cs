namespace ListMEAPI.DTOs.Request.Produtos
{
    public class CadastroProdutosRequest
    {
        /// <summary>
        /// Nome do produto
        /// </summary>
        public string Nome_Produtos { get; set; }
        /// <summary>
        /// Descrição do produto
        /// </summary>
        public string? Descricao_Produtos { get; set; }
        /// <summary>
        /// Preço do produto
        /// </summary>
        public float Preco { get; set; }
    }
}
