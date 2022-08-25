<template>
    <div id="titulo">
        <img alt="casaImagem" id="imagem-casa" src="./imagens/icons8-house-90.png">
        <h1 id="titulo-residencia"><b>Residências</b></h1>
        <div id="button-add">
            Adicionar residências
            <button type="button"><img alt="mais-image" id="mais-image" src="../assets/mais.png"></button>
        </div>
    </div>
    
    <main>
        <ul>
            <li>
            <button class="botao_residencia" type="button">Nome da residência</button>
            Descrição
            Tentar fazer de um jeito que crie automaticamente essa li
            <button type="button"><img alt="editar" id="editar" src="../assets/pencil.png"></button>
            </li>
        </ul>
    </main>
</template>

<script>
export default{
    name:`Residencias`,
}
</script>

<style scoped>

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
    right: 50px;
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
ul {
    list-style: none;
}
</style>