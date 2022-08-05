using ListMEAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListMEAPI.Controllers.TelaGerenciarCompras
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstoqueController : ControllerBase
    {
        private ListMEContext _listMEContext = new ListMEContext();
        //GET ESTOQUE
        [HttpGet("Receber o estoque")]
        public ActionResult<EstoqueModel> GetEstoque()
        {
            return Ok(_listMEContext.Estoque);
        }
        //POST ESTOQUE
        [HttpPost("AdicionarEstoque")]

        public ActionResult<EstoqueModel> AdicionarEstoque(EstoqueModel estoque)
        {
            _listMEContext.Estoque.Add(estoque);
            _listMEContext.SaveChanges();
            return Ok(estoque);
        }
        //PUT ESTOQUE
        //Necessário entender como será feita a identificação do estoque
        //Utilizando por enquanto o Id do estoque
        [HttpPut("Alterar Estoque{Id}")]
        public ActionResult<EstoqueModel> PutEstoque(int Id, EstoqueModel estoque)
        {
            var existeEstoque = _listMEContext.Estoque.Find(Id);
            if(existeEstoque != null)
            {
                //existeEstoque.Produtos = estoque.Produtos;
                _listMEContext.SaveChanges();
                return Ok(_listMEContext.Estoque.Find(Id));
            }
            return NotFound();
        }
        //DELETE ESTOQUE
        [HttpDelete("Deletar estoque{Id}")]
        public ActionResult<EstoqueModel> DeleteEstoque(int Id)
        {
            var existeEstoque = _listMEContext.Estoque.Find(Id);
            if(existeEstoque != null)
            {
                _listMEContext.Estoque.Remove(existeEstoque);
                _listMEContext.SaveChanges();
                return NoContent();
            }
            return NotFound();
        }
    }
}
