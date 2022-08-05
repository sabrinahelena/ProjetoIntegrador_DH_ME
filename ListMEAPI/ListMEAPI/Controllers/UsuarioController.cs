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
     


        [HttpPost("AdicionarProduto")]

        public ActionResult<ProdutosModel> AdicionarProduto(ProdutosModel produto)
        {
            _listMEContext.Produtos.Add(produto);
            _listMEContext.SaveChanges();
            return Ok(produto);

        }
        [HttpPost("AdicionarListaCompra")]

        public ActionResult<ListaComprasModel> AdicionarListaCompra(ListaComprasModel ListaCompras)
        {
            _listMEContext.ListaCompras.Add(ListaCompras);
            _listMEContext.SaveChanges();
            return Ok(ListaCompras);
        }



        [HttpGet("ExibirTodosUsuariosComRelacionamentos")]
        public ActionResult<RelacionarUsuario> RequererTodosUsuarios()
        {
            return Ok(_listMEContext.RelacaoUsuario.Include(c => c.Id_Usuario).Include(c => c.Id_ListaCompras).Include(c => c.Id_Residencia).Include(c => c.Id_Estoque).Include(c => c.Id_Produto).ToList());
        }

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



