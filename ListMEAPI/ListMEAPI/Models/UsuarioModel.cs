using System.ComponentModel.DataAnnotations;

namespace ListMEAPI.Models
{
    public class UsuarioModel
    {
        public UsuarioModel() { }

        public UsuarioModel(string nome_Usuario, string sobrenome, string? telefone, string data_Nascimento, string email, string? foto_Perfil, string senha)
        {
            Nome_Usuario = nome_Usuario;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Data_Nascimento = data_Nascimento;
            Email = email;
            Foto_Perfil = foto_Perfil;
            Senha = senha;
            Residencias = new List<ResidenciaModel>();
        }

        [Key]
        public int Id_Usuario { get; set; }
        public string Nome_Usuario { get; set; }
        public string Sobrenome { get; set; }
        public string? Telefone { get; set; }
        public string Data_Nascimento { get; set; }
        public string Email { get; set; }
        public string? Foto_Perfil { get; set; }

        public string Senha { get; set; }
        public IList<ResidenciaModel> Residencias { get; private set; }
        public void AdicionarResidencia(ResidenciaModel residencia)
        {
            Residencias.Add(residencia);
        }
    }
}
