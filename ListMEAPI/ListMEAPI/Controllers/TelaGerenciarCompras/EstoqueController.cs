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

        [HttpPost("CriacaoDoEstoque")]
        public ActionResult CriarEstoque()
        {
            _estoqueService.Criar();
            return Ok();
        }

        [HttpGet]
        public List<EstoqueModel> GetEstoque()
        {
            return _estoqueService.GetEstoque();
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
        [HttpPut("adicionarprodutonoestoque{IdProduto}/{IdEstoque}")]
        public ActionResult<EstoqueModel> putnoestoque(int IdProduto, int IdEstoque)
        {
           
            return Ok(_estoqueService.AdicionarProdutoAoEstoque(IdProduto, IdEstoque));
        }
    }
}
