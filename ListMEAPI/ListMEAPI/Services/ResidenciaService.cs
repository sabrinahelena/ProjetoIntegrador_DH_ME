using ListMEAPI.DTOs.Request.Residencia;
using ListMEAPI.DTOs.Response.Residencia;
using ListMEAPI.Interfaces.Repositorios.Residencia;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Mapper;
using ListMEAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListMEAPI.Services
{
    public class ResidenciaService : IResidenciaService
    {
        private IResidenciaRepository _residenciaRepository;

        public ResidenciaService(IResidenciaRepository residenciaRepository)
        {
            _residenciaRepository = residenciaRepository;
        }
        public UsuarioModel RetornarUm(int id)
        {
            var usuarioRetornado = _residenciaRepository.GetUsuario(id);
           
            return usuarioRetornado;
        }
        public void Cadastrar(CadastroResidenciaRequest residencia, int id)
        {

            var residenciaNova = new ResidenciaModel(residencia.Nome_Residencias, residencia.Descricao_Residencias, residencia.Foto_Residencias);
            _residenciaRepository.Create(residenciaNova);
            var usuarioRetornado = RetornarUm(id);
            usuarioRetornado.AdicionarResidencia(residenciaNova);
            _residenciaRepository.Save();

        }

        public List<ResidenciaResponse> Listar()
        {
            var list = _residenciaRepository.GetAll();

            return list.Select(c => ResidenciaMapper.From(c)).ToList();
        }

        public void Salvar()
        {
            _residenciaRepository.Save();

        }
    }
}

