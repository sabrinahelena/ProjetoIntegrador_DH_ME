

<template>
  <div>
    <MenuLateral/>
    <RouterView></RouterView>
  </div>
  
</template>

<script>
import MenuLateral from './components/MenuLateral.vue';
import Perfil from './components/Perfil.vue';
import Residencias from './components/Residencias.vue';
import ListaCompras from './components/ListaCompras.vue';
import Home from './components/Home.vue'
import Estoque from './components/Estoque.vue';
import Login from './components/Login.vue';

export default{
  name:`App`,

  components:{
    MenuLateral,
    Perfil,
    Residencias,
    ListaCompras,
    Home,
    Estoque,
    Login,
}
}
</script>

