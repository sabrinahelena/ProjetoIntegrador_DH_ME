using ListMEAPI.DTOs.Request.Contato;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Servicos
{
    public interface IContatoService
    {
        void Cadastrar(CadastroContatoRequest contato); //POST
        List<ContatoModel> Listar(); //GET 

        void Deletar(int id); //DELETE

        void Salvar();

        ContatoModel ExibirContato(int id);
    }
}
