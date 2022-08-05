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
