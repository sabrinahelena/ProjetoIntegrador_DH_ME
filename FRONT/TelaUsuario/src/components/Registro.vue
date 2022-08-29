<template>

<div class="tela_principal"> 
        <div class="primeiro_bloco"> 
            <div class="alinhamento">
                <h1> Bem-vindo de volta! </h1>
                <div class="texto_primeirobloco">
                    <p> Se você já possui uma conta, autentique-se agora!</p>
                </div>
                <form >
                    <RouterLink to="/redirectLogin">
                        <button type="submit" class="botao_primeirobloco">LOGIN</button>
                    </RouterLink>
                </form>
                <div>
                    <figure class="figure">
                        <img class="imagem" src="./imagens/Privacy-policy-rafiki.png">
                    </figure>
                </div>
            </div>
        </div>
        <div class="segundo_bloco">
            <div class="alinhamento_segundobloco">
            <h1>Cadastre-se</h1>
            <form
                method = "get"
                
                >
                <div>
                    <input 
                    v-model="bodyRegistro.nome_Usuario"
                    class="inputs"
                    id="primeiro-nome"
                    name="primeiro-nome"
                    placeholder="Nome"
                    type="text">
                </div>
                <br>
                <div> 
                    <input 
                    v-model="bodyRegistro.sobrenome"
                    class="inputs"
                    id="last-name"
                    name="last-name"
                    placeholder="Sobrenome"
                    type="text">
                </div>
                <br>

                <div>
                    <input
                    v-model="bodyRegistro.telefone"
                    class="inputs"
                    id="telefone"
                    name="telefone"
                    type="text"
                    placeholder="Telefone">
                </div>
                <br>

                <div>
                    <input 
                    v-model="bodyRegistro.data_Nascimento"
                    class="inputs"
                    id="data-nascimento"
                    name="data-nascimento"
                    type="date"
                    >
                </div>
                <br>

                <div>
                    <input 
                    v-model="bodyRegistro.email"
                    class="inputs"
                    id="email"
                    name="email"
                    type="email"
                    placeholder="Email"
                    >
                </div>
                <br>


                <div>
                    <input 
                    v-model="bodyRegistro.senha"
                    class="inputs"
                    id="senha"
                    name="password"
                    type="password"
                    placeholder="Senha"
                    >
                </div>
                <br>
                
                <a >
                
                   <input v-on:click="PostUsuario(bodyRegistro)  " type="button" class="botao_segundobloco" value="Confirmar" >
                
                </a>
               
            </form>
        </div>
    </div>

</div>

</template>

<script>
import { RouterLink } from "vue-router";
import RegistroService from "../Services/RegistroService"
const {PostRegistro} = new RegistroService();
    export default {
    name: `Registro`,
    data() {
        return {
            bodyRegistro: {
                nome_Usuario : null,
                sobrenome : null,
                telefone : null,
                data_Nascimento : null,
                email : null,
                foto_Perfil:"",
                senha : null
            
            }
        }
    },
    methods: {
        PostUsuario: (bodyRegistro) => {
            PostRegistro(bodyRegistro);
        },
        Teste:()=>{
            
        }

    }
    // let usuario = await response.json();
    // console.log(usuario);
 }
</script>

<style>
    body{
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    background-color: rgb(236, 235, 235);
}

.tela_principal{
    display: flex;
    margin-top: 30px;
    height: 600px;
    justify-content: center;

}

/* PRIMEIRO BLOCO */

.primeiro_bloco{
    color: white;
    width: 550px;
    border: 1px solid black;
    background-color: #2E4756;
    text-align: center;
    border-radius: 20px;
}

.texto_primeirobloco{
    width: 300px;
    margin: auto;
    
}

.alinhamento{
    margin-top: 60px;
}

.imagem{
    width: 350px;
    margin-top: -50px;
}
/*SEGUNDO BLOCO */

.segundo_bloco{
    color: #2E4756;
    width: 550px;
    border: 1px solid black;
    background-color:white;
    text-align: center;
    border-radius: 20px;
    border-color: white;

}

.alinhamento_segundobloco{
    margin-top: 60px;
}



/* GERAL */

.botao_primeirobloco{
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
margin-top: 40px;
cursor: pointer;
}

.botao_primeirobloco:hover{
    transition:all 1s;
    transform: scale(1.1);
}

.botao_segundobloco{
    background-color: #16262E; 
    border-radius: 30px;
    color: white;
    border-color: white;
    padding: 15px 32px;
    text-align: center;
    text-decoration: none;
    font-size: 16px;
    width: auto;
    height: 50px;
    font-weight: bold;
    cursor: pointer;
}

.botao_segundobloco:hover{
        transition:all 1s;
        transform: scale(1.1);
}

.inputs{
    height: 25px;
    border-radius: 5px;
    background-color: rgb(236, 235, 235);
    border-style: none;
}

@media(max-width: 750px){
    body{
        font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
        background-color: rgb(236, 235, 235);
    }
    
    .tela_principal{
        display: flex;
        flex-direction: column;
        margin-top: 30px;
        height: 600px;
        justify-content: center;
        align-items: center;
    
    }
    
    /* PRIMEIRO BLOCO */
    
    .primeiro_bloco{
        margin-top: 10px;
        color: white;
        width: 320px;
        border: 1px solid black;
        background-color: #2E4756;
        text-align: center;
        border-radius: 20px;
    }
    
    .texto_primeirobloco{
        width: 100px;
        margin: auto;
        
    }
    
    .alinhamento{
        margin-top: 300px;
    }
    
    .imagem{
        width: 200px;
        margin-top: -50px;
    }
    /*SEGUNDO BLOCO */
    
    .segundo_bloco{
        color: #2E4756;
        width: 320px;
        border: 1px solid black;
        background-color:white;
        text-align: center;
        border-radius: 20px;
        border-color: white;
    
    }
    
    .alinhamento_segundobloco{
        margin-top: 0px;
    }
    
    
    
    /* GERAL */
    
    .botao_primeirobloco{
    background-color: white; 
    border-radius: 30px;
    color: #16262E;
    border-color: #16262E;
    padding: 12px 15px;
    text-align: center;
    text-decoration: none;
    font-size: 16px;
    width: auto;
    height: 40px;
    font-weight: bold;
    margin-top: 40px;
    cursor: pointer;
    }
    
    .botao_primeirobloco:hover{
        transition:all 1s;
        transform: scale(1.1);
    }
    
    .botao_segundobloco{
        background-color: #16262E; 
        border-radius: 30px;
        color: white;
        border-color: white;
        padding: 12px 15px;
        text-align: center;
        text-decoration: none;
        font-size: 16px;
        width: auto;
        height: 40px;
        font-weight: bold;
        cursor: pointer;
    }
    
    .botao_segundobloco:hover{
            transition:all 1s;
            transform: scale(1.1);
    }
    
    .inputs{
        height: 25px;
        border-radius: 5px;
        background-color: rgb(236, 235, 235);
        border-style: none;
    }

}


</style>