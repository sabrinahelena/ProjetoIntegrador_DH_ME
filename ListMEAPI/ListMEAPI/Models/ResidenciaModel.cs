using System.ComponentModel.DataAnnotations;

namespace ListMEAPI.Models
{
    public class ResidenciaModel
    {
        public ResidenciaModel() { }

        public ResidenciaModel(string nome_Residencias, string? descricao_Residencias, string? foto_Residencias)
        {
            Nome_Residencias = nome_Residencias;
            Descricao_Residencias = descricao_Residencias;
            Foto_Residencias = foto_Residencias;
        }

        [Key]
        public int Id_Residencias { get; set; }
        public string Nome_Residencias { get; set; }
        public string? Descricao_Residencias { get; set; }
        public string? Foto_Residencias { get; set; }
        public EstoqueModel? Estoque { get; set; }

    }
}
