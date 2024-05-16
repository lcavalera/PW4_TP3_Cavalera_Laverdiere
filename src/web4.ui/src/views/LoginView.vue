<template>
<BaseLayout>
    <div class="login">
        <Login titre="Profile Utilisateur" />
    </div>
</BaseLayout>
</template>

<script>
  // @ is an alias to /src
import Login from '../components/Login.vue';
  
export default {
  name: 'LoginView',
  components: {
    Login
  }
}
</script>