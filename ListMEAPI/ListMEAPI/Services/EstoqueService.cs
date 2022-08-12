using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Interfaces.Repositorios.Estoque;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;
using ListMEAPI.Repositories;

namespace ListMEAPI.Services
{
    public class EstoqueService : IEstoqueService

    {
        private IEstoqueRepository _estoqueRepository;
        private ValidacaoRepository _validacaoRepository;
        public EstoqueService(IEstoqueRepository estoqueRepository, ValidacaoRepository validacao)
        {
            _estoqueRepository = estoqueRepository;
            _validacaoRepository = validacao;
        }
        public bool Criar(int IdResidencia, int IdProduto)
        {
            var procuraProduto = _validacaoRepository.FindProduto(IdProduto);
            var procuraResidencia = _validacaoRepository.FindResidencia(IdResidencia);
            if(procuraProduto == null || procuraResidencia == null)
            {
                return false;
            }
            var NovoEstoque = new EstoqueModel(IdResidencia,procuraProduto,0,"");
            _estoqueRepository.Create(NovoEstoque,procuraResidencia);
            return true;
        }
     

        

        public bool DeleteEstoque(int Id)
        {
           return _estoqueRepository.Delete(Id);
        }

        public List<EstoqueModel> GetEstoque()
        {
            return _estoqueRepository.GetAll();
        }

        public List<EstoqueModel> GetEstoquePorIdResidencia(int IdResidencia)
        {
            if(_validacaoRepository.FindResidencia(IdResidencia) == null)
            {
                return null;
            }
            else
            {
                return _estoqueRepository.GetByIdFromResidencia(IdResidencia);
            }
        }

        

        public EstoqueModel AlterarProdutoNoEstoque(AlterarQuantidadeEDataRequest alteracoes, int IdProduto, int IdEstoque)
        {
            var searchProduto = _validacaoRepository.FindProduto(IdProduto);
            if (searchProduto != null)
            {
                var searchEstoqueComProduto = _validacaoRepository.FindEstoqueWithProduto(searchProduto);
                if (searchEstoqueComProduto != null)
                {
                    return _estoqueRepository.PatchEstoque(alteracoes, searchProduto, searchEstoqueComProduto);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
