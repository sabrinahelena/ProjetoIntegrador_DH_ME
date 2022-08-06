using ListMEAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private ListMEContext _listMEContext = new ListMEContext();
     

        //Não funciona
        [HttpGet("ExibirTodosUsuariosComRelacionamentos")]
        public ActionResult<RelacionarUsuario> RequererTodosUsuarios()
        {
            return Ok(_listMEContext.RelacaoUsuario.Include(c => c.Id_Usuario).Include(c => c.Id_ListaCompras).Include(c => c.Id_Residencia).Include(c => c.Id_Estoque).Include(c => c.Id_Produto).ToList());
        }
  
        //Não funciona
        [HttpGet("ExibirTodosUsuariosSemRelacionamentos")]
       
        public ActionResult<List<UsuarioModel>> RequererTodasResidencias()
        {
            var Usuarios = _listMEContext.Usuarios.ToList();
            if (Usuarios == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Usuarios);
            }

        }

        [HttpGet("ExibirUsuario{Id}")]

        public ActionResult<UsuarioModel> RequererUmUsuarioPeloId(int Id)
        {
            //Usei find para localizar um usuário pelo ID
            var usuario = _listMEContext.Usuarios.Find(Id);
            if (usuario == null)
            {
                return NotFound(); //Se não houver usuário no Id, retorna esse código
            }
            else
            {
                return Ok(usuario);
            }
        }

    }
}



