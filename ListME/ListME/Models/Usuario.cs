namespace ListME.Models
{
    public class Usuario
    {
        public string Id_Usuario { get; set; }
        public string Nome_Usuario { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Data_Nascimento { get; set; }
        public string Email { get; set; }
        public string Foto_Perfil { get; set; }

        public List<Residencias> residencias { get; set; } = new List<Residencias>();
        public List<Produtos_ListaDeCompras> produtos { get; set; } = new List<Produtos_ListaDeCompras>();
    }
}
