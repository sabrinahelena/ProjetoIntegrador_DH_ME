﻿using ListMEAPI.Models;

namespace ListMEAPI.DTOs.Response.Estoque
{
    public class EstoqueResponse
    {
        public int Id_Estoque { get; set; }
        public ProdutosModel Produto { get; set; }   
    }
}
