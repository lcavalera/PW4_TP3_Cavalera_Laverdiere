<template>
    <div class="accueil">  
        <h3>{{ titre }}</h3><br>
        <input type="text" placeholder="filtrer par titre" v-model="filter" /><br>
        <table>
            <thead>
                <th>Titre</th>
                <th>Ville</th>
                <th>Nbr</th>
                <th>Participation</th>
                <th>Prix</th>
                <th>Catégories</th>
                <th>Date de début</th>
                <th>Action</th>
            </thead>
            <tbody>
                <tr :class="{ done: item.done }" v-for="(item, index) in todos" :key="index">
                    <td><input type="checkbox" :checked="item.done" @click="toggleTodo(index)"></td>
                    <td>{{ item.text }}</td>
                    <td>
                        <button @click="deleteTodo(index)"><i class="fa fa-trash"></i></button>
                        <button @click="$router.push(`/todos/${item.id}/edit`)">edit</button>
                        <button @click="$router.push(`/todos/${item.id}/view`)">view</button>
                    </td>
                </tr>
            </tbody>
    </table><br>


</div>
</template>
  
<script>
  import { mapState, mapGetters, mapActions } from 'vuex'

  export default {
    name: 'EvenementsList',
    props: {
      titre: String
    },
    data() {
      return {
        filter: ""
      }
    },
    methods: {
      ...mapActions({

      })
    },
    computed: {
      ...mapState({}),
      ...mapGetters({})
    }
  }
</script>
  
<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
/* .done {
  background: rgb(7, 240, 7);
} */

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