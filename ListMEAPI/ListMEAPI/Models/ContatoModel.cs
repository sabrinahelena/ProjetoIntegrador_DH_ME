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
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Mensagem { get; set; }
    }
}
