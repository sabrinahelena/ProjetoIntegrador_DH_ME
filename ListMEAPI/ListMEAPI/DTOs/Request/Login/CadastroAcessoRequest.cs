using System.ComponentModel.DataAnnotations;

namespace ListMEAPI.DTOs.Request.Login
{
    public class CadastroAcessoRequest
    {
        /// <summary>
        /// O e-mail para autenticar.
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// A senha para autenticar.
        /// </summary>
        /// 
        [MinLength(4, ErrorMessage = "A senha deve conter ao menos 4 dígitos.")]

        public string senha { get; set; }
    }
}
