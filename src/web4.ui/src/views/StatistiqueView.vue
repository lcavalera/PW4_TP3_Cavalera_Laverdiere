<template>
<BaseLayout>
    <div class="statistique">
        <Statistique titre="Statistique de la plateforme"/>
    </div>
</BaseLayout>
</template>

<script>
  // @ is an alias to /src
import Statistique from '../components/Statistique.vue';
  
export default {
  name: 'StatistiqueView',
  components: {
    Statistique
  }
}
</script>
  