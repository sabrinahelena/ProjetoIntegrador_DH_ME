using ListMEAPI.DTOs.Request.Produtos;
using System.ComponentModel.DataAnnotations;

namespace ListMEAPI.Models
{
    public class EstoqueModel
    {
        public EstoqueModel() {
            
        }
        public EstoqueModel(int idresidencia,ProdutosModel produto, int quantidade_produto,string data_validade )
        {
            IdResidencia = idresidencia;
            Produto = produto;
            Quantidade_Produto = quantidade_produto;
            Data_Validade = data_validade;  
        }
        [Key]
        public int Id_Estoque { get; set; }

        [Required]
        public int IdResidencia { get; set; }
        [Required]
        public ProdutosModel Produto { get; set; }
       
        public int Quantidade_Produto { get; set; }
        public string Data_Validade { get; set; }
        public bool AdicionarQuantidadeEData(AlterarQuantidadeEDataRequest dadosEnviados, ProdutosModel produto)
        {
            
            this.Data_Validade = dadosEnviados.Data_Validade;
            if (dadosEnviados.Quantidade_Produto < 0)
            {
                if (this.Quantidade_Produto + dadosEnviados.Quantidade_Produto < 0)
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
