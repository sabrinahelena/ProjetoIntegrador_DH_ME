using ListMEAPI.DTOs.Request.Usuario;
using ListMEAPI.DTOs.Response.Usuario;
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
        public ActionResult<dynamic> Create([FromBody] CadastroUsuarioRequest usuario)
        {
            var teste = _usuarioService.Cadastrar(usuario);
            if (teste == true)
            {

                return BadRequest(new { menssager = "E-mail ja existente" });
            }
            else {
                return Ok(teste);
                    
            };
        }

        /// <summary>
        /// Listar todos os usuários
        /// </summary>
        /// <returns>Lista de usuários cadastrados</returns>
        /// <response code="404">Não há usuários cadastrados</response>
        /// <response code="200">Retorna a lista de usuários cadastrados</response>
        /// <response code="500">Ocorreu algum erro ao obter lista de usuários cadastrados</response>
        [HttpGet("Listar usuários")]
        public ActionResult<List<UsuarioResponse>> GetAll()
        {
            return Ok(_usuarioService.Listar());
        }

        /// <summary>
        /// Delete um usuário a partir de sua Id
        /// </summary>
        /// <returns>Retorna o usuário recém criado</returns>
        /// <param name="Id">Id do usuário</param>
        /// <response code="404">Usuário não encontrado</response>
        /// <response code="204">Usuário deletado</response>
        [HttpDelete("Deletar Usuário por Id {Id}")]

        public ActionResult<UsuarioResponse> Deleta(int Id)
        {
            var boolean = _usuarioService.Deletar(Id);
            if(boolean == true)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
            
        }

        /// <summary>
        /// Retorna usuário encontrado a partir de sua Id
        /// </summary>
        /// <returns>Retorna o usuário encontrado a partir da Id</returns>
        /// <param name="Id">Id do usuário</param>
        /// <response code="404">Usuário não encontrado</response>
        /// <response code="200">Retorna usuário encontrado</response>
        [HttpGet("ExibirUmUsuario{Id}")]

        public ActionResult<UsuarioResponse> ExibeUm(int Id)
        {
            var verificacao = _usuarioService.ExibirUsuario(Id);
            if (verificacao != null)
            {
                return Ok(verificacao);
            }
            else
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Substitui um usuário a partir de sua Id
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Exemplo requisição:
        ///
        ///     PUT /api/CadastroUsuario/AtualizarUsuarioPorId{Id}
        ///     {    
        ///         "nome_Usuario": "Sabrina",
        ///         "sobrenome": "Ferreira",
        ///         "telefone": "31985268244",
        ///         "data_Nascimento": "08/01/2004",
        ///         "email": "sabrinahelenaf@gmail.com",
        ///         "foto_Perfil": "string",
        ///         "senha": "sabrinalinda",
        ///     }
        ///
        /// </remarks>
        /// <param name="Id">Id do usuário</param>
        /// <param name="Usuario">Modelo do usuário</param>
        /// <response code="400">Usuário não pode ter sua Id modificada</response>
        /// <response code="404">Usuário não encontrado</response>
        /// <response code="204">Usuário substituído</response>
        [HttpPut("AtualizarUsuarioPorId{Id}")]

        public ActionResult<UsuarioResponse> AtualizaUsuario(int Id, AtualizacaoUsuarioRequest usuarioAtualizado)
        {
            var verificacao = _usuarioService.Atualizar(Id, usuarioAtualizado);
            if (verificacao != null)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

    }
}
