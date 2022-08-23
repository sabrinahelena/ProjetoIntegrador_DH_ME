

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


export default{
  name:`App`,

  components:{
    MenuLateral,
    Perfil,
    Residencias,
    ListaCompras
}
}
</script>

