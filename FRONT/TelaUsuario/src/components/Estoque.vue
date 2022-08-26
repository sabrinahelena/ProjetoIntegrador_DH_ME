<template>
  <div id="titulo">
    <table>
      <thead>
        <th>Produto</th>
        <th>Quantidade</th>
        <th>Data de validade</th>
      </thead>
      <tbody>
        <tr>
          <th>Maçã</th>
          <td>3</td>
          <td>20/09/2022</td>
        </tr>
        <tr>
          <th>Banana</th>
          <td>6</td>
          <td>21/08/2022</td>
        </tr>
        <tr>
          <th>Leite</th>
          <td>6</td>
          <td>21/08/2022</td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
export default {
  name: `Residencias`,
}
</script>

<style scoped>
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

* {
  box-sizing: border-box;
}


table {
  position: fixed;
  margin-top: 200px;
  width: 900px;
  height: 1px;
  border-collapse: collapse;
}

table>thead {
  background-color: #2E4756;
  color: white;
  height: 30px;
}

th,
td {
  text-align: center;
  font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
  height: 1px;
  padding: 5px 10px;
  font-size: 20px;
  border-bottom: 1px solid #2E4756;
}


</style>