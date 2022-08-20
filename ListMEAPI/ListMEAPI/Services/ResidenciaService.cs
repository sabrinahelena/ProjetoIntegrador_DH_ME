using ListMEAPI.DTOs.Request.Residencia;
using ListMEAPI.DTOs.Response.Residencia;
using ListMEAPI.Interfaces.Repositorios.Residencia;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Mapper;
using ListMEAPI.Models;
using ListMEAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ListMEAPI.Services
{
    public class ResidenciaService : IResidenciaService
    {
        private IResidenciaRepository _residenciaRepository;
        private ValidacaoRepository _validacaoRepository;

        public ResidenciaService(IResidenciaRepository residenciaRepository, ValidacaoRepository validacao)
        {
            _residenciaRepository = residenciaRepository;
            _validacaoRepository = validacao;
        }
        public UsuarioModel RetornarUm(int id)
        {
            var usuarioRetornado = _residenciaRepository.GetUsuario(id);
           
            return usuarioRetornado;
        }
        public void Cadastrar(CadastroResidenciaRequest residencia, int id)
        {

            var residenciaNova = new ResidenciaModel(residencia.Nome_Residencias, residencia.Descricao_Residencias, residencia.Foto_Residencias);
            var usuarioRetornado = _validacaoRepository.FindUsuario(id);
            if(usuarioRetornado == null){ }
            _residenciaRepository.Create(residenciaNova,usuarioRetornado);
          
            
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

        public ResidenciaModel ExibirResidencia(int Id)
        {
            return _residenciaRepository.GetOneResidencia(Id);
        }

        public bool Deletar(int Id)
        {
            var searchResidencia = _validacaoRepository.FindResidencia(Id);
            if (searchResidencia != null)
            {
                _residenciaRepository.Delete(searchResidencia);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

