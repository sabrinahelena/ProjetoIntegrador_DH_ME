using ListMEAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.Controllers.TelaSelecaoResidencia
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidenciaUsuarioController : ControllerBase
    {
        //GET para retornar todas residências referentes ao usuário X
        private ListMEContext _listMEContext = new ListMEContext();

        [HttpGet("RequererResidencias")]
        public ActionResult<UsuarioModel> RequererTodasResidencias(int IdUsuario)
        {
            var usuario = _listMEContext.Usuarios.Find(IdUsuario);

            //if (_listMEContext.Usuarios.Any(u => usuario.residencias == u.residencias))
            //{
            return Ok(_listMEContext.Usuarios.Include(c => c.residencias)
                .Where(c => c == usuario).ToList()) ;
            //}
            //else
            //{
            //    return NoContent();
            //}
        }

        //POST para selecionar a residência
        //GET retornando a relação
    }
}
