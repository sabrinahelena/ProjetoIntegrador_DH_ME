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
        private ListMEContext _listMEContext = new ListMEContext();

        //PUT PARA USUÁRIO E RESIDÊNCIA
        [HttpPut("SubstituirUsuario{Id}")]
        //[Authorize]

        /*
         * Apenas administradores poderão deletar algum contato, depois de respondido.
         */
        public ActionResult SubstituirUsuarioPelaId(int Id, UsuarioModel usuario)
        {
            if (Id != usuario.Id_Usuario)
            {
                return BadRequest();
            }
            else
            {
                //Substitui valor da instância no banco de dados 
                _listMEContext.Entry(usuario).State = EntityState.Modified;
                _listMEContext.SaveChanges();

                return NoContent();
            }

        }

        [HttpPut("SubstituirResidencia{Id}")]
        //[Authorize]

        /*
         * Apenas administradores poderão deletar algum contato, depois de respondido.
         */
        public ActionResult SubstituirResidenciaPelaId(int Id, ResidenciaModel residencia)
        {
            if (Id != residencia.Id_Residencias)
            {
                return BadRequest();
            }
            else
            {
                //Substitui valor da instância no banco de dados 
                _listMEContext.Entry(residencia).State = EntityState.Modified;
                _listMEContext.SaveChanges();

                return NoContent();
            }

        }
        //DELETE PARA USUÁRIO E RESIDÊNCIA

        [HttpDelete("DeletarUsuario{Id}")]
        //[Authorize]

        /*
         * Apenas administradores poderão deletar algum contato, depois de respondido.
         */
        public ActionResult<UsuarioModel> DeleteUmUsuarioPelaId(int Id)
        {
            var usuario = _listMEContext.Usuarios.Find(Id);
            if (usuario == null)
            {
                return NotFound();
            }
            else
            {
                _listMEContext.Usuarios.Remove(usuario);
                _listMEContext.SaveChanges();
                return NoContent();
            }
        }


        [HttpDelete("DeletarResidencia{Id}")]
        //[Authorize]

        /*
         * Apenas administradores poderão deletar algum contato, depois de respondido.
         */

        public ActionResult<ResidenciaModel> DeleteUmaResidenciaPelaId(int Id)
        {
            var residencia = _listMEContext.Residencias.Find(Id);
            if (residencia == null)
            {
                return NotFound();
            }
            else
            {
                _listMEContext.Residencias.Remove(residencia);
                _listMEContext.SaveChanges();
                return NoContent();
            }
        }
    }
}
