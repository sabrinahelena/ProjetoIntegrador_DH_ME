namespace ListMEAPI.DTOs.Response
{
    public class UsuarioResponse
    {
        public int Id_Usuario { get; set; }
        public string Nome_Usuario { get; set; }

        public List<ResidenciaResponse> Residencias { get; set; }

    }
}
