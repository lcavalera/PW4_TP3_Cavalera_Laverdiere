<template>
    <Menubar :model="items">
        <template #item="{item, props}" >
            <RouterLink v-if="item.route" v-slot="{href, navigate}" :to="item.route" custom>
                <a v-ripple :href="href" v-bind="props.action" @click="navigate">
                    <span class="ml-2">{{ item.label }}</span>
                </a>
            </RouterLink>
        </template>
    </Menubar>
</template>

<script>
import Menubar from 'primevue/menubar';
import { RouterLink } from 'vue-router';

    export default {
        name: 'MenuNav',
        data(){
            return {
                items:[
                    {
                        label: 'Accueil',
                        route: '/'
                    },
                    {
                        label: 'Evenements',
                        route: '/evenements'
                    },
                    {
                        label: 'Statistique',
                        route: '/statistique'
                    },
                    {
                        label: 'Login',
                        route: '/login'
                    },
                ]
            }
        }
    }
</script>