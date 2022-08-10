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
        //LEITURA DO BANCO DE DADOS
        private readonly ListMEContext _context;

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

        public ResidenciaModel ExibirResidencia(int id)
        {
            return _residenciaRepository.GetOneResidencia(id);
        }
        public dynamic Cadastrar(CadastroResidenciaRequest residencia, int id)
        {
            var usuarioRetornado = RetornarUm(id);
            if (usuarioRetornado == null)
            {

                return usuarioRetornado;
            }
            var residenciaNova = new ResidenciaModel(residencia.Nome_Residencias, residencia.Descricao_Residencias, residencia.Foto_Residencias);
            _residenciaRepository.Create(residenciaNova);
            
            usuarioRetornado.AdicionarResidencia(residenciaNova);
            _residenciaRepository.Save();

            return residenciaNova;
        }

        public List<ResidenciaResponse> Listar()
        {
            var list = _residenciaRepository.GetAll();

            return list.Select(c => ResidenciaMapper.From(c)).ToList();
        }

        public bool Deletar(int id)
        {
            return _residenciaRepository.Delete(id);
        }

        ResidenciaModel IResidenciaService.Atualizar(int Id, CadastroResidenciaRequest residenciaAtualizada)
        {
            return _residenciaRepository.Update(Id, residenciaAtualizada); ;
        }

        public void Salvar()
        {
            _residenciaRepository.Save();

        }
    }
}

