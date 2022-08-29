
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
                        <label for="Nome">Nome:</label>
                        <input v-model="usuario.nome_Usuario" id="Nome-placeholder" type="text" placeholder="nome usuário"/>
                    </div>
                </li>
                <li class="a">
                    <label for="Email">Email:</label>
                    <input v-model="usuario.email" id="Email" type="email" placeholder="Pegar email do usuario" />
                </li >
                <li class="a">
                    <label for="Data">Data de Aniversário:</label>
                    <input v-model="usuario.data_Nascimento" id="Data" type="date" placeholder="10/20/2000" />  
                </li >
                <li class="a"> 
                    <label for="Telefone">Telefone:</label>
                    <input v-model="usuario.telefone" id="telefone" type="text" placeholder="" />  
                </li>
            </ul> 
        </form>
        <div>
     <button class="editarD" id="EditarNome" type="button"><img alt="abrirEditar" id="edit-button" src="./imagens/icons8-confirm-67.png"></button>
        </div>
            <img class="img" src="./imagens/Online-page-(1).gif"/>

    </div>
  </div>
</template>
<script>
import UsuarioService from '../Services/UsuarioService'
const{ GetById }= new UsuarioService();
export default{
  name:`Perfil`,
  data(){
    return{
        usuario:{
        id_Usuario: null,
        nome_Usuario: null,
        sobrenome: null,
        telefone: null,
        data_Nascimento: null,
        email: null
        }
    }
  },
  mounted(){
    GetById(1).then(response=>this.usuario=response);
    console.log(this.usuario);
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

 .imagemC{
    margin-left: 0px;
    margin-top: 0px;
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
    cursor: pointer;
}

.editarD{
    margin-top: -300px;
    margin-left: 20px;
    background-color: white;
    border: 3px solid #2E4756;
    border-radius: 12px;
    cursor: pointer;
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

@media(max-width: 750px){

.img{
    width: 180px;
    margin-top: -10px;
    margin-left: 60px;
    margin-bottom: 0px;
    
}
.estoqueImagem{
 width: 30px;
 height: 30px;
 margin-left: 50px;
 margin-top: 27px;
 
 }

 .titulo-estoque{
  color: #2E4756;
  font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    margin-left: 20px;
    margin-top: 45px;
    font-size: 20px;

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
  margin-left: 10px;
align-items: center;
}
.form{
    margin-top: 10px;
    border: 3px solid #2E4756;
    width: 300px;
    margin-left: 9s0px;
    height: 450px;
    border-radius: 20px;
}
.a{
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    color: #2E4756;
    font-size: 18px
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
    font-size: 18px;
    
    
}
ul{
    text-align: left;
    list-style: none;
    
    
}
ul li{
    margin: 2px;
    text-align: left;
    margin-left: 50px;
}
#nome-placeholder{
    display: none;
}
#edit-button{
    width: 20px;
    height: 20px;
}
}
</style>
