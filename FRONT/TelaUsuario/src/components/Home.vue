<template>
       <div id="pagina">
        <div class="main"> 
            <figure>
                <img class="imagem" src="../assets/Frozen-food.gif">
            </figure>
                <div class="texto">
                    <p class="fonte titulo"> Seja bem-vindo ao ListME!</p>
                    <DIV class="texto_main">
                        <p class="fonte b">Para adicionar ou selecionar uma residência, clique em "Residências" dentro de Configurações no menu à esquerda.</p>
                        <p class="fonte a">Dentro de sua residência, você poderá gerenciar seu estoque e sua lista de compras através da função "Gerenciar compras" no menu à esquerda.</p>
                    </DIV>
            </div>
        </div>
       </div>
</template>

<script>
export default{
    name:`Home`,
}
</script>

<style scoped>

.texto_main{
    display: flex;
    margin-top: 10px;
    border: 2px solid #2E4756;
    border-radius: 20px;
    width: 550px;
    margin-left: 110px;
    flex-direction: column;
}
.imagem{
    margin-left: -70px;
    width: 300px;
}
.main{
    display: flex;
    margin-top: 200px;
}

.texto{
    margin-top: -100px;
    margin-left: -100px;
    display: flex;
    flex-direction: column;
    text-align: center;
    justify-content: center;
}
.fonte{
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    font-size: 19px;
}
#pagina{
    position: fixed;
    top: 0;
    right: 0;
    width: 70%;
}

.titulo{
    margin-left: 100px;
    font-weight: bold;
    margin-top: 50px;
    font-size: 25px;
}

@media(max-width: 750px){

.texto_main{
    display: flex;
    margin-top: 10px;
    border: 2px solid #2E4756;
    border-radius: 20px;
    width: 200px;
    margin-left: 150px;
    flex-direction: column;
}
.imagem{
    margin-left: 45px;
    width: 150px;
}
.main{
    display: flex;
    flex-direction: column;
    margin-top: 100px;
}

.texto{
    margin-top: -50px;
    margin-left: -100px;
    display: flex;
    flex-direction: column;
    text-align: center;
    justify-content: center;
}
.fonte{
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    font-size: 12px;
}
#pagina{
    position: fixed;
    top: 0;
    right: 0;
    width: 70%;
}

.titulo{
    margin-left: 150px;
    font-weight: bold;
    margin-top: 50px;
    font-size: 18px;
    width: 200px;

}



}

</style>