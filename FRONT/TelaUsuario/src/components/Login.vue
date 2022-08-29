<template>
    <div class="alinhar">
        <div class="main">
            <div class="primeiro_bloco">
                <figure class="figure_login">
                    <img class="imagem_login" src="./imagens/Privacy policy-rafiki.png">
                </figure>
                <div>
                    <p class="registro_texto"> Não possui uma conta? Registre-se agora!</p>
                    <form action="" > <!-- colocar rota pro registrar --> 
                        <button class="botao_primeirobloco">Registrar</button>
                    </form>
                </div>
            </div>
            <div class="tela_principal">
                <h1 class="titulo">Faça seu login</h1>
                <div class="form">
                    <form method="get">
                        <div>
                            <input v-model="bodyLogin.email" class="inputs" id="email" name="email" required placeholder="Email" type="email">
                        </div>
                        <br>

                        <div>
                            <input v-model="bodyLogin.senha" class="inputs" id="senha" name="senha" required placeholder="Senha" type="password">
                        </div>
                        <br>
                        <a>
                            <input v-on:click="PostAcesso()" type="button" class="botao" value="Confirmar">
                        </a>
                        <div class="checkbox">
                            <input type="checkbox" name="manterlog" id="logado" value="manterlogado">
                            <label for="logado"> Manter-me logado </label>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import LoginService from '../Services/LoginService'
const {PostLogin} = new LoginService();
export default {
    name: `Login`,
    data() {
        return {
            
            bodyLogin: {
                email: "", //retirar isso e substituir por coisas do login
                senha: ""
            }
        }
    },
    methods: {
        PostAcesso: (bodyLogin) => {
            PostLogin(bodyLogin);
        }
    }
}


</script>


<style>
body {
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    background-color: rgb(236, 235, 235);
}

.main {
    display: flex;
    border: 1px solid black;
    margin-top: 100px;
    background-color: #16262E;
    border-radius: 20px;

}

.titulo {
    margin-left: 140px;
    margin-bottom: -15px;
}

.tela_principal {
    border-left: 1px solid rgb(236, 235, 235);
    margin-left: 200px;
    color: white;
    display: flex;
    flex-direction: column;
    text-align: center;
    width: 500px;
    height: 500px;
}

.form {
    margin-left: 150px;
    margin-top: 90px;
}

.botao {
    margin-top: 50px;
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
}

.botao:hover {
    transition: all 1s;
    transform: scale(1.1);
}

.checkbox {

    margin-top: 30px;
}

.inputs {
    height: 25px;
    border-radius: 5px;
    border-style: none;
    width: 200px;
}

.imagem_login {
    margin-left: 100px;
    width: 350px;
}

.primeiro_bloco {
    display: flex;
    flex-direction: column;
}

.botao_primeirobloco {
    margin-left: 240px;
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
}

.botao_primeirobloco:hover {
    transition: all 1s;
    transform: scale(1.1);
}

.registro_texto {
    color: white;
    margin-top: -10px;
    margin-left: 150px;
}

@media(max-width: 750px) {
    .main {
        justify-content: center;
        display: flex;
        border: 1px solid black;
        margin-top: 0px;
        background-color: #16262E;
        border-radius: 20px;
        flex-direction: column;
        width: 300px;
        height: 900px;

    }

    .alinhar {
        margin-left: 50px;

    }

    .titulo {
        margin-top: 50px;
        font-size: 20px;
        width: 300px;
        margin-left: 100px;
        margin-bottom: 0px;
    }

    .tela_principal {
        border-top: 1px solid rgb(236, 235, 235);
        margin-left: -100px;
        color: white;
        display: flex;
        flex-direction: column;
        text-align: center;
        width: 250px;
        height: 500px;
    }

    .form {
        margin-left: 150px;
        margin-top: 90px;
    }

    .botao {
        margin-top: 50px;
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
        cursor: pointer;
        margin-left: 50px;
    }

    .botao:hover {
        transition: all 1s;
        transform: scale(1.1);
    }

    .checkbox {
        width: 200px;
        margin-top: 30px;
    }

    .inputs {
        height: 25px;
        border-radius: 5px;
        border-style: none;
        width: 200px;
    }

    .imagem_login {
        margin-left: 10px;
        width: 200px;
    }

    .primeiro_bloco {
        display: flex;
        flex-direction: column;
    }

    .botao_primeirobloco {
        margin-left: 100px;
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
        cursor: pointer;
        margin-bottom: 30px;
    }

    .botao_primeirobloco:hover {
        transition: all 1s;
        transform: scale(1.1);
    }

    .registro_texto {
        color: white;
        margin-top: -10px;
        margin-left: 0px;
        text-align: center;

    }


}
</style>