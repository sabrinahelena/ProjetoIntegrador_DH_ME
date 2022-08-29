using ListMEAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMEAPITest.Produto
{
    public class ProdutoTest
    {
        [Fact]
        public void produtoModel()
        {
            ProdutosModel novoProduto = new ProdutosModel("teste", "testedescricao", 0);
        }
    }
}
