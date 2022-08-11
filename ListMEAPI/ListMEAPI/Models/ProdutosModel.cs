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
            //Quantidade_Produto = 0;
        }


        [Key]
        public int Id_Produtos { get; set; }
        public string Nome_Produtos { get; set; }
        public string? Descricao_Produtos { get; set; }
        public float Preco { get; set; }
        //public string? Data_Validade { get; set; }

        //public int? Quantidade_Produto { get; set; }

    }
}
