using ListME.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstoqueController : ControllerBase
    {
        private ListMEContext _listMEContext = new ListMEContext();

        [HttpGet("ExibirTodoEstoque")]

        public ActionResult<List<Estoque>> RequererTodosEstoque()
        {
            var ListaEstoque = _listMEContext.Produtos_ListaDeCompras.ToList();
            if (ListaEstoque == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(ListaEstoque);
            }
        }

        [HttpGet("ExibirEstoque{Id}")]

        public ActionResult<Estoque> RequererItemEstoque(int Id)
        {
            //Usei find para localizar um usuário pelo ID
            var estoque = _listMEContext.Estoque.Find(Id);
            if (estoque == null)
            {
                return NotFound(); //Se não houver usuário no Id, retorna esse código
            }
            else
            {
                return Ok(estoque);
            }
        }

        [HttpPost("AdicionarProdutoAoEstoque")] //PRODUTOS PUXA ROTA CASO QUEIRA ADD AO ESTOQUE

        public Estoque AdicionarAoEstoque(Estoque estoque)
        {
            try
            {
                _listMEContext.Estoque.Add(estoque);
                _listMEContext.SaveChanges();

            }
            catch
            {

            }

            return estoque;
        }

        /// <summary>
        /// Deletar um produto do estoque a partir da sua Id
        /// </summary>
        /// <returns>Retorna o produto recém deletado do estoque</returns>
        /// <param name="Id">Id do produto</param>
        /// <response code="201">Retorna o produto recém deletado do estoque</response>
        /// <response code="404">produto não encontrado</response>
        /// <response code="204">produto deletado</response>
        /// <response code="500">Ocorreu algum erro ao deletar o produto</response>
        [HttpDelete("DeletarProdutoEstoque{Id}")]

        public ActionResult<Estoque> DeleteItemEstoquePelaId(int Id)
        {
            var estoque = _listMEContext.Estoque.Find(Id);
            if (estoque == null)
            {
                return NotFound();
            }
            else
            {
                _listMEContext.Estoque.Remove(estoque);
                _listMEContext.SaveChanges();
                return NoContent();
            }

        }

        [HttpPut("SubstituirProdutoEstoque{Id}")]

        public ActionResult SubstituirPelaIdEstoque(int Id, Estoque Estoque)
        {
            if (Id != Estoque.Id_Estoque)
            {
                return BadRequest();
            }
            else
            {
                //Substitui valor da instância no banco de dados 
                _listMEContext.Entry(Estoque).State = EntityState.Modified;
                _listMEContext.SaveChanges();

                return NoContent();
            }

        }
    }
}
