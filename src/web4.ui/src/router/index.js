import { createRouter, createWebHistory } from 'vue-router'
import AccueilView from '@/views/AccueilView.vue'

const routes = [
  {
    path: '/',
    name: 'home',
    component: AccueilView
  },
  {
    path: '/evenements',
    name: 'evenements',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/EvenementsView.vue')
  },
  {
    path: '/login',
    name: 'login',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/LoginView.vue')
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
