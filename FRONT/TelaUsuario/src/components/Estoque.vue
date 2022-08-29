<template>
  <div id="titulo">
    <div class="y">
      <div class="t">
        <img class="estoqueImagem" src="../assets/icone-inventario.png">
        <h1 class="titulo-estoque"><b>Estoque</b></h1>
      </div>
      <div id="button-add">
        <span class="add_estoque"> Adicionar produto</span>
        <button v-on:click="Acao()" class="botao_editarR" type="button"><img alt="mais-image" id="mais-image"
            src="../assets/mais.png"></button>
      </div>
    </div>

    <div class="modal">
      <h1 class="form-titulo"> Adicione um produto </h1>
      <div class="form">
        <main class="lista">
          <ul>

            <li v-for="produto in Produtos">
              <span class="texto_descricao">{{produto.nome_Produtos}}
              <button v-on:click="AddEstoque(1,produto.id_Produtos)" class="botao_editarR " type="button"><img alt="editar" id="editar"
                  src="../assets/mais.png"></button></span>
            </li>
          </ul>
        </main>
        <button v-on:click="Fechar()" class="fechar" type="button"><img class="imagem_fechar"
            src="../assets/icons8-close-60.png" id="mais-image"></button>
      </div>

    </div>

    <div class="popup">
      <form method="get">
        <div>
          <input v-model="bodyAlteracaoEstoque.quantidade_Produto" class="inputs" id="quant" name="quant" required placeholder="Quantidade" type="number">
        </div>
        <br>
        <button v-on:click="FecharPopUp()" class="fecharP" type="button"><img class="imagem_fecharP"
            src="../assets/icons8-close-60.png" id="mais-imageP"></button>
          <button v-on:click="AlterarEstoque(bodyAlteracaoEstoque,estoque.produto.id_Produtos,estoque.id_Estoque)" class="ADD" type="button"><img class="imagemAdd"
          src="../assets/icons8-confirm-67(1).png" id="mais-imageA"></button>
      </form>
    </div>

    <div class="z">
      <table>
        <thead>
          <th>Produto</th>
          <th>Quantidade</th>
          <th>Editar quantidade</th>
          <th>Remover produto</th>
        </thead>
        <tbody>
          <tr v-for="estoque in Estoques">
            <th>{{ estoque.produto.nome_Produtos }}</th>
            <td>{{ estoque.quantidade_Produto }}</td>

            <td>
              <div id="button-addA">
                <button v-on:click="AbrirPopUp(estoque)" class="botao_editarR" type="button"><img alt="mais-image"
                    id="mais-image" src="../assets/pencil.png"></button>
              </div>
            </td>
            <td>
              <div id="button-addA">

              <button v-on:click="RemoveEstoque(estoque.id_Estoque)" class="botao_editarR" type="button"><img alt="mais-image" id="mais-image"
                  src="../assets/icons8-remove-60.png"></button>
              </div>
            </td>
        </tr>
        </tbody>
      </table>
    </div>
  </div>
</template>

<script>
import EstoqueService from "../Services/EstoqueService"
import ProdutoService from "../Services/ProdutoService";
const {GetByIdEstoque, PostEstoque, DeleteEstoque, PatchEstoque} = new EstoqueService();
const {GetAll} = new ProdutoService();
export default {
  name: `Residencias`,
  data(){
    return{
      Estoques:[],
      Produtos:[],
      bodyAlteracaoEstoque:{
        data_Validade:"",
        quantidade_Produto:0
      }
    }
  },
  methods: {
    Acao: () => {
      let modal = document.querySelector('.modal')
      modal.style.display = 'block';
      let titulo = document.querySelector('.y')
      titulo.style.display = 'none';
      let resto = document.querySelector('.z')
      resto.style.display = 'none';
      let popup = document.querySelector('.popup')
      popup.style.display = 'none'
    },
    Fechar: () => {
      let modal = document.querySelector('.modal')
      modal.style.display = 'none';
      let titulo = document.querySelector('.y')
      titulo.style.display = 'block';
      let resto = document.querySelector('.z')
      resto.style.display = 'block';
    },

    AddEstoque:(IdResidencia, IdProduto)=>{
      PostEstoque(IdResidencia, IdProduto);
    },
    RemoveEstoque:(IdEstoque)=>{
      DeleteEstoque(IdEstoque);
    },
    FecharPopUp: () => {
      let popup = document.querySelector('.popup')
      popup.style.display = 'none';
      let titulo = document.querySelector('.y')
      titulo.style.display = 'block';
      let resto = document.querySelector('.z')
      resto.style.display = 'block';
    },

    AbrirPopUp: (estoque) => {
      let popup = document.querySelector('.popup')
      popup.style.display = 'block';
      let titulo = document.querySelector('.y')
      titulo.style.display = 'none';
      let resto = document.querySelector('.z')
      resto.style.display = 'none';
      let modal = document.querySelector('.modal')
      modal.style.display = 'none'
      return estoque;
    },

    AlterarEstoque:(bodyAlteracaoEstoque,IdProduto,IdResidencia)=>{
      PatchEstoque(bodyAlteracaoEstoque,IdProduto,IdResidencia)
    }
  },
  mounted(){
    GetByIdEstoque(1).then(response=>this.Estoques=response);
    GetAll().then(response=>this.Produtos=response);
  }
}
</script>

<style scoped>
.inputs{
  margin-top: 50px;
  margin-left: 60px;
}

.ADD {
  background-color: #2E4756;  
  width: 40px;
  height: 40px;
  float: right;
  cursor: pointer;
  margin-right: 290px;
  margin-top: -15px;
  border: 1px solid #2E4756;

}
.imagem_fecharP{
  width: 30px
}

.imagemAdd{
  width: 56px
}
.fecharP {
  background-color: #2E4756;
  width: 40px;
  height: 40px;
  float: right;
  cursor: pointer;
  margin-right: 20px;
  margin-top: -10px;
  border: 1px solid #2E4756;

}
.botao_editarR {
  background-color: white;
  border: 3px solid #2E4756;
  border-radius: 12px;
  cursor: pointer;


}

#editar {
  width: 25px;
}

.texto_descricao {
  margin-left: 2px;
  font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
  font-size: 18px;
  color: white;
  font-weight: bold;

}

.form-titulo {
  font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
  color: white;
  text-align: center;
  margin-top: 30px
}

.inputs {
  width: 250px;
  border-radius: 4px;
  border-style: none;
  height: 20px;

}

ul {
  list-style: none;
}


.botao_adicionar {
  margin-left: 60px;
  background-color: white;
  border-radius: 30px;
  color: #16262E;
  border-color: #16262E;
  padding: 15px 32px;
  text-align: center;
  text-decoration: none;
  font-size: 16px;
  width: auto;
  height: 50px;
  font-weight: bold;
  cursor: pointer;
  margin-top: 160px;
}

.input-mensagem {
  border-radius: 4px;
  width: 250px;
  border-style: none;
  height: 20px;
}

.form {
  margin-top: 20px;
  margin-left: 10px;
}

.fechar {
  background-color: #2E4756;
  width: 30px;
  height: 30px;
  float: right;
  cursor: pointer;
  margin-right: 40px;
  margin-top: 300px;
  border: 1px solid #2E4756;

}
.popup {
  margin-top: 50px;
  width: 500px;
  height: 500px;
  position: absolute;
  display: none;
  background-color: #2E4756;
  animation: animate;
  animation-duration: 800ms;
  border-radius: 20px;

}


@keyframes animate {
  from {
    opacity: 1;
  }

  from {
    opacity: 0;
  }
}

.modal {
  margin-top: 50px;
  width: 500px;
  height: 500px;
  position: absolute;
  display: none;
  background-color: #2E4756;
  animation: animate;
  animation-duration: 800ms;
  border-radius: 20px;

}

@keyframes animate {
  from {
    opacity: 1;
  }

  from {
    opacity: 0;
  }
}

#button-add {
  /* right: 50px; */
  margin-top: 20px;
  top: 150px;
  display: flex;
  position: fixed;
  text-align: center;
  align-items: center;
  font-size: 15px;

}

#button-addA {
  /* right: 50px; */
  font-size: 15px;

}


#mais-image {
  width: 30px;
}


.add_estoque {
  font-weight: bold;
  font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
}

.botao_editarR {
  margin-left: 20px;
  background-color: white;
  border: 3px solid #2E4756;
  border-radius: 12px;
  cursor: pointer;

}

#titulo {
  position: fixed;
  top: 0;
  right: 0;
  width: 70%;
  height: 100vh;
  display: flex;
  text-align: left;
  font-size: 10px;
  margin-top: 50px;
  color: black;
}

.t {
  display: flex;
  justify-content: center;
  margin-top: 18px;
}

.titulo-estoque {
  color: #2E4756;
  font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
  margin-left: 20px;
  margin-top: 35px;

}

.estoqueImagem {
  width: 70px;
  height: 70px;
  margin-top: 18px;

}

* {
  box-sizing: border-box;
}

table {
  margin-top: 200px;
  width: 900px;
  height: 1px;
  margin-left: -200px;
  border-collapse: collapse;
}

table>thead {
  background-color: #2E4756;
  color: white;
  height: 30px;
}

th,
td {
  text-align: center;
  font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
  height: 1px;
  padding: 5px 10px;
  font-size: 20px;
  border-bottom: 1px solid #2E4756;
}

@media(max-width: 750px) {
  #button-add {
    /* right: 50px; */
    margin-top: 20px;
    top: 150px;
    display: flex;
    position: fixed;
    text-align: center;
    align-items: center;
    font-size: 15px;

  }

  #mais-image {
    width: 25px;
  }


  .add_estoque {
    margin-left: 90px;
    font-weight: bold;
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
  }

  .botao_editarR {
    margin-left: 10px;
    background-color: white;
    border: 3px solid #2E4756;
    border-radius: 12px;
    cursor: pointer;

  }

  #titulo {
    position: fixed;
    top: 0;
    right: 0;
    width: 70%;
    height: 100vh;
    display: flex;
    text-align: left;
    font-size: 9px;
    margin-top: 50px;
    color: black;
  }

  .t {
    display: flex;
    justify-content: center;
    margin-top: 18px;
  }

  .titulo-estoque {
    color: #2E4756;
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    margin-left: 10px;
    margin-top: 35px;

  }

  .estoqueImagem {
    width: 30px;
    height: 30px;
    margin-left: 70px;
    margin-top: 35px;

  }

  * {
    box-sizing: border-box;
  }


  table {
    position: fixed;
    margin-top: 200px;
    width: 200px;
    height: 1px;
    border-collapse: collapse;
    margin-left: 70px;
  }

  table>thead {
    background-color: #2E4756;
    color: white;
    height: 1px;
  }

  th,
  td {
    text-align: center;
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    height: 1px;
    padding: 1px 1px;
    font-size: 11px;
    border-bottom: 1px solid #2E4756;
  }
}
</style>