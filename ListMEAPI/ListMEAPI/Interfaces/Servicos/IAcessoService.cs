using ListMEAPI.DTOs.Request.Login;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Servicos
{
    public interface IAcessoService
    {
        void Cadastrar(CadastroAcessoRequest acesso); //POST
        List<AcessoModel> Listar(); //GET 

        void Deletar(int id); //DELETE

        void Salvar();

        AcessoModel Atualizar(int id, CadastroAcessoRequest acessoAtualizado);


        AcessoModel ExibirAcesso(int id);
    }
}
