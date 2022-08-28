using ListMEAPI.DTOs.Response.Residencia;

namespace ListMEAPI.DTOs.Response.Usuario
{
    public class UsuarioResponse
    {
        public int Id_Usuario { get; set; }
        public string Nome_Usuario { get; set; }
        public string Sobrenome { get; set; }
        public string? Telefone { get; set; }
        public string Data_Nascimento { get; set; }
        public string Email { get; set; }

        public List<ResidenciaResponse> Residencias { get; set; }

    }
}
