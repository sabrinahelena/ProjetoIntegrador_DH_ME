using ListMEAPI.DTOs.Response;
using ListMEAPI.Models;

namespace ListMEAPI.Mapper
{
    public class UsuarioMapper
    {
        public static UsuarioResponse From(UsuarioModel usuario)
        {
            var dto = new UsuarioResponse();
            dto.Id_Usuario = usuario.Id_Usuario;
            dto.Nome_Usuario = usuario.Nome_Usuario;

            if (usuario.Residencias != null)
                //SELECT = PERMITE ACESSAR A LISTA DE RESIDENCIAS E GUARDAR NO ENDERECOS
                dto.Residencias = usuario.Residencias.Select(c => ResidenciaMapper.From(c)).ToList();

            return dto;

        }
    }
}
