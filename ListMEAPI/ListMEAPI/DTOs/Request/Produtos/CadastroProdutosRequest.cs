using System.ComponentModel.DataAnnotations;

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
