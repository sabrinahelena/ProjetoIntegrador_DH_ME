using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Servicos
{
    public interface IEstoqueService
    {
        bool Criar(int IdResidencia, int IdProduto); //POST
        bool DeleteEstoque(int Id); //Delete

        List<EstoqueModel> GetEstoque();
        List<EstoqueModel> GetEstoquePorIdResidencia(int IdResidencia);
        EstoqueModel AlterarProdutoNoEstoque(AlterarQuantidadeEDataRequest produtos, int IdProduto, int IdEstoque); //Patch alterando a data de validade e quantidade do produto no estoque


    }
}
