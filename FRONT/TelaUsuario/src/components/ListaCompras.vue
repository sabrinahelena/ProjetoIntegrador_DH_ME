<template>
  <div id="titulo">
    <div class="t"> 
     <img class="estoqueImagem" src="./imagens/carrinho-azul.png">
        <h1 class="titulo-estoque"><b>Lista de Compras</b></h1>
        </div>
    <table>
      <thead>
        <th>Produto</th>
        <th>Quantidade</th>
      </thead>
      <tbody>
        <tr v-for="lista in Lista">
          <th>{{lista.produto.nome_Produtos}}</th>
          <td>{{lista.quantidade_Produto}}</td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
import ListaDeComprasService from "../Services/ListaDeComprasService"
const {GetById} = new ListaDeComprasService();
export default {
  name: `ListaCompras`,
  data(){
    return{
      Lista:[]
    }
  },
  mounted(){
    GetById(1).then(response=>this.Lista=response);
  }
}
</script>

<style scoped>

#button-add{
    /* right: 50px; */
    margin-top: 20px;
    top: 150px;
    display: flex;
    position: fixed;
    text-align: center;
    align-items: center;
    font-size: 15px;  
}

#mais-image{
    width: 30px;
}


.add_estoque{
    font-weight: bold;
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
}
.botao_editarR{
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

.t{
  display: flex;
  justify-content: center;
  margin-top: 18px;
}

.titulo-estoque{
  color: #2E4756;
  font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    margin-left: 20px;
    margin-top: 35px;

}
.estoqueImagem{
 width: 70px;
 height: 70px;
 margin-top: 18px;
 
 }

* {
  box-sizing: border-box;
}


table {
  position: fixed;
  margin-top: 200px;
  width: 900px;
  height: 1px;
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

@media(max-width: 750px){
  #button-add{
    /* right: 50px; */
    margin-top: 20px;
    top: 150px;
    display: flex;
    position: fixed;
    text-align: center;
    align-items: center;
    font-size: 15px;
   
}

#mais-image{
    width: 25px;
}


.add_estoque{
  margin-left: 90px;
    font-weight: bold;
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
}
.botao_editarR{
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

.t{
  display: flex;
  justify-content: center;
  margin-top: 18px;
}

.titulo-estoque{
  color: #2E4756;
  font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    margin-left: 10px;
    margin-top: 35px;

}
.estoqueImagem{
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