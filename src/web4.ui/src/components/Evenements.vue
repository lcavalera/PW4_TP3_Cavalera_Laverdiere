<template>
    <div class="accueil">  
        <h2>{{ titre }}</h2><br>
        <label>Filtrer les évènements: </label>
        <input type="text" placeholder="filtrer par titre ou description" v-model="filter" /><br>
        <table>
            <thead>
                <th>Titre</th>
                <th>Ville</th>
                <th>Nbr Participation</th>
                <th>Prix</th>
                <th>Catégories</th>
                <th>Date de début</th>
                <th>Action</th>
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
                        <button v-if="isManager()" @click="deleteTodo(index)"><i class="fa fa-trash"></i></button>
                    </td>
                </tr>
            </tbody>
    </table><br>


</div>
</template>
  
<script>
  import mainOidc from '@/api/authClient';
import { mapState, mapActions } from 'vuex'

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
    created() {
      this.getEvenementsApi()
    .catch((error) => this.$toast.error(`Erreur lors de la comunication avec le serveur lors du chargement de la liste des évènements. (Error: ${error.response == null ? error.code : error.response.status})`))
    },
    watch: {
      filter(value){
      this.filtrage(value);
      }
    },
    methods: {
      ...mapActions({
        getEvenementsApi: 'getEvenementsApi',
        filtrage: 'filtrage'
      }),
      isManager(){
        if(mainOidc.isAuthenticated && mainOidc.accessToken.includes("manager")){
          return true;
        }else{
          return false;
        }
      }
    },
    computed: {
      ...mapState({ evenements: 'evenements'})
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