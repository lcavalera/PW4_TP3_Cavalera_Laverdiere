<template>
  <section class="statistique">
    <h2>{{ titre }}</h2>
    <table>
      <thead>
        <th>Nom</th>
        <th>Profit</th>
      </thead>
      <tbody>
        <tr v-for="(item, index) in statistiques" :key="index">
          <td>{{ item.nom }}</td>
          <td>{{ item.profit }}</td>
        </tr>
      </tbody>
    </table><br>
  </section>
</template>

<script>
import { mapState, mapActions } from 'vuex'

export default {
  name: 'LoginPage',
  props: {
    titre: String
  },
  created() {
    this.getStatistiqueApi()
    .catch((error) => this.$toast.error(`Erreur lors de la comunication avec le serveur lors du chargement de la liste des statistiques. (Error: ${error.response == null ? error.code : error.response.status})`))
  },
  methods: {
    ...mapActions({ 
      getStatistiqueApi: 'getStatistiqueApi'})
  },
    computed: {
      ...mapState({ statistiques: 'statistiques'})
    }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
table {
  font-family: Arial, sans-serif;
  border: 1px solid;
  border-collapse: collapse;
  width: 400px;
  margin-top: 10px;
}
.statistique{
  display: inline-block;
  margin: auto;
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