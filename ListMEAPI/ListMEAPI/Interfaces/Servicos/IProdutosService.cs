using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Servicos
{
    public interface IProdutosService
    {
        void Criar(CadastroProdutosRequest produto); //POST
        bool DeleteProduto(int Id); //Delete
        List<ProdutosModel> GetEstoque();
    }
}
