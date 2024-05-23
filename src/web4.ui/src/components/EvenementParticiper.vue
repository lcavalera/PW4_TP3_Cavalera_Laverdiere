<template>
  <div class="evenement">
    <h2>Details sur l'événement</h2>
    <label>Titre: </label><input id="titre" type="text" v-model="evenement.titre" disabled>
    <label>Date Debut: </label><input id="titre" type="text" v-model="evenement.dateDebut" disabled>
    <label>Date Fin: </label><input id="titre" type="text" v-model="evenement.dateDeFin" disabled>
  </div><br>
  <h2>Remplir le formulaire pour participer à l'événement</h2>
<form @submit="addParticipation" class="form" method="post">
  <p v-if="errors.length">
    <b>Veuillez corriger les erreurs suivantes: </b>
    <ul>
      <li class="erreurs" v-for="(error, index) in errors" :key="index">{{ error }}</li>
    </ul>
  </p>
  <p>
    <label>Nom: </label>
    <input 
      id="titre" 
      type="text"
      name="nom" 
      v-model="participation.nom" 
      placeholder="Inserez votre nom" 
    >
    <br>
  </p>
  <p>
    <label>Prenom: </label>
    <input 
      id="titre" 
      type="text" 
      v-model="participation.prenom" 
      placeholder="Inserez votre prenom" 
    ><br>
  </p>
  <p>
    <label>Courriel: </label>
    <input 
      id="titre" 
      type="text" 
      v-model="participation.courriel" 
      placeholder="Inserez votre courriel" 
    ><br>
  </p>
  <p>
    <label>Nombre de places: </label>
    <input 
      id="titre" 
      type="number" 
      max="10" min="1" 
      placeholder="0" 
      v-model="participation.nombrePlaces" 
      >
  </p>
  <p>
    <input
      type="submit"
      value="Submit"
    >
  </p>
</form><br>
<button @click="$router.push(`/evenements/`)">Retour</button>
</template>
  
  <script>
  import {mapState, mapActions } from 'vuex'
  
  export default {
    name: "EvenementParticipation",
    props: {
      titre: String,
    },
    data() {
      return {
        participation: {},
        errors: []
      };
    },
    methods: {
      ...mapActions({ 
        getEvenementApi: 'getEvenementApi',
        createParticipation: 'createParticipation'
      }),
      addParticipation: function(e) {
        if (this.participation.nom && 
            this.participation.prenom && 
            this.participation.courriel && 
            this.participation.nombrePlaces) {
        this.participation.evenementID = this.evenement.id

        this.createParticipation(this.participation)
          .then(data =>{
            console.log("creation avec success: ", data)
            this.participation = {}
            this.$toast.success(`La participation (id: ${data.id}) a été ajouté avec success.)`)
          })
          .catch(() => this.$toast.error(`Erreur lors de la comunication avec le serveur lors de l'ajout de la participation de (nom: ${this.paricipation.nom}).`));
          this.$router.push(`/evenements/`)
          return true;
        }

        this.errors = [];

        if (!this.participation.nom){
          this.errors.push('Nom obligatoire.');
        }

        if (!this.participation.prenom){
          this.errors.push('Prenom obligatoire.');
        }

        if (!this.participation.courriel){
          this.errors.push('Courriel obligatoire.');
        }

        if (!this.participation.nombrePlaces){
          this.errors.push('Nombre de places obligatoire.');
        }
        e.preventDefault();
    }
    },
    created(){
      this.getEvenementApi(this.$route.params.id)
    },
    computed: {
        ...mapState({evenement: 'evenement'})
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
    width: 300px;
  }
  .form input{
    width: 100%;
  }
  .erreurs{
    color: red;
  }
  </style>