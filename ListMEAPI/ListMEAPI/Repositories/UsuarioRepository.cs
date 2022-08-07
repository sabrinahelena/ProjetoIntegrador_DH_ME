﻿using ListMEAPI.Interfaces.Repositorios;
using ListMEAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ListMEAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        //LEITURA DO BANCO DE DADOS
        private readonly ListMEContext _context;

        public UsuarioRepository(ListMEContext ctx)
        {
            //INSERÇÃO NO BANCO DE DADOS
            _context = ctx;
        }

        public void Create(UsuarioModel usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
        }

        //DELETE
        public void Delete(int id)
        {
            var result = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(result);
            _context.SaveChanges();

        }

        public List<UsuarioModel> GetAll()
        {
            return _context.Usuarios.Include(i => i.Residencias).ToList();
        }
        /*
         * 
         * PUXA USUÁRIO SEM RESIDENCIA
         */
        public UsuarioModel GetOne(int id)
        {
            //var requerimento = _context.Usuarios.Find(id);
            var result = _context.Usuarios.Include(i => i.Residencias).Where(i => i.Id_Usuario == id).FirstOrDefault();
            return result;
        }

        public void Update(int id, UsuarioModel usuario)
        {
            if (id != usuario.Id_Usuario)
            {
                _context.Entry(usuario).State = EntityState.Modified;

                _context.SaveChanges();
            }
        }

        //public ActionResult SubstituirUsuarioPelaId(int Id, UsuarioModel usuario)
        //{
        //    if (Id != usuario.Id_Usuario)
        //    {
        //        return BadRequest();
        //    }
        //    if (Id == usuario.Id_Usuario)
        //    {
        //        //Substitui valor da instância no banco de dados 
        //        _listMEContext.Entry(usuario).State = EntityState.Modified;
        //        _listMEContext.SaveChanges();

        //        return NoContent();
        //    }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

