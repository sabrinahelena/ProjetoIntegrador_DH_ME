using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ListMEAPI.Controllers.TelaGerenciarCompras
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListaDeComprasController : ControllerBase
    {
        public IListaDeComprasService _listaDeComprasService;
        public ListaDeComprasController(IListaDeComprasService listaService)
        {
            _listaDeComprasService = listaService;
        }
        //ADICIONAR MAIS PRODUTOS NA LISTA DE COMPRAS DA RESIDÊNCIA
        /// <summary>
        /// Cadastra uma novo produto na lista de compras
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Exemplo requisição:
        ///     IdResidencia:0,
        ///     IdProduto:0
        /// </remarks>
        /// <param name="IdProduto">Id do produto</param>
        /// <param name="IdResidencia">Id da residência</param>
        /// <response code="200"></response>
        /// <response code="500">Ocorreu algum erro ao adicionar o produto na lista</response>
        [HttpPost("AdicionarListaDeCompras")]
        public ActionResult AdicionarListaDeCompras(int IdResidencia, int IdProduto)
        {
            var boolean = _listaDeComprasService.CadastrarProdutoNaLista(IdResidencia, IdProduto);
            if (boolean)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Retorna todos os produtos na lista de compras da residênci a partir da Id da residência
        /// </summary>
        /// <returns>Retorna todos os produtos na lista de compras da residênci a partir da Id da residência</returns>
        /// <param name="Id">Id do usuário</param>
        /// <response code="404">Usuário não encontrado</response>
        /// <response code="200">Retorna usuário encontrado</response>
        [HttpGet("RequererListaDeComprasPorIdResidência")]
        public ActionResult<List<EstoqueModel>> Listar(int IdResidencia)
        {
            var existe = _listaDeComprasService.ListarAListaDeCompras(IdResidencia);
            if(existe == null)
            {
                return BadRequest(new { message = "Rêsidencia não encontrada" });
            }
            return Ok(existe);
        }

        /// <summary>
        /// Deleta um produto da lista a partir de sua Id
        /// </summary>
        /// <returns>Retorna se o estoque foi deletado ou não</returns>
        /// <param name="IdProduto">Id do estoque</param>
        /// <param name="IdResidencia">Id do estoque</param>
        /// <response code="404">Produto ou residência não encontrado</response>
        /// <response code="204">Produto deletado da lista de compras da residência</response>
        [HttpDelete("DeletarProdutoDaListaPorId")]
        [Authorize(Roles = "Adm,Usuario")]
        public ActionResult DeletarProdutoDaListaPorId(int IdProduto, int IdResidencia)
        {
            var boolean = _listaDeComprasService.DeletarProdutoLista(IdResidencia, IdProduto);
            if (boolean)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }
        //ALTERAR QUANTIDADE DO PRODUTO NA LISTA DE COMPRAS DA RESIDÊNCIA
        /// <summary>
        /// Altera a quantidade de um produto na lista de compras de uma residência
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Exemplo requisição:
        ///     IdResidencia:0,
        ///     IdProduto:2,
        ///     Quantidade: -4
        /// </remarks>
        /// <param name="IdResidencia">Id da residência</param>
        /// <param name="IdProduto">Id do produto</param>
        /// <param name="Quantidade">Quantidade a ser adicionada ou retirada</param>
        /// <response code="200">A quantidade foi alterada com sucesso</response>
        /// <response code="500">Ocorreu algum erro ao alterar a quantidade</response>
        [HttpPatch("AtualizarQuantidadeProdutoNaListaDeCompras")]
        public ActionResult AtualizarQuantidadeProdutoNaListaDeCompras(int IdResidencia,int IdProduto,int Quantidade )
        {
            var boolean = _listaDeComprasService.AlterarQuantidade(IdResidencia, IdProduto, Quantidade);
            if (boolean)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
