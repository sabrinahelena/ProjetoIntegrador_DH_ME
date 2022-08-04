namespace ListMEAPI.Models
{
    public class RelacionarUsuario
    {
        public int Id_Relacionamento { get; set; }
        public UsuarioModel Id_Usuario { get; set; }
        public ResidenciaModel Id_Residencia { get; set; }
        public EstoqueModel Id_Estoque { get; set; }
        public ListaComprasModel Id_ListaCompras { get; set; }
        public ProdutosModel Id_Produto { get; set; }
    }
}
