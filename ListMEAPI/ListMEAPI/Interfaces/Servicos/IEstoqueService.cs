using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Servicos
{
    public interface IEstoqueService
    {
        void Criar(EstoqueModel estoque); //POST
        bool DeleteEstoque(int Id); //Delete

        EstoqueModel AdicionarProdutoAoEstoque(); //Put adicionando produto ao estoque


    }
}
