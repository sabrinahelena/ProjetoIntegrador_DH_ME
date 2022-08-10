using System.ComponentModel.DataAnnotations;

namespace ListMEAPI.DTOs.Request.Usuario
{
    public class AtualizacaoUsuarioRequest
    {
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

        [MinLength(13, ErrorMessage = "O número deve conter pelo menos treze dígitos: '(0XX) - XXXXX-XXXX'")]
        public string? Telefone { get; set; }

        /// <summary>
        /// A data de nascimento do usuário
        /// </summary>
        /// 
        [MinLength(8, ErrorMessage = "A data de nascimento deve conter pelo menos 8 dígitos, considerando DIA (XX), MÊS (XX), e ANO (XXXX)")]
        public string Data_Nascimento { get; set; }
        /// <summary>
        /// O e-mail do usuário
        /// </summary>
        /// 
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
    }
}
