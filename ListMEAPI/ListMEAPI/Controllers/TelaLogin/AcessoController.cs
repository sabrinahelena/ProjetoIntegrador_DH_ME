using ListMEAPI.DTOs.Request.Login;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListMEAPI.Controllers.TelaLogin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcessoController : ControllerBase
    {
        public IAcessoService _acessoService;

        public AcessoController(IAcessoService acessoService)
        {
            _acessoService = acessoService;
        }
        [HttpPost]
        
        [AllowAnonymous]

        public ActionResult<dynamic> Create([FromBody] CadastroAcessoRequest acesso)
        {

            var teste = _acessoService.Cadastrar(acesso);
            if(teste == null)
            {
                return NotFound(new { menssager = "E-mail ou senha incorretos" });
            }
            else
            {
                return Ok(teste);
            }
        }
    }
}
