﻿using ListME.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstoqueController : ControllerBase
    {
        private ListMEContext _listMEContext = new ListMEContext();

        [HttpGet("ExibirTodoEstoque")]

        public ActionResult<List<Estoque>> RequererTodosEstoque()
        {
            var ListaEstoque = _listMEContext.Produtos_ListaDeCompras.ToList();
            if (ListaEstoque == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(ListaEstoque);
            }
        }

        [HttpGet("ExibirEstoque{Id}")]

        public ActionResult<Estoque> RequererItemEstoque(int Id)
        {
            //Usei find para localizar um usuário pelo ID
            var estoque = _listMEContext.Estoque.Find(Id);
            if (estoque == null)
            {
                return NotFound(); //Se não houver usuário no Id, retorna esse código
            }
            else
            {
                return Ok(estoque);
            }
        }

        [HttpPost("AdicionarProdutoAoEstoque")] //PRODUTOS PUXA ROTA CASO QUEIRA ADD AO ESTOQUE

        public Estoque AdicionarAoEstoque(Estoque estoque)
        {
            try
            {
                _listMEContext.Estoque.Add(estoque);
                _listMEContext.SaveChanges();

            }
            catch
            {

            }

            return estoque;
        }

        /// <summary>
        /// Deletar um produto do estoque a partir da sua Id
        /// </summary>
        /// <returns>Retorna o produto recém deletado do estoque</returns>
        /// <param name="Id">Id do produto</param>
        /// <response code="201">Retorna o produto recém deletado do estoque</response>
        /// <response code="404">produto não encontrado</response>
        /// <response code="204">produto deletado</response>
        /// <response code="500">Ocorreu algum erro ao deletar o produto</response>
        [HttpDelete("DeletarProdutoEstoque{Id}")]

        public ActionResult<Estoque> DeleteItemEstoquePelaId(int Id)
        {
            var estoque = _listMEContext.Estoque.Find(Id);
            if (estoque == null)
            {
                return NotFound();
            }
            else
            {
                _listMEContext.Estoque.Remove(estoque);
                _listMEContext.SaveChanges();
                return NoContent();
            }

        }
        //PARTE SABRINA

        /// <summary>
        /// Substitui produto do estoque a partir de seu Id
        /// </summary>
        /// <returns>Retorna produto substituído</returns>
        /// <remarks>
        ///     Exemplo requisição:
        ///
        ///     PUT /SubstituirProdutoEstoque{Id}
        ///{
        /// "id_Estoque": 0,
        /// "data_Validade": "string",
        /// "quantidade_Estoque": 0,
        /// "produtos": [
        ///  {
        ///    "id_Produtos": 0,
        ///    "nome_Produtos": "string",
        ///    "descricao_Produtos": "string",
        ///    "preco": 0,
        ///    "quantidade_Produtos": 0
        ///  }
        /// ]
        ///  }
        /// </remarks>
        /// <param name="Id">Id do estoque</param>
        /// <param name="Estoque">Modelo do estoque</param>
        /// <response code="400">Estoque não pode ter sua Id modificada</response>
        /// <response code="404">Estoque não encontrado</response>
        /// <response code="204">Estoque substituído</response>
        [HttpPut("SubstituirProdutoEstoque{Id}")]

        public ActionResult SubstituirPelaIdEstoque(int Id, Estoque Estoque)
        {
            if (Id != Estoque.Id_Estoque)
            {
                return BadRequest();
            }
            else
            {
                //Substitui valor da instância no banco de dados 
                _listMEContext.Entry(Estoque).State = EntityState.Modified;
                _listMEContext.SaveChanges();

                return NoContent();
            }

        }
    }
}
