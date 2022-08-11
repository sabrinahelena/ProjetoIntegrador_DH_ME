using ListMEAPI.DTOs.Request.Produtos;
using System.ComponentModel.DataAnnotations;

namespace ListMEAPI.Models
{
    public class ProdutosNoEstoqueModel
    {
       
        public ProdutosNoEstoqueModel(ProdutosModel? produto)
        {
            this.Quantidade_Produto = 0;
            this.Data_Validade = "";
            this.Produto = produto; 
        }
        
        public ProdutosNoEstoqueModel() { }
        
        [Key]
        public int Id_ProdutosNoEstoque { get; set; }
        public int Quantidade_Produto { get; set; }
        public string? Data_Validade { get; set; }
        public ProdutosModel? Produto { get; set; }
        public void AdicionarProduto(ProdutosModel produto)
        {
            this.Produto = produto;
        }
        public bool AdicionarDataEQuantidade(AlterarQuantidadeEDataRequest dadosEnviados)
        {

            Data_Validade = dadosEnviados.Data_Validade;
            if (dadosEnviados.Quantidade_Produto < 0)
            {
                if (this.Quantidade_Produto - dadosEnviados.Quantidade_Produto < 0)
                {
                    return false;
                }
                else
                {
                    this.Quantidade_Produto += dadosEnviados.Quantidade_Produto;
                    return true;
                }
            }
            else
            {
                this.Quantidade_Produto += dadosEnviados.Quantidade_Produto;
                return true;
            }
        }
    }


}

