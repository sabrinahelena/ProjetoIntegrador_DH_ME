using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Servicos
{
    public interface IEstoqueService
    {
        void Criar(); //POST
        bool DeleteEstoque(int Id); //Delete

        EstoqueModel AdicionarProdutoAoEstoque(int IdProduto, int IdEstoque); //Put adicionando produto ao estoque

        List<EstoqueModel> GetEstoque();


    }
}
