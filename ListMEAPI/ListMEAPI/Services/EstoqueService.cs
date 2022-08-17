using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Interfaces.Repositorios.Estoque;
using ListMEAPI.Interfaces.Repositorios.Lista_de_compras;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;
using ListMEAPI.Repositories;

namespace ListMEAPI.Services
{
    public class EstoqueService : IEstoqueService

    {
        private IEstoqueRepository _estoqueRepository;
        private ValidacaoRepository _validacaoRepository;
        private IListaDeComprasRepository _listaDeComprasRepository;
        public EstoqueService(IEstoqueRepository estoqueRepository, ValidacaoRepository validacao, IListaDeComprasRepository lista)
        {
            _estoqueRepository = estoqueRepository;
            _validacaoRepository = validacao;
            _listaDeComprasRepository = lista;
        }
        public bool Criar(int IdResidencia, int IdProduto)
        {
            var procuraProduto = _validacaoRepository.FindProduto(IdProduto);
            var procuraResidencia = _validacaoRepository.FindResidencia(IdResidencia);
            if (procuraProduto == null || procuraResidencia == null)
            {
                return false;
            }
            else
            {
                var NovoEstoque = new EstoqueModel(IdResidencia, procuraProduto, 0, "");
                if (_validacaoRepository.FindListaDeCompras(IdResidencia, IdProduto) == null)
                {
                    var NovaLista = new EstoqueModel(IdResidencia, procuraProduto, 0, IdResidencia);
                    _estoqueRepository.CreateWhithLista(NovoEstoque, procuraResidencia, NovaLista);
                }
                else
                {
                    _estoqueRepository.Create(NovoEstoque, procuraResidencia);
                }

                return true;
            }

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
            if (_validacaoRepository.FindResidencia(IdResidencia) == null)
            {
                return null;
            }
            else
            {
                return _estoqueRepository.GetByIdFromResidencia(IdResidencia);
            }
        }

        public EstoqueModel AlterarProdutoNoEstoque(AlterarQuantidadeEDataRequest alteracoes, int IdProduto, int IdResidencia)
        {
            var searchProduto = _validacaoRepository.FindProduto(IdProduto);
            if (searchProduto != null)
            {
                var searchEstoqueComProduto = _validacaoRepository.FindEstoqueWithProduto(searchProduto, IdResidencia);
                if (searchEstoqueComProduto != null)
                {   
                    var adicionado = _estoqueRepository.PatchEstoque(alteracoes, searchProduto, searchEstoqueComProduto);
                    if(adicionado != null && alteracoes.Quantidade_Produto < 0)
                    {
                        var listaDeCompras = _validacaoRepository.FindListaDeCompras(IdResidencia, IdProduto);
                        _listaDeComprasRepository.Patch(listaDeCompras, -alteracoes.Quantidade_Produto);
                    }
                    return adicionado;
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
