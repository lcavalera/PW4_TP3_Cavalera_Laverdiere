import { createApp } from 'vue';
import App from './App.vue';
import router from './router';
import store from './store';
import Toaster from "@meforma/vue-toaster";
import BaseLayout from '@/layout/BaseLayout.vue';
import mainOidc from './api/authClient.js';
import PrimeVue from 'primevue/config';
import MenuBar from 'primevue/menubar';
import 'primevue/resources/themes/aura-light-green/theme.css'

mainOidc.startup().then(ok => 
    {if (ok) 
        {
            const app = createApp(App);
            app.use(store);
            app.use(PrimeVue);
            app.component('MenuBar', MenuBar);
            app.component('BaseLayout', BaseLayout);
            app.config.globalProperties.$oidc = mainOidc;
            app.use(Toaster, {position: "top"});
            app.use(router);
            app.mount('#app');
        }
    })
       


//createApp(App)
//.use(store)
//.use(router)
//.component('BaseLayout', BaseLayout)
//.use(Toaster, {position: "top"})
//.mount('#app')
