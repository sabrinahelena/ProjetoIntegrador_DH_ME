using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ListMEAPI.Models;

namespace ListMEAPI.Controllers.TelaGerenciarCompras
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListaComprasController : ControllerBase
    {
        private ListMEContext _listMEContext = new ListMEContext();

        //GET LISTACOMPRAS
        //PUT LISTACOMPRAS
        //POST LISTACOMPRAS
        //DELETE LISTACOMPRAS
        /// <summary>
        /// Cadastra uma nova lista de compras
        /// </summary>
        /// <returns>Retorna a lista de compra recém criada</returns>
        /// <remarks>
        /// Exemplo requisição:
        ///
        ///     POST /api/ListaCompras/AdicionarListaDeCompras
        ///     {
        ///         "teste": "1",
        ///         "listaProdutos": [
        ///         {
        ///         "nome_Produtos": "Macarrão",
        ///         "descricao_Produto": "macarrão parafuso",
        ///         "preco": 20,
        ///         "data_Validade": "10/12/2030",
        ///         "quantidade_Produto": 3
        ///         }
        ///         ]       
        ///     }
        ///
        /// </remarks>
        /// <param name="listaCompras">Modelo do estoque</param>
        /// <response code="200">Retorna o estoque recém criado</response>
        /// <response code="500">Ocorreu algum erro criar o estoque</response>
        [HttpPost("AdicionarListaDeCompras")]

        public ActionResult<ListaComprasModel> AdicionarListaDeCompras(ListaComprasModel listaCompras)
        {
            _listMEContext.ListaCompras.Add(listaCompras);
            _listMEContext.SaveChanges();
            return Ok(listaCompras);
        }


        /// <summary>
        /// Listar todas listas de compras
        /// </summary>
        /// <returns>Lista de compras criados</returns>
        /// <response code="404">Não há lista de compra cadastrada</response>
        /// <response code="200">Retorna a lista de compra cadastrados</response>
        /// <response code="500">Ocorreu algum erro ao obter lista de compra cadastrados</response>

        [HttpGet("ExibirTodasListasDeCompras")]

        public ActionResult<List<ListaComprasModel>> RequererTodasListasDeCompras()
        {
            var ListaCompras = _listMEContext.ListaCompras.ToList();
            if (ListaCompras == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(ListaCompras);
            }

        }
        /// <summary>
        /// Retorna lista de compra encontrado a partir de sua Id
        /// </summary>
        /// <returns>Retorna a lista de compra encontrado a partir da Id</returns>
        /// <param name="Id">Id do contato</param>
        /// <response code="404">lista de compra não encontrado</response>
        /// <response code="200">Retorna lista de compra encontrado</response>

        [HttpGet("ExibirListaDeCompras{Id}")]

        public ActionResult<ListaComprasModel> RequererUmaListaDeCompras(int Id)
        {
            //Usando find para localizar uma lista pelo ID
            var listaCompras = _listMEContext.ListaCompras.Find(Id);
            if (listaCompras == null)
            {
                return NotFound(); //Se não houver lista com essa Id, retorna esse código
            }
            else
            {
                return Ok(listaCompras);
            }
        }

        /// <summary>
        /// Substitui um estoque a partir de sua Id
        /// </summary>
        /// <returns></returns>
        /// <remarks>  
        /// Exemplo requisição:
        ///
        ///     PUT /api/Estoque/SubstituirListaDeCompras{Id}
        ///     {
        ///         "teste": "1",
        ///         "listaProdutos": [
        ///         {
        ///         "nome_Produtos": "Macarrão",
        ///         "descricao_Produto": "macarrão parafuso",
        ///         "preco": 20,
        ///         "data_Validade": "10/12/2030",
        ///         "quantidade_Produto": 3
        ///         }
        ///         ]       
        ///     }
        ///
        /// </remarks>
        /// <param name="Id">Id do usuário</param>
        /// <param name="estoque">Modelo do usuário</param>
        /// <response code="400">Usuário não pode ter sua Id modificada</response>
        /// <response code="404">Usuário não encontrado</response>
        /// <response code="204">Usuário substituído</response>
        [HttpPut("SubstituirListaDeCompras{Id}")]

        public ActionResult SubstituirPelaIdResidencia(int Id, ListaComprasModel ListaDeCompras)
        {
            if (Id != ListaDeCompras.Id_ListaDeCompras)
            {
                return BadRequest();
            }
            else
            {
                //Substitui valor da instância no banco de dados 
                _listMEContext.Entry(ListaDeCompras).State = EntityState.Modified;
                _listMEContext.SaveChanges();

                return NoContent();
            }

        }

        /// <summary>
        /// Delete a lista de compras a partir de sua Id
        /// </summary>
        /// <returns>Retorna a lista de compras recém deletado</returns>
        /// <param name="Id">Id da lista de compras</param>
        /// <response code="404">lista de compras não encontrado</response>
        /// <response code="204">lista de compras deletado</response>

        [HttpDelete("DeletarListaDeCompras{Id}")]

        public ActionResult<ListaComprasModel> DeletarListaDecomprasPelaId(int Id)
        {
            var listaDecompras = _listMEContext.ListaCompras.Find(Id);
            if (listaDecompras == null)
            {
                return NotFound();
            }
            else
            {
                _listMEContext.ListaCompras.Remove(listaDecompras);
                _listMEContext.SaveChanges();
                return NoContent();
            }

        }



       
    }


}
