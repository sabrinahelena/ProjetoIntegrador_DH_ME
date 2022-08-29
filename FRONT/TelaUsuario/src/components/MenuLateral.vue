
<template>
  <div id="menu-items">
    <div class="header">
      <p class="texto_header"> Sabrina Helena <br> sabrinahelenaf@gmail.com </p>
    </div>
    <nav>
      <ul class="menu">
        <div class="logo">
          <figure>
            <img class="imagem_logo" src="../assets/icons8-house-96.png">
          </figure>
          <h2 class="titulo_site">ListMe</h2>
        </div>
        <div class="itens">
          <div class="item_home">
              <figure class="figure_logo">
                  <img class="imagem_home" src="../assets/icons8-house-30.png">
              </figure>
              <li class="item home"><RouterLink to="/home" class="item">Home</RouterLink></li>
          </div>
          <div class="item_home">
              <figure class="figure_logo">
                  <img class="imagem_home" src="../assets/icons8-automation-48.png">
              </figure>
            <li class="item home">Configurações</li>
          </div>
          <div class="item_home">
              <figure class="figure_logo">
                <img class="imagem_subitem" src="../assets/profile-user.png">
              </figure>
            <li class="item subitem"><RouterLink  to="/perfil" class="item" >Perfil</RouterLink></li>
          </div>
            <div class="item_home">
              <figure class="figure_logo">
                <img class="imagem_subitem" src="../assets/icons8-real-estate-50.png">
              </figure>
              <li class="item subitem"><RouterLink to="/sobre" class="item" >Residencias</RouterLink></li>
            </div>
              <div class="item_home">
                <figure class="figure_logo">
                <img  class="imagem_home" src="../assets/icons8-warehouse-60.png">
              </figure>
              <li class="item home"><RouterLink to="/estoque" class="item" >Estoque</RouterLink></li>
              </div>
            <div class="item_home">
                <figure class="figure_logo">
                <img class="imagem_home" src="../assets/icons8-buying-48.png">
              </figure>
              <li class="item home"><RouterLink to="/listacompras" class="item" >Compras</RouterLink></li>
            </div>
            
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
  width: 2440px;
    }

.titulo_site{
    font-size: 35px;
    margin-left: -30px;
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
}

.texto_header{
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
  text-align: center;
    margin-right: 80px;
    font-size: 12px;
}

.itens{
  margin-left: -10px;
  margin-top: 60px;
}


.imagem_home{
  width: 30px;
  height: 30px;
}

.imagem_subitem{
  width: 30px;
  height: 30px;
  margin-top: -20px;
  margin-left: 30px;
}

.logo{
  margin-top: -75px;
  align-items: center;
  margin-left: -70px;
  display: flex;
  flex-direction: row;
}

.imagem_logo{
    width: 70px;
    height: auto;
}

.item{
  font-size: 21px;
  text-decoration: none;
  color: white;
  font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;

}

.item:hover{
    background-color: #16262E;
    border-radius: 10px;
    transition:all 1s;
    transform: scale(1.1);
    height: 30px;
}

.subitem{
margin-left: 5px;
}
#menu-items{
display: grid;
grid-template-columns: 200px 1fr;
grid-template-rows: 1fr;
min-height: 100vh;

  position: fixed;
  top:0;
  left:0;
  background-color: #2E4756;
  width: 22%;
  height: 100vh;
  display: flex;
  flex-direction: column;
  justify-content: flex-start;
  text-align: left;
  align-items: center;

}

.home{
  margin-top: 15px;
  margin-left: -25px;
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

.item_home{
  margin-left: -50px;
  display: flex;
  text-align: center;
}

@media(max-width: 750px){

.header{
  display: flex;
  justify-content: end;
  background-color: #2E4756;
  color: white;
  width: 700px;
    }

.titulo_site{
    font-size: 24px;
    margin-left: -35px;
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
}

.texto_header{
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
  text-align: center;
    margin-right: 80px;
    font-size: 11px;
}

.itens{
  margin-left: 10px;
  margin-top: 60px;
}


.imagem_home{
  width: 20px;
  height: 20px;
}

.imagem_subitem{
  width: 20px;
  height: 20px;
  margin-top: -20px;
  margin-left: 0px;
}

.logo{
  margin-top: -75px;
  align-items: center;
  margin-left: 7px;
  display: flex;
  flex-direction: row;
}

.imagem_logo{
    width: 50px;
    height: auto;
}

.item{
  font-size: 18px;
  text-decoration: none;
  color: white;
  font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;

}

.item:hover{
    background-color: #16262E;
    border-radius: 10px;
    transition:all 1s;
    transform: scale(1.1);
    height: 30px;
}

.subitem{
  margin-top: 5px;
margin-left: -25px;
}
#menu-items{
  position: fixed;
  top:0;
  left:0;
  background-color: #2E4756;
  width: 42%;
  height: 100vh;
  display: flex;
  flex-direction: column;
  justify-content: flex-start;
  text-align: left;
  align-items: center;

}

.home{
  margin-top: 15px;
  margin-left: -25px;
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

.item_home{
  margin-left: -50px;
  display: flex;
  text-align: center;
}
}

</style>