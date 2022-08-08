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
        public string email { get; set; }

        public string senha { get; set; }
    }
}
