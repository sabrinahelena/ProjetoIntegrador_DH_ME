using ListMEAPI.DTOs.Request.Login;
using ListMEAPI.DTOs.Response.Login;
using ListMEAPI.Interfaces.Repositorios.Login;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListMEAPI.Services
{
    public class AcessoService : IAcessoService
    {
        private IAcessoRepository _acessoRepository;

        public AcessoService(IAcessoRepository acessoRepository)
        {
            _acessoRepository = acessoRepository;
        }

        //POST

        public ActionResult<dynamic> Cadastrar(CadastroAcessoRequest acesso)
        {
            var acessoNovo = new AcessoModel(acesso.email, acesso.senha);

            return Ok(_acessoRepository.Create(acessoNovo));
        }
    
    }
}
