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
    component: () => import(/* webpackChunkName: "about" */ '../views/EvenementsView.vue'),
    children: [
      {
        // UserProfile will be rendered inside User's <router-view>
        // when /todos/ is matched
        path: '',
        name: 'evenementslist',
        component: () => import(/* webpackChunkName: "about" */ '../components/Evenements.vue'),
      },
      {
        // UserProfile will be rendered inside User's <router-view>
        // when /evenement/ is matched
        path: ':id',
        name: 'evenementdetails',
        component: () => import(/* webpackChunkName: "about" */ '../components/EvenementDetails.vue'),
      },
      {
        // UserPosts will be rendered inside User's <router-view>
        // when /todos/1/edit is matched
        path: ':id/:action',
        name: 'todo',
        component: () => import(/* webpackChunkName: "about" */ '../components/EvenementParticiper.vue'),
      }
    ]
  },
  {
    path: '/statistique',
    name: 'statistique',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/StatistiqueView.vue')
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
