using System.ComponentModel.DataAnnotations;

namespace ListMEAPI.Models
{
    public class ProdutosModel
    {
        public ProdutosModel(string nome_Produtos, string? descricao_Produtos, float preco)
        {
            Nome_Produtos = nome_Produtos;
            Descricao_Produtos = descricao_Produtos;
            Preco = preco;
        }

        [Key]
        public int Id_Produtos { get; set; }
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
