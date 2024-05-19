<template>
  <form class="evenement">
  <label>Titre: </label><input id="titre" type="text" v-model="evenement.titre">
  <label>Date Debut: </label><input id="titre" type="text" v-model="evenement.dateDebut">
  <label>Date Fin: </label><input id="titre" type="text" v-model="evenement.dateDeFin">
  <label>Desctiption: </label><textarea id="titre" type="text" v-model="evenement.description"></textarea>
  <label>Adresse: </label><input id="titre" type="text" v-model="evenement.adresse">
  <label>Nom Organisateur: </label><input id="titre" type="text" v-model="evenement.nomOrganisateur">
  <label>Prix: </label><input id="titre" type="text" v-model="evenement.prix">
  <!-- <label>Categories: </label><input v-for="(item, index) in evenement.categories" :key="index" id="titre" type="text" :value="item"> -->
  <label>Ville: </label><input id="titre" type="text" v-model="evenement.villeNom">
  <label>Ids participations: </label><input id="titre" type="text" v-model="evenement.participationIds">
</form>
<button>Soumettre</button>
</template>
  
  <script>
  import httpclient from '@/api/httpclient'
  
  export default {
    name: "EvenementParticipation",
    props: {
      titre: String,
    },
    data() {
      return {
        evenement: {}
      };
    },
    methods: {
      getEvenementsApi(id){
        httpclient.get(`Evenements/${id}`)
        .then(reponse => this.evenement = reponse.data)
        .catch(error => console.log(error))
      }
    },
    created(){
      this.getEvenementsApi(this.$route.params.id)
    }
  };
  </script>
  
  <style scoped>
 
  button,
  [aria-label] {
    cursor: pointer;
  }
  .evenement{
    margin: auto;
    display: grid;
    font-family: Arial, sans-serif;
    width: 500px;
  }
  .evenement label{
    justify-items: center;
    font-weight: bold;
    text-align: left;
  }
  </style>