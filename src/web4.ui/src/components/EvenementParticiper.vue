<template>
  <div class="evenement">
    <label>Titre: </label><input id="titre" type="text" v-model="evenement.titre" disabled>
    <label>Date Debut: </label><input id="titre" type="text" v-model="evenement.dateDebut" disabled>
    <label>Date Fin: </label><input id="titre" type="text" v-model="evenement.dateDeFin" disabled>
  </div><br>
  <h2>Remplir le formulaire pour participer à l'evenement</h2>
<form class="form">
  <label>Nom: </label><input id="titre" type="text" v-model="participation.nom"><br>
  <label>Prenom: </label><input id="titre" type="text" v-model="participation.prenom"><br>
  <label>Courriel: </label><input id="titre" type="text" v-model="participation.courriel"><br>
  <label>Nombre de places: </label><input id="titre" type="text" v-model="participation.nombrePlaces">
</form><br>
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
        evenement: {},
        participation: {}
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
  .form{
    text-align: left;
    margin: auto;
    font-family: Arial, sans-serif;
    width: 500px;
  }
  .form input{
    width: 100%;
  }
  </style>