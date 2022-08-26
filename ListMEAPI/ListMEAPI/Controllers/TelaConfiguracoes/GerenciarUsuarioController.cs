using ListMEAPI.Controllers.TelaGerenciarCompras;
using ListMEAPI.DTOs.Request.Residencia;
using ListMEAPI.DTOs.Response.Residencia;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ListMEAPI.Controllers.TelaConfiguracoes
{
    [Route("api/[controller]")]
    [ApiController]
    public class GerenciarUsuarioController : ControllerBase
    {
        public IResidenciaService _residenciaService;

        public GerenciarUsuarioController(IResidenciaService residenciaService)
        {
            _residenciaService = residenciaService;
        }

        /// <summary>
        /// Cadastra uma nova residência
        /// </summary>
        /// <returns>Retorna a residência recém criada</returns>
        /// <remarks>
        /// Exemplo requisição:
        ///
        ///     POST /api/GerenciarUsuario/AdicionarResidencia
        ///     {
        ///        "nome_Residencias": "Casa na montanha",
        ///        "descricao_Residencias": "Casa isolada no meio da floresta",
        ///        "foto_Residencias": "x"
        ///     }
        ///
        /// </remarks>
        /// <param name="residencia">Modelo da residência</param>
        /// <response code="200">Retorna a residência recém criada</response>
        /// <response code="500">Ocorreu algum erro criar a residência</response>
        [HttpPost("AdicionarResidencia")]
        public IActionResult Create([FromBody] CadastroResidenciaRequest residencia, int id)
        {
            var existe = _residenciaService.Cadastrar(residencia, id);
            if ( existe== null)
            {
                return NotFound(new { mensagem = "Usuario não existe no banco" });
            };
            return Ok(existe);
        }

        /// <summary>
        /// Listar todas as residências
        /// </summary>
        /// <returns>Lista de residências solicitadas</returns>
        /// <response code="404">Não há residências cadastradas</response>
        /// <response code="200">Retorna a lista de residências cadastradas</response>
        /// <response code="500">Ocorreu algum erro ao obter lista de residências cadastradas</response>
        [HttpGet("ListarTodasResidencias")]
        public ActionResult<List<ResidenciaResponse>> GetAll()
        {
            return Ok(_residenciaService.Listar());
        }

        ///// <summary>
        ///// Retorna residência encontrada a partir de sua Id
        ///// </summary>
        ///// <returns>Retorna a residência encontrada a partir da Id</returns>
        ///// <param name="Id">Id da residência</param>
        ///// <response code="404">Residência não encontrada</response>
        ///// <response code="200">Retorna residência encontrada</response>
        //[HttpGet("RequererResidenciaPorId{Id}")]
        //public ActionResult<ResidenciaResponse> ExibeUm(int Id)
        //{
        //    if (_residenciaService.ExibirResidencia(Id) == null)
        //    {
        //        return NotFound(new { menssager = "Residencia não encontrada" });

        //    }
        //    return Ok(_residenciaService.ExibirResidencia(Id));

        //}



        /// <summary>
        /// Retorna residência encontrada a partir da Id de um usuário
        /// </summary>
        /// <returns>Retorna a residência encontrada a partir da Id</returns>
        /// <param name="Id">Id da residência</param>
        /// <response code="404">Residência não encontrada</response>
        /// <response code="200">Retorna residência encontrada</response>
        [HttpGet("RequererResidênciasPorIdUsuario")]
        public ActionResult<List<ResidenciaModel>> ListarResidenciasDoUsuario(int IdUsuario)
        {
            var existe = _residenciaService.ListarPorIdUsuario(IdUsuario);
            if (existe == null)
            {
                return BadRequest(new { message = "Usuário não encontrado ou não há residências" });
            }
            return Ok(existe);
        }

        /// <summary>
        /// Delete uma residência a partir de sua Id
        /// </summary>
        /// <returns>Retorna a residência recém deletada</returns>
        /// <param name="Id">Id da residência</param>
        /// <response code="404">Residência não encontrada</response>
        /// <response code="204">Residência deletada</response>
        [HttpDelete("DeletarResidenciaPorId{Id}")]
        public ActionResult<ResidenciaResponse> Deleta(int Id)
        {
            var boolean = _residenciaService.Deletar(Id);
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
        /// Altera uma residência a partir de sua Id
        /// </summary>
        /// <returns>Retorna a residência recém alterada</returns>
        /// <param name="IdResidencia">Id da residência</param>
        /// <response code="404">Residência não encontrada</response>
        /// <response code="200">Residência alterada</response>
        [HttpPatch("AlterarResidencia")]
        public ActionResult<ResidenciaModel> PatchResidencia (PatchResidencialRequest alteracoes,int IdResidencia)
        {
            var existe = _residenciaService.AlterarResidencia(alteracoes, IdResidencia);
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
