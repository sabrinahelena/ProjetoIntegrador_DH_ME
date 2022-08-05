using ListMEAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.Controllers.TelaGerenciarCompras
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private ListMEContext _listMEContext = new ListMEContext();

        //GET PRODUTOS
        [HttpGet("RequererTodosProdutos")]
        //[Authorize]


        /*
         * Aqui, terá que ter login para realizar a ação de puxar a lista de produtos
         */

        public ActionResult<ProdutosModel> RequererTodosProdutos()
        {
            return Ok(_listMEContext.Produtos.ToList());
        }
        //PUT PRODUTOS

        [HttpPut]
        //[Authorize]

        /*
         * Aqui, terá que ter login para realizar a ação de att a lista de produtos
         */

        [HttpPut("SubstituirProduto{Id}")]

        public ActionResult<ProdutosModel> SubstituirPelaId(int Id, ProdutosModel produto)
        {
            if (Id != produto.Id_Produtos)
            {
                return BadRequest();
            }
            else
            {
                //Substitui valor da instância no banco de dados 
                _listMEContext.Entry(produto).State = EntityState.Modified;
                _listMEContext.SaveChanges();

                return NoContent();
            }

        }

        //POST PRODUTOS

        [HttpPost("AdicionarProduto")]

        //[Authorize]

        /*
         * Aqui, terá que ter login para realizar a ação de att a lista de produtos
         */

        public ActionResult<ProdutosModel> AdicionarProduto(ProdutosModel produto)
        {
            if (produto == null)
            {
                return BadRequest();
            }
            else
            {
                _listMEContext.Produtos.Add(produto);
                _listMEContext.SaveChanges();
                return Ok(produto);
            }

        }

        //DELETE PRODUTOS

        [HttpDelete("DeletarProdutoPorId")]

        //[Authorize]

        /*
         * Aqui, terá que ter login para realizar a ação de att a lista de produtos
         */
        public ActionResult<ProdutosModel> DeletarProdutoPorId(int Id)
        {
            var requerimento = _listMEContext.Produtos.Find(Id);

            if (requerimento == null)
            {
                return NotFound();
            }
            else
            {
                _listMEContext.Produtos.Remove(requerimento);
                _listMEContext.SaveChanges();
                return Ok(requerimento);
            }
        }

    }
}
