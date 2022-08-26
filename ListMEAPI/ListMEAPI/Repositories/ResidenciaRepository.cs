using ListMEAPI.DTOs.Request.Residencia;
using ListMEAPI.Interfaces.Repositorios.Residencia;
using ListMEAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.Repositories
{
    public class ResidenciaRepository : IResidenciaRepository
    {
        //LEITURA DO BANCO DE DADOS
        private readonly ListMEContext _context;

        public ResidenciaRepository(ListMEContext ctx)
        {
            //INSERÇÃO NO BANCO DE DADOS
            _context = ctx;
        }

        //POST
        public void Create(ResidenciaModel residencia, UsuarioModel usuario)
        {
            usuario.AdicionarResidencia(residencia);
            _context.Add(residencia);
            _context.SaveChanges();
        }

        //GET
        public List<ResidenciaModel> GetAll()
        {
            
            return _context.Residencias.ToList();
        }

        //GET ALL RESIDENCIAS DE UM USUÁRIO
        public List<ResidenciaModel> GetAllResidenciasFromUsuario(int IdUsuario)
        {
            return _context.Residencias.Where(i => i.Id_Usuario == IdUsuario).ToList();
        }

        //DELETE
        public void Delete(ResidenciaModel residencia)
        {
           
            _context.Residencias.Remove(residencia);
            _context.SaveChanges();

        }

        //PUT
        public ResidenciaModel Update(int Id, CadastroResidenciaRequest residenciaAtualizada)
        {
            ResidenciaModel residenciaAntiga = _context.Residencias.Find(Id);
            if (residenciaAntiga != null)
            {
                residenciaAntiga.Nome_Residencias = residenciaAtualizada.Nome_Residencias;
                residenciaAntiga.Descricao_Residencias = residenciaAtualizada.Descricao_Residencias;
                residenciaAntiga.Foto_Residencias = residenciaAtualizada.Foto_Residencias;
                
                _context.SaveChanges();
                return residenciaAntiga;
            }
            return residenciaAntiga;
        }
        
        //PATCH
        public ResidenciaModel Patch(ResidenciaModel residencia, PatchResidencialRequest alteracoes)
        {
            residencia.Nome_Residencias = alteracoes.Nome_Residencia;
            residencia.Descricao_Residencias = alteracoes.Descricao_Residencia;
            _context.SaveChanges();
            return residencia;
        }
    }
}
