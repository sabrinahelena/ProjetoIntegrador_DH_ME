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
        private ListMEContext _listMEContext = new ListMEContext();
       
        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <returns>Retorna o usuário recém criado</returns>
        /// <remarks>
        /// Exemplo requisição:
        ///
        ///     POST /api/CadastroUsuario/AdicionarUsuario
        ///     {
        ///        "nome_Usuario": "Sabrina",
        ///        "sobrenome": "Helena",
        ///        "telefone": "99999999999"
        ///        "data_Nascimento": "08/01/2004",
        ///        "email:" "sabrinahelenaf@gmail.com",
        ///        "foto_Perfil:" "x",
        ///        "residencias": [
        ///        {
        ///        "nome_Residencias": "casa de praia",
        ///        "descricao_Residencias": "de frente para o mar",
        ///        "foto_Residencias": x"
        ///        }
        ///       ]
        ///   
        ///     }
        ///
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

        public ActionResult<UsuarioModel> AdicionarUsuario(UsuarioModel usuario)
        {
            _listMEContext.Usuarios.Add(usuario);
            _listMEContext.SaveChanges();
            return Ok(usuario);
        }
    }
}
