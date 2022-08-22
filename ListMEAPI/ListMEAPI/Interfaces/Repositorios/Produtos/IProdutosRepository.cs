using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Repositorios.Produtos
{
    public interface IProdutosRepository
    {
        //Create da residenciamodel
        void Create(ProdutosModel produto); //POST
        List<ProdutosModel> GetAll(); //GET 
        ProdutosModel GetUsuario(int id);
        void DeleteProduto(ProdutosModel produto);
        ProdutosModel PutProduto(int IdProduto, CadastroProdutosRequest alteracoes);

    }
}
