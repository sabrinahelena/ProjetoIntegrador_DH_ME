using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = ServiceStack.DataAnnotations.RequiredAttribute;

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
        

        [Key]
        public int Id_Usuario { get; set; }
        /// <summary>
        /// O nome do usuário
        /// </summary>
        public string Nome_Usuario { get; set; }
        /// <summary>
        /// O sobrenome do usuário
        /// </summary>
        public string Sobrenome { get; set; }
        /// <summary>
        /// O telefone do usuário
        /// </summary>
        /// 
        [Required]
        [MinLength(13, ErrorMessage = "O número deve conter pelo menos treze dígitos: '(0XX) - XXXXX-XXXX'")]
        public string? Telefone { get; set; }

        /// <summary>
        /// A data de nascimento do usuário
        /// </summary>
        /// 
        [MinLength(8, ErrorMessage = "A data de nascimento deve conter pelo menos 8 dígitos, considerando DIA (XX), MÊS (XX), e ANO (XXXX)")]

        public string Data_Nascimento { get; set; }
        public string Email { get; set; }
        /// <summary>
        /// A foto de perfil do usuário
        /// </summary>
        public string? Foto_Perfil { get; set; }
        /// <summary>
        /// A senha do usuário
        /// </summary>
        /// 

        [MinLength(4, ErrorMessage = "A senha deve conter ao menos 4 dígitos.")]

        public string Senha { get; set; }

        public string tipousuario = "Usuario";
        public List<ResidenciaModel> Residencias { get; private set; }
        public void AdicionarResidencia(ResidenciaModel residencia)
        {
            Residencias.Add(residencia);

        }
    }
}
