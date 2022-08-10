using ListMEAPI.Controllers.TelaGerenciarCompras;
using ListMEAPI.DTOs.Request.Residencia;
using ListMEAPI.DTOs.Response.Residencia;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.Controllers.TelaConfiguracoes
{
    [Route("api/[controller]")]
    [ApiController]
    public class GerenciarUsuarioController : ControllerBase
    {
        public IResidenciaService _residenciaService;

        public GerenciarUsuarioController(IResidenciaService residenciaService)
        {
            _residenciaService = residenciaService;
        }


        //ADICIONAR MAIS RESIDÊNCIAS
        /// <summary>
        /// Cadastra uma nova residência
        /// </summary>
        /// <returns>Retorna a residência recém criada</returns>
        /// <remarks>
        /// Exemplo requisição:
        ///
        ///     POST /api/GerenciarUsuario/AdicionarResidencia
        ///     {
        ///        "nome_Residencias": "Casa na montanha",
        ///        "descricao_Residencias": "Casa isolada no meio da floresta",
        ///        "foto_Residencias": "x"
        ///     }
        ///
        /// </remarks>
        /// <param name="residencia">Modelo da residência</param>
        /// <response code="200">Retorna a residência recém criada</response>
        /// <response code="500">Ocorreu algum erro criar a residência</response>
        [HttpPost("AdicionarResidencia")]

        //[Authorize]

        /*
         * Aqui, terá que ter login para realizar a ação de adicionar residência
         */

        public IActionResult Create([FromBody] CadastroResidenciaRequest residencia, int id)
        {

            if (_residenciaService.Cadastrar(residencia, id) == null)
            {
                return NotFound(new { mensagem = "Usuario não existe no banco" });
            };
            return Ok();
        }

        /// <summary>
        /// Listar todas as residências
        /// </summary>
        /// <returns>Lista de residências solicitadas</returns>
        /// <response code="404">Não há residências cadastradas</response>
        /// <response code="200">Retorna a lista de residências cadastradas</response>
        /// <response code="500">Ocorreu algum erro ao obter lista de residências cadastradas</response>
        [HttpGet("ListarResidencias")]
        public ActionResult<List<ResidenciaResponse>> GetAll()
        {
            return Ok(_residenciaService.Listar());
        }

        /// <summary>
        /// Retorna residência encontrada a partir de sua Id
        /// </summary>
        /// <returns>Retorna a residência encontrada a partir da Id</returns>
        /// <param name="Id">Id da residência</param>
        /// <response code="404">Residência não encontrada</response>
        /// <response code="200">Retorna residência encontrada</response>
        [HttpGet("ListarResidenciaPorId{Id}")]
        
        public ActionResult<ResidenciaResponse> ExibeUm(int Id)
        {
            if (_residenciaService.ExibirResidencia(Id) == null)
            {
                return NotFound(new { menssager = "Residencia não encontrada" });

            }
            return Ok(_residenciaService.ExibirResidencia(Id));
        }

        /// <summary>
        /// Delete uma residência a partir de sua Id
        /// </summary>
        /// <returns>Retorna a residência recém deletada</returns>
        /// <param name="Id">Id da residência</param>
        /// <response code="404">Residência não encontrada</response>
        /// <response code="204">Residência deletada</response>
        [HttpDelete("DeletarResidenciaPorId{Id}")]

        public ActionResult<ResidenciaResponse> Deleta(int Id)
        {
            _residenciaService.Deletar(Id);
            return Ok();
        }

        /// <summary>
        /// Substitui uma residência a partir de sua Id
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Exemplo requisição:
        ///
        ///     PUT /api/GerenciarUsuario/AtualizarResidenciaPorId{Id}
        ///     {
        ///        "nome_Residencias": "Casa na montanha",
        ///        "descricao_Residencias": "Casa isolada no meio da floresta",
        ///        "foto_Residencias": "x"
        ///     }
        ///
        /// </remarks>
        /// <param name="Id">Id da residência</param>
        /// <param name="residenciaAtualizada">Modelo de residência</param>
        /// <response code="400">Residência não pode ter sua Id modificada</response>
        /// <response code="404">Residência não encontrada</response>
        /// <response code="204">Residência substituída</response>
        [HttpPut("AtualizarResidenciaPorId{Id}")]

        public ActionResult<ResidenciaResponse> AtualizaUsuario(int Id, CadastroResidenciaRequest residenciaAtualizada)
        {
            return Ok(_residenciaService.Atualizar(Id, residenciaAtualizada));
        }

        //PUT PARA USUÁRIO E RESIDÊNCIA
        /// <summary>
        /// Substitui um usuário a partir de sua Id
        /// </summary>
        /// <returns></returns>
        /// <remarks>  
        /// Exemplo requisição:
        ///
        ///     PUT /api/GerenciarUsuario/SubstituirUsuario{Id}
        ///     {
        ///        "nome_Usuario": "Sabrina",
        ///        "sobrenome": "Helena",
        ///        "telefone": "99999999999",
        ///        "data_Nascimento": "08/01/2004",
        ///        "email": "sabrinahelenaf@gmail.com",
        ///        "foto_Perfil": "x",
        ///        "residencias": [
        ///        {
        ///        "nome_Residencias": "casa de inverno",
        ///        "descricao_Residencias": "para passar o natal",
        ///        "foto_Residencias": "x"
        ///        }
        ///        ]
        ///        
        ///     }
        ///
        /// </remarks>
        /// <param name="Id">Id do usuário</param>
        /// <param name="usuario">Modelo do usuário</param>
        /// <response code="400">Usuário não pode ter sua Id modificada</response>
        /// <response code="404">Usuário não encontrado</response>
        /// <response code="204">Usuário substituído</response>
        //[HttpPut("SubstituirUsuario{Id}")]
        ////[Authorize]

        ///*
        // * Apenas administradores poderão deletar algum contato, depois de respondido.
        // */
        //public ActionResult SubstituirUsuarioPelaId(int Id, UsuarioModel usuario)
        //{
        //    if (Id != usuario.Id_Usuario)
        //    {
        //        return BadRequest();
        //    }
        //    else
        //    {
        //        //Substitui valor da instância no banco de dados 
        //        _listMEContext.Entry(usuario).State = EntityState.Modified;
        //        _listMEContext.SaveChanges();

        //        return NoContent();
        //    }

        //}

        /// <summary>
        /// Substitui uma residência a partir de sua Id
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Exemplo requisição:
        ///
        ///     PUT /api/GerenciarUsuario/SubstituirResidencia{Id}
        ///     {
        ///        "nome_Residencias": "Casa na montanha",
        ///        "descricao_Residencias": "Condomínio no meio da floresta",
        ///        "foto_Residencias": "x"
        ///     }
        ///
        /// </remarks>
        /// <param name="Id">Id do usuário</param>
        /// <param name="residencia">Modelo da residência</param>
        /// <response code="400">residência não pode ter sua Id modificada</response>
        /// <response code="404">residência não encontrado</response>
        /// <response code="204">residência substituído</response>

        //[HttpPut("SubstituirResidencia{Id}")]
        ////[Authorize]

        ///*
        // * Apenas administradores poderão deletar algum contato, depois de respondido.
        // */
        //public ActionResult SubstituirResidenciaPelaId(int Id, ResidenciaModel residencia)
        //{
        //    if (Id != residencia.Id_Residencias)
        //    {
        //        return BadRequest();
        //    }
        //    else
        //    {
        //        //Substitui valor da instância no banco de dados 
        //        _listMEContext.Entry(residencia).State = EntityState.Modified;
        //        _listMEContext.SaveChanges();

        //        return NoContent();
        //    }

        //}        //[HttpPut("SubstituirResidencia{Id}")]
        ////[Authorize]

        ///*
        // * Apenas administradores poderão deletar algum contato, depois de respondido.
        // */
        //public ActionResult SubstituirResidenciaPelaId(int Id, ResidenciaModel residencia)
        //{
        //    if (Id != residencia.Id_Residencias)
        //    {
        //        return BadRequest();
        //    }
        //    else
        //    {
        //        //Substitui valor da instância no banco de dados 
        //        _listMEContext.Entry(residencia).State = EntityState.Modified;
        //        _listMEContext.SaveChanges();

        //        return NoContent();
        //    }

        //}

        //DELETE PARA USUÁRIO E RESIDÊNCIA
        /// <summary>
        /// Delete um usuário a partir de sua Id
        /// </summary>
        /// <returns>Retorna o usuário recém deletado</returns>
        /// <param name="Id">Id do usuário</param>
        /// <response code="404">Usuário não encontrado</response>
        /// <response code="204">Usuário deletado</response>
        //[HttpDelete("DeletarUsuario{Id}")]
        ////[Authorize]

        ///*
        // * Apenas administradores poderão deletar algum contato, depois de respondido.
        // */
        //public ActionResult<UsuarioModel> DeleteUmUsuarioPelaId(int Id)
        //{
        //    var usuario = _listMEContext.Usuarios.Find(Id);
        //    if (usuario == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        _listMEContext.Usuarios.Remove(usuario);
        //        _listMEContext.SaveChanges();
        //        return NoContent();
        //    }
        //}        //[HttpDelete("DeletarUsuario{Id}")]
        ////[Authorize]

        ///*
        // * Apenas administradores poderão deletar algum contato, depois de respondido.
        // */
        //public ActionResult<UsuarioModel> DeleteUmUsuarioPelaId(int Id)
        //{
        //    var usuario = _listMEContext.Usuarios.Find(Id);
        //    if (usuario == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        _listMEContext.Usuarios.Remove(usuario);
        //        _listMEContext.SaveChanges();
        //        return NoContent();
        //    }
        //}

        /// <summary>
        /// Delete uma residência a partir de sua Id
        /// </summary>
        /// <returns>Retorna a residência recém deletada</returns>
        /// <param name="Id">Id da residência</param>
        /// <response code="404">residência não encontrado</response>
        /// <response code="204">residência deletado</response>
        //[HttpDelete("DeletarResidencia{Id}")]
        ////[Authorize]

        ///*
        // * Apenas administradores poderão deletar algum contato, depois de respondido.
        // */

        //public ActionResult<ResidenciaModel> DeleteUmaResidenciaPelaId(int Id)
        //{
        //    var residencia = _listMEContext.Residencias.Find(Id);
        //    if (residencia == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        _listMEContext.Residencias.Remove(residencia);
        //        _listMEContext.SaveChanges();
        //        return NoContent();
        //    }
        //}
    }
}
