using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListMEAPI.Controllers.TelaGerenciarCompras
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstoqueController : ControllerBase
    {
        public IEstoqueService _estoqueService;
        public EstoqueController(IEstoqueService estoqueService)
        {
            _estoqueService = estoqueService;
        }

        /// <summary>
        /// Cadastra um novo produto no estoque da casa
        /// </summary>
        /// <returns>Retorna o Ok ou BadRequest</returns>
        /// <remarks>
        /// Exemplo requisição:
        ///     IdResidência:0;  
        ///     IdProduto:0;
        /// </remarks>
        /// <param name="usuario">Modelo do usuário</param>
        /// <response code="200">Retorna se foi adicionado o produto no estoque</response>
        /// <response code="500">Ocorreu algum erro ao colocar um produto no estoque</response>
        [HttpPost("AdicionarEstoquePorIdResidencia{IdResidencia}")]
        public ActionResult CriarEstoque(int IdResidencia, int IdProduto)
        {
            var boolean = _estoqueService.Criar(IdResidencia, IdProduto);
            if (boolean)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Listar todos os estoques
        /// </summary>
        /// <returns>Lista de usuários cadastrados</returns>
        /// <response code="404">Não há estoques cadastrados</response>
        /// <response code="200">Retorna a lista de estoques cadastrados</response>
        /// <response code="500">Ocorreu algum erro ao obter lista de estoques cadastrados</response>
        [HttpGet("ListarTodosEstoques")]
        public List<EstoqueModel> GetEstoque()
        {
            return _estoqueService.GetEstoque();
        }

        /// <summary>
        /// Retorna os estoques encontrados a partir da Id da residência
        /// </summary>
        /// <returns>Retorna todos os estoques encontrado a partir da Id da residência</returns>
        /// <param name="Id">Id da residência</param>
        /// <response code="404">Residência não encontrada ou não há produtos no estoque dessa residência</response>
        /// <response code="200">Retorna todos os estoques da residência encontrada</response>
        [HttpGet("RequererEstoquePorIdResidencia{IdResidencia}")]
        public ActionResult<List<EstoqueModel>> GettEstoqueByIdResidencia(int IdResidencia)
        {
            var Existe = _estoqueService.GetEstoquePorIdResidencia(IdResidencia);
            if (Existe == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(Existe);
            }
        }

        /// <summary>
        /// Delete um estoque a partir de sua Id
        /// </summary>
        /// <returns>Retorna se o estoque foi deletado ou não</returns>
        /// <param name="Id">Id do estoque</param>
        /// <response code="404">Estoque não encontrado</response>
        /// <response code="204">Estoque deletado</response>
        [HttpDelete("DeletarEstoquePorId{Id}")]
        public ActionResult DeletarEstoque(int Id)
        {
            var boolean = _estoqueService.DeleteEstoque(Id);
            if (boolean)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Altera atributos de um estoque a partir de sua Id e do Id do produto
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Exemplo requisição:
        ///
        ///     Patch /api/Estoque/AlterarQuantidadeOuData{Id}
        ///     {    
        ///         "Data_Validade": "01/01/2030",
        ///         "Quantidade_Produto": 10
        ///     }
        /// </remarks>
        /// <param name="IdProduto">Id do produto</param>
        /// <param name="IdResidencia">Id do estoque</param>
        /// <param name="produtos">Modelo das alterações do estoque</param>
        /// <response code="400">Estoque não pode ter quantidade negativa</response>
        /// <response code="404">Estoque ou produto não encontrado</response>
        /// <response code="204">Estoque alterado</response>
        [HttpPatch("AtualizarEstoque{IdProduto}/{IdEstoque}")]
        public ActionResult<EstoqueModel> AlterarQuantidadeOuData(AlterarQuantidadeEDataRequest produtos, int IdProduto, int IdResidencia)
        {
            var existe = _estoqueService.AlterarProdutoNoEstoque(produtos, IdProduto, IdResidencia);
     
            if (existe != null)
            {
                return Ok(existe);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
