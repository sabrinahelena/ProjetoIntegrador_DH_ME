using ListMEAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMEAPITest.Acesso
{
    public class AcessoTest
    {
        public void GetAcesso()
        {
            AcessoModel novoAcesso = new AcessoModel("teste@teste.com", "senhateste");
        }
    }
}
