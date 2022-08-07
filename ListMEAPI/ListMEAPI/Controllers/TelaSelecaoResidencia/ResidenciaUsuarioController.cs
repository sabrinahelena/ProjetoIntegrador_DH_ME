//using ListMEAPI.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace ListMEAPI.Controllers.TelaSelecaoResidencia
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ResidenciaUsuarioController : ControllerBase
//    {
//        //GET para retornar todas residências referentes ao usuário X

//        private ListMEContext _listMEContext = new ListMEContext();

//        /// <summary>
//        /// Listar todas residências a partir do usuário
//        /// </summary>
//        /// <returns>Lista de residências a partir do usuário</returns>
//        /// <response code="404">Não há residências a partir do usuário cadastrada</response>
//        /// <response code="200">Retorna a residência cadastrados</response>
//        /// <response code="500">Ocorreu algum erro ao obter residência cadastrados</response>
//        [HttpGet("RequererResidencias")]
//        public ActionResult<UsuarioModel> RequererTodasResidencias(int IdUsuario)
//        {
//            var usuario = _listMEContext.Usuarios.Find(IdUsuario);

//            if (usuario == null)
//            {
//                return BadRequest();
//            }
//            else
//            {
//                return Ok(_listMEContext.Usuarios.Include(c => c.Residencias)
//                    .Where(c => c == usuario).ToList());
//            }
//        }
//    }
//}
