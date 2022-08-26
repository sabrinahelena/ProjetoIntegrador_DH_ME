using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Interfaces.Repositorios.Lista_de_compras;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;
using ListMEAPI.Repositories;

namespace ListMEAPI.Services
{
    public class ListaDeComprasService : IListaDeComprasService
    {
        private IListaDeComprasRepository _listaRepository;
        private ValidacaoRepository _validacaoRepository;
        public ListaDeComprasService(IListaDeComprasRepository estoqueRepository, ValidacaoRepository validacao)
        {
            _listaRepository = estoqueRepository;
            _validacaoRepository = validacao;
        }

        //POST
        public bool CadastrarProdutoNaLista(int IdResidencia, int IdProduto)
        {
            var searchResidencia = _validacaoRepository.FindResidencia(IdResidencia);
            var searchProduto = _validacaoRepository.FindProduto(IdProduto);
            var searchLista = _validacaoRepository.FindListaDeCompras(IdResidencia, IdProduto);
            if (searchProduto != null && searchResidencia != null && searchLista == null)
            {
                var CadastrarNaLista = new EstoqueModel(IdResidencia, searchProduto, 0, IdResidencia);
                _listaRepository.Create(CadastrarNaLista, searchResidencia);
                return true;
            }
            else
            {
                return false;
            }
        }

        //GET ALL LISTAS DE COMPRAS DE UM USUÁRIO
        public List<EstoqueModel> ListarAListaDeCompras(int IdResidencia)
        {
            var searchResidencia = _validacaoRepository.FindResidencia(IdResidencia);
            if (searchResidencia != null)
            {
                return _listaRepository.GetListaDeCompras(IdResidencia);
            }
            else
            {
                return null;
            }
        }

        //DELETE
        public bool DeletarProdutoLista(int IdResidencia, int IdProduto)
        {
            var searchResidencia = _validacaoRepository.FindResidencia(IdResidencia);
            var searchProduto = _validacaoRepository.FindProduto(IdProduto);
            var searchLista = _validacaoRepository.FindListaDeCompras(IdResidencia, IdProduto);
            if (searchResidencia != null && searchProduto != null && searchLista != null)
            {
                _listaRepository.Delete(searchLista);
                return true;
            }
            else
            {
                return false;
            }
        }


        //PATCH
        public bool AlterarQuantidade(int IdResidencia, int IdProduto, int quantidade)
        {
            var searchResidencia = _validacaoRepository.FindResidencia(IdResidencia);
            var searchProduto = _validacaoRepository.FindProduto(IdProduto);
            var searchLista = _validacaoRepository.FindListaDeCompras(IdResidencia, IdProduto);
            if(searchResidencia != null && searchProduto != null && searchLista != null)
            {
                return _listaRepository.Patch(searchLista, quantidade);
            }
            else
            {
                return false;
            }
        }
    }
}
