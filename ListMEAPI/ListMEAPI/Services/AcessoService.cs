using ListMEAPI.DTOs.Request.Login;
using ListMEAPI.DTOs.Response.Login;
using ListMEAPI.Interfaces.Repositorios.Login;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;

namespace ListMEAPI.Services
{
    public class AcessoService : IAcessoService
    {
        private IAcessoRepository _acessoRepository;

        public AcessoService(IAcessoRepository acessoRepository)
        {
            _acessoRepository = acessoRepository;
        }

        //POST

        public void Cadastrar(CadastroAcessoRequest acesso)
        {
            var acessoNovo = new AcessoModel(acesso.usuario, acesso.senha);

            _acessoRepository.Create(acessoNovo);
        }


        //DELETE
        public void Deletar(int id)
        {
            _acessoRepository.Delete(id);
        }

        //GET POR ID

        public AcessoModel ExibirAcesso(int id)
        {
            return _acessoRepository.GetOne(id);
        }


        //GET
        public List<AcessoModel> Listar()
        {
            return _acessoRepository.GetAll();
        }

        //PUT
        public AcessoModel Atualizar(int id, CadastroAcessoRequest acessoAtualizado)
        {
            return _acessoRepository.Update(id, acessoAtualizado);
        }

        //save
        public void Salvar()
        {
            _acessoRepository.Save();

        }
    }
}
