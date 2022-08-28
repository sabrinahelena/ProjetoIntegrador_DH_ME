<template>
  <div id="titulo">
    <div class="y">
      <div class="t">
        <img class="estoqueImagem" src="./imagens/carrinho-azul.png">
        <h1 class="titulo-estoque"><b>Lista de Compras</b></h1>
      </div>
      <div id="button-add">
        <span class="add_estoque"> Adicionar produto</span>
        <button v-on:click="Acao()" class="botao_editarR" type="button"><img alt="mais-image" id="mais-image"
            src="../assets/mais.png"></button>
      </div>
    </div>
    <div class="popup">
      <form method="get">
        <div>
          <input class="inputs" id="quant" name="quant" required placeholder="Quantidade" type="number">
        </div>
        <br>
        <button v-on:click="FecharPopUp()" class="fecharP" type="button"><img class="imagem_fecharP"
            src="./imagens/icons8-close-60.png" id="mais-imageP"></button>
          <button v-on:click="" class="ADD" type="button"><img class="imagemAdd"
          src="./imagens/icons8-confirm-67 (1).png" id="mais-imageA"></button>
      </form>

    </div>
    <div class="modal">
      <h1 class="form-titulo"> Adicione um produto </h1>
      <div class="form">
        <main>
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
    <div class="x">
      <table>
        <thead>
          <th>Produto</th>
          <th>Quantidade</th>
          <th>Editar quantidade</th>
          <th>Remover produto</th>
        </thead>
        <tbody>
          <tr>
            <th>Maçã</th>
            <td>3</td>
            <td>
              <div id="button-addA">
                <button v-on:click="AbrirPopUp()" class="botao_editarR" type="button"><img alt="mais-image"
                    id="mais-image" src="../assets/pencil.png"></button>
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
export default {
  name: `ListaCompras`,
  methods: {
    Acao: () => {
      let modal = document.querySelector('.modal')
      modal.style.display = 'block';
      let titulo = document.querySelector('.y')
      titulo.style.display = 'none';
      let resto = document.querySelector('.x')
      resto.style.display = 'none';
      let popup = document.querySelector('.popup')
      popup.style.display = 'none'
    },
    AbrirPopUp: () => {
      let popup = document.querySelector('.popup')
      popup.style.display = 'block';
      let titulo = document.querySelector('.y')
      titulo.style.display = 'none';
      let resto = document.querySelector('.x')
      resto.style.display = 'none';
      let modal = document.querySelector('.modal')
      modal.style.display = 'none'
    },
    Fechar: () => {
      let modal = document.querySelector('.modal')
      modal.style.display = 'none';
      let titulo = document.querySelector('.y')
      titulo.style.display = 'block';
      let resto = document.querySelector('.x')
      resto.style.display = 'block';
      let z = document.querySelector('.z')
      z.style.display = 'block';
    },
    FecharPopUp: () => {
      let popup = document.querySelector('.popup')
      popup.style.display = 'none';
      let titulo = document.querySelector('.y')
      titulo.style.display = 'block';
      let resto = document.querySelector('.x')
      resto.style.display = 'block';
      let z = document.querySelector('.z')
      z.style.display = 'block';
    }
  }
}
</script>

<style scoped>

.imagem_fecharP{
  width: 30px
}
.imagemAdd{
  width: 56px
}
.inputs{
  margin-top: 50px;
  margin-left: 60px;
}
.botao_editarR {
  background-color: white;
  border: 3px solid #2E4756;
  border-radius: 12px;
  cursor: pointer;
  margin-left: 4px;
}

#editar {
  width: 25px;
}


ul {
  list-style: none;
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
.popup {
  margin-top: 200px;
  margin-left: 200px;
  width: 400px;
  height: 120px;
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

#mais-image {
  width: 30px;
}


.add_estoque {
  font-weight: bold;
  font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
}

.botao_editarR {
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
  margin-left: -300px;
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
    margin-left: 60px;
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
    margin-left: 55px;
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