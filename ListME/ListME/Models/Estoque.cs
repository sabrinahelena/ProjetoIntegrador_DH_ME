namespace ListME.Models
{
    public class Estoque
    {
        public int Id_Estoque { get; set; }
        public string? Data_Validade { get; set; }
        public int Quantidade_Estoque { get; set; }

        public List<Produtos_ListaDeCompras>? produtos { get; set; } = new List<Produtos_ListaDeCompras>();

    }
}
