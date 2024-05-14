<template>
    <div class="evenements">
      <Evenements titre="Liste des Évènements"/>
    </div>
  </template>
  
  <script>
  // @ is an alias to /src
import Evenements from '../components/Evenements.vue';
  
  export default {
    name: 'EvenementsView',
    components: {
      Evenements
    }
  }
  </script>
  