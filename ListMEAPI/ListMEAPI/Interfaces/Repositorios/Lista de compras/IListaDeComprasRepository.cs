using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Repositorios.Lista_de_compras
{
    public interface IListaDeComprasRepository
    {

        List<EstoqueModel> GetListaDeCompras(int IdResidencia);
        void Create(EstoqueModel Cadastro,ResidenciaModel residencia);
        bool Patch(EstoqueModel lista, int quantidade);
        void Delete(EstoqueModel lista);
    }
}
