<template>
    <div id="titulo">
        <img alt="casaImagem" id="imagem-casa" src="../assets/casa.png">
        <h1 id="titulo-residencia"><b>Residências</b></h1>
        <div id="button-add">
            Adicionar residências
            <button type="button"><img alt="mais-image" id="mais-image" src="../assets/mais.png"></button>
        </div>
    </div>
    
    <main>
        <ul>
            <li>
            <button type="button">Nome da residência</button>
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
    width: 35px;
    height: 35px;
    margin-top: 18px;
}
#titulo-residencia{
    margin-left: 20px;
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