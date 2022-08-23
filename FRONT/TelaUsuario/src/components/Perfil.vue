
<template>
  <div id="perfil-container">
    
    <form id="Formulario">
        <ul>
            <li>
                <div id="Nome-Input">
                    <label for="Nome">Nome: </label>
                    <input  id="Nome-placeholder" type="text" placeholder="Pegar nome do usuário"/>
                    
                    <button id="EditarNome" type="button"><img alt="abrirEditar" id="edit-button" src="../assets/pencil.png"></button>
                </div>
            </li>
            <li>
                <label for="Email">Email: </label>
                <input id="Email" type="email" placeholder="Pegar email do usuario"/>
            </li>
            <li>
                <label for="Data">Data de Aniversário: </label>
                <input id="Data" type="date" placeholder="10/20/2000" />  
            </li>
            <li>
                <label for="Telefone">Telefone: </label>
                <input id="telefone" type="text" placeholder="11-99999999" />  
            </li>
        </ul> 
    </form>
    
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
#perfil-container{
    position: fixed;
    top: 0;
    right: 0;
    width: 75%;
    height: 100vh;
    display: flex;
    flex-direction: column;
    text-align: center;
    font-size: 25px;
    
    
}
ul{
    text-align: left;
    list-style: none;
    
    
}
ul li{
    margin: 100px 0px;
    text-align: left;
    margin-left: 100px;
}
#nome-placeholder{
    display: none;
}
#edit-button{
    width: 30px;
}
</style>
