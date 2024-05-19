<template>
  <BaseLayout>
    <div class="evenements">
      <router-view titre="Liste des Évènements"/>
    </div>
  </BaseLayout>
</template>
  
<script>
  // @ is an alias to /src
  
  export default {
    name: 'EvenementsView',
  }
</script>
  