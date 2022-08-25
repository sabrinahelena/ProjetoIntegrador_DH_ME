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
        public dynamic Cadastrar(CadastroResidenciaRequest residencia, int id)
        {

            var residenciaNova = new ResidenciaModel(residencia.Nome_Residencias, residencia.Descricao_Residencias, residencia.Foto_Residencias,id);
            var usuarioRetornado = _validacaoRepository.FindUsuario(id);
            if(usuarioRetornado == null){
                return null;
            }
            _residenciaRepository.Create(residenciaNova,usuarioRetornado);

            return usuarioRetornado;
            
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

        ResidenciaModel IResidenciaService.Atualizar(int id, CadastroResidenciaRequest residenciaAtualizada)
        {
            return _residenciaRepository.Update(id, residenciaAtualizada);
        }

        public List<ResidenciaModel> ListarResidenciasDoUsuario(int IdUsuario)
        {
            return _residenciaRepository.GetAllResidenciasFromUsuario(IdUsuario);
        }

        public ResidenciaModel AlterarResidencia(PatchResidencialRequest alteracoes, int IdResidencia)
        {
            var searchResidencia = _validacaoRepository.FindResidencia(IdResidencia);
            if (searchResidencia != null)
            {
                _residenciaRepository.Patch(searchResidencia, alteracoes);
                return searchResidencia;
            }
            else
            {
                return null;
            }
        }
    }
}

