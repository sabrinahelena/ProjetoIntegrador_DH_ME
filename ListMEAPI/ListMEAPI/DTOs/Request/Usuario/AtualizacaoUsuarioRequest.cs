namespace ListMEAPI.DTOs.Request.Usuario
{
    public class AtualizacaoUsuarioRequest
    {
        public string Nome_Usuario { get; set; }
        public string Sobrenome { get; set; }
        public string? Telefone { get; set; }
        public string Data_Nascimento { get; set; }
        public string Email { get; set; }
        public string? Foto_Perfil { get; set; }
        public string Senha { get; set; }
    }
}
