using ListMEAPI.DTOs.Request.Contato;
using ListMEAPI.DTOs.Response.Contato;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListMEAPI.Controllers.Home
{
    [Route("api/[controller]")]
    [ApiController]


    /*
     * Esse controller fica na pasta Home, pois na tela inicial (home) haverá um espaço
     * no qual o cliente poderá entrar em contato com a equipe.
     */
    public class ContatoController : ControllerBase
    {
        public IContatoService _contatoService;

        public ContatoController(IContatoService contatoService)
        {
            _contatoService = contatoService;
        }

        /// <summary>
        /// Cadastra um novo contato
        /// </summary>
        /// <returns>Retorna o contato recém criado</returns>
        /// <remarks>
        /// Exemplo requisição:
        ///
        ///     POST /api/Contato/AdicionarContato
        ///     {
        ///        "nome": "Sabrina",
        ///        "email": "sabrinahelenaf@gmail.com"
        ///        "mensagem": "Olá, gostaria de saber quanto custa os serviços do app"
        ///     }
        ///
        /// </remarks>
        /// <param name="contato">Modelo do contato</param>
        /// <response code="200">Retorna o contato recém criado</response>
        /// <response code="500">Ocorreu algum erro criar o contato</response>
        [HttpPost("AdicionarContato")]
        [AllowAnonymous]

        /*
         * Para armazenar esse contato, o usuário faz um post do model Contato, que contém
         * nome, email (para respondermos) e a mensagem. Esse método permite anônimos, não é necessário
         * autenticar.
         */
        public IActionResult Create([FromBody] CadastroContatoRequest contato)
        {
            if (contato == null)
            {
                return BadRequest();
            }
            else
            {
                _contatoService.Cadastrar(contato);
                return Ok();
            }
        }

        /// <summary>
        /// Listar todos os contatos
        /// </summary>
        /// <returns>Lista de contatos solicitados</returns>
        /// <response code="404">Não há contatos cadastrados</response>
        /// <response code="200">Retorna a lista de contatos cadastrados</response>
        /// <response code="500">Ocorreu algum erro ao obter lista de contatos cadastrados</response>
        [HttpGet("ListarTodosContatos")]
        //[Authorize]

        /*
         * Aqui, terá que ter autorização, pois um usuário cliente normal não pode
         * puxar os contatos. Apenas nós, a equipe, que gerencia o app poderá puxar
         * essa lista com os contatos.
         */
        public ActionResult<List<ContatoResponse>> GetAll()
        {
            return Ok(_contatoService.Listar());
        }

        /// <summary>
        /// Retorna contato encontrado a partir de sua Id
        /// </summary>
        /// <returns>Retorna o contato encontrado a partir da Id</returns>
        /// <param name="Id">Id do contato</param>
        /// <response code="404">Contato não encontrado</response>
        /// <response code="200">Retorna contato encontrado</response>
        [HttpGet("RequererContatoPorId{Id}")]
        //[Authorize]


        /*
         * Aqui, terá que ter autorização, pois um usuário cliente normal não pode
         * puxar os contatos. Apenas nós, a equipe, que gerencia o app poderá puxar
         * essa lista com os contatos.
         */

        public ActionResult<ContatoResponse> ExibeUm(int Id)
        {
            var existe = _contatoService.ExibirContato(Id);
            if (existe == null)
            {
                return BadRequest(new { message = "Contanto não encontrado" });
            }
            return Ok(existe);
        }
    


        /// <summary>
        /// Delete um contato a partir de sua Id
        /// </summary>
        /// <returns>Retorna o contato recém deletado</returns>
        /// <param name="Id">Id do contato</param>
        /// <response code="404">Contato não encontrado</response>
        /// <response code="204">Contato deletado</response>

        [HttpDelete("DeletarContatoPorId{Id}")]
        //[Authorize]

        /*
         * Apenas administradores poderão deletar algum contato, depois de respondido.
         */


        public ActionResult<ContatoResponse> Deleta(int Id)
        {
            _contatoService.Deletar(Id);
            return Ok();
        }
    }
}
