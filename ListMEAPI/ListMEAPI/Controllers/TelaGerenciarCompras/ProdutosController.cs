using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListMEAPI.Controllers.TelaGerenciarCompras
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        public IProdutosService _produtosService;

        public ProdutosController(IProdutosService produtosService)
        {
            _produtosService = produtosService;
        }

        //ADICIONAR MAIS PRODUTOS
        /// <summary>
        /// Cadastra um novo produto
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Exemplo requisição:
        ///
        ///     POST /api/Produtos/CadastrarProduto
        ///     {
        ///        "nome_Produtos": "Leite",
        ///        "descricao_Produtos": "Leite em caixa",
        ///        "preco": "10"
        ///     }
        ///
        /// </remarks>
        /// <param name="produto">Modelo do produto</param>
        /// <response code="200">Produto foi cadastrado com seucesso</response>
        /// <response code="500">Ocorreu algum erro ao criar o produto</response>
        [HttpPost("Adicionar Produto Ao Sistema")]
        public ActionResult<ProdutosModel> CadastrarProduto(CadastroProdutosRequest produto)
        {
            _produtosService.Criar(produto);
            return Ok();
        }

        /// <summary>
        /// Listar todos os produtos
        /// </summary>
        /// <returns>Lista de produtos solicitados</returns>
        /// <response code="404">Não há podutos cadastradas</response>
        /// <response code="200">Retorna a lista de produtos cadastrados</response>
        /// <response code="500">Ocorreu algum erro ao obter lista de produtos cadastrados</response>
        [HttpGet]
        public ActionResult<List<ProdutosModel>> GetAll()
        {
            return Ok(_produtosService.GetEstoque());
        }

        /// <summary>
        /// Retorna produto encontrado a partir de sua Id
        /// </summary>
        /// <returns>Retorna a residência encontrada a partir da Id</returns>
        /// <param name="IdProduto">Id do produto</param>
        /// <response code="404">Produto não encontrada</response>
        /// <response code="200">Retorna produto encontrado</response>
        [HttpDelete("Delete por Id {IdProduto}")]
        public ActionResult DeleteProduto(int IdProduto)
        {
            var boolean = _produtosService.DeleteProduto(IdProduto);
            if (boolean)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        //PUT PARA USUÁRIO E RESIDÊNCIA
        /// <summary>
        /// Substitui um produto a partir de sua Id
        /// </summary>
        /// <returns></returns>
        /// <remarks>  
        /// Exemplo requisição:
        ///
        ///     PUT /api/GerenciarUsuario/SubstituirUsuario{Id}
        ///     {
        ///        "nome_Produtos": "Leite Desnatado",
        ///        "Descriocao_Produtos": "Leite Desnatado em caixa",
        ///        "preco": "20",
        ///        
        ///     }
        ///
        /// </remarks>
        /// <param name="IdProduto">Id do produto</param>
        /// <param name="alteracoes">Modelo das alteracoes do produto</param>
        /// <response code="400">Produto não pode ter sua Id modificada</response>
        /// <response code="404">Produto não encontrado</response>
        /// <response code="204">Produto substituído</response>
        [HttpPut("Alterar Produto")]
        public ActionResult<ProdutosModel> AlterarProduto(int IdProduto, CadastroProdutosRequest alteracoes)
        {
            var existe = _produtosService.AlterarProduto(IdProduto, alteracoes);
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
