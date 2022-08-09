using ListMEAPI.Interfaces.Repositorios.Estoque;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;

namespace ListMEAPI.Services
{
    public class EstoqueService : IEstoqueService

    {
        private IEstoqueRepository _estoqueRepository;
        public EstoqueService(IEstoqueRepository estoqueRepository)
        {
            _estoqueRepository = estoqueRepository;
        }
        public void Criar()
        {
            var NovoEstoque = new EstoqueModel();
            _estoqueRepository.Create(NovoEstoque);
        }
        public EstoqueModel AdicionarProdutoAoEstoque(int IdProduto, int IdEstoque)
        {
            return _estoqueRepository.PutOnEstoque(IdProduto, IdEstoque);
        }

        

        public bool DeleteEstoque(int Id)
        {
           return _estoqueRepository.Delete(Id);
        }

        public List<EstoqueModel> GetEstoque()
        {
            return _estoqueRepository.GetAll();
        }
    }
}
