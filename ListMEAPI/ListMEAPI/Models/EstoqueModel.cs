namespace ListMEAPI.Models
{
    public class EstoqueModel
    {
        public int Id_Estoque { get; set; }
       
         List<ProdutosModel>? Produtos { get; set; }
    }
}
