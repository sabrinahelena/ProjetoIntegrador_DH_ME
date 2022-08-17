using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Servicos
{
    public interface IListaDeComprasService
    {
        List<EstoqueModel> ListarAListaDeCompras(int IdResidencia);
        public bool CadastrarProdutoNaLista(int IdResidencia, int IdProduto);
        bool AlterarQuantidade(int IdResidencia, int IdProduto, int quantidade);
        bool DeletarProdutoLista(int IdResidencia,int IdProduto);
    }
}
