
<template>
  <div id="menu-items">
    <div class="header">
      <p class="texto_header"> Sabrina Helena <br> sabrinahelenaf@gmail.com </p>
    </div>
    <nav>
      <ul class="menu">
        <div class="logo">
          <figure>
            <img class="imagem_logo" src="./imagens/icons8-house-96.png">
          </figure>
          <h2 class="titulo_site">ListMe</h2>
        </div>
        <div class="itens">
          <li class="item"><RouterLink to="/home" class="item">Home</RouterLink></li>
          <li class="item">Configurações</li>
          <li class="item subitem"><RouterLink  to="/perfil " class="item" >Perfil</RouterLink></li>
          <li class="item subitem"><RouterLink to="/sobre" class="item" >Residencias</RouterLink></li>
          <li class="item"><RouterLink to="/listacompras" class="item" >Gerenciar Compras</RouterLink></li>
        </div>
      </ul>
    </nav>
  </div>
</template>

<!-- SCRIPT -->
<script>
export default{
  name:`MenuLateral`,
}
</script>



<!-- STYLE -->
<style scoped>

/* HEADER */

.header{
  display: flex;
  justify-content: end;
  background-color: #2E4756;
  color: white;
  width: 2490px;}

.titulo_site{
    margin-left: -30px;
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
}

.texto_header{
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
  text-align: center;
    margin-right: 30px;
    font-size: 12px;
}

.itens{
  margin-left: -10px;
  margin-top: 60px;
}

.logo{
  margin-top: -75px;
  align-items: center;
  margin-left: -60px;
  display: flex;
  flex-direction: row;
}

.imagem_logo{
    width: 50px;
    height: auto;
}

.item{
  font-size: 21px;
  margin-top: 40px;
  text-decoration: none;
  color: white;
  font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;

}

.subitem{
margin-left: 30px;
}
#menu-items{
  position: fixed;
  top:0;
  left:0;
  background-color: #2E4756;
  width: 20%;
  height: 100vh;
  display: flex;
  flex-direction: column;
  justify-content: flex-start;
  text-align: left;
  align-items: center;
}

ul{
  list-style: none;
  text-align: left;
  align-items: left;
  color:white;
}

ul li{
  font-size: 25px;
}

ul li a{
  color:white;
}



</style>