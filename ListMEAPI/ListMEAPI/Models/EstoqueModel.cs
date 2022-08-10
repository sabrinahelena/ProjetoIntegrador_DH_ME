using ListMEAPI.DTOs.Request.Produtos;
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
        //public List<ProdutosNoEstoque> produtos { get; set; }

        public void AdicionarProdutoNaLista(ProdutosModel produto)
        {
            Produtos.Add(produto);
        }
        public void RemoverProdutoNaLista(ProdutosModel produto)
        {
            Produtos.Remove(produto);
        }
        public bool AdicionarQuantidadeEData(AlterarQuantidadeEDataRequest dadosEnviados, ProdutosModel produto)
        {
            var existe = Produtos.FirstOrDefault(produto);
            existe.Data_Validade = dadosEnviados.Data_Validade;
            if(dadosEnviados.Quantidade_Produto < 0)
            {
                if(existe.Quantidade_Produto - dadosEnviados.Quantidade_Produto < 0)
                {
                    return false;
                }
                else
                {
                    existe.Quantidade_Produto += dadosEnviados.Quantidade_Produto;
                    return true;
                }
            }
            else
            {
                existe.Quantidade_Produto += dadosEnviados.Quantidade_Produto;
                return true;
            }
        }
    }
}
