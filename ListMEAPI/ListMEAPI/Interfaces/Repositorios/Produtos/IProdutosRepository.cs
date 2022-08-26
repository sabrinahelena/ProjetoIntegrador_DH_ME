using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Repositorios.Produtos
{
    public interface IProdutosRepository
    {
        //Create da residenciamodel
        void Create(ProdutosModel produto); //POST
        List<ProdutosModel> GetAll(); //GET 
        void DeleteProduto(ProdutosModel produto);
        void PutProduto(ProdutosModel produto, CadastroProdutosRequest alteracoes);

    }
}
