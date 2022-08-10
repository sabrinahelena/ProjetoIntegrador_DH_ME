namespace ListMEAPI.DTOs.Request.Residencia
{
    public class CadastroResidenciaRequest
    {
        /// <summary>
        /// A descrição para identificar a residência
        /// </summary>
        public string Nome_Residencias { get; set; }
        public string? Descricao_Residencias { get; set; }
        /// <summary>
        /// A foto da residência
        /// </summary>
        public string? Foto_Residencias { get; set; }
        /// <summary>
        /// Toda residência possui um estoque.
        /// </summary>
    }
}
