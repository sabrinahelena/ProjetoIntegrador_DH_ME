namespace ListME.Models
{
    public class ListaDeCompras
    {
        public int Id_ListaDeCompras { get; set; }

        public List<Produtos_ListaDeCompras> ListaProdutos { get; set; } = new List<Produtos_ListaDeCompras>();
    }
}
