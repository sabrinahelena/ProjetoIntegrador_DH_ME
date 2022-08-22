
<template>
  <div id="menu-items">
    
    <ul>
      <h2><b>ListMe</b></h2>
      <li><a href="/">Home</a></li>
      <li><a href="/">Configurações</a></li>
      <li><a href="/">Gerenciar Compras</a></li>
    </ul>
    
  </div>
</template>
<script>
export default{
  name:`MenuLateral`
}
</script>

<style scoped>
#menu-items{
  position: fixed;
  top:0;
  left:0;
  background-color: #2E4756;
  width: 25%;
  height: 100vh;
  display: flex;
  flex-direction: column;
  justify-content: flex-start;
  text-align: left;
  align-items: center;
}

ul{
  list-style: none;
  text-align: left;
  align-items: left;
  color:white;
}

ul li{
  margin: 100px 0px;
  font-size: 25px;
}

ul li a{
  color:white;
}
</style>