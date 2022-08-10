using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Servicos
{
    public interface IEstoqueService
    {
        void Criar(); //POST
        bool DeleteEstoque(int Id); //Delete

        EstoqueModel AdicionarProdutoAoEstoque(int IdProduto, int IdEstoque); //Put adicionando produto ao estoque
        EstoqueModel RetirarProdutoDoEstoque(int IdProduto, int IdEstoque); //Put retiranndo produto do estoque
        List<EstoqueModel> GetEstoque();
        EstoqueModel AlterarProdutoNoEstoque(AlterarQuantidadeEDataRequest produtos, int IdProduto, int IdEstoque); //Patch alterando a data de validade e quantidade do produto no estoque


    }
}
