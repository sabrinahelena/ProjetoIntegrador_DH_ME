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
        [HttpPut("Adicionar Produto No Estoque {IdProduto}/{IdEstoque}")]
        public ActionResult<EstoqueModel> PutNoEstoque(int IdProduto, int IdEstoque)
        {
            var existe = _estoqueService.AdicionarProdutoAoEstoque(IdProduto, IdEstoque);
            if (existe != null)
            {
                return Ok(existe);
            }
            else
            {
                return NotFound(new {comment = "Prduto não encontrado ou repetido" });
            }
            
        }

        [HttpPut("Remover Produto Do Estoque {IdProduto}/{IdEstoque}")]
        public ActionResult RetirarProduto(int IdProduto ,int IdEstoque)
        {
            var verifica=_estoqueService.RetirarProdutoDoEstoque(IdProduto, IdEstoque);
           if(verifica != null)
            {
                return Ok();
            }
            else
            {
                return NotFound(new {comment="Estoque ou produto não encontrado"});
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
