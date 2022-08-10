using System.ComponentModel.DataAnnotations;

namespace ListMEAPI.Models
{
    public class AcessoModel
    {
        public AcessoModel(string email, string senha)
        {
            this.email = email;
            this.senha = senha;
        }


        [Key]

        public int Id_Acesso { get; set; }
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
