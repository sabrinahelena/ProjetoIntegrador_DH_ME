namespace ListME.Models
{
    public class UsuarioRelacaorResidencia
    {
        public int Id_UsuarioRelacaoResidencia { get; set; }
        public Usuario usuarioRelacaoResidencia { get; set; }
        public Residencias residenciaRelacaoResidencia { get; set; }
    }
}
