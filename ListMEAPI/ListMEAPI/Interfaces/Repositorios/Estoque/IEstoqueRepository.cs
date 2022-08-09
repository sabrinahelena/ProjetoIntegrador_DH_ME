using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Repositorios.Estoque
{
    public interface IEstoqueRepository
    {
        void Create(EstoqueModel estoque);
        List<EstoqueModel> GetAll();
        bool Delete(int Id);

        EstoqueModel PutOnEstoque(int IdProduto, int IdEstoque);
    }
}
