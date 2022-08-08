using System.ComponentModel.DataAnnotations;

namespace ListMEAPI.Models
{
    public class AcessoModel
    {
        public AcessoModel(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }


        [Key]

        public int Id_Acesso { get; set; }
        public string usuario { get; set; }

        public string senha { get; set; }
    }
}
