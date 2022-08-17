using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        [HttpGet("Get Lista de compras por Id de residência")]
        public ActionResult<List<EstoqueModel>> Listar(int IdResidencia)
        {
            
            return Ok(_listaDeComprasService.ListarAListaDeCompras(IdResidencia));
        }
        [HttpPost]
        public ActionResult CriarLista(int IdResidencia, int IdProduto)
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
        [HttpPatch("Alterar quantidade de um produto na lista de compras")]
        public ActionResult AlterarProdutoNaLista(int IdResidencia,int IdProduto,int quantidade )
        {
            var boolean = _listaDeComprasService.AlterarQuantidade(IdResidencia, IdProduto, quantidade);
            if (boolean)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        public ActionResult DeletarProdutoDaLista(int IdProduto,int IdResidencia)
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
    }
}
