using ListMEAPI.DTOs.Request;
using ListMEAPI.DTOs.Response;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListMEAPI.Controllers.TelaCadastro
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroUsuarioController : ControllerBase
    {

        public IUsuarioService _usuarioService;

        public CadastroUsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <returns>Retorna o usuário recém criado</returns>
        /// <remarks>
        /// Exemplo requisição:
        ///
        ///     POST /api/CadastroUsuario/AdicionarUsuario
        ///     {
        /// 
        ///         "nome_Usuario": "string",
        ///         "sobrenome": "string",
        ///         "telefone": "string",
        ///         "data_Nascimento": "string",
        ///         "email": "string",
        ///         "foto_Perfil": "string",
        ///         "senha": "string",
        ///         "nome_Residencias": "string",
        ///         "descricao_Residencias": "string",
        ///         "foto_Residencias": "string"
        ///     }
        /// </remarks>
        /// <param name="usuario">Modelo do usuário</param>
        /// <response code="200">Retorna o usuário recém criado</response>
        /// <response code="500">Ocorreu algum erro criar o usuários</response>
        //POST USUARIO

        [HttpPost("AdicionarUsuario")]
        [AllowAnonymous]

        /*
         * Para criar seu acesso, não precisa estar autenticado.
         */
        public IActionResult Create([FromBody] CadastroUsuarioRequest usuario)
        {
            _usuarioService.Cadastrar(usuario);
            return Ok();
        }

        [HttpGet]
        public ActionResult<List<UsuarioResponse>> GetAll()
        {
            return Ok(_usuarioService.Listar());
        }

        [HttpDelete("{Id}")]

        public ActionResult<UsuarioResponse> Deleta(int Id)
        {
             _usuarioService.Deletar(Id);
            return Ok();
        }

        [HttpGet("ExibirUmUsuario{Id}")]

        public ActionResult<UsuarioResponse> ExibeUm(int Id)
        {
            return Ok(_usuarioService.ExibirUsuario(Id));
        }

        [HttpPut("AtualizarUsuarioPorId{Id}")]

        public ActionResult<UsuarioResponse> AtualizaUsuario(int Id, AtualizacaoUsuarioRequest usuarioAtualizado)
        {
            return Ok(_usuarioService.Atualizar(Id, usuarioAtualizado));
        }

    }
}
