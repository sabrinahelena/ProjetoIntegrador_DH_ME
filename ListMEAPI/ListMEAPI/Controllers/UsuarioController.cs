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

        [HttpPost("AdicionarUsuario")]

        public ActionResult<UsuarioModel> AdicionarUsuario(UsuarioModel usuario)
        {
            _listMEContext.Usuarios.Add(usuario);
            _listMEContext.SaveChanges();
            return Ok(usuario);
        }

        [HttpPost("AdicionarResidencia")]

        public ActionResult<ResidenciaModel> AdicionarResidencia(ResidenciaModel residencia)
        {
            _listMEContext.Residencias.Add(residencia);
            _listMEContext.SaveChanges();
            return Ok(residencia);
        }

        [HttpPost("AdicionarEstoque")]

        public ActionResult<EstoqueModel> AdicionarEstoque(EstoqueModel estoque)
        {
            _listMEContext.Estoque.Add(estoque);
            _listMEContext.SaveChanges();
            return Ok(estoque);
        }


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


        [HttpPost("AdicionarRelacao")]
        public ActionResult<RelacionarUsuario> RelacionarUsuario(RelacionarUsuario Relacao, int IdUsuario, int IdResidencia, int IdEstoque, int IdListaDeCompras, int IdProduto)
        {
            var usuario = _listMEContext.Usuarios.Find(IdUsuario);
            var residencia = _listMEContext.Residencias.Find(IdResidencia);
            var estoque = _listMEContext.Estoque.Find(IdEstoque);
            var produto = _listMEContext.Produtos.Find(IdProduto);
            var listaDecompras = _listMEContext.ListaCompras.Find(IdListaDeCompras);

            Relacao.Id_Usuario = usuario;
            Relacao.Id_Residencia = residencia;
            Relacao.Id_Estoque = estoque;
            Relacao.Id_ListaCompras = listaDecompras;
            Relacao.Id_Produto = produto;

            _listMEContext.RelacaoUsuario.Add(Relacao);

            _listMEContext.SaveChanges();
            return Ok(Relacao);
        }

        [HttpGet]
        public ActionResult<RelacionarUsuario> RequererTodosUsuarios()
        {
            return Ok(_listMEContext.RelacaoUsuario.Include(c => c.Id_Usuario).Include(c => c.Id_ListaCompras).Include(c => c.Id_Residencia).Include(c => c.Id_Estoque).Include(c => c.Id_Produto).ToList());
        }
    }
}



