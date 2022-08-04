using ListMEAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListMEAPI.Controllers.Home
{
    [Route("api/[controller]")]
    [ApiController]

    /*
     * Esse controller fica na pasta Home, pois na tela inicial (home) haverá um espaço
     * no qual o cliente poderá entrar em contato com a equipe.
     */ 
    public class ContatoController : ControllerBase
    {
        private ListMEContext _listMEContext = new ListMEContext();
        [HttpPost]
        [AllowAnonymous]

        /*
         * Para armazenar esse contato, o usuário faz um post do model Contato, que contém
         * nome, email (para respondermos) e a mensagem. Esse método permite anônimos, não é necessário
         * autenticar.
         */ 
        public ActionResult<ContatoModel> AdicionarContato(ContatoModel contato)
        {
            if(contato == null)
            {
                return BadRequest();
            }
            else
            {
                _listMEContext.Contato.Add(contato);
                _listMEContext.SaveChanges();
                return Ok(contato);
            }

        }


        

        [HttpGet]
        //[Authorize]

        /*
         * Aqui, terá que ter autorização, pois um usuário cliente normal não pode
         * puxar os contatos. Apenas nós, a equipe, que gerencia o app poderá puxar
         * essa lista com os contatos.
         */

        public ActionResult<ContatoModel> RequererTodosPedidosContato()
        {
            return Ok(_listMEContext.Contato.ToList());
        }


        [HttpGet("{Id}")]
        //[Authorize]


        /*
         * Aqui, terá que ter autorização, pois um usuário cliente normal não pode
         * puxar os contatos. Apenas nós, a equipe, que gerencia o app poderá puxar
         * essa lista com os contatos.
         */

        public ActionResult<ContatoModel> RequererPedidosContatoPorId(int Id)
        {
            var requerimento = _listMEContext.Contato.FirstOrDefault(x => x.Id_Contato == Id);

            if (requerimento == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(requerimento);
            }
        }

        [HttpDelete("{Id}")]
        //[Authorize]

        /*
         * Apenas administradores poderão deletar algum contato, depois de respondido.
         */ 
        

        public ActionResult<ContatoModel> DeletarContatoPorId(int Id)
        {
            var requerimento = _listMEContext.Contato.Find(Id);

            if(requerimento == null)
            {
                return NotFound();
            }
            else
            {
                _listMEContext.Contato.Remove(requerimento);
                _listMEContext.SaveChanges();
                return Ok(requerimento);
            }
        }
    }
}
