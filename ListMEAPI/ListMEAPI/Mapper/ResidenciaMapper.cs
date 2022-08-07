using ListMEAPI.DTOs.Response;
using ListMEAPI.Models;

namespace ListMEAPI.Mapper
{
    /*
    * O mapper funciona para relacionar o response ao model
    * O DTO armazena os dados, e transferência desses dados é feita no mapper
    */
    public static class ResidenciaMapper
    {
        public static ResidenciaResponse From(ResidenciaModel residencia)
        {
            var dto = new ResidenciaResponse();
            dto.Id_Residencias = residencia.Id_Residencias;
            dto.Descricao_Residencias = residencia.Descricao_Residencias;
            dto.Nome_Residencias = residencia.Nome_Residencias;
            dto.Foto_Residencias = residencia.Foto_Residencias;
       

            return dto;
        }
    }
}
