using ListMEAPI.DTOs.Request.Contato;
using ListMEAPI.Interfaces.Repositorios.Contato;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;

namespace ListMEAPI.Services
{
    public class ContatoService : IContatoService
    {
        private IContatoRepository _contatoRepository;

        public ContatoService(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
        public dynamic Cadastrar(CadastroContatoRequest contato)
        {
            var contact = new ContatoModel(contato.Nome, contato.Email, contato.Mensagem);

            _contatoRepository.Create(contact);
            return contact;
        }

        public void Deletar(int id)
        {
            _contatoRepository.Delete(id);
        }

        public ContatoModel ExibirContato(int id)
        {
            return _contatoRepository.GetOne(id);
        }

        public List<ContatoModel> Listar()
        {
            return _contatoRepository.GetAll();
        }

        public void Salvar()
        {
            _contatoRepository.Save();
        }
    }
}
