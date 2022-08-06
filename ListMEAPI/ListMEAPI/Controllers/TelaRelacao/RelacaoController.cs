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
        /// <summary>
        /// Cadastra uma nova relação
        /// </summary>
        /// <returns>Retorna a lista de relações</returns>
        /// <remarks>
        /// Exemplo requisição:
        ///
        ///     POST /api/Relacao/AdicionarRelacao
        ///     {
        ///         "IdUsuario": "1",
        ///         "IdResidencia": "1",
        ///         "IdEstoque": "1",
        ///         "IdListaDeCompras": "1",
        ///         "IdProduto": "1"
        ///     }
        ///
        /// </remarks>
        /// <response code="200">Retorna a relação recém criado</response>
        /// <response code="500">Ocorreu algum erro criar a relação</response>
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


        /// <summary>
        /// Retorna relação encontrado a partir de sua Id
        /// </summary>
        /// <returns>Retorna a relação encontrada a partir da Id</returns>
        /// <param name="Id">Id da relação</param>
        /// <response code="404">Relação não encontrado</response>
        /// <response code="200">Retorna relação encontrado</response>
        [HttpGet("RequererRelacaoPorId{Id}")]

        public ActionResult<RelacionarUsuario> RequererRelacaoPorId(int Id)
        {
            var requerimento = _listMEContext.RelacaoUsuario.FirstOrDefault(x => x.Id_Relacionamento == Id);

            if (requerimento == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(requerimento);
            }
        }

        /// <summary>
        /// Substitui uma relação a partir de sua Id
        /// </summary>
        /// <returns></returns>
        /// <remarks>  
        /// Exemplo requisição:
        ///
        ///     PUT /api/Relacao/AlterarRelacao{Id}
        ///     {
        ///         "IdUsuario": "1",
        ///         "IdResidencia": "1",
        ///         "IdEstoque": "1",
        ///         "IdListaDeCompras": "1",
        ///         "IdProduto": "1"          
        ///     }
        /// </remarks>
        /// <param name="Id">Id do usuário</param>
        /// <response code="400">Usuário não pode ter sua Id modificada</response>
        /// <response code="404">Usuário não encontrado</response>
        /// <response code="204">Usuário substituído</response>

        [HttpPut("AlterarRelacao{Id}")]
        public ActionResult<RelacionarUsuario> PutRelacao(int Id, RelacionarUsuario relacao)
        {
            var existeRelacao = _listMEContext.RelacaoUsuario.Find(Id);
            if (existeRelacao != null)
            {
                _listMEContext.Entry(existeRelacao).State = EntityState.Modified;
                _listMEContext.SaveChanges();
                return NoContent();
            }
            return NotFound();
        }
        /// <summary>
        /// Deleta a relação a partir de sua Id
        /// </summary>
        /// <returns>Retorna a relação recém deletado</returns>
        /// <param name="Id">Id da relação</param>
        /// <response code="404">Relação não encontrado</response>
        /// <response code="204">Relação deletado</response>
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

       

       
    }
}
