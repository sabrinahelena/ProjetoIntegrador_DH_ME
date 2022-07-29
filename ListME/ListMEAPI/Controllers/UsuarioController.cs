using ListME.Models;
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

        //USUÁRIOS 


        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <remarks>
        /// Exemplo requisição:
        ///
        ///     POST /Acesso
        ///  {
        ///     "id_Acesso": 0,
        ///     "login": "string",
        ///     "senha": "string",
        ///     "usuario": {
        ///     "id_Usuario": 0,
        ///     "nome_Usuario": "string",
        ///     "sobrenome": "string",
        ///     "telefone": "string",
        ///     "data_Nascimento": "string",
        ///     "email": "string",
        ///     "foto_Perfil": "string",
        ///     "residencias": [
        ///     {
        ///         "id_Residencias": 0,
        ///         "nome_Residencias": "string",
        ///         "descricao_Residencias": "string",
        ///         "foto_Residencias": "string",
        ///         "estoque": {
        ///              "id_Estoque": 0,
        ///              "data_Validade": "string",
        ///              "quantidade_Estoque": 0,
        ///                 "produtos": [
        ///      {
        ///     "id_Produtos": 0,
        ///"nome_Produtos": "string",
        ///"descricao_Produtos": "string",
        ///   "preco": 0,
        ///      "quantidade_Produtos": 0
        ///     }
        ///        ]
        ///        }
        ///      }
        ///   ]
        ///  }
        ///}
        /// </remarks>
        /// <returns>Retorna o usuário recém criado</returns>
        /// <param name="usuario">Cadastro do usuário</param>
        /// <response code="201">Retorna o usuário recém criado</response>
        /// <response code="500">Ocorreu algum erro criar o usuários</response>
        [HttpPost("AdicionarUsuario")]

        public Acesso AdicionarUsuarioLogin(Acesso usuario)
        {
            try
            {
                _listMEContext.Acesso.Add(usuario);
                _listMEContext.SaveChanges();

            }
            catch
            {

            }

            return usuario;
        }

        /// <summary>
        /// Deletar um usuario a partir da sua Id
        /// </summary>
        /// <returns>Retorna o usuário recém deletado</returns>
        /// <param name="Id">Id do usuário</param>
        /// <response code="201">Retorna o usuário recém deletado</response>
        /// <response code="404">Usuário não encontrado</response>
        /// <response code="204">Usuário deletado</response>
        /// <response code="500">Ocorreu algum erro ao deletar o usuários</response>
        [HttpDelete("DeletarUsuario{Id}")]

        public ActionResult<Acesso> DeleteUmPelaId(int Id)
        {
            var usuario = _listMEContext.Acesso.Find(Id);
            if (usuario == null)
            {
                return NotFound();
            }
            else
            {
                _listMEContext.Acesso.Remove(usuario);
                _listMEContext.SaveChanges();
                return NoContent();
            }

        }

        [HttpPut("SubstituirUsuario{Id}")]

        public ActionResult SubstituirPelaId(int Id, Acesso usuario)
        {
            if (Id != usuario.Id_Acesso)
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


        //RESIDÊNCIAS

        [HttpGet("ExibirTodasResidencias")]

        public ActionResult<List<Residencias>> RequererTodasResidencias()
        {
            var ListaResidencias = _listMEContext.Residencias.ToList();
            if (ListaResidencias == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(ListaResidencias);
            }

        }

        [HttpGet("ExibirResidencia{Id}")]

        public ActionResult<Residencias> RequererUmaResidencia(int Id)
        {
            //Usei find para localizar um usuário pelo ID
            var residencia = _listMEContext.Residencias.Find(Id);
            if (residencia == null)
            {
                return NotFound(); //Se não houver usuário no Id, retorna esse código
            }
            else
            {
                return Ok(residencia);
            }
        }

        [HttpPost("AdicionarResidencia")]

        public Residencias AdicionarResidencia(Residencias residencias)
        {
            try
            {
                _listMEContext.Residencias.Add(residencias);
                _listMEContext.SaveChanges();

            }
            catch
            {

            }

            return residencias;
        }

        /// <summary>
        /// Deletar uma residência a partir de sua Id
        /// </summary>
        /// <returns>Retorna a residência recém deletada</returns>
        /// <param name="Id">Id da residência</param>
        /// <response code="201">Retorna a residência recém deletada</response>
        /// <response code="404">Residência não encontrada</response>
        /// <response code="204">Residência deletada</response>
        /// <response code="500">Ocorreu algum erro ao deletar a residência</response>
        [HttpDelete("DeletarResidencia{Id}")]

        public ActionResult<Residencias> DeleteResidenciaPelaId(int Id)
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

        [HttpPut("SubstituirResidencia{Id}")]

        public ActionResult SubstituirPelaIdResidencia(int Id, Residencias Residencia)
        {
            if (Id != Residencia.Id_Residencias)
            {
                return BadRequest();
            }
            else
            {
                //Substitui valor da instância no banco de dados 
                _listMEContext.Entry(Residencia).State = EntityState.Modified;
                _listMEContext.SaveChanges();

                return NoContent();
            }

        }


        //Produtos_ListaDeCompras

        [HttpGet("ExibirTodosProdutos")]

        public ActionResult<List<Produtos_ListaDeCompras>> RequererTodosProdutos()
        {
            var ListaProdutos = _listMEContext.Produtos_ListaDeCompras.ToList();
            if (ListaProdutos == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(ListaProdutos);
            }

        }

        [HttpGet("ExibirProduto{Id}")]

        public ActionResult<Produtos_ListaDeCompras> RequererUmProduto(int Id)
        {
            //Usei find para localizar um usuário pelo ID
            var produto = _listMEContext.Produtos_ListaDeCompras.Find(Id);
            if (produto == null)
            {
                return NotFound(); //Se não houver usuário no Id, retorna esse código
            }
            else
            {
                return Ok(produto);
            }
        }

        [HttpPost("AdicionarProduto")]

        public Produtos_ListaDeCompras AdicionarProduto(Produtos_ListaDeCompras Produtos)
        {
            try
            {
                _listMEContext.Produtos_ListaDeCompras.Add(Produtos);
                _listMEContext.SaveChanges();

            }
            catch
            {

            }

            return Produtos;
        }


        [HttpDelete("DeletarProduto{Id}")]

        public ActionResult<Produtos_ListaDeCompras> DeleteProdutoPelaId(int Id)
        {
            var produto = _listMEContext.Produtos_ListaDeCompras.Find(Id);
            if (produto == null)
            {
                return NotFound();
            }
            else
            {
                _listMEContext.Produtos_ListaDeCompras.Remove(produto);
                _listMEContext.SaveChanges();
                return NoContent();
            }

        }

        [HttpPut("SubstituirProduto{Id}")]

        public ActionResult SubstituirPelaIdProduto(int Id, Produtos_ListaDeCompras Produto)
        {
            if (Id != Produto.Id_Produtos)
            {
                return BadRequest();
            }
            else
            {
                //Substitui valor da instância no banco de dados 
                _listMEContext.Entry(Produto).State = EntityState.Modified;
                _listMEContext.SaveChanges();

                return NoContent();
            }

        }

    }
}

