using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Interfaces.Repositorios.Produtos;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;
using ListMEAPI.Repositories;

namespace ListMEAPI.Services
{
    public class ProdutosService : IProdutosService
    {
        private IProdutosRepository _produtosRepository;
        private ValidacaoRepository _validacaoRepository;

        public ProdutosService(IProdutosRepository produtosRepository,ValidacaoRepository validacao)
        {
            _produtosRepository = produtosRepository;
            _validacaoRepository = validacao;
        }

        //POST
        public bool Criar(CadastroProdutosRequest produto)
        {
            var searchProdutoExistente = _validacaoRepository.ExisteProduto(produto.Nome_Produtos);
            if (searchProdutoExistente)
            {
                return false;
            }
            var novoProduto = new ProdutosModel(produto.Nome_Produtos, produto.Descricao_Produtos, produto.Preco);
            _produtosRepository.Create(novoProduto);
            return true;
        }

        //GET ALL 
        public List<ProdutosModel> GetEstoque()
        {
            return _produtosRepository.GetAll();
        }

        //DELETE
        public bool DeleteProduto(int Id)
        {
            var searchProduto = _validacaoRepository.FindProduto(Id);
            if(searchProduto == null)
            {
                return false;
            }
            else
            {
                _produtosRepository.DeleteProduto(searchProduto);
                return true;
            }
        }

        //PATCH
        public ProdutosModel AlterarProduto(int IdProduto, CadastroProdutosRequest alteracoes)
        {
            var searchProduto = _validacaoRepository.FindProduto(IdProduto);
            if (searchProduto != null)
            {
                _produtosRepository.PutProduto(searchProduto, alteracoes);
                return searchProduto;
            }
            else
            {
                return null;
            }
        }
    }
}
