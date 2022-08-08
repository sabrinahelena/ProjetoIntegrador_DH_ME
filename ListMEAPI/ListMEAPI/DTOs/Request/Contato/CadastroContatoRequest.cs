namespace ListMEAPI.DTOs.Request.Contato
{
    public class CadastroContatoRequest
    {
        /*
         * DTO = Objeto de Transferência de Dados
         * É um padrão de projeto de software usado para transferir dados 
         * entre subsistemas de um software.
         */
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Mensagem { get; set; }

        //ResidênciaModel

    }
}
