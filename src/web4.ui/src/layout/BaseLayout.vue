<template>

    <div class="container">
        <header id="header">
            <slot name="header">
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
                    {{ displayProfileName() }}
                </div>
                <div v-if="!isLoggedIn()" id="login">
                    <router-link to="/login">Login</router-link>
                </div>
                <div>
                    {{ displaydevInfo() }}
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
import mainOidc from '@/api/authClient';
import { Buffer } from 'buffer';

// @ts-ignore
window.Buffer = Buffer;
    export default {
        methods:{
            isAdmin(){
                if(mainOidc.isAuthenticated){
                    return true;
                }else{
                    return false;
                }
            },
            isLoggedIn(){
                if(mainOidc.isAuthenticated){
                    return true;
                }else{
                    return false;
                }
            },
            displayProfileName(){
                return `Profile(${mainOidc.userProfile.name})`
            },
            displaydevInfo(){
                return `${this.parseJwt(mainOidc.accessToken).role}`
            },
            parseJwt(token) {
                return JSON.parse(Buffer.from(token.split('.')[1], 'base64').toString());
            }
        }
    }    

</script>
    <style scoped>
    #header{
        display: flexbox;
        background-color: lightgray;
        height: 30px;
        text-align: left;
        padding-left: 20px;
        padding-top: 20px; 
        padding-bottom: 50px;  
    
    }
    #header div{
        display: inline-block;
        padding-left: 20px;
    }
    #footer{
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
    a{
        text-decoration: none;
        color: #2c3e50;
        font-weight: bold;
    }
    #login{
        float: right;
        padding-right: 20px;
    }
    </style>