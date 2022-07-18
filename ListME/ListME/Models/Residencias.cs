namespace ListME.Models
{
    public class Residencias
    {
        public int Id_Residencias { get; set; }
        public string Nome_Residencias { get; set; }
        public string Descricao_Residencias { get; set; }
        public string Foto_Residencias { get; set; }
        public Estoque estoque { get; set; }


    }
}
