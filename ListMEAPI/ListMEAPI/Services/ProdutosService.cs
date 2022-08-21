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

        public ProdutosModel AlterarProduto(int IdProduto, CadastroProdutosRequest alteracoes)
        {
            
                return _produtosRepository.PutProduto(IdProduto, alteracoes);
            
        }

        public void Criar(CadastroProdutosRequest produto)
        {
            var novoProduto = new ProdutosModel(produto.Nome_Produtos, produto.Descricao_Produtos, produto.Preco);
            _produtosRepository.Create(novoProduto);
        }

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

        public List<ProdutosModel> GetEstoque()
        {
            return _produtosRepository.GetAll();
        }

        
    }
}
