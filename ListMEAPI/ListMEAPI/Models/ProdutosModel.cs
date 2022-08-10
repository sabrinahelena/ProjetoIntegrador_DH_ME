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
        /// <summary>
        /// A data de validade do produto
        /// </summary>
        [MinLength(8, ErrorMessage = "A data de validade deve conter pelo menos 8 dígitos, considerando DIA (XX), MÊS (XX), e ANO (XXXX)")]
        public string? Data_Validade { get; set; }

        /// <summary>
        /// A quantidade existente do produto
        /// </summary>
        public int? Quantidade_Produto { get; set; }

    }
}
