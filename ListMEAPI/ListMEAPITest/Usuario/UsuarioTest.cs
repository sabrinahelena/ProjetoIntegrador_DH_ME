using ListMEAPI.DTOs.Response.Usuario;
using ListMEAPI.Interfaces.Repositorios.Usuario;
using ListMEAPI.Mapper;
using ListMEAPI.Models;
using ListMEAPI.Repositories;
using ListMEAPI.Services;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Data.Entity;
using Xunit;

namespace ListMEAPITest.Usuario
{
    public class UsuarioTest
    {

        

        //[Fact]
        //public IEnumerable<UsuarioModel> usuarioModel()
        //{

        //    return new List<UsuarioModel>()
        //    {
        //       new UsuarioModel ( "teste", "teste", "(00)000000000", "05/05/2015", "teste1@teste.com", "testefoto", "testeteste" ),
        //       new UsuarioModel ( "teste", "teste", "(00)000000000", "05/05/2015", "teste1@teste.com", "testefoto", "testeteste" ),
        //       new UsuarioModel ( "teste", "teste", "(00)000000000", "05/05/2015", "teste1@teste.com", "testefoto", "testeteste" ),
        //       new UsuarioModel ( "teste", "teste", "(00)000000000", "05/05/2015", "teste1@teste.com", "testefoto", "testeteste" ),
        //       new UsuarioModel ( "teste", "teste", "(00)000000000", "05/05/2015", "teste1@teste.com", "testefoto", "testeteste" ),
        //    };

        //}

        [Fact]
        public void Add_Usuario()
        {
            UsuarioModel usuarioModel = new UsuarioModel("teste", "teste", "(00)000000000", "05/05/2015", "teste1@teste.com", "testefoto", "testeteste");

        }

        [Fact]
        public IEnumerable<UsuarioService> usuarioServices()
        {
            return new List<UsuarioService>();
        }

        [Fact]
        public IEnumerable<UsuarioRepository> usuarioRepositories()
        {
            return new List<UsuarioRepository>();
        }
        


        



    }
}