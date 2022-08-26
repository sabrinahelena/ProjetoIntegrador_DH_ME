
<template>
  <div id="perfil-container">
    
       <div class="t"> 
     <img class="estoqueImagem" src="./imagens/icons8-male-user-96.png">
        <h1 class="titulo-estoque"><b>Perfil</b></h1>

        <div>
     <button class="editarP" id="EditarNome" type="button"><img alt="abrirEditar" id="edit-button" src="../assets/pencil.png"></button>
        </div>
                </div>
    <div class="form">
        <form id="Formulario">
            <ul>
                <li class="a">
                    <div id="Nome-Input">
                        <label for="Nome">Nome: </label>
                        <input  id="Nome-placeholder" type="text" placeholder="Nome usuário"/>
                    </div>
                </li>
                <li class="a">
                    <label for="Email">Email: </label>
                    <input id="Email" type="email" placeholder="Pegar email do usuario"/>
                </li >
                <li class="a">
                    <label for="Data">Data de Aniversário: </label>
                    <input id="Data" type="date" placeholder="10/20/2000" />  
                </li >
                <li class="a"> 
                    <label for="Telefone">Telefone: </label>
                    <input id="telefone" type="text" placeholder="11-99999999" />  
                </li>
            </ul> 
        </form>
            <img class="img" src="./imagens/Online page (1).gif"/>

    </div>
  </div>
</template>
<script>
export default{
  name:`Perfil`,
  data(){
    return{
        nomePlaceholder:true
    }
  }
}
</script>

<style scoped>

.img{
    width: 300px;
    margin-top: -900px;
    margin-left: 650px;
    margin-bottom: 90px;
    
}
.estoqueImagem{
 width: 50px;
 height: 50px;
 margin-top: 27px;
 
 }

 .titulo-estoque{
  color: #2E4756;
  font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    margin-left: 20px;
    margin-top: 35px;
    font-size: 22px;

}

.editarP{
    margin-top: 30px;
    margin-left: 20px;
    background-color: white;
    border: 3px solid #2E4756;
    border-radius: 12px;
    cursor: pointer;;
}
.t{
  display: flex;
  justify-content: center;
  margin-top: 60px;
  margin-left: -800px
}
.form{
    margin-top: 10px;
    border: 3px solid #2E4756;
    width: 600px;
    height: 450px;
    border-radius: 20px;
}
.a{
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    color: #2E4756;
}
body{
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
}
#perfil-container{
    position: fixed;
    top: 0;
    right: 0;
    width: 75%;
    height: 100vh;
    display: flex;
    flex-direction: column;
    text-align: center;
    font-size: 22px;
    
    
}
ul{
    text-align: left;
    list-style: none;
    
    
}
ul li{
    margin: 60px;
    text-align: left;
    margin-left: 100px;
}
#nome-placeholder{
    display: none;
}
#edit-button{
    width: 30px;
    height: 30px;
}
</style>
