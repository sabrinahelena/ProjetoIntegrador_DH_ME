﻿using ListMEAPI.DTOs.Request.Produtos;
using ListMEAPI.Models;

namespace ListMEAPI.Interfaces.Servicos
{
    public interface IProdutosService
    {
        bool Criar(CadastroProdutosRequest produto); //POST
        bool DeleteProduto(int Id); //Delete
        List<ProdutosModel> GetEstoque();
        ProdutosModel AlterarProduto(int IdProduto, CadastroProdutosRequest alteracoes);
    }
}
