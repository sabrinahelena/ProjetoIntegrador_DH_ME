//using ListMEAPI.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace ListMEAPI.Controllers.TelaGerenciarCompras
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProdutosController : ControllerBase
//    {
//        private ListMEContext _listMEContext = new ListMEContext();

//        //POST PRODUTOS
//        /// <summary>
//        /// Cadastra um novo produto
//        /// </summary>
//        /// <returns>Retorna produto recém criada</returns>
//        /// <remarks>
//        /// Exemplo requisição:
//        ///
//        ///     POST /api/Produtos/AdicionarProduto
//        ///     {
//        ///         "nome_Produtos": "Macarrão",
//        ///         "descricao_Produto": "macarrão parafuso",
//        ///         "preco": 20,
//        ///         "data_Validade": "10/12/2030",
//        ///         "quantidade_Produto": 3             
//        ///     }
//        ///
//        /// </remarks>
//        /// <param name="produto">Modelo do estoque</param>
//        /// <response code="200">Retorna o estoque recém criado</response>
//        /// <response code="500">Ocorreu algum erro criar o estoque</response>

//        [HttpPost("AdicionarProduto")]

//        //[Authorize]

//        /*
//         * Aqui, terá que ter login para realizar a ação de att a lista de produtos
//         */

//        public ActionResult<ProdutosModel> AdicionarProduto(ProdutosModel produto)
//        {
//            if (produto == null)
//            {
//                return BadRequest();
//            }
//            else
//            {
//                _listMEContext.Produtos.Add(produto);
//                _listMEContext.SaveChanges();
//                return Ok(produto);
//            }

//        }
//        //GET PRODUTOS
        
//        /// <summary>
//        /// Listar todos produtos
//        /// </summary>
//        /// <returns>Lista de produtos criados</returns>
//        /// <response code="404">Não há produtos cadastrados</response>
//        /// <response code="200">Retorna produtos cadastrados</response>
//        /// <response code="500">Ocorreu algum erro ao obter produtos cadastrados</response>
//        [HttpGet("RequererTodosProdutos")]
//        //[Authorize]


//        /*
//         * Aqui, terá que ter login para realizar a ação de puxar a lista de produtos
//         */

//        public ActionResult<List<ProdutosModel>> RequererTodosProdutos()
//        {
//            var produtos = _listMEContext.Produtos.ToList();
//            if (produtos == null)
//            {
//                return NotFound();
//            }
//            else
//            {
//                return Ok(produtos);
//            }
//        }
//        //PUT PRODUTOS

//        /// <summary>
//        /// Substitui um estoque a partir de sua Id
//        /// </summary>
//        /// <returns></returns>
//        /// <remarks>  
//        /// Exemplo requisição:
//        ///
//        ///     PUT /api/Produtos/SubstituirPelaId{Id}
//        ///     {
//        ///         "nome_Produtos": "Macarrão",
//        ///         "descricao_Produto": "macarrão parafuso",
//        ///         "preco": 20,
//        ///         "data_Validade": "10/12/2030",
//        ///         "quantidade_Produto": 3             
//        ///     }
//        /// </remarks>
//        /// <param name="Id">Id do usuário</param>
//        /// <param name="produto">Modelo do usuário</param>
//        /// <response code="400">Usuário não pode ter sua Id modificada</response>
//        /// <response code="404">Usuário não encontrado</response>
//        /// <response code="204">Usuário substituído</response>

//        [HttpPut]
//        //[Authorize]

//        /*
//         * Aqui, terá que ter login para realizar a ação de att a lista de produtos
//         */

//        [HttpPut("SubstituirProduto{Id}")]

//        public ActionResult<ProdutosModel> SubstituirPelaId(int Id, ProdutosModel produto)
//        {
//            if (Id != produto.Id_Produtos)
//            {
//                return BadRequest();
//            }
//            else
//            {
//                //Substitui valor da instância no banco de dados 
//                _listMEContext.Entry(produto).State = EntityState.Modified;
//                _listMEContext.SaveChanges();

//                return NoContent();
//            }

//        }

//        //DELETE PRODUTOS
//        /// <summary>
//        /// Deleta o produto a partir de sua Id
//        /// </summary>
//        /// <returns>Retorna o produto recém deletado</returns>
//        /// <param name="Id">Id do produto</param>
//        /// <response code="404">produto não encontrado</response>
//        /// <response code="204">produtos deletado</response>
//        [HttpDelete("DeletarProdutoPorId")]

//        //[Authorize]

//        /*
//         * Aqui, terá que ter login para realizar a ação de att a lista de produtos
//         */
//        public ActionResult<ProdutosModel> DeletarProdutoPorId(int Id)
//        {
//            var requerimento = _listMEContext.Produtos.Find(Id);

//            if (requerimento == null)
//            {
//                return NotFound();
//            }
//            else
//            {
//                _listMEContext.Produtos.Remove(requerimento);
//                _listMEContext.SaveChanges();
//                return Ok(requerimento);
//            }
//        }

//    }
//}
