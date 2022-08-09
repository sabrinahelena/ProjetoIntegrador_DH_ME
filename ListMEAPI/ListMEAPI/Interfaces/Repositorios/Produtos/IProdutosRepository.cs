using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Repositorios.Produtos
{
    public interface IProdutosRepository
    {
        //Create da residenciamodel
        void Create(ProdutosModel produto); //POST
        List<ProdutosModel> GetAll(); //GET 

        ProdutosModel GetUsuario(int id);
    }
}
