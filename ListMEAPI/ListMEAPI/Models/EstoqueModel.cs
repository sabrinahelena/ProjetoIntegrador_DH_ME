using ListMEAPI.DTOs.Request.Produtos;
using System.ComponentModel.DataAnnotations;

namespace ListMEAPI.Models
{
    public class EstoqueModel
    {
        public EstoqueModel()
        {
            Produtos = new List<ProdutosNoEstoqueModel>();
        }
        [Key]
        public int Id_Estoque { get; set; }
       
        //public List<ProdutosModel> Produtos { get; set; }
        public IList<ProdutosNoEstoqueModel> Produtos { get; set; }

        public void AdicionarProdutoNaLista(ProdutosNoEstoqueModel produto)
        {
            Produtos.Add(produto);
        }
        public void RemoverProdutoNaLista(ProdutosNoEstoqueModel produto)
        {
            Produtos.Remove(produto);
        }

        //public List<ProdutosModel> RetornaProdutoCadastrado()
        //{
        //    List<ProdutosModel> lista = new List<ProdutosModel>();
        //    foreach(var produto in Produtos)
        //    {
        //         lista.Add(produto.Produto);
        //    }
        //    return lista;
        //}
       
        
    }
}
