<template>
    <div id="titulo">
        <img alt="casaImagem" id="imagem-casa" src="./imagens/icons8-house-90.png">
        <h1 id="titulo-residencia"><b>Residências</b></h1>
        <div id="button-add">
            <span class="add_residencia"> Adicionar residências</span>
            <button v-on:click="Add()"  class="botao_editarR" type="button"><img alt="mais-image" id="mais-image" src="../assets/mais.png"></button>
        </div>
        <figure>
            <img class="imagem_residencia" src="./imagens/Ordinary day.gif"/>
        </figure>
    </div>
    
    <main class="lista">
        <ul>
            <li v-for="residencia in residencias">
            <button class="botao_residencia" type="button">{{residencia.nome_Residencia}}</button>
            <span class="texto_descricao">{{residencia.descricao_Residencias}}</span>
            <button class="botao_editarR a" type="button"><img alt="editar" id="editar" src="../assets/pencil.png"></button>
            </li>   
        </ul>
    </main>
</template>

<script>
import ResidenciaService from '../Services/ResidenciaService'
const{ GetAll,Post }= new ResidenciaService();
export default{
    
    name:`Residencias`,
    data(){
        return{
            residencias:[]
        }
    },
    methods:{
        Add: () =>{
            Post({
                nome_Residencias:"TestePost",
                descricao_Residencias:"DescricaoTeste",
                foto_Residencias:"nada",
            },1)
        }
    },
    mounted(){
        GetAll().then(response=>this.residencias=response);
    }
}
</script>

<style scoped>


.imagem_residencia{
    margin-left: 300px;
    width: 300px;
    margin-top: 30px
}
.botao_residencia{
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    background-color: #2E4756; /* Green */
    border-radius: 20px;
    border: none;
    color: white;
    padding: 15px 32px;
    text-align: center;
    text-decoration: none;
    display: inline-block;
    font-size: 16px;
    cursor: pointer;

}


.botao_residencia:hover{
    transition:all 1s;
    transform: scale(0.9);
}
#titulo{
    position: fixed;
    top: 0;
    right: 0;
    width: 70%;
    height: 100vh;
    display: flex;
    text-align: left;
    font-size: 10px;
    margin-top: 50px;
    color:black;
}
#imagem-casa{
    width: 70px;
    height: 70px;
    margin-top: 18px;
}
#titulo-residencia{
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    margin-left: 20px;
    margin-top: 35px;
    color: #2E4756;
}
#button-add{
    /* right: 50px; */
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
#editar{
    width:30px ;
}
main{
    position: fixed;
    display: flex;
    right: 0;
    width: 70%;
    text-align: left;
    margin-top: 300px;
}
.texto_descricao{
    margin-left: 20px;
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
}
.add_residencia{
    font-weight: bold;
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
}
ul {
    list-style: none;
}

.botao_editarR{
    margin-left: 20px;
    background-color: white;
    border: 3px solid #2E4756;
    border-radius: 12px;
    cursor: pointer;

}

</style>