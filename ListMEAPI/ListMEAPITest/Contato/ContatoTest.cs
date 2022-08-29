using ListMEAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMEAPITest.Contato
{
    public class ContatoTest
    {
        

        [Fact]
        public void Add_Contato()
        {
            ContatoModel novoContato = new ContatoModel("teste", "teste1@teste.com", "testeteste");
        }


    

        [Fact]
        public void Return_Contato()
        {
            Assert.True(true);
        }
    }
}
