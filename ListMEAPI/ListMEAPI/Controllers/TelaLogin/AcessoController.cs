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
        [Route("Autenticar")]
        [AllowAnonymous]

        public dynamic Create([FromBody] CadastroAcessoRequest acesso)
        {

            return (_acessoService.Cadastrar(acesso));


        }
    }
}
