using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListMEAPI.Controllers.TelaGerenciarCompras
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        public IProdutosService _produtosService;

        public ProdutosController(IProdutosService produtosService)
        {
            _produtosService = produtosService;
        }
        [HttpPost("Adicionar Produto Ao Sistema")]
        public ActionResult<ProdutosModel> CadastrarProduto(CadastroProdutosRequest produto)
        {
            _produtosService.Criar(produto);
            return Ok();
        }
        [HttpGet]
        public ActionResult<List<ProdutosModel>> GetAll()
        {
            return Ok(_produtosService.GetEstoque());
        }

        [HttpDelete("Delete por Id {IdProduto}")]
        public ActionResult DeleteProduto(int IdProduto)
        {
            var boolean = _produtosService.DeleteProduto(IdProduto);
            if (boolean)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut("Alterar Produto")]
        public ActionResult<ProdutosModel> AlterarProduto(int IdProduto, CadastroProdutosRequest alteracoes)
        {
            var existe = _produtosService.AlterarProduto(IdProduto, alteracoes);
            if (existe != null)
            {
                return Ok(existe);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
