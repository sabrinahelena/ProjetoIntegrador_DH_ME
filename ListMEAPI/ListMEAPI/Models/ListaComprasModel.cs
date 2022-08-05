namespace ListMEAPI.Models

{
    public class ListaComprasModel
    {
        public int Id_ListaDeCompras { get; set; }

        public List<ProdutosModel>? ListaProdutos { get; set; } = new List<ProdutosModel>();
    }
}
