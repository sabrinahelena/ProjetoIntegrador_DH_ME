﻿using ListMEAPI.DTOs.Request.Residencia;
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
        public dynamic Create(ResidenciaModel residencia)
        {
            _context.Add(residencia);
            _context.SaveChanges();

            return null;
        }

        //GET
        public List<ResidenciaModel> GetAll()
        {
            return _context.Residencias.ToList();
        }

        //GET USUÁRIO POR ID
        public UsuarioModel GetUsuario(int Id)
        {
            var usuarioRequerido = _context.Usuarios.Find(Id);
            return usuarioRequerido;
        }

        //GET RESIDENCIA POR ID
        public ResidenciaModel GetOneResidencia(int Id)
        {
            var residenciaRequerida = _context.Residencias.Find(Id);
            return residenciaRequerida;
        }

        //DELETE
        public bool Delete(int id)
        {
            var result = _context.Residencias.Find(id);
            if (result != null)
            {
                _context.Residencias.Remove(result);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

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
        public void Save()
        {
            _context.SaveChanges();

        }
    }
}
