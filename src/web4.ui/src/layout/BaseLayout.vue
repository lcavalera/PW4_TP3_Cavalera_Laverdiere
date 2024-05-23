<template>
    <div>
        <header id="header">
            <slot name="header">
                <!-- ====== Nous avons essayé PrimeVue mais cela 
                    n'a pas fonctionné lorsque nous voulions 
                    activer le menu STATISTIQUES 
                    uniquement pour l'administrateur et 
                    afficher la personne enregistrée 
                    au lieu du LOGIN.====== -->

                <!-- <MenuBar :model="items" class="menubar">   
                    <template  #item="{item, props}" >
                        <RouterLink v-if="item.route" v-slot="{href, navigate}" :to="item.route" custom>
                            <a :href="href" v-bind="props.action" @click="navigate">
                                <span class="ml-2">{{ item.label }}</span>
                            </a>
                        </RouterLink>
                    </template>
                </Menubar> -->
                <div>
                    <router-link to="/">Accueil</router-link>
                </div>
                <div>
                    <router-link to="/evenements">Évènements</router-link>
                </div>
                <div v-if="isAdmin()">
                    <router-link to="/statistique">Statistique</router-link>
                </div>
                <div v-if="isLoggedIn()" id="login">
                    <router-link to="/login"> {{ displayProfileName() }}</router-link>
                </div>
                <div v-if="!isLoggedIn()" id="login">
                    <router-link to="/login">Login</router-link>
                </div>

            </slot>
        </header><br>
        <main>
            <slot name="default"></slot>
        </main><br>
        <footer id="footer">
            <slot name="footer">@ Copyright 2024</slot>
        </footer>
    </div>

</template>
<script>
// import MenuNav from '@/components/MenuNav.vue';
import mainOidc from '@/api/authClient';
import { Buffer } from 'buffer';

// @ts-ignore
window.Buffer = Buffer;
export default {
    data() {
        return {
            items: [
                {
                    label: 'Accueil',
                    command: () => {
                        this.$router.push('/')
                    }
                },
                {
                    label: 'Evenements',
                    command: () => {
                        this.$router.push('/evenements')
                    }
                },
                {
                    label: 'Statistique',
                    command: () => {
                        this.$router.push('/statistique')
                    }
                },
                {
                    label: 'Login',
                    command: () => {
                        this.$router.push('/login')
                    }
                },
            ]
        }
    },
    methods: {
        isAdmin() {
            if (mainOidc.isAuthenticated) {
                if (this.parseJwt(mainOidc.accessToken).role == 'admin') {
                    return true;
                }
                return false;
            } else {
                return false;
            }
        },
        isLoggedIn() {
            if (mainOidc.isAuthenticated) {
                return true;
            } else {
                return false;
            }
        },
        displayProfileName() {
            return `Profile(${mainOidc.userProfile.name})`
        },
        affiche(table) {
            return table[1].role
        },
        parseJwt(token) {
            return JSON.parse(Buffer.from(token.split('.')[1], 'base64').toString());
        }
    }
}

</script>
<style scoped>
#header {
    background-color: lightgray;
    height: 30px;
    text-align: left;
    padding-left: 20px;
    padding-top: 20px;
    padding-bottom: 80px;

}

#header div {
    display: inline-block;
    padding-left: 20px;
}

#footer {
    background-color: lightgray;
    height: 50px;
    padding-top: 10px;
    padding-left: 20px;
    text-align: left;
}

a.router-link-exact-active {
    color: #42b983;
    font-weight: bold;
}

a {
    text-decoration: none;
    color: #2c3e50;
    font-weight: bold;
}

#login {
    float: right;
    padding-right: 20px;
}
</style>