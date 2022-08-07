namespace ListMEAPI.DTOs.Request
{
    /*
     * DTO = Objeto de Transferência de Dados
     * É um padrão de projeto de software usado para transferir dados 
     * entre subsistemas de um software.
     */

    public class CadastroUsuarioRequest
    {
        //Tudo aquilo que pedimos ao cadastrar um usuário

        //UsuárioModel
        public string Nome_Usuario { get; set; }
        public string Sobrenome { get; set; }
        public string? Telefone { get; set; }
        public string Data_Nascimento { get; set; }
        public string Email { get; set; }
        public string? Foto_Perfil { get; set; }
        public string Senha { get; set; }

        //ResidênciaModel
        public string Nome_Residencias { get; set; }
        public string? Descricao_Residencias { get; set; }
        public string? Foto_Residencias { get; set; }


    }
}
