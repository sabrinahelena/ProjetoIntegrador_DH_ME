<template>

<table class="table">
  <thead>
    <tr>
      <th>#</th>
      <th>First</th>
      <th>Last</th>
      <th>Handle</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th >1</th>
      <td>Mark</td>
      <td>Otto</td>
      <td>@mdo</td>
    </tr>
    <tr>
      <th >2</th>
      <td>Jacob</td>
      <td>Thornton</td>
      <td>@fat</td>
    </tr>
    <tr>
      <th>3</th>
      <td>Larry</td>
      <td>the Bird</td>
      <td>@twitter</td>
    </tr>
  </tbody>
</table>

</template>


<style scoped>

* {
            box-sizing: border-box;
        }
        
        table {
            border: 1px solid black;
            border-collapse: collapse;
            font-family: Arial, Helvetica, sans-serif;
        }

        table > thead {
         background-color: black;
         color: white;
        }

        th, td {
            border: 1px solid black;
            padding: 5px 10px;
        }
</style>


<script>
export default{
    name:'Estoque'
}
</script>