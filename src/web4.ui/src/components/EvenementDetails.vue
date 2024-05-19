<template>
    <form class="evenement">
    <label>Titre: </label><input id="titre" type="text" v-model="evenement.titre" disabled>
    <label>Date Debut: </label><input id="titre" type="text" v-model="evenement.dateDebut" disabled>
    <label>Date Fin: </label><input id="titre" type="text" v-model="evenement.dateDeFin" disabled>
    <label>Desctiption: </label><textarea id="titre" type="text" v-model="evenement.description" disabled></textarea>
    <label>Adresse: </label><input id="titre" type="text" v-model="evenement.adresse" disabled>
    <label>Nom Organisateur: </label><input id="titre" type="text" v-model="evenement.nomOrganisateur" disabled>
    <label>Prix: </label><input id="titre" type="text" v-model="evenement.prix" disabled>
    <label>Categories: </label><input v-for="(item, index) in evenement.categories" :key="index" id="titre" type="text" :value="item" disabled>
    <label>Ville: </label><input id="titre" type="text" v-model="evenement.villeNom" disabled>
    <label>Ids participations: </label><input id="titre" type="text" v-model="evenement.participationIds" disabled>
  </form>
  <button @click="$router.push(`/evenements/`)">Retour</button>
</template>
    
    <script>
    import httpclient from '@/api/httpclient'
    
    export default {
      name: "EvenementDetails",
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