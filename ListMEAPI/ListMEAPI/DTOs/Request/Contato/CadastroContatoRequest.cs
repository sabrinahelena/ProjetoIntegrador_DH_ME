namespace ListMEAPI.DTOs.Request.Contato
{
    public class CadastroContatoRequest
    {
        /*
         * DTO = Objeto de Transferência de Dados
         * É um padrão de projeto de software usado para transferir dados 
         * entre subsistemas de um software.
         */
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

        //ResidênciaModel

    }
}
