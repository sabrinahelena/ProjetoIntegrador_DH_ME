using System.ComponentModel.DataAnnotations;

namespace ListMEAPI.Models
{
    public class EstoqueModel
    {
        public EstoqueModel()
        {
            Produtos = new List<ProdutosModel>();
        }
        [Key]
        public int Id_Estoque { get; set; }
       
        public List<ProdutosModel> Produtos { get; set; }

        public void AdicionarProdutoNaLista(ProdutosModel produto)
        {
            Produtos.Add(produto);
        }
    }
}
