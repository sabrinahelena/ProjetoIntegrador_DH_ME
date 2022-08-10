using System.ComponentModel.DataAnnotations;

namespace ListMEAPI.Models
{
    public class ContatoModel
    {
        public ContatoModel(string nome, string email, string mensagem)
        {
            Nome = nome;
            Email = email;
            Mensagem = mensagem;
        }

        [Key]
        public int Id_Contato { get; set; }

        /// <summary>
        /// O nome da pessoa que quer entrar em contato.
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// O e-mail da pessoa que quer entrar em contato.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// A mensagem da pessoa que quer entrar em contato.
        /// </summary>
        public string Mensagem { get; set; }
    }
}
