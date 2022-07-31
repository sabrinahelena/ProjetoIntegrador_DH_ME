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

        // Estoque

        /// <summary>
        /// Cadastra um novo estoque
        /// </summary>
        /// <remarks>
        /// Exemplo requisição:
        ///
        ///     POST /Estoque
        ///  {
        ///     "id_Estoque": 0,
        ///     "Data_Validade": "string",
        ///     "Quantidade_Estoque": 0,
        ///     "produtos": 
        ///      {
        ///     "id_Produtos": 0,
        ///     "nome_Produtos": "string",
        ///     "descricao_Produtos": "string",
        ///     "preco": 0,
        ///     "quantidade_Produtos": 0
        ///     }
        ///}
        /// </remarks>
        /// <returns>Retorna o estoque recém criado</returns>
        /// <param name="estoque">Cadastro do estoque</param>
        /// <response code="201">Retorna o estoque recém criado</response>
        /// <response code="500">Ocorreu algum erro criar o estoque</response>

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
