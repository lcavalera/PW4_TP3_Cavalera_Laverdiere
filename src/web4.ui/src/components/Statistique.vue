<template>
    <section class="statistique">
        <h2>{{ titre }}</h2>
        <table>
            <thead>
                <th>Nom</th>
                <th>Profit</th>
            </thead>
            <tbody>
                <tr v-for="(item, index) in evenements" :key="index">
                    <td>{{ item.titre }}</td>
                    <td>{{ item.villeNom }}</td>
                    <td>{{ item.participationIds.length }}</td>
                    <td>{{ item.prix }}</td>
                    <td><ul v-for="(item, index) in item.categories" :key="index">{{ item }}</ul></td>
                    <td>{{ item.dateDebut }}</td>
                    <td>
                        <button @click="$router.push(`/evenements/${item.id}`)">detail</button>
                        <button @click="$router.push(`/evenements/${item.id}/participer`)">participer</button>
                        <button @click="deleteTodo(index)"><i class="fa fa-trash"></i></button>
                    </td>
                </tr>
            </tbody>
    </table><br>
    </section>
</template>

<script>
 export default {
    name: 'LoginPage',
    props: {
      titre: String
    }
  }
</script>

  <!-- Add "scoped" attribute to limit CSS to this component only -->
  <style scoped>
  button,
  [aria-label] {
    cursor: pointer;
  }
  
  table {
    font-family: Arial, sans-serif;
    border: 1px solid;
    border-collapse: collapse;
    width: 100%;
    margin-top: 10px;
  }
  
  th {
    background-color: #f8f8f8;
    padding: 5px;
  }
  
  td {
    border: 1px solid;
    padding: 5px;
  }
  </style>