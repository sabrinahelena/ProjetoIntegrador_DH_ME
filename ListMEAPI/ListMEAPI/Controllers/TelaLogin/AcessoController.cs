//using ListMEAPI.Models;
//using ListMEAPI.Services;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace ListMEAPI.Controllers.TelaLogin
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AcessoController : ControllerBase
//    {

//        [HttpPost]
//        [Route("Autenticar")]
//        [AllowAnonymous]

//        public ActionResult<dynamic> Autenticar(AcessoModel acesso)
//        {
//            var usuario = _listMEContext.Usuarios.Where(Usuario => Usuario.Nome_Usuario == acesso.usuario && Usuario.Senha == acesso.senha).FirstOrDefault();
//            if(usuario == null)
//            {
//                return NotFound(new { menseger = "Usuário ou senha incorretos" });
//            }
//            else
//            {
//                var chaveToken = TokenService.GerarChaveToken();
//                var usuarioEx = _listMEContext.Usuarios.Where(Usuario => Usuario.Nome_Usuario == acesso.usuario && Usuario.Senha == acesso.senha).FirstOrDefault();
//                usuarioEx.Senha = "";

//                return Ok(new { token = chaveToken, user = usuarioEx });
//            }
        
//        }


//        //POST ACESSO E AUTENTICAÇÃO ROLA AQUI
//    }
//}
