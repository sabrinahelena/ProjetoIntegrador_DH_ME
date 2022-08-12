using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListMEAPI.Controllers.TelaGerenciarCompras
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstoqueController : ControllerBase
    {
        public IEstoqueService _estoqueService;
        public EstoqueController(IEstoqueService estoqueService)
        {
            _estoqueService = estoqueService;
        }

        [HttpPost("CriacaoDoEstoque {IdResidencia}")]
        public ActionResult CriarEstoque(int IdResidencia, int IdProduto)
        {
            var boolean = _estoqueService.Criar(IdResidencia, IdProduto);
            if (boolean)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public List<EstoqueModel> GetEstoque()
        {
            return _estoqueService.GetEstoque();
        }
        [HttpGet("Listar por Id Residencia {IdResidencia}")]
        public ActionResult<List<EstoqueModel>> GettEstoqueByIdResidencia(int IdResidencia)
        {
            var Existe = _estoqueService.GetEstoquePorIdResidencia(IdResidencia);
            if (Existe == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(Existe);
            }
        }
        [HttpDelete("{Id}")]
        public ActionResult DeletarEstoque(int Id)
        {
            var boolean = _estoqueService.DeleteEstoque(Id);
            if (boolean)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
        
        
        [HttpPatch("Alterar quantidade de produto ou data de validade {IdProduto}/{IdEstoque}")]
        public ActionResult AlterarQuantidadeOuData(AlterarQuantidadeEDataRequest produtos, int IdProduto, int IdEstoque)
        {
            _estoqueService.AlterarProdutoNoEstoque(produtos, IdProduto, IdEstoque);
            return Ok();
        }
    }
}
