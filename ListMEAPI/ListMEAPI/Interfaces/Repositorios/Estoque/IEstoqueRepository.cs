using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Repositorios.Estoque
{
    public interface IEstoqueRepository
    {
        void Create(EstoqueModel estoque);
        List<EstoqueModel> GetAll();
        bool Delete(int Id);
        public EstoqueModel RemoveFromEstoque(int IdProduto, int IdEstoque);
        EstoqueModel PutOnEstoque(int IdProduto, int IdEstoque);
        EstoqueModel PatchEstoque(AlterarQuantidadeEDataRequest produtos, int IdProduto, int IdEstoque);
        //void CreateProdutoNoEstoque(ProdutosNoEstoque produtosNoEstoque);
    }
}
