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

        /// <summary>
        /// Exibe todas as residências
        /// </summary>
        /// <response code="200">Retorna todas as residências cadastradas</response>
        /// <response code="204">Caso não haja residências cadastradas</response> 
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

        /// <summary>
        /// Busca uma residência no registro pelo o seu Id
        /// </summary>
        /// <param name="Id">Digitar o Id da residência</param>
        /// <response code="200">Retorna a residência digitada</response>
        /// <response code="404">Caso não haja residência com o Id fornecido</response> 
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
        /// <summary>
        /// Exibe todos os produtos da lista de compras
        /// </summary>
        /// <response code="200">Retorna os produtos da lista de compras</response>
        /// <response code="204">Caso não haja produto na lista de compras</response> 
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

        /// <summary>
        /// Busca um produto na lista de compras pelo o seu Id
        /// </summary>
        /// <param name="Id">Digitar o Id do produto</param>
        /// <response code="200">Retorna o produto da lista de compras</response>
        /// <response code="404">Caso não haja produto com o Id fornecido</response> 
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

