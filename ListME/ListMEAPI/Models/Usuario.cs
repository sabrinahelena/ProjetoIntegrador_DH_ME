using System.ComponentModel.DataAnnotations;

namespace ListME.Models
{
    //.
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        /// <summary>
        /// O nome do usuário
        /// </summary>
        [Required]
        [MinLength(3, ErrorMessage = "O nome deve conter pelo menos três letras")]
        public string Nome_Usuario { get; set; }
        /// <summary>
        /// O sobrenome do usuário
        /// </summary>
        [Required]
        [MinLength(3, ErrorMessage = "O nome deve conter pelo menos três letras")]
        public string Sobrenome { get; set; }

        [MinLength(13, ErrorMessage = "O número deve conter pelo menos 13 números")]
        public string? Telefone { get; set; }

        [MinLength(8, ErrorMessage = "A data de nascimento deve contar dia (DD), mês (MM) e ano (AAAA)")]
        public string Data_Nascimento { get; set; }
        public string Email { get; set; }
        public string? Foto_Perfil { get; set; }

        // public List<Residencias> residencias { get; set; } = new List<Residencias>();
    }
}
//teste
