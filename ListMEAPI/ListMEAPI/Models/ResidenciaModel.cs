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
        /// <summary>
        /// O nome para identificar a residência
        /// </summary>
        public string Nome_Residencias { get; set; }
        /// <summary>
        /// A descrição para identificar a residência
        /// </summary>
        public string? Descricao_Residencias { get; set; }
        /// <summary>
        /// A foto da residência
        /// </summary>
        public string? Foto_Residencias { get; set; }
        /// <summary>
        /// Toda residência possui um estoque.
        /// </summary>
        public EstoqueModel? Estoque { get; set; }

    }
}
