using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace ListMEAPI.Models
{
    public class UsuarioModel
    {


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
        public UsuarioModel(int id_Usuario, string nome_Usuario, string sobrenome, string? telefone, string data_Nascimento, string email, string? foto_Perfil, string senha, IList<ResidenciaModel> residencias)
        {
            Id_Usuario = id_Usuario;
            Nome_Usuario = nome_Usuario;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Data_Nascimento = data_Nascimento;
            Email = email;
            Foto_Perfil = foto_Perfil;
            Senha = senha;
            Residencias = residencias;
        }


        [Key]
        public int Id_Usuario { get; set; }
        public string Nome_Usuario { get; set; }
        public string Sobrenome { get; set; }
        public string? Telefone { get; set; }
        public string Data_Nascimento { get; set; }

        [Unique]

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
