<template>
    <div id="titulo">
        <img alt="casaImagem" id="imagem-casa" src="./imagens/icons8-house-90.png">
        <h1 id="titulo-residencia"><b>Residências</b></h1>
        <div id="button-add">
            <span class="add_residencia"> Adicionar residências</span>
            <button v-on:click="Acao()" class="botao_editarR" type="button"><img alt="mais-image" id="mais-image"
                    src="../assets/mais.png"></button>
        </div>
        <div class="modal">
            <h1 class="form-titulo"> Adicione uma residência </h1>
                <div class="form">
                    <form
                    method = "get"
                    action= ""
                    >
                    <div>
                        <input 
                        v-model="ResidenciaBody.nome_Residencias" 
                        class="input-mensagem"
                        id="primeiro-nome"
                        name="primeiro-nome"
                        type="text"
                        placeholder="Nome residência"
                        >
                        
                    </div>
                    <br>
                    <div>
                        <input  
                        v-model="ResidenciaBody.descricao_Residencias"
                        class="input-mensagem"
                        id="mensagem"
                        name="mensagem"
                        type="text"
                        placeholder="Descrição residência"
                        >
                    </div>
                </form>

                    </div>
                
                
                    <button v-on:click="Fechar()" class="fechar" type="button"><img class="imagem_fechar" src="./imagens/icons8-close-60.png" id="mais-image"></button>
                    <button v-on:click="Add(ResidenciaBody);Fechar()"  class="botao_adicionar">Adicionar</button>
                </div>
        <figure>
            <img class="imagem_residencia" src="./imagens/Ordinary day.gif" />
        </figure>
    </div>

    <main class="lista">
        <ul>
            <li v-for="residencia in residencias">

                <button class="botao_residencia" type="button">{{ residencia.nome_Residencias }}</button>
                <span class="texto_descricao">{{ residencia.descricao_Residencias }}</span>
                <button class="botao_editarR a" type="button"><img alt="editar" id="editar"
                        src="../assets/pencil.png"></button>
            </li>

        </ul>
    </main>
</template>

<script>
import ResidenciaService from '../Services/ResidenciaService'
const { GetAll, Post } = new ResidenciaService();

export default {

    name: `Residencias`,
    data() {
        return {
            residencias: [],
            ResidenciaBody:{
                nome_Residencias: "Nome Residência",
                descricao_Residencias: "Descrição Residência",
                foto_Residencias: "null"
            }
        }
    },
    methods: {
        Add: (ResidenciaBody) => {
            Post(ResidenciaBody, 1)
        },
        Acao: () => {
            let modal = document.querySelector('.modal')
            modal.style.display = 'block';
        },
        Fechar: () => {
            let modal = document.querySelector('.modal')
            modal.style.display = 'none';
            
        }
    },
    mounted() {
        GetAll().then(response => this.residencias = response);
    }
}
</script>
<style scoped>
.form-titulo{
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    color: white;
    text-align: center;
    margin-top: 30px
}
.inputs{
    width: 250px;
    border-radius: 4px;
    border-style: none;
    height: 20px;

}

.botao_adicionar{
    margin-left: 180px;
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

.input-mensagem{
    border-radius: 4px;
    width: 250px;
    border-style: none;
    height: 20px;
}

.form{
    margin-top: 150px;
    margin-left: 120px;
}

.fechar {
    background-color: #2E4756;
    width: 30px;
    height: 30px;
    float: right;
    cursor: pointer;
    margin-right: 30px;
    margin-top: 170px;
    border: 1px solid #2E4756;

}

.modal {
    margin-top: 80px;
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

.imagem_residencia {
    margin-left: 300px;
    width: 300px;
    margin-top: 30px
}

.botao_residencia {
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    background-color: #2E4756;
    /* Green */
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


.botao_residencia:hover {
    transition: all 1s;
    transform: scale(0.9);
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

#imagem-casa {
    width: 70px;
    height: 70px;
    margin-top: 18px;
}

#titulo-residencia {
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    margin-left: 20px;
    margin-top: 35px;
    color: #2E4756;
}

#button-add {
    /* right: 50px; */
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

#editar {
    width: 30px;
}

main {
    position: fixed;
    display: flex;
    right: 0;
    width: 70%;
    text-align: left;
    margin-top: 300px;
}

.texto_descricao {
    margin-left: 20px;
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
}

.add_residencia {
    font-weight: bold;
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
}

ul {
    list-style: none;
}

.botao_editarR {
    margin-left: 20px;
    background-color: white;
    border: 3px solid #2E4756;
    border-radius: 12px;
    cursor: pointer;

}
</style>