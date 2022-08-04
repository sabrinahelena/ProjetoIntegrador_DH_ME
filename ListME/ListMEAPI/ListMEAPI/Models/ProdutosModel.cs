namespace ListMEAPI.Models
{
    public class ProdutosModel
    {
        public int Id_Produtos { get; set; }
        public string Nome_Produtos { get; set; }
        public string? Descricao_Produtos { get; set; }
        public float Preco { get; set; }
        public string? Data_Validade { get; set; }

        public int? Quantidade_Produto { get; set; }

    }
}
