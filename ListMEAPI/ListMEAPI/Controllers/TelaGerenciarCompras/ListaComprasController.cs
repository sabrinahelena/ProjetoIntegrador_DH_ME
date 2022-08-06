﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ListMEAPI.Models;

namespace ListMEAPI.Controllers.TelaGerenciarCompras
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListaComprasController : ControllerBase
    {
        private ListMEContext _listMEContext = new ListMEContext();

        //GET LISTACOMPRAS
        //PUT LISTACOMPRAS
        //POST LISTACOMPRAS
        //DELETE LISTACOMPRAS

        [HttpPost("AdicionarListaDeCompras")]

        public ActionResult<ListaComprasModel> AdicionarListaDeCompras(ListaComprasModel listaCompras)
        {
            _listMEContext.ListaCompras.Add(listaCompras);
            _listMEContext.SaveChanges();
            return Ok(listaCompras);
        }


        [HttpGet("ExibirTodasListasDeCompras")]

        public ActionResult<List<ListaComprasModel>> RequererTodasListasDeCompras()
        {
            var ListaCompras = _listMEContext.ListaCompras.ToList();
            if (ListaCompras == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(ListaCompras);
            }

        }


        [HttpGet("ExibirLisaDeProdutos{Id}")]

        public ActionResult<ListaComprasModel> RequererUmaListaDeCompras(int Id)
        {
            //Usando find para localizar uma lista pelo ID
            var residencia = _listMEContext.ListaCompras.Find(Id);
            if (residencia == null)
            {
                return NotFound(); //Se não houver lista com essa Id, retorna esse código
            }
            else
            {
                return Ok(residencia);
            }
        }

        [HttpPut("SubstituirListaDeCompras{Id}")]

        public ActionResult SubstituirPelaIdResidencia(int Id, ListaComprasModel ListaDeCompras)
        {
            if (Id != ListaDeCompras.Id_ListaDeCompras)
            {
                return BadRequest();
            }
            else
            {
                //Substitui valor da instância no banco de dados 
                _listMEContext.Entry(ListaDeCompras).State = EntityState.Modified;
                _listMEContext.SaveChanges();

                return NoContent();
            }

        }



        [HttpDelete("DeletarListaDeCompras{Id}")]

        public ActionResult<ListaComprasModel> DeletarListaDecomprasPelaId(int Id)
        {
            var listaDecompras = _listMEContext.ListaCompras.Find(Id);
            if (listaDecompras == null)
            {
                return NotFound();
            }
            else
            {
                _listMEContext.ListaCompras.Remove(listaDecompras);
                _listMEContext.SaveChanges();
                return NoContent();
            }

        }



       
    }


}
