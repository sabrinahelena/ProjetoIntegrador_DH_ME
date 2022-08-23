import { createApp } from 'vue'
import { createRouter, createWebHashHistory } from 'vue-router'

import App from './App.vue'
import Perfil from './components/Perfil.vue'
import Residencias from './components/Residencias.vue'


const router = createRouter({
    history: createWebHashHistory(),
    routes: [
        {
            path: '/',
            component: Perfil
        },
        {
            path: '/sobre',
            component: Residencias
        }
    ]
})

const app = createApp(App)

app.use(router)

app.mount('#app')