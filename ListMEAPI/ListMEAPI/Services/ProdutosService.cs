using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Interfaces.Repositorios.Produtos;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;

namespace ListMEAPI.Services
{
    public class ProdutosService : IProdutosService
    {
        private IProdutosRepository _produtosRepository;

        public ProdutosService(IProdutosRepository produtosRepository)
        {
            _produtosRepository = produtosRepository;
        }
        public void Criar(CadastroProdutosRequest produto)
        {
            var novoProduto = new ProdutosModel(produto.Nome_Produtos, produto.Descricao_Produtos, produto.Preco);
            _produtosRepository.Create(novoProduto);
        }

        public bool DeleteProduto(int Id)
        {
            throw new NotImplementedException();
        }

        public List<ProdutosModel> GetEstoque()
        {
            return _produtosRepository.GetAll();
        }
    }
}
