using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Repositorios.Estoque
{
    public interface IEstoqueRepository
    {
        void Create(EstoqueModel estoque, ResidenciaModel residencia);
        List<EstoqueModel> GetAll();
        List<EstoqueModel> GetByIdFromResidencia(int IdResidencia);
        bool Delete(int Id);
       
        EstoqueModel PatchEstoque(AlterarQuantidadeEDataRequest alteracoes, ProdutosModel Produto, EstoqueModel Estoque);
       
    }
}
