<template>
    <section class="login">
        <h2>{{ titre }}</h2>
        <form>
          <label for="nom">Nom d'usager </label>
          <input type="text" disabled><br><br>
          <label for="role">Rôles </label>
          <input type="text" disabled>
        </form><br>
        <button :click="signOut()">Déconnexion</button>
    </section>
</template>

<script>
import mainOidc from '@/api/authClient'

 export default {
    name: 'LoginPage',
    props: {
      titre: String
    },
    data(){
      return{
        nom: mainOidc.userProfile.family_name,
        role: mainOidc.accessToken
      }
    },
    methods:{
      signOut(){
        mainOidc.signOut();
      },
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