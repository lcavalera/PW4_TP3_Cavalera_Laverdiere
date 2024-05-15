import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import Toaster from "@meforma/vue-toaster";
import BaseLayout from '@/layout/BaseLayout.vue'

createApp(App).use(store).use(router).component('BaseLayout', BaseLayout).use(Toaster, {position: "top"}).mount('#app')
