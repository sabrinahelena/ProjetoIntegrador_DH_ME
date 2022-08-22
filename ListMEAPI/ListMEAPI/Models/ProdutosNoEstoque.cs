using System.ComponentModel.DataAnnotations;

namespace ListMEAPI.Models
{
    public class ProdutosNoEstoque
    {
        [Key]
        public int Id_ProdutosNoEstoque { get; set; }   
        public int Quantidade_Produtos { get; set; }
        public string Data_Validade { get; set; }
        public ProdutosModel Produtos { get; set; }

    }
}
