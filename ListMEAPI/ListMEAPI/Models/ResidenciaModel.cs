﻿using System.ComponentModel.DataAnnotations;

namespace ListMEAPI.Models
{
    public class ResidenciaModel
    {
        public ResidenciaModel()
        {
            Estoque = new List<EstoqueModel>();
            Lista_Compras = new List<EstoqueModel>();
        }
        public ResidenciaModel(string nome_Residencias, string? descricao_Residencias, string? foto_Residencias)
        {
            Nome_Residencias = nome_Residencias;
            Descricao_Residencias = descricao_Residencias;
            Foto_Residencias = foto_Residencias;
            Estoque = new List<EstoqueModel>();
            Lista_Compras = new List<EstoqueModel>();
        }

        [Key]
        public int Id_Residencias { get; set; }
        public string Nome_Residencias { get; set; }
        public string? Descricao_Residencias { get; set; }
        public string? Foto_Residencias { get; set; }
        public List<EstoqueModel> Estoque { get; set; }
        public List<EstoqueModel> Lista_Compras { get; set; }
        public void AddEstoque(EstoqueModel estoque)
        {
            Estoque.Add(estoque);
        }
        public void AddListaCompras(EstoqueModel lista)
        {
            Lista_Compras.Add(lista);
        }
        
    }
}
