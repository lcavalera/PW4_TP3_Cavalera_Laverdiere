<template>
    <section class="accueil">  
      <h1>{{ titre }}</h1>
      <p>
        Portail de réservation d'événements avec listes d'événements et de réservations..
      </p>
      <h3>Technologies utilisées</h3>
      <ul>
            <li><a href="https://router.vuejs.org" target="_blank" rel="noopener">vue-router</a></li>
            <li><a href="https://vuex.vuejs.org/guide/" target="_blank" rel="noopener">vuex</a></li>
            <li><a href="https://v2.vuejs.org/v2/cookbook/using-axios-to-consume-apis.html?redirect=true" target="_blank" rel="noopener">axios</a></li>
            <li><a href="https://github.com/soukoku/vue-oidc-client" target="_blank" rel="noopener">vue-oidc-client</a></li>
            <li><a href="https://primevue.org/vite/" target="_blank" rel="noopener">primevue</a></li>
            <li><a href="https://github.com/vuejs/vue-cli/tree/dev/packages/%40vue/cli-plugin-eslint" target="_blank" rel="noopener">eslint</a></li>
      </ul>
    </section>
    <section>
        <h3>Équipe</h3>
        <p>
            Luca Cavalera & Frédéric Laverdière
        </p>
        <ul>
            <li><a href="https://www.linkedin.com/in/luca-cavalera/" target="_blank"><img src="../../public/1685318454611.jpg" alt="Luca Cavalera"></a></li>
            <li><a href="https://www.linkedin.com/in/fr%C3%A9d%C3%A9ric-laverdi%C3%A8re-0b809499/" target="_blank"><img src="../../public/1634737679875.jpg" alt="Frédéric Laverdière"></a></li>
        </ul>
    </section>
  </template>
  
  <script>
  export default {
    name: 'AccueilPage',
    props: {
      titre: String
    }
  }
  </script>
  
  <!-- Add "scoped" attribute to limit CSS to this component only -->
  <style scoped>
  h3 {
    margin: 40px 0 0;
  }
  ul {
    list-style-type: none;
    padding: 0;
  }
  li {
    display: inline-block;
    margin: 0 10px;
  }
  a {
    color: #42b983;
  }
  img {
    height: 100px;
  }
  </style>
  