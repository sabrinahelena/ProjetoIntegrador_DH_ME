using ListMEAPI.DTOs.Response.Residencia;

namespace ListMEAPI.DTOs.Response.Usuario
{
    public class AtualizacaoUsuarioResponse
    {
        public int Id_Usuario { get; set; }
        public string Nome_Usuario { get; set; }

        public List<ResidenciaResponse> Residencias { get; set; }
    }
}
