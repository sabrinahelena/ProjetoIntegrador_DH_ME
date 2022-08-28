<template>
  <div id="titulo">
    <div class="y">
      <div class="t">
        <img class="estoqueImagem" src="./imagens/icone-inventario.png">
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
            <li>
              <span class="texto_descricao">PRODUTO
              <button class="botao_editarR " type="button"><img alt="editar" id="editar"
                  src="../assets/mais.png"></button></span>
            </li>
          </ul>
        </main>
        <button v-on:click="Fechar()" class="fechar" type="button"><img class="imagem_fechar"
            src="./imagens/icons8-close-60.png" id="mais-image"></button>
      </div>

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
          <th>{{estoque.produto.nome_Produtos}}</th>
          <td>{{estoque.quantidade_Produto}}</td>
            <td>
              <div id="button-addA">
              <button v-on:click="" class="botao_editarR" type="button"><img alt="mais-image" id="mais-image"
                  src="../assets/pencil.png"></button>
              </div>
            </td>
            <td>
              <div id="button-addA">
              <button v-on:click="" class="botao_editarR" type="button"><img alt="mais-image" id="mais-image"
                  src="./imagens/icons8-remove-60.png"></button>
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
  const {GetById} = new EstoqueService();
export default {
  name: `Residencias`,
  data(){
    return{
      Estoques:[]
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
    },
    Fechar: () => {
      let modal = document.querySelector('.modal')
      modal.style.display = 'none';
      let titulo = document.querySelector('.y')
      titulo.style.display = 'block';
      let resto = document.querySelector('.z')
      resto.style.display = 'block';
    }
  },
  mounted(){
    GetById(1).then(response=>this.Estoques=response);
  }
}
</script>

<style scoped>
.botao_editarR {
    background-color: white;
    border: 3px solid #2E4756;
    border-radius: 12px;
    cursor: pointer;
    

}

#editar{
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