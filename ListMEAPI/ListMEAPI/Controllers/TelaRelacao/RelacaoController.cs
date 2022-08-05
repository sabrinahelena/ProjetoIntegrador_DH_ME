using ListMEAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.Controllers.TelaRelacao
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelacaoController : ControllerBase
    {
        private ListMEContext _listMEContext = new ListMEContext();

        [HttpPost("AdicionarRelacao")]
        public ActionResult<RelacionarUsuario> RelacionarUsuario(RelacionarUsuario Relacao, int IdUsuario, int IdResidencia, int IdEstoque, int IdListaDeCompras, int IdProduto)
        {
            var usuario = _listMEContext.Usuarios.Find(IdUsuario);
            var residencia = _listMEContext.Residencias.Find(IdResidencia);
            var estoque = _listMEContext.Estoque.Find(IdEstoque);
            var produto = _listMEContext.Produtos.Find(IdProduto);
            var listaDecompras = _listMEContext.ListaCompras.Find(IdListaDeCompras);

            Relacao.Id_Usuario = usuario;
            Relacao.Id_Residencia = residencia;
            Relacao.Id_Estoque = estoque;
            Relacao.Id_ListaCompras = listaDecompras;
            Relacao.Id_Produto = produto;

            _listMEContext.RelacaoUsuario.Add(Relacao);

            _listMEContext.SaveChanges();
            return Ok(Relacao);
        }

        [HttpDelete("DeletarRelacao{Id}")]
        public ActionResult<RelacionarUsuario> DeleteRelacao(int Id, RelacionarUsuario relacao)
        {
            var existeRelacao = _listMEContext.RelacaoUsuario.Find(Id);
            if(existeRelacao != null)
            {
                _listMEContext.RelacaoUsuario.Remove(existeRelacao);
                _listMEContext.SaveChanges();
                return NoContent();
            }
            return NotFound();
        }

        [HttpPut("AlterarRelacao{Id}")]
        public ActionResult<RelacionarUsuario> PutRelacao(int Id, RelacionarUsuario relacao)
        {
            var existeRelacao = _listMEContext.RelacaoUsuario.Find(Id);
            if(existeRelacao != null)
            {
                _listMEContext.Entry(existeRelacao).State = EntityState.Modified;
                _listMEContext.SaveChanges();
                return NoContent();
            }
            return NotFound();
        }

        [HttpGet("{Id}")]
        public ActionResult<RelacionarUsuario> GetRelacao(int Id)
        {
            return _listMEContext.RelacaoUsuario.Find(Id);
        }
    }
}
