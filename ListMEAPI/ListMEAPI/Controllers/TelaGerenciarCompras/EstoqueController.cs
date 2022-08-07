//using ListMEAPI.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace ListMEAPI.Controllers.TelaGerenciarCompras
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class EstoqueController : ControllerBase
//    {
//        private ListMEContext _listMEContext = new ListMEContext();
//        //POST ESTOQUE
//        /// <summary>
//        /// Cadastra um novo estoque
//        /// </summary>
//        /// <returns>Retorna o estoque recém criada</returns>
//        /// <remarks>
//        /// Exemplo requisição:
//        ///
//        ///     POST /api/Estoque/AdicionarEstoque
//        ///     {
//        ///        
//        ///        
//        ///        
//        ///     }
//        ///
//        /// </remarks>
//        /// <param name="estoque">Modelo do estoque</param>
//        /// <response code="200">Retorna o estoque recém criado</response>
//        /// <response code="500">Ocorreu algum erro criar o estoque</response>
//        [HttpPost("AdicionarEstoque")]

//        public ActionResult<EstoqueModel> AdicionarEstoque(EstoqueModel estoque)
//        {
//            _listMEContext.Estoque.Add(estoque);
//            _listMEContext.SaveChanges();
//            return Ok(estoque);
//        }

//        //GET ESTOQUE
//        /// <summary>
//        /// Listar todo estoque
//        /// </summary>
//        /// <returns>Lista de estoques criados</returns>
//        /// <response code="404">Não há estoque cadastrado</response>
//        /// <response code="200">Retorna a lista de estoques cadastrados</response>
//        /// <response code="500">Ocorreu algum erro ao obter lista de estoquea cadastrados</response>
//        [HttpGet("RequererTodoEstoque")]
//        public ActionResult<List<EstoqueModel>> RequererTodoEstoque()
//        {
//            var estoque = _listMEContext.Estoque.ToList();
//            if (estoque == null)
//            {
//                return NotFound();
//            }
//            else
//            {
//                return Ok(estoque);
//            }
//        }


//        //PUT ESTOQUE
//        //Necessário entender como será feita a identificação do estoque
//        //Utilizando por enquanto o Id do estoque

//        /// <summary>
//        /// Substitui um estoque a partir de sua Id
//        /// </summary>
//        /// <returns></returns>
//        /// <remarks>  
//        /// Exemplo requisição:
//        ///
//        ///     PUT /api/Estoque/SubstituirEstoque{Id}
//        ///     {
//        ///       
//        ///        }
//        ///        ]
//        ///        
//        ///     }
//        ///
//        /// </remarks>
//        /// <param name="Id">Id do usuário</param>
//        /// <param name="estoque">Modelo do usuário</param>
//        /// <response code="400">Usuário não pode ter sua Id modificada</response>
//        /// <response code="404">Usuário não encontrado</response>
//        /// <response code="204">Usuário substituído</response>
//        [HttpPut("SubstituirEstoque{Id}")]
//        public ActionResult<EstoqueModel> PutEstoque(int Id, EstoqueModel estoque)
//        {
//            if (Id != estoque.Id_Estoque)
//            {
//                return BadRequest();
//            }
//            else
//            {
//                //Substitui valor da instância no banco de dados 
//                _listMEContext.Entry(estoque).State = EntityState.Modified;
//                _listMEContext.SaveChanges();

//                return NoContent();
//            }
//        }

//        /// <summary>
//        /// Delete o estoque a partir de sua Id
//        /// </summary>
//        /// <returns>Retorna o estoque recém deletado</returns>
//        /// <param name="Id">Id do estoque</param>
//        /// <response code="404">estoque não encontrado</response>
//        /// <response code="204">estoque deletado</response>
//        //DELETE ESTOQUE
//        [HttpDelete("DeletarEstoque{Id}")]
//        public ActionResult<EstoqueModel> DeleteEstoque(int Id)
//        {
//            var existeEstoque = _listMEContext.Estoque.Find(Id);
//            if(existeEstoque != null)
//            {
//                _listMEContext.Estoque.Remove(existeEstoque);
//                _listMEContext.SaveChanges();
//                return NoContent();
//            }
//            return NotFound();
//        }
//    }
//}
