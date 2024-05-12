<template>
    <div class="home">
      <img alt="Vue logo" src="../assets/logo.png">
      <Accueil titre="TP3 - Programmation Web"/>
    </div>
  </template>
  
  <script>
  // @ is an alias to /src
import Accueil from '../components/Accueil.vue';
  
  export default {
    name: 'AccueilView',
    components: {
      Accueil
    }
  }
  </script>
  