import { createApp } from 'vue'
import { createRouter, createWebHashHistory } from 'vue-router'

import App from './App.vue'
import Perfil from './components/Perfil.vue'
import Residencias from './components/Residencias.vue'
import Home from './components/Home.vue'
import ListaCompras from './components/ListaCompras.vue'
import Estoque from './components/Estoque.vue'


const router = createRouter({
    history: createWebHashHistory(),
    routes: [
        {
            path: '/perfil',
            component: Perfil
        },
        {
            path: '/sobre',
            component: Residencias
        },
        {
            path: '/home',
            component: Home
        },
        {
            path: '/listacompras',
            component: ListaCompras
        },
        {
            path:'/estoque',
            component: Estoque
        }
    ]
})

const app = createApp(App)

app.use(router)

app.mount('#app')